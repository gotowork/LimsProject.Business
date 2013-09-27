using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections;


namespace LimsProject.BusinessLayer.Modules
{
    public class ModSolution
    {


        public List<CCustom_solution> GetLstMrc(Comun.TypeMr typeMr, short idelement)
        {
            CSettings oSettings = new CSettings();
            List<CMr_detail> lstMr_detail = new CMr_detailFactory().GetAll().Where(c => c.Analyte == idelement).ToList();
            List<CMr> lstMr = new CMrFactory().GetAll();

            // get reference material
            List<CCustom_solution> query1 =
                (from t1 in lstMr_detail
                 join t2 in lstMr on t1.Idmr equals t2.Idmr
                 where t2.Type_mr == Convert.ToChar(typeMr)
                 select new CCustom_solution
                 {
                     Idmr = t2.Idmr,
                     Idmr_detail = t1.Idmr_detail,
                     Code = t2.Cod_mr,
                     Name = t2.Cod_mr
                 }).ToList<CCustom_solution>();

            return query1;
        }

        public List<CCustom_solution> GetLstSolutions(short idelement)
        {
            List<CSolution> lstSolution = new CSolutionFactory().GetAll(); /*.Where(c => c.Idelement == idelement).ToList();*/

            List<CCustom_solution> query =
               (from t3 in lstSolution
                select new CCustom_solution
                {
                    Idsolution = t3.Idsolution,
                    Code = t3.Cod_solution,
                    Name = t3.Solution_name
                }).ToList<CCustom_solution>();
            return query;
        }

        public List<CCustom_solution> GetLstPatternSolution(short idelement)
        {
            CSettings oSettings = new CSettings();
            List<CConvert_unit_measurement> lstConvertUnit = new CConvert_unit_measurementFactory().GetAll().Where(c=> c.Idunit2 == oSettings.GetUnitMeasureSolution()).ToList();
            List<CMr_detail> lstMr_detail = new CMr_detailFactory().GetAll().Where(c => c.Analyte == idelement).ToList();
            List<CMr> lstMr = new CMrFactory().GetAll();
            List<CSolution> lstSolution = new CSolutionFactory().GetAll().Where(c => c.Idelement == idelement).ToList();
                        
            // get reference material
            List<CCustom_solution> query1 =
                (from t1 in lstMr_detail
                 join t2 in lstMr on t1.Idmr equals t2.Idmr
                 join t3 in lstConvertUnit on t1.Idunit1 equals t3.Idunit1
                 select new CCustom_solution
                 {
                     Idmr = t2.Idmr,
                     Idmr_detail = t1.Idmr_detail,
                     Code = t2.Cod_mr,
                     Lote = t2.Lot,
                     Name = t2.Cod_mr,
                     Purity = 100,
                     IsPattern = true,
                     Concentration = Convert.ToDecimal(t1.Nominal_value) * Convert.ToDecimal(t3.Factor),
                     Name_group = "Material de Referencia y Sales"
                 }).ToList<CCustom_solution>();

            // get solutions
            List<CCustom_solution> query2 =
                (from t3 in lstSolution
                 select new CCustom_solution
                 {
                     Idsolution = t3.Idsolution,
                     Code = t3.Cod_solution,
                     Name = t3.Solution_name,
                     Lote = t3.Lote,
                     Purity = Convert.ToDecimal(t3.Purity),
                     IsPattern = false,
                     Concentration = Convert.ToDecimal(t3.Concentration),
                     Name_group = "Soluciones"
                 }).ToList<CCustom_solution>();

            List<CCustom_solution> lst = new List<CCustom_solution>(query1.Union(query2));
            return lst;
        }

        //public BindingList<CSolution> GetLstChildSolution(int idsolution)
        //{
        //    List<CSolution> lst = new CSolutionFactory()
        //        .GetAll().Where(c => c.Idpattern == idsolution && c.Status == true).ToList();
        //    return new BindingList<CSolution>(lst);
        //}

        //public BindingList<CSolution> GetLstChildMr(short idmr)
        //{
        //    List<CSolution> lst = new CSolutionFactory()
        //        .GetAll().Where(c => c.Idpattern_mr == idmr && c.Status == true).ToList();
        //    return new BindingList<CSolution>(lst);
        //}

        

        public decimal? GetConcentrationPPM(short idmr_detail)
        {
            CMr_detailFactory faMr_detail = new CMr_detailFactory();
            CMr_detail oMr_detail = faMr_detail.GetByPrimaryKey(new CMr_detailKeys(idmr_detail));
            CSettings oSettings = new CSettings();
            CConvert_unit_measurementFactory faCConvert_unit_measurement = new CConvert_unit_measurementFactory();
            var query = (
                from t in faCConvert_unit_measurement.GetAll()
                where t.Idunit2 == oSettings.GetUnitMeasureSolution()
                && t.Idunit1 == oMr_detail.Idunit1
                select new
                {
                    Concentration = oMr_detail.Nominal_value * t.Factor
                }).ToList();

            foreach (var item in query)
            {
                if (item.Concentration != null)
                    return Math.Round(Convert.ToDecimal(item.Concentration), 4);                
            }
            decimal? num = null;

            return num;
        }

        public BindingList<CCustom_std_solution> GetStdByMethod(int? idtemplate_method)
        {
            BindingList<CCustom_std_solution> query = new BindingList<CCustom_std_solution>(
                (from p in new CCalibFactory().GetAll()
                 where p.Idtemplate_method == idtemplate_method
                 select new CCustom_std_solution
                 {
                     Std_name = p.Name_calib,
                     Concentration = Convert.ToDecimal(p.Concentration)
                 }).ToList());

            return query;
        }

        public BindingList<CCustom_method_solution> GetMethodsByMrcPattern(int idelement, short idmr_detail, int? idreactive_medium, int? idreactive_modif, int? idgroup_solution)
        {
            List<CTemplate_method_aa> lstTemplate_method_aa =
                new CTemplate_method_aaFactory()
                .GetAll()
                .Where(c => c.Mrorpattern == idmr_detail && c.Medium == idreactive_medium && c.Modif == idreactive_modif).ToList();

            List<CTemplate_method> lstTemplate_method =
                new CTemplate_methodFactory()
                .GetAll()
                .Where(c => c.Idelement == idelement).ToList();

            var query_group_methods = new CGroup_solution_methodsFactory().GetAll().Where(c => c.Idgroup_solution == idgroup_solution).ToList();

            BindingList<CCustom_method_solution> query = new BindingList<CCustom_method_solution>(
                (from m in lstTemplate_method
                 join n in lstTemplate_method_aa on m.Idtemplate_method equals n.Idtemplate_method
                 join p in query_group_methods on n.Idtemplate_method equals p.Idtemplate_method into ps
                 from q in ps.DefaultIfEmpty()
                 select new CCustom_method_solution { 
                     Sel = q == null ? false : Convert.ToBoolean(q.Status),
                     Idtemplate_method = n.Idtemplate_method,
                     Cod_template_method = m.Cod_template_method,
                     Title = m.Title
                 }
                 ).ToList());

            return query;
        }

        public BindingList<CCustom_method_solution> GetMethodsBySolution(int idelement, int idsolution, int? idreactive_medium, int? idreactive_modif, int? idgroup_solution)
        {
            List<CTemplate_method_aa> lstTemplate_method_aa =
                new CTemplate_method_aaFactory()
                .GetAll()
                .Where(c => /*c.Sol_intermedia == idsolution &&*/ c.Medium == idreactive_medium && c.Modif == idreactive_modif).ToList();

            List<CTemplate_method> lstTemplate_method =
                new CTemplate_methodFactory()
                .GetAll()
                .Where(c => c.Idelement == idelement).ToList();

            var query_group_methods = new CGroup_solution_methodsFactory().GetAll().Where(c => c.Idgroup_solution == idgroup_solution).ToList();

            BindingList<CCustom_method_solution> query = new BindingList<CCustom_method_solution>(
                (from m in lstTemplate_method
                 join n in lstTemplate_method_aa on m.Idtemplate_method equals n.Idtemplate_method
                 join p in query_group_methods on n.Idtemplate_method equals p.Idtemplate_method into ps
                 from q in ps.DefaultIfEmpty()
                 select new CCustom_method_solution
                 {
                     Sel = q == null ? false : true,
                     Idtemplate_method = n.Idtemplate_method,
                     Cod_template_method = m.Cod_template_method,
                     Title = m.Title
                 }
                 ).ToList());

            return query;
        }
        /// <summary>
        /// Lista los métodos por elemento, material de referencia patron y soluciones intermedias si tubieran
        /// </summary>
        /// <param name="group_solution"></param>
        /// <returns></returns>        

        public enum Correlative
        {
            EstandarCalibracion,
            SolucionIntermedia,
            EstandarVerificacion,
            SolucionTitulante
        }                

        public CSolution_interm_methods GetSolution_interm_methods(int idtemplate_method, int idsolution_interm)
        {
            CSolution_interm_methodsFactory faGroup_solution_methods = new CSolution_interm_methodsFactory();
            List<CSolution_interm_methods> lstTmp = faGroup_solution_methods.GetAll();

            try
            {
                if (lstTmp.Exists(c => c.Idtemplate_method == idtemplate_method && c.Idsolution_interm == idsolution_interm))
                {
                    CSolution_interm_methods oSolution_interm_methods = 
                        lstTmp.Single(c => c.Idtemplate_method == idtemplate_method
                            && c.Idsolution_interm == idsolution_interm);
                    return oSolution_interm_methods;
                }
            }
            catch
            {
                if (lstTmp.Count(c => c.Idtemplate_method == idtemplate_method && c.Idsolution_interm == idsolution_interm) > 1)
                    return lstTmp[0];
                return null;
            }
            return null;
        }

        public List<CSolution> GetLstSolInterm1ByGroup(int idgroup_solution)
        {
            List<CSolution> lst = 
                new CSolutionFactory()
                .GetAll()
                .Where(c => c.Idgroup_solution == idgroup_solution && c.Type_sol == 1).ToList();
            return lst;
        }

        public List<CSolution> GetLstSolInterm2ByGroup(int idgroup_solution)
        {
            List<CSolution> lst =
                new CSolutionFactory()
                .GetAll()
                .Where(c => c.Idgroup_solution == idgroup_solution && c.Type_sol == 2).ToList();
            return lst;
        }

        public List<CSolution> GetLstStdVerifByGroup(int idgroup_solution)
        {
            List<CSolution> lst = 
                new CSolutionFactory()
                .GetAll()
                .Where(c => c.Idgroup_solution == idgroup_solution && (c.Type_sol == 3 || c.Type_sol == 4)).ToList();
            return lst;
        }

        ///Group_solution
        ///1:SC, 2:SI-1, 3:SI-2, 4:EV, 5:ST
        ///
        ///Solution
        ///1:solution intermedia 1, 2:solution intermedia 2, 3: estandar verificación
        ///               
    }

    public class CCustom_solution
    {
        public int Idsolution { get; set; }
        public short Idmr { get; set; }
        public short Idmr_detail { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Lote { get; set; }
        public decimal Purity { get; set; }
        public bool IsPattern { get; set; } // Patron
        public decimal Concentration { get; set; }
        public string Name_group { get; set; }
    }    

    public class CCustom_method_solution
    {
        public bool Sel { get; set; }
        public int Idtemplate_method { get; set; }
        public string Cod_template_method { get; set; }
        public string Title { get; set; }        
    }

    public class CCustom_std_solution
    {
        public string Std_name { get; set; }
        public decimal Concentration { get; set; }
    }
}
