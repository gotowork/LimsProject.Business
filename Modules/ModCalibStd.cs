using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace LimsProject.BusinessLayer.Modules
{
    public class ModCalibStd
    {
        /// <summary>
        /// Este método obtiene las calibraciones de los métodos
        /// </summary>
        /// <param name="idelement"></param>
        /// <param name="idmr_detail"></param>
        /// <param name="idreactive_medium"></param>
        /// <param name="idreactive_modif"></param>
        /// <returns></returns>
        public CSet_methods_calib GetMethodCalib(int idelement, short idmr_detail, int? idreactive_medium, int? idreactive_modif)
        {
            CSet_methods_calibFactory faSet_methods_calib = new CSet_methods_calibFactory();
            List<CSet_methods_calib> lstSet_methods_calib = 
                faSet_methods_calib.GetAll()
                .Where(c=> c.Idelement == idelement 
                    && c.Idmr_detail == idmr_detail
                    && (idreactive_medium == null || c.Idreactive_medium == idreactive_medium)
                    && (idreactive_modif == null || c.Idreactive_modif == idreactive_modif)).ToList();
            
            if (lstSet_methods_calib.Count > 0)
                return lstSet_methods_calib.First();

            CSet_methods_calib oSet_methods_calib = new CSet_methods_calib();
            oSet_methods_calib.Idelement = idelement;
            oSet_methods_calib.Idmr_detail = idmr_detail;
            oSet_methods_calib.Idreactive_medium = idreactive_medium;
            oSet_methods_calib.Idreactive_modif = idreactive_modif;

            return oSet_methods_calib;
        }

        public int GetNewCorrelative(int idelement, short idmr_detail, int? idreactive_medium, int? idreactive_modif)
        {
            CSet_methods_calibFactory faSet_methods_calib = new CSet_methods_calibFactory();
            List<CSet_methods_calib> lstSet_methods_calib =
                faSet_methods_calib.GetAll()
                .Where(c => c.Idelement == idelement
                    && c.Idmr_detail == idmr_detail
                    && (idreactive_medium == null || c.Idreactive_medium == idreactive_medium)
                    && (idreactive_modif == null || c.Idreactive_modif == idreactive_modif)).ToList();
            
            int num = 0;
            if (lstSet_methods_calib.Count > 0)
                num = lstSet_methods_calib.Max(c => Convert.ToInt32(c.Order_set));
            return num+1;
        }

        public List<CTemplate_method> GetMethodsCalib(int idelement, short idmr_detail)
        {
            var lstTemplate_method = 
                new CTemplate_methodFactory()
                .GetAll()
                .Where(c => c.Idelement == idelement).ToList();

            var lsTemplate_method_aa = 
                new CTemplate_method_aaFactory()
                .GetAll()
                .Where(c=> c.Mrorpattern == idmr_detail).ToList();

            var lst =
                (from t1 in lstTemplate_method
                 join t2 in lsTemplate_method_aa on t1.Idtemplate_method equals t2.Idtemplate_method                 
                 select t1
                 ).ToList<CTemplate_method>();

            foreach (var item in lst)
                item.Cod_template_method = item.Cod_template_method + " - " + item.Title;
            
            return lst;
        }

        public BindingList<CCustomCalibStd> GetCustomCalibStd(CGroup_solution oGroup_solution, BindingList<CCustom_method_solution> lstSelectedMethods)
        {
            // --- Get previus absorbances
            //List<CCalib_std> lstSet_calibsPrevius = new CCalib_stdFactory().GetAll()
            //    .Where(c => c.Idgroup_solution == oGroup_solution.Idgroup_solution_previus).ToList();

            //var lstTemplate_method = 
            //    new CTemplate_methodFactory()
            //    .GetAll()
            //    .Where(c => c.Idelement == oGroup_solution.Idelement).ToList();

            //var lsTemplate_method_aa = 
            //    new CTemplate_method_aaFactory()
            //    .GetAll()
            //    .Where(c=> c.Mrorpattern == oGroup_solution.Idmr_detail 
            //        && (oGroup_solution.Idreactive_medium == null || c.Medium == oGroup_solution.Idreactive_medium) 
            //        && (oGroup_solution.Idreactive_modif == null || c.Modif == oGroup_solution.Idreactive_modif)).ToList();
            //var lstCalib = new CCalibFactory().GetAll();

            //// --- recuperar plantilla query de calibraciones de métodos sin datos
            //var query1 =
            //    (from t1 in lstTemplate_method
            //     join t2 in lsTemplate_method_aa on t1.Idtemplate_method equals t2.Idtemplate_method into tmp                 
            //     from t3 in tmp
            //     join t4 in lstCalib on t3.Idtemplate_method equals t4.Idtemplate_method
            //     join t5 in lstSelectedMethods on t4.Idtemplate_method equals t5.Idtemplate_method // into ps
                 
            //     select new
            //     {
            //         Idtemplate_method = t1.Idtemplate_method,
            //         Cod_template_method = t1.Cod_template_method + " - " + t1.Title,
            //         Validaty_calib = t3.Validity_calib,
            //         Idcalib = t4.Idcalib,
            //         Name_calib = t4.Name_calib,
            //         Concentration = t4.Concentration
            //     }
            //     ).ToList();
            
            //// --- recuperar datos
            //CSet_methods_calibFactory faSet_methods_calib = new CSet_methods_calibFactory();
            //CGroup_solutionFactory faGroup_solution = new CGroup_solutionFactory();
            //CSet_calibsFactory faSet_calib = new CSet_calibsFactory();
            //CCalib_stdFactory faCalib_std = new CCalib_stdFactory();

            //var lstGroup_solution =
            //    faGroup_solution.GetAll()
            //    .Where(c => ( ((oGroup_solution.Type_solution == 1 || oGroup_solution.Type_solution == 2) && c.Idmr_detail == oGroup_solution.Idmr_detail) ||
            //                  (oGroup_solution.Type_solution == 3 /*&& c.Idsolution_pattern == oGroup_solution.Idsolution_pattern*/))
            //        && c.Idelement == oGroup_solution.Idelement
            //        && c.Idreactive_medium == oGroup_solution.Idreactive_medium
            //        && c.Idreactive_modif == oGroup_solution.Idreactive_modif).ToList();

            //var lstSet_calibs =
            //    faSet_calib.GetAll().Where(c=> c.Idgroup_solution == oGroup_solution.Idgroup_solution).ToList();

            //var lstCalib_std = faCalib_std.GetAll();
           
            //var query2 =
            //    (from t1 in lstSet_calibs                  
            //     join t2 in lstCalib_std on t1.Idset_calibs equals t2.Idset_calibs                 
            //     select new
            //     {
            //         Idtemplate_method = t1.Idtemplate_method,
            //         Idgroup_solution = t1.Idgroup_solution,
            //         Idset_calibs = t1.Idset_calibs,
            //         Idcalib = t2.Idcalib,
            //         Idcalib_std = t2.Idcalib_std,
            //         Absorbance_previus = t2.Absorbance_previus,
            //         Absorbance = t2.Absorbance
                     
            //     }).ToList();

            //// --- cruzar tablas: plantilla y datos
            //BindingList<CCustomCalibStd>
            //    final_data = new BindingList<CCustomCalibStd>(
            //    (from t1 in query1
            //     join t2 in query2 on
            //     new
            //     {
            //         field1 = t1.Idtemplate_method,
            //         field2 = t1.Idcalib
            //     } 
            //     equals
            //     new
            //     {
            //         field1 = Convert.ToInt32(t2.Idtemplate_method),
            //         field2 = Convert.ToInt64(t2.Idcalib)
            //     }
            //     into ps
            //     from t3 in ps.DefaultIfEmpty()
            //     select new CCustomCalibStd
            //     {
            //         Idcalib_std = t3 == null ? 0 : t3.Idcalib_std,
            //         Idtemplate_method = t1.Idtemplate_method,
            //         Idcalib = t1.Idcalib,
            //         Name = t1.Name_calib,
            //         Absorbance_previus = GetValuePreviusAbsorbance(lstSet_calibsPrevius, Convert.ToInt32(oGroup_solution.Idgroup_solution_previus), t1.Idtemplate_method, Convert.ToInt32(t1.Idcalib)),
            //         Absorbance = t3 == null ? 0 : Convert.ToDecimal(t3.Absorbance),
            //         Concentration = t1.Concentration,
            //         Cod_template_method = t1.Cod_template_method
            //     }).ToList());

            //return final_data;
            BindingList<CCustomCalibStd> afewf = new BindingList<CCustomCalibStd>();
            return afewf;
        }

        public decimal GetValuePreviusAbsorbance(List<CCalib_std> lst, int idgroup_solution, int idtemplate_method, int idcalib)
        {
            foreach (CCalib_std item in lst)
            {
                if (item.Idgroup_solution == idgroup_solution 
                    && item.Idtemplate_method == idtemplate_method
                    && item.Idcalib == idcalib)
                    return Convert.ToDecimal(item.Absorbance);
            }            
            return 0;
        }

        public CSet_calibs GetSet_CalibBy(int idgroup_solution, int idtemplate_method)
        {
            CSet_calibsFactory faSet_calibs = new CSet_calibsFactory();
            List<CSet_calibs> lstSet_calibs = 
                faSet_calibs
                .GetAll()
                .Where(c=> c.Idgroup_solution == idgroup_solution && c.Idtemplate_method == idtemplate_method).ToList();

            if (lstSet_calibs.Count >= 1)
            {
                CSet_calibs oSet_calibs = lstSet_calibs[0];
                return oSet_calibs;            
            }
            return null;
        }
    }

    public class CCustomCalibStd
    {
        public long Idcalib_std { get; set; }
        public long Idcalib { get; set; }
        public int Idset_calibs { get; set; }
        public string Name { get; set; }
        public decimal Absorbance_previus { get; set; }
        public decimal Absorbance { get; set; }
        public decimal? Concentration { get; set; }
        public int? Idtemplate_method { get; set; }
        public string Cod_template_method { get; set; }
    }

}
