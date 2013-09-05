using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CMethods_multiFactory
    {

        #region data Members

        CMethods_multiSql _dataObject = null;

        #endregion

        #region Constructor

        public CMethods_multiFactory()
        {
            _dataObject = new CMethods_multiSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CMethods_multi
        /// </summary>
        /// <param name="businessObject">CMethods_multi object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CMethods_multi businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CMethods_multi
        /// </summary>
        /// <param name="businessObject">CMethods_multi object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CMethods_multi businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CMethods_multi by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CMethods_multi GetByPrimaryKey(CMethods_multiKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CMethods_multis
        /// </summary>
        /// <returns>list</returns>
        public List<CMethods_multi> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CMethods_multis
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CMethods_multi by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CMethods_multi> GetAllBy(CMethods_multi.CMethods_multiFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CMethods_multiKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CMethods_multi by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CMethods_multi.CMethods_multiFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
