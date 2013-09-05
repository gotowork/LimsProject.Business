using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CTrace_batchFactory
    {

        #region data Members

        CTrace_batchSql _dataObject = null;

        #endregion

        #region Constructor

        public CTrace_batchFactory()
        {
            _dataObject = new CTrace_batchSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CTrace_batch
        /// </summary>
        /// <param name="businessObject">CTrace_batch object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CTrace_batch businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CTrace_batch
        /// </summary>
        /// <param name="businessObject">CTrace_batch object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CTrace_batch businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CTrace_batch by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CTrace_batch GetByPrimaryKey(CTrace_batchKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CTrace_batchs
        /// </summary>
        /// <returns>list</returns>
        public List<CTrace_batch> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CTrace_batchs
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CTrace_batch by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CTrace_batch> GetAllBy(CTrace_batch.CTrace_batchFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CTrace_batchKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CTrace_batch by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CTrace_batch.CTrace_batchFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
