using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CDocument_recepFactory
    {

        #region data Members

        CDocument_recepSql _dataObject = null;

        #endregion

        #region Constructor

        public CDocument_recepFactory()
        {
            _dataObject = new CDocument_recepSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CDocument_recep
        /// </summary>
        /// <param name="businessObject">CDocument_recep object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CDocument_recep businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CDocument_recep
        /// </summary>
        /// <param name="businessObject">CDocument_recep object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CDocument_recep businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CDocument_recep by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CDocument_recep GetByPrimaryKey(CDocument_recepKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CDocument_receps
        /// </summary>
        /// <returns>list</returns>
        public List<CDocument_recep> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CDocument_receps
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CDocument_recep by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CDocument_recep> GetAllBy(CDocument_recep.CDocument_recepFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CDocument_recepKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CDocument_recep by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CDocument_recep.CDocument_recepFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
