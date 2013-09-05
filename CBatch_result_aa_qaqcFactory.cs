using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CBatch_result_aa_qaqcFactory
    {

        #region data Members

        CBatch_result_aa_qaqcSql _dataObject = null;

        #endregion

        #region Constructor

        public CBatch_result_aa_qaqcFactory()
        {
            _dataObject = new CBatch_result_aa_qaqcSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CBatch_result_aa_qaqc
        /// </summary>
        /// <param name="businessObject">CBatch_result_aa_qaqc object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CBatch_result_aa_qaqc businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CBatch_result_aa_qaqc
        /// </summary>
        /// <param name="businessObject">CBatch_result_aa_qaqc object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CBatch_result_aa_qaqc businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CBatch_result_aa_qaqc by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CBatch_result_aa_qaqc GetByPrimaryKey(CBatch_result_aa_qaqcKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CBatch_result_aa_qaqcs
        /// </summary>
        /// <returns>list</returns>
        public List<CBatch_result_aa_qaqc> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CBatch_result_aa_qaqcs
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CBatch_result_aa_qaqc by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CBatch_result_aa_qaqc> GetAllBy(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CBatch_result_aa_qaqcKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CBatch_result_aa_qaqc by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
