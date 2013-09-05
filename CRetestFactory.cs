using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CRetestFactory
    {

        #region data Members

        CRetestSql _dataObject = null;

        #endregion

        #region Constructor

        public CRetestFactory()
        {
            _dataObject = new CRetestSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CRetest
        /// </summary>
        /// <param name="businessObject">CRetest object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CRetest businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CRetest
        /// </summary>
        /// <param name="businessObject">CRetest object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CRetest businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CRetest by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CRetest GetByPrimaryKey(CRetestKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CRetests
        /// </summary>
        /// <returns>list</returns>
        public List<CRetest> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CRetests
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CRetest by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CRetest> GetAllBy(CRetest.CRetestFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CRetestKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CRetest by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CRetest.CRetestFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
