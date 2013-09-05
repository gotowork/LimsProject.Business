using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CType_sample_controlFactory
    {

        #region data Members

        CType_sample_controlSql _dataObject = null;

        #endregion

        #region Constructor

        public CType_sample_controlFactory()
        {
            _dataObject = new CType_sample_controlSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CType_sample_control
        /// </summary>
        /// <param name="businessObject">CType_sample_control object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CType_sample_control businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CType_sample_control
        /// </summary>
        /// <param name="businessObject">CType_sample_control object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CType_sample_control businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CType_sample_control by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CType_sample_control GetByPrimaryKey(CType_sample_controlKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CType_sample_controls
        /// </summary>
        /// <returns>list</returns>
        public List<CType_sample_control> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CType_sample_controls
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CType_sample_control by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CType_sample_control> GetAllBy(CType_sample_control.CType_sample_controlFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CType_sample_controlKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CType_sample_control by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CType_sample_control.CType_sample_controlFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
