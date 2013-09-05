using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CControl_sampleFactory
    {

        #region data Members

        CControl_sampleSql _dataObject = null;

        #endregion

        #region Constructor

        public CControl_sampleFactory()
        {
            _dataObject = new CControl_sampleSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CControl_sample
        /// </summary>
        /// <param name="businessObject">CControl_sample object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CControl_sample businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CControl_sample
        /// </summary>
        /// <param name="businessObject">CControl_sample object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CControl_sample businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CControl_sample by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CControl_sample GetByPrimaryKey(CControl_sampleKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CControl_samples
        /// </summary>
        /// <returns>list</returns>
        public List<CControl_sample> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CControl_samples
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CControl_sample by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CControl_sample> GetAllBy(CControl_sample.CControl_sampleFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CControl_sampleKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CControl_sample by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CControl_sample.CControl_sampleFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
