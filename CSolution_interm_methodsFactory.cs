using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CSolution_interm_methodsFactory
    {

        #region data Members

        CSolution_interm_methodsSql _dataObject = null;

        #endregion

        #region Constructor

        public CSolution_interm_methodsFactory()
        {
            _dataObject = new CSolution_interm_methodsSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CSolution_interm_methods
        /// </summary>
        /// <param name="businessObject">CSolution_interm_methods object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CSolution_interm_methods businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CSolution_interm_methods
        /// </summary>
        /// <param name="businessObject">CSolution_interm_methods object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CSolution_interm_methods businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CSolution_interm_methods by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CSolution_interm_methods GetByPrimaryKey(CSolution_interm_methodsKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CSolution_interm_methodss
        /// </summary>
        /// <returns>list</returns>
        public List<CSolution_interm_methods> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CSolution_interm_methodss
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CSolution_interm_methods by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CSolution_interm_methods> GetAllBy(CSolution_interm_methods.CSolution_interm_methodsFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CSolution_interm_methodsKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CSolution_interm_methods by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CSolution_interm_methods.CSolution_interm_methodsFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
