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
        #region sql server

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

        #endregion

        #region postgresql 

        public List<CTemplate_method_icp_detail> getListTemplate_method_icp_detail(int idtemplate_method)
        {
            List<CTemplate_method_icp_detail> query =
                (from m in new CElement_wavelengthFactory().GetAll()
                 join n in new CTemplate_method_icp_detailFactory().GetAll().Where(x => x.Idtemplate_method == idtemplate_method)
                    on m.Idelement_wavelength equals n.Idelement_wavelength into mn
                 from p in mn.DefaultIfEmpty()
                 select new CTemplate_method_icp_detail 
                 { 
                     Idelement_wavelength = p == null ? m.Idelement_wavelength : p.Idelement_wavelength,
                     Idelement = m.Idelement,
                     Idtemplate_method = idtemplate_method,
                     Idl = p == null ? Comun.NullDecimal : p.Idl,
                     Ipc = p == null ? Comun.NullDecimal : p.Ipc,
                     Ldr = p == null ? Comun.NullDecimal : p.Ldr,
                     Lfb = p == null ? Comun.NullDecimal : p.Lfb,
                     Lfm = p == null ? Comun.NullDecimal : p.Lfm,
                     Mdl_axial = p == null ? Comun.NullDecimal : p.Mdl_axial,
                     Mdl_radial = p == null ? Comun.NullDecimal : p.Mdl_radial,
                     Qc = p == null ? Comun.NullDecimal :p.Qc,
                     Std1 = p == null ? Comun.NullDecimal : p.Std1,
                     Std2 = p == null ? Comun.NullDecimal : p.Std2,
                     Priority = p == null ? Comun.NullDecimal : p.Priority,
                     Num_decimal = p == null ? Comun.NullDecimal : p.Num_decimal
                 }).ToList();

            return query;
        }

        #endregion
    }
}
