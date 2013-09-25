using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace LimsProject.BusinessLayer.Modules
{
    public class ModSolInterm
    {

        public List<CSolution> GetLstSolution(CGroup_solution p_group_solution)
        {            
            List<CSolution> lst = 
                (from m in new CSolutionFactory().GetAll()
                 where m.Idgroup_solution == p_group_solution.Idgroup_solution
                 select m).ToList();

            return lst;
        }

        public List<CSolution_interm> GetLstSolution(int? idtemplate_method, short? idelement, Comun.TypePatternMr type_pattern)
        {                        
            char type_mr = type_pattern == Comun.TypePatternMr.MrCertificado ? 'C' : 'S';

            List<CSolution_interm> lstPattern = 
                (from m in new CMr_detailFactory().GetAll().Where(x => x.Analyte == idelement)
                 from n in new CMrFactory().GetAll().Where(x => x.Type_mr == type_mr).Where(x => x.Idmr == m.Idmr)
                 select new CSolution_interm
                 {
                     Idsolution_interm = -1,
                     Cod_solution = n.Cod_mr,
                     Id = m.Idmr,
                     Parentid = 0,
                     Type_sol = 0,
                     Concentration = m.Nominal_value,
                     Root_idmr_detail = m.Idmr_detail,
                     Root_type_pattern = Convert.ToInt32(type_pattern)
                 }).ToList();

            List<CSolution_interm> lstSolution =
                (from m in new CSolution_intermFactory().GetAll().Where(x => x.Idelement == idelement && x.Root_type_pattern == Convert.ToInt32(type_pattern))
                 join n in new CSolution_interm_methodsFactory().GetAll().Where(x => x.Idtemplate_method == idtemplate_method)
                    on m.Idsolution_interm equals n.Idsolution_interm into mn
                 from p in mn.DefaultIfEmpty()
                 select new CSolution_interm { 
                     Cod_solution = m.Cod_solution,
                     Concentration = m.Concentration,
                     Date_begin = m.Date_begin,
                     Date_end = m.Date_end,
                     Dateedit = m.Dateedit,
                     Datenew = m.Datenew,
                     Flag_current_method = p == null ? false : true,
                     Id = m.Id,
                     Idelement = m.Idelement,
                     Idreactive_medium = m.Idreactive_medium,
                     Idreactive_modif = m.Idreactive_modif,
                     Idsolution_interm = m.Idsolution_interm,
                     Image_index = m.Image_index,
                     Lote = m.Lote,
                     Num_months = m.Num_months,
                     Observation = m.Observation,
                     Parentid = m.Parentid,
                     Prepared_by = m.Prepared_by,
                     Purity = m.Purity,
                     Reactive_medium_value = m.Reactive_medium_value,
                     Reactive_modif_value = m.Reactive_modif_value,
                     Root_idmr_detail = m.Root_idmr_detail,
                     Root_type_pattern = m.Root_type_pattern,
                     Solution_name = m.Solution_name,
                     Solution_status = m.Solution_status,
                     Status = m.Status,
                     Type_sol = m.Type_sol,
                     Useredit = m.Useredit,
                     Usernew = m.Usernew,
                     Volumen = m.Volumen,
                     Aliquot = m.Aliquot
                 }).ToList();

            List<CSolution_interm> lstTotal = lstSolution.Union(lstPattern).ToList();

            return lstTotal;
        }

        public List<CTemplate_method> GetLstTemplate_methodBySolution(int idsolution_interm)
        {
            List<CTemplate_method> lst =
                (from m in new CSolution_interm_methodsFactory().GetAll()
                 from n in new Methods()
                 .GetAllLastVersionMethods()
                 .Where(x=> x.Idtemplate_method == m.Idtemplate_method)
                 where m.Idsolution_interm == idsolution_interm && m.Status == true
                 select n).ToList();

            return lst;
        }

        public List<CSolution_interm> GetLstSolution_intermByMethod(int idtemplate_method)
        {
            List<CSolution_interm> lst =
                (from m in new CSolution_intermFactory().GetAll()
                 from n in new CSolution_interm_methodsFactory().GetAll().Where(x=> x.Idsolution_interm == m.Idsolution_interm)
                 where n.Idtemplate_method == idtemplate_method
                 select m).ToList();

            return lst;
        }
    }
}
