using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CSolution_intermFactory
    {

        #region data Members

        CSolution_intermSql _dataObject = null;

        #endregion

        #region Constructor

        public CSolution_intermFactory()
        {
            _dataObject = new CSolution_intermSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CSolution_interm
        /// </summary>
        /// <param name="businessObject">CSolution_interm object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CSolution_interm businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CSolution_interm
        /// </summary>
        /// <param name="businessObject">CSolution_interm object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CSolution_interm businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CSolution_interm by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CSolution_interm GetByPrimaryKey(CSolution_intermKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CSolution_interms
        /// </summary>
        /// <returns>list</returns>
        public List<CSolution_interm> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CSolution_interms
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CSolution_interm by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CSolution_interm> GetAllBy(CSolution_interm.CSolution_intermFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CSolution_intermKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CSolution_interm by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CSolution_interm.CSolution_intermFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
