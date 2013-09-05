using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CSolutionFactory
    {

        #region data Members

        CSolutionSql _dataObject = null;

        #endregion

        #region Constructor

        public CSolutionFactory()
        {
            _dataObject = new CSolutionSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CSolution
        /// </summary>
        /// <param name="businessObject">CSolution object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CSolution businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CSolution
        /// </summary>
        /// <param name="businessObject">CSolution object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CSolution businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CSolution by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CSolution GetByPrimaryKey(CSolutionKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CSolutions
        /// </summary>
        /// <returns>list</returns>
        public List<CSolution> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CSolutions
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CSolution by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CSolution> GetAllBy(CSolution.CSolutionFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CSolutionKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CSolution by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CSolution.CSolutionFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
