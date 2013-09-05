using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CReportTestClientFactory
    {

        #region data Members

        CReportTestClientSql _dataObject = null;

        #endregion

        #region Constructor

        public CReportTestClientFactory()
        {
            _dataObject = new CReportTestClientSql();
        }

        #endregion


        #region Public Methods        

        public DataTable GetClient()
        {
            return _dataObject.SelectClient();
        }

        public DataTable GetResultByClient()
        {
            return _dataObject.SelectResultByClient();
        }
        

        #endregion

    }
}
