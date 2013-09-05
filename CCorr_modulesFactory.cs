using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CCorr_modulesFactory
    {

        #region data Members

        CCorr_modulesSql _dataObject = null;

        #endregion

        #region Constructor

        public CCorr_modulesFactory()
        {
            _dataObject = new CCorr_modulesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CCorr_modules
        /// </summary>
        /// <param name="businessObject">CCorr_modules object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CCorr_modules businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CCorr_modules
        /// </summary>
        /// <param name="businessObject">CCorr_modules object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CCorr_modules businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CCorr_modules by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CCorr_modules GetByPrimaryKey(CCorr_modulesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CCorr_moduless
        /// </summary>
        /// <returns>list</returns>
        public List<CCorr_modules> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CCorr_moduless
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CCorr_modules by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CCorr_modules> GetAllBy(CCorr_modules.CCorr_modulesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CCorr_modulesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CCorr_modules by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CCorr_modules.CCorr_modulesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
