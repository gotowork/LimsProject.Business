using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CBatchicpFactory
    {

        #region data Members

        CBatchicpSql _dataObject = null;

        #endregion

        #region Constructor

        public CBatchicpFactory()
        {
            _dataObject = new CBatchicpSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CBatchicp
        /// </summary>
        /// <param name="businessObject">CBatchicp object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CBatchicp businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CBatchicp
        /// </summary>
        /// <param name="businessObject">CBatchicp object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CBatchicp businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CBatchicp by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CBatchicp GetByPrimaryKey(CBatchicpKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CBatchicps
        /// </summary>
        /// <returns>list</returns>
        public List<CBatchicp> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CBatchicps
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CBatchicp by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CBatchicp> GetAllBy(CBatchicp.CBatchicpFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CBatchicpKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CBatchicp by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CBatchicp.CBatchicpFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
