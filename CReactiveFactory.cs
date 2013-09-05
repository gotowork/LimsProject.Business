using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CReactiveFactory
    {

        #region data Members

        CReactiveSql _dataObject = null;

        #endregion

        #region Constructor

        public CReactiveFactory()
        {
            _dataObject = new CReactiveSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CReactive
        /// </summary>
        /// <param name="businessObject">CReactive object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CReactive businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CReactive
        /// </summary>
        /// <param name="businessObject">CReactive object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CReactive businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CReactive by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CReactive GetByPrimaryKey(CReactiveKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CReactives
        /// </summary>
        /// <returns>list</returns>
        public List<CReactive> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CReactives
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CReactive by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CReactive> GetAllBy(CReactive.CReactiveFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CReactiveKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CReactive by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CReactive.CReactiveFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
