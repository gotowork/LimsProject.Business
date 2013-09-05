using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CReportTestFactory
    {

        #region data Members

        CReportTestSql _dataObject = null;

        #endregion

        #region Constructor

        public CReportTestFactory()
        {
            _dataObject = new CReportTestSql();
        }

        #endregion


        #region Public Methods        

        /// <summary>
        /// get datatable of all CBatchs
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetReportResults(long p_idrecep_sample_report)
        {
            return _dataObject.SelectReportResults(p_idrecep_sample_report);
        }

        public DataTable GetReportMethods(long p_idrecep_sample_report)
        {
            return _dataObject.SelectReportMethods(p_idrecep_sample_report);
        }

        public DataTable GetReportHead(long p_idrecep_sample_report)
        {
            return _dataObject.SelectReportHead(p_idrecep_sample_report);
        }
        

        #endregion

    }
}
