using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CPrep_samplesFactory
    {

        #region data Members

        CPrep_samplesSql _dataObject = null;

        #endregion

        #region Constructor

        public CPrep_samplesFactory()
        {
            _dataObject = new CPrep_samplesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CPrep_samples
        /// </summary>
        /// <param name="businessObject">CPrep_samples object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CPrep_samples businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CPrep_samples
        /// </summary>
        /// <param name="businessObject">CPrep_samples object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CPrep_samples businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CPrep_samples by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CPrep_samples GetByPrimaryKey(CPrep_samplesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CPrep_sampless
        /// </summary>
        /// <returns>list</returns>
        public List<CPrep_samples> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CPrep_sampless
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CPrep_samples by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CPrep_samples> GetAllBy(CPrep_samples.CPrep_samplesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CPrep_samplesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CPrep_samples by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CPrep_samples.CPrep_samplesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
