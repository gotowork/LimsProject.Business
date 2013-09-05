using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CTree_expressionFactory
    {

        #region data Members

        CTree_expressionSql _dataObject = null;

        #endregion

        #region Constructor

        public CTree_expressionFactory()
        {
            _dataObject = new CTree_expressionSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CTree_expression
        /// </summary>
        /// <param name="businessObject">CTree_expression object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CTree_expression businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CTree_expression
        /// </summary>
        /// <param name="businessObject">CTree_expression object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CTree_expression businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CTree_expression by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CTree_expression GetByPrimaryKey(CTree_expressionKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CTree_expressions
        /// </summary>
        /// <returns>list</returns>
        public List<CTree_expression> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CTree_expressions
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CTree_expression by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CTree_expression> GetAllBy(CTree_expression.CTree_expressionFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CTree_expressionKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CTree_expression by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CTree_expression.CTree_expressionFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
