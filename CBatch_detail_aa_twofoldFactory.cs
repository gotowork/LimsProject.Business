using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CBatch_detail_aa_twofoldFactory
    {

        #region data Members

        CBatch_detail_aa_twofoldSql _dataObject = null;

        #endregion

        #region Constructor

        public CBatch_detail_aa_twofoldFactory()
        {
            _dataObject = new CBatch_detail_aa_twofoldSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CBatch_detail_aa_twofold
        /// </summary>
        /// <param name="businessObject">CBatch_detail_aa_twofold object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CBatch_detail_aa_twofold businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CBatch_detail_aa_twofold
        /// </summary>
        /// <param name="businessObject">CBatch_detail_aa_twofold object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CBatch_detail_aa_twofold businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CBatch_detail_aa_twofold by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CBatch_detail_aa_twofold GetByPrimaryKey(CBatch_detail_aa_twofoldKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CBatch_detail_aa_twofolds
        /// </summary>
        /// <returns>list</returns>
        public List<CBatch_detail_aa_twofold> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CBatch_detail_aa_twofolds
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CBatch_detail_aa_twofold by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CBatch_detail_aa_twofold> GetAllBy(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CBatch_detail_aa_twofoldKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CBatch_detail_aa_twofold by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
