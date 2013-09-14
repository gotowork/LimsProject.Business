using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CTemplate_method_vcFactory
    {

        #region data Members

        CTemplate_method_vcSql _dataObject = null;

        #endregion

        #region Constructor

        public CTemplate_method_vcFactory()
        {
            _dataObject = new CTemplate_method_vcSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CTemplate_method_vc
        /// </summary>
        /// <param name="businessObject">CTemplate_method_vc object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CTemplate_method_vc businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CTemplate_method_vc
        /// </summary>
        /// <param name="businessObject">CTemplate_method_vc object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CTemplate_method_vc businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CTemplate_method_vc by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CTemplate_method_vc GetByPrimaryKey(CTemplate_method_vcKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CTemplate_method_vcs
        /// </summary>
        /// <returns>list</returns>
        public List<CTemplate_method_vc> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CTemplate_method_vcs
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CTemplate_method_vc by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CTemplate_method_vc> GetAllBy(CTemplate_method_vc.CTemplate_method_vcFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CTemplate_method_vcKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CTemplate_method_vc by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CTemplate_method_vc.CTemplate_method_vcFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
