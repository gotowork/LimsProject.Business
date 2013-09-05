using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CDestiny_sample_recepFactory
    {

        #region data Members

        CDestiny_sample_recepSql _dataObject = null;

        #endregion

        #region Constructor

        public CDestiny_sample_recepFactory()
        {
            _dataObject = new CDestiny_sample_recepSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CDestiny_sample_recep
        /// </summary>
        /// <param name="businessObject">CDestiny_sample_recep object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CDestiny_sample_recep businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CDestiny_sample_recep
        /// </summary>
        /// <param name="businessObject">CDestiny_sample_recep object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CDestiny_sample_recep businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CDestiny_sample_recep by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CDestiny_sample_recep GetByPrimaryKey(CDestiny_sample_recepKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CDestiny_sample_receps
        /// </summary>
        /// <returns>list</returns>
        public List<CDestiny_sample_recep> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CDestiny_sample_receps
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CDestiny_sample_recep by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CDestiny_sample_recep> GetAllBy(CDestiny_sample_recep.CDestiny_sample_recepFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CDestiny_sample_recepKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CDestiny_sample_recep by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CDestiny_sample_recep.CDestiny_sample_recepFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
