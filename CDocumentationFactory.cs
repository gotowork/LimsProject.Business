using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CDocumentationFactory
    {

        #region data Members

        CDocumentationSql _dataObject = null;

        #endregion

        #region Constructor

        public CDocumentationFactory()
        {
            _dataObject = new CDocumentationSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CDocumentation
        /// </summary>
        /// <param name="businessObject">CDocumentation object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CDocumentation businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CDocumentation
        /// </summary>
        /// <param name="businessObject">CDocumentation object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CDocumentation businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CDocumentation by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CDocumentation GetByPrimaryKey(CDocumentationKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CDocumentations
        /// </summary>
        /// <returns>list</returns>
        public List<CDocumentation> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CDocumentations
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CDocumentation by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CDocumentation> GetAllBy(CDocumentation.CDocumentationFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CDocumentationKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CDocumentation by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CDocumentation.CDocumentationFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
