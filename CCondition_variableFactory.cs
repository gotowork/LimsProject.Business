using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CCondition_variableFactory
    {

        #region data Members

        CCondition_variableSql _dataObject = null;

        #endregion

        #region Constructor

        public CCondition_variableFactory()
        {
            _dataObject = new CCondition_variableSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CCondition_variable
        /// </summary>
        /// <param name="businessObject">CCondition_variable object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CCondition_variable businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CCondition_variable
        /// </summary>
        /// <param name="businessObject">CCondition_variable object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CCondition_variable businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CCondition_variable by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CCondition_variable GetByPrimaryKey(CCondition_variableKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CCondition_variables
        /// </summary>
        /// <returns>list</returns>
        public List<CCondition_variable> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CCondition_variables
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CCondition_variable by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CCondition_variable> GetAllBy(CCondition_variable.CCondition_variableFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CCondition_variableKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CCondition_variable by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CCondition_variable.CCondition_variableFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
