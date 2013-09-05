using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CBatchFactory
    {

        #region data Members

        CBatchSql _dataObject = null;

        #endregion

        #region Constructor

        public CBatchFactory()
        {
            _dataObject = new CBatchSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CBatch
        /// </summary>
        /// <param name="businessObject">CBatch object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CBatch businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CBatch
        /// </summary>
        /// <param name="businessObject">CBatch object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CBatch businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CBatch by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CBatch GetByPrimaryKey(CBatchKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CBatchs
        /// </summary>
        /// <returns>list</returns>
        public List<CBatch> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CBatchs
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CBatch by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CBatch> GetAllBy(CBatch.CBatchFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CBatchKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CBatch by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CBatch.CBatchFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
