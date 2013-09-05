using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CReportEtiqFactory
    {

        #region data Members

        CReportEtiqSql _dataObject = null;

        #endregion

        #region Constructor

        public CReportEtiqFactory()
        {
            _dataObject = new CReportEtiqSql();
        }

        #endregion


        #region Public Methods        

        /// <summary>
        /// get datatable of all CBatchs
        /// </summary>
        /// <returns>list</returns>        
        public DataTable GetReportSamples(long p_idrecep_sample)
        {
            return _dataObject.SelectReportSamples(p_idrecep_sample);
        }

        public DataTable GetReportMethodsBySamples(long p_idrecep_sample)
        {
            return _dataObject.SelectReportMethodsBySamples(p_idrecep_sample);
        }

        #endregion

    }
}
