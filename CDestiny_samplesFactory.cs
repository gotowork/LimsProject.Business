using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CDestiny_samplesFactory
    {

        #region data Members

        CDestiny_samplesSql _dataObject = null;

        #endregion

        #region Constructor

        public CDestiny_samplesFactory()
        {
            _dataObject = new CDestiny_samplesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CDestiny_samples
        /// </summary>
        /// <param name="businessObject">CDestiny_samples object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CDestiny_samples businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CDestiny_samples
        /// </summary>
        /// <param name="businessObject">CDestiny_samples object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CDestiny_samples businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CDestiny_samples by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CDestiny_samples GetByPrimaryKey(CDestiny_samplesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CDestiny_sampless
        /// </summary>
        /// <returns>list</returns>
        public List<CDestiny_samples> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CDestiny_sampless
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CDestiny_samples by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CDestiny_samples> GetAllBy(CDestiny_samples.CDestiny_samplesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CDestiny_samplesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CDestiny_samples by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CDestiny_samples.CDestiny_samplesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
