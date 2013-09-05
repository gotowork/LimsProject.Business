using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CPrice_version_detailFactory
    {

        #region data Members

        CPrice_version_detailSql _dataObject = null;

        #endregion

        #region Constructor

        public CPrice_version_detailFactory()
        {
            _dataObject = new CPrice_version_detailSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CPrice_version_detail
        /// </summary>
        /// <param name="businessObject">CPrice_version_detail object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CPrice_version_detail businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CPrice_version_detail
        /// </summary>
        /// <param name="businessObject">CPrice_version_detail object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CPrice_version_detail businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CPrice_version_detail by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CPrice_version_detail GetByPrimaryKey(CPrice_version_detailKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CPrice_version_details
        /// </summary>
        /// <returns>list</returns>
        public List<CPrice_version_detail> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CPrice_version_details
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CPrice_version_detail by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CPrice_version_detail> GetAllBy(CPrice_version_detail.CPrice_version_detailFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CPrice_version_detailKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CPrice_version_detail by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CPrice_version_detail.CPrice_version_detailFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
