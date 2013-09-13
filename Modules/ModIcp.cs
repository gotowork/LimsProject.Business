using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace LimsProject.BusinessLayer.Modules
{
    public class ModIcp
    {
        DatabaseProviderFactory factory = new DatabaseProviderFactory();
        Database namedDB;

        public ModIcp()
        {
            namedDB = factory.Create("las2010");
        }

        public DataTable GetMethodsIcp()
        {            
            return namedDB.ExecuteDataSet(CommandType.Text, "spFindIcpMethods").Tables[0];            
        }

        public DataTable GetSamples(DateTime pDateIni, DateTime pDateEnd, string pMethod)
        {
            StringBuilder sql = new StringBuilder("spFindIcpSamples @DateIni='{0}', @DateEnd='{1}', @MethodName='{2}'");
            string dateIni = pDateIni.ToString("yyyyMMdd");
            string dateEnd = pDateEnd.ToString("yyyyMMdd");
            string method = pMethod;

            return namedDB.ExecuteDataSet(CommandType.Text, string.Format(sql.ToString(), dateIni, dateEnd, method)).Tables[0];
        }

        public DataTable GetAnalysis(DateTime pDateIni, DateTime pDateEnd, string pMethod, string pSamplesSelected)
        {
            StringBuilder sql = new StringBuilder("spFindIcpAnalysis @DateIni='{0}', @DateEnd='{1}', @MethodName='{2}', @SamplesSelected='{3}'");
            string dateIni = pDateIni.ToString("yyyyMMdd");
            string dateEnd = pDateEnd.ToString("yyyyMMdd");
            string method = pMethod;

            return namedDB.ExecuteDataSet(CommandType.Text, string.Format(sql.ToString(), dateIni, dateEnd, pMethod, pSamplesSelected)).Tables[0];
        }

        public DataTable GetElements(string element)
        {
            StringBuilder sql = new StringBuilder("spFindIcpElements @element={0}");
            if (element == null)
                sql = new StringBuilder("spFindIcpElements @element=null");
            else
                sql = new StringBuilder(string.Format("spFindIcpElements @element='{0}'", element));            

            return namedDB.ExecuteDataSet(CommandType.Text, sql.ToString()).Tables[0];
        }
    }
}
