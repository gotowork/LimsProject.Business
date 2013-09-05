using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CPrice_attachFactory
    {

        #region data Members

        CPrice_attachSql _dataObject = null;

        #endregion

        #region Constructor

        public CPrice_attachFactory()
        {
            _dataObject = new CPrice_attachSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CPrice_attach
        /// </summary>
        /// <param name="businessObject">CPrice_attach object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CPrice_attach businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CPrice_attach
        /// </summary>
        /// <param name="businessObject">CPrice_attach object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CPrice_attach businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CPrice_attach by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CPrice_attach GetByPrimaryKey(CPrice_attachKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CPrice_attachs
        /// </summary>
        /// <returns>list</returns>
        public List<CPrice_attach> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CPrice_attachs
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CPrice_attach by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CPrice_attach> GetAllBy(CPrice_attach.CPrice_attachFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CPrice_attachKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CPrice_attach by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CPrice_attach.CPrice_attachFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
