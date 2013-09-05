using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LimsProject.BusinessLayer.Modules
{
    public class Qaqc
    {
        List<CRecep_sample_detail_elem> lstSamples = null;
        List<CTemplate_method_aa> lstMethods = null;

        private void Retrieve_Lst_Samples()
        {
            CRecep_sample_detail_elemFactory faRecep_sample_detail_elem = new CRecep_sample_detail_elemFactory();
            lstSamples = faRecep_sample_detail_elem.GetAll();

            CTemplate_method_aaFactory faTemplate_method_aa = new CTemplate_method_aaFactory();
            lstMethods = faTemplate_method_aa.GetAll();
        }


        public int NumTotalTest(int idtemplate_method)
        {
            if (lstSamples == null)
                Retrieve_Lst_Samples();

            return lstSamples.Count(c => c.Idtemplate_method == idtemplate_method);
        }

        public bool IsRetest(long idrecep_sample_detail_elem, long idbatch)
        {
            CRetestFactory faRetest = new CRetestFactory();
            List<CRetest> lstRetest = faRetest.GetAll();
            if (lstRetest.Count(c => c.Origin_batch == idbatch && c.Destiny_batch == idbatch) > 0)
                return true;
            else
                return false;
        }

        public bool ExistsResultPendingSel(long idrecep_sample_detail_elem, long idbatch)        
        {
            CRetestFactory faRetest = new CRetestFactory();
            List<CRetest> lstRetest = faRetest.GetAll();

            return lstRetest
                .Exists(c => c.Idrecep_sample_detail_elem == idrecep_sample_detail_elem
                && (c.Origin_batch == idbatch || c.Destiny_batch == idbatch) && c.Status_retest == 0);
        }
    }
}
