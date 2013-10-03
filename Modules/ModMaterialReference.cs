using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LimsProject.BusinessLayer.Modules
{
    public class ModMaterialReference
    {
        public List<CMr_detail> SelectByMr(short idmr)
        {
            return new CMr_detailFactory().GetAll().Where(x => x.Idmr == idmr).ToList();
        }

        public List<CMr_jar> GetJarByMr(short idmr)
        {
            return new CMr_jarFactory().GetAll().Where(x => x.Idmr == idmr).ToList();
        }

        public IList GetBy_TypeMr_And_Element(Comun.TypeMr typeMr, short idelement)
        {            
            List<CMr_detail> lstMr_detail = new CMr_detailFactory().GetAll().Where(c => c.Analyte == idelement).ToList();
            List<CMr> lstMr = new CMrFactory().GetAll();

            // get reference material
            var query1 =
                (from t1 in lstMr_detail
                 join t2 in lstMr on t1.Idmr equals t2.Idmr
                 where t2.Type_mr == Convert.ToChar(typeMr)
                 select new
                 {
                     t2.Idmr,
                     t1.Idmr_detail,
                     t2.Cod_mr,
                     t1.Nominal_value
                 }).Distinct().ToList();

            return query1;
        }

        public IList GetConcentration_By_TypeMr(Comun.TypeMr typeMr, short idelement)
        {
            List<CMr_detail> lstMr_detail = new CMr_detailFactory().GetAll().Where(c=> c.Analyte == idelement).ToList();
            List<CMr> lstMr = new CMrFactory().GetAll().Where(x => x.Type_mr == Convert.ToChar(typeMr)).ToList();

            // get reference material
            var query1 =
                (from t1 in lstMr_detail
                 from t2 in lstMr.Where(x=> x.Idmr == t1.Idmr)
                 select new
                 {
                     t1.Nominal_value
                 }).Distinct().ToList();
            return query1;
        }

        public IList GetBy_Element(short idelement)
        {
            List<CMr> lstMr = new CMrFactory().GetAll().Where(c => c.Status_mr == true).ToList();
            List<CMr_detail> lstMr_detail = new CMr_detailFactory().GetAll().Where(c => c.Analyte == idelement).ToList();

            var lst = (from t1 in lstMr
                       join t2 in lstMr_detail on t1.Idmr equals t2.Idmr
                       select new CCustomMr_detail
                       {
                           Cod_mr = t1.Cod_mr,
                           Idmr = t1.Idmr,
                           Idmr_detail = t2.Idmr_detail
                       }).ToList();
            return lst;
        }
    }
}
