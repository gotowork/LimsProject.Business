using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CTemplate_method_icpFactory
    {

        #region data Members

        CTemplate_method_icpSql _dataObject = null;

        #endregion

        #region Constructor

        public CTemplate_method_icpFactory()
        {
            _dataObject = new CTemplate_method_icpSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CTemplate_method_icp
        /// </summary>
        /// <param name="businessObject">CTemplate_method_icp object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CTemplate_method_icp businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CTemplate_method_icp
        /// </summary>
        /// <param name="businessObject">CTemplate_method_icp object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CTemplate_method_icp businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CTemplate_method_icp by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CTemplate_method_icp GetByPrimaryKey(CTemplate_method_icpKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CTemplate_method_icps
        /// </summary>
        /// <returns>list</returns>
        public List<CTemplate_method_icp> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CTemplate_method_icps
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CTemplate_method_icp by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CTemplate_method_icp> GetAllBy(CTemplate_method_icp.CTemplate_method_icpFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CTemplate_method_icpKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CTemplate_method_icp by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CTemplate_method_icp.CTemplate_method_icpFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
