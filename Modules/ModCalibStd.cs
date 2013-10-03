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

        public List<CCustomCalibStd> GetCustomCalibStd(int idsolution_interm, CTemplate_method_aa templat_method_aa)
        {
            //cruzar calibStd con calibs, composición externa y filtrarlo por metodo
            var query =
                (from m in new CSet_calibsFactory().GetAll().Where(x => x.Last_calib == true)
                 from n in new CCalib_stdFactory().GetAll().Where(x => x.Idset_calibs == m.Idset_calibs)
                 select n).ToList();

            List<CCustomCalibStd> lst =
                (from m in new CCalibFactory().GetAll().Where(x => x.Idtemplate_method == templat_method_aa.Idtemplate_method)
                 join n in query                    
                    .Where(x => x.Idtemplate_method == templat_method_aa.Idtemplate_method
                                && x.Idsolution_interm == idsolution_interm)
                    on m.Idcalib equals n.Idcalib into mn
                 from p in mn.DefaultIfEmpty()
                 select new CCustomCalibStd
                 {
                     Idtemplate_method = m.Idtemplate_method,
                     Idcalib = m.Idcalib,
                     Idcalib_std = p == null ? 0 : p.Idcalib_std,
                     Name = m.Name_calib,
                     Concentration = m.Concentration,
                     Absorbance = p == null ? Comun.NullInt32 : 0,
                     Absorbance_previus = p == null ? Comun.NullInt32 : p.Absorbance
                 }).ToList();
            
            return lst;
        }

        public decimal GetValuePreviusAbsorbance(List<CCalib_std> lst, int idsolution_interm, int idtemplate_method, int idcalib)
        {
            foreach (CCalib_std item in lst)
            {
                if (item.Idsolution_interm == idsolution_interm
                    && item.Idtemplate_method == idtemplate_method
                    && item.Idcalib == idcalib)
                    return Convert.ToDecimal(item.Absorbance);
            }            
            return 0;
        }

        public CSet_calibs GetSet_CalibBy(int idsolution_interm, int idtemplate_method)
        {
            return new CSet_calibsFactory()
                .GetAll()
                .Where(c => c.Idsolution_interm == idsolution_interm
                    && c.Idtemplate_method == idtemplate_method
                    && c.Last_calib == true).FirstOrDefault();
        }
    }

    public class CCustomCalibStd
    {
        public long Idcalib_std { get; set; }
        public long Idcalib { get; set; }
        public int Idset_calibs { get; set; }
        public string Name { get; set; }
        public decimal? Absorbance_previus { get; set; }
        public decimal? Absorbance { get; set; }
        public decimal? Concentration { get; set; }
        public int? Idtemplate_method { get; set; }
        public string Cod_template_method { get; set; }
    }

}
