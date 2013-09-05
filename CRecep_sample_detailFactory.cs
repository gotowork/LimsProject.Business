using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CRecep_sample_detailFactory
    {

        #region data Members

        CRecep_sample_detailSql _dataObject = null;

        #endregion

        #region Constructor

        public CRecep_sample_detailFactory()
        {
            _dataObject = new CRecep_sample_detailSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CRecep_sample_detail
        /// </summary>
        /// <param name="businessObject">CRecep_sample_detail object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CRecep_sample_detail businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CRecep_sample_detail
        /// </summary>
        /// <param name="businessObject">CRecep_sample_detail object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CRecep_sample_detail businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CRecep_sample_detail by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CRecep_sample_detail GetByPrimaryKey(CRecep_sample_detailKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CRecep_sample_details
        /// </summary>
        /// <returns>list</returns>
        public List<CRecep_sample_detail> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CRecep_sample_details
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CRecep_sample_detail by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CRecep_sample_detail> GetAllBy(CRecep_sample_detail.CRecep_sample_detailFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CRecep_sample_detailKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CRecep_sample_detail by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CRecep_sample_detail.CRecep_sample_detailFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
