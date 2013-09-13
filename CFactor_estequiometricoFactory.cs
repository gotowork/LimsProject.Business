using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CFactor_estequiometricoFactory
    {

        #region data Members

        CFactor_estequiometricoSql _dataObject = null;

        #endregion

        #region Constructor

        public CFactor_estequiometricoFactory()
        {
            _dataObject = new CFactor_estequiometricoSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CFactor_estequiometrico
        /// </summary>
        /// <param name="businessObject">CFactor_estequiometrico object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CFactor_estequiometrico businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CFactor_estequiometrico
        /// </summary>
        /// <param name="businessObject">CFactor_estequiometrico object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CFactor_estequiometrico businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CFactor_estequiometrico by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CFactor_estequiometrico GetByPrimaryKey(CFactor_estequiometricoKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CFactor_estequiometricos
        /// </summary>
        /// <returns>list</returns>
        public List<CFactor_estequiometrico> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CFactor_estequiometricos
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CFactor_estequiometrico by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CFactor_estequiometrico> GetAllBy(CFactor_estequiometrico.CFactor_estequiometricoFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CFactor_estequiometricoKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CFactor_estequiometrico by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CFactor_estequiometrico.CFactor_estequiometricoFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
