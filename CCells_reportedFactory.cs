using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CCells_reportedFactory
    {

        #region data Members

        CCells_reportedSql _dataObject = null;

        #endregion

        #region Constructor

        public CCells_reportedFactory()
        {
            _dataObject = new CCells_reportedSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CCells_reported
        /// </summary>
        /// <param name="businessObject">CCells_reported object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CCells_reported businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CCells_reported
        /// </summary>
        /// <param name="businessObject">CCells_reported object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CCells_reported businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CCells_reported by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CCells_reported GetByPrimaryKey(CCells_reportedKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CCells_reporteds
        /// </summary>
        /// <returns>list</returns>
        public List<CCells_reported> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CCells_reporteds
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CCells_reported by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CCells_reported> GetAllBy(CCells_reported.CCells_reportedFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CCells_reportedKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CCells_reported by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CCells_reported.CCells_reportedFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
