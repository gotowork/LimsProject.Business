using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CDescription_sampleFactory
    {

        #region data Members

        CDescription_sampleSql _dataObject = null;

        #endregion

        #region Constructor

        public CDescription_sampleFactory()
        {
            _dataObject = new CDescription_sampleSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CDescription_sample
        /// </summary>
        /// <param name="businessObject">CDescription_sample object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CDescription_sample businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CDescription_sample
        /// </summary>
        /// <param name="businessObject">CDescription_sample object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CDescription_sample businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CDescription_sample by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CDescription_sample GetByPrimaryKey(CDescription_sampleKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CDescription_samples
        /// </summary>
        /// <returns>list</returns>
        public List<CDescription_sample> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CDescription_samples
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CDescription_sample by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CDescription_sample> GetAllBy(CDescription_sample.CDescription_sampleFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CDescription_sampleKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CDescription_sample by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CDescription_sample.CDescription_sampleFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
