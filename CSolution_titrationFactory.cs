using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CSolution_titrationFactory
    {

        #region data Members

        CSolution_titrationSql _dataObject = null;

        #endregion

        #region Constructor

        public CSolution_titrationFactory()
        {
            _dataObject = new CSolution_titrationSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CSolution_titration
        /// </summary>
        /// <param name="businessObject">CSolution_titration object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CSolution_titration businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CSolution_titration
        /// </summary>
        /// <param name="businessObject">CSolution_titration object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CSolution_titration businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CSolution_titration by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CSolution_titration GetByPrimaryKey(CSolution_titrationKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CSolution_titrations
        /// </summary>
        /// <returns>list</returns>
        public List<CSolution_titration> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CSolution_titrations
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CSolution_titration by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CSolution_titration> GetAllBy(CSolution_titration.CSolution_titrationFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CSolution_titrationKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CSolution_titration by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CSolution_titration.CSolution_titrationFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
