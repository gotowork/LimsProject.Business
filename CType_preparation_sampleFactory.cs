using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CType_preparation_sampleFactory
    {

        #region data Members

        CType_preparation_sampleSql _dataObject = null;

        #endregion

        #region Constructor

        public CType_preparation_sampleFactory()
        {
            _dataObject = new CType_preparation_sampleSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CType_preparation_sample
        /// </summary>
        /// <param name="businessObject">CType_preparation_sample object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CType_preparation_sample businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CType_preparation_sample
        /// </summary>
        /// <param name="businessObject">CType_preparation_sample object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CType_preparation_sample businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CType_preparation_sample by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CType_preparation_sample GetByPrimaryKey(CType_preparation_sampleKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CType_preparation_samples
        /// </summary>
        /// <returns>list</returns>
        public List<CType_preparation_sample> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CType_preparation_samples
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CType_preparation_sample by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CType_preparation_sample> GetAllBy(CType_preparation_sample.CType_preparation_sampleFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CType_preparation_sampleKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CType_preparation_sample by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CType_preparation_sample.CType_preparation_sampleFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
