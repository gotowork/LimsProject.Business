using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CModuleFactory
    {

        #region data Members

        CModuleSql _dataObject = null;

        #endregion

        #region Constructor

        public CModuleFactory()
        {
            _dataObject = new CModuleSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CModule
        /// </summary>
        /// <param name="businessObject">CModule object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CModule businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CModule
        /// </summary>
        /// <param name="businessObject">CModule object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CModule businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CModule by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CModule GetByPrimaryKey(CModuleKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CModules
        /// </summary>
        /// <returns>list</returns>
        public List<CModule> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CModules
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CModule by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CModule> GetAllBy(CModule.CModuleFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CModuleKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CModule by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CModule.CModuleFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
