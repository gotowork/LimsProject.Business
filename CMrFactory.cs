using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CMrFactory
    {

        #region data Members

        CMrSql _dataObject = null;

        #endregion

        #region Constructor

        public CMrFactory()
        {
            _dataObject = new CMrSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CMr
        /// </summary>
        /// <param name="businessObject">CMr object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CMr businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CMr
        /// </summary>
        /// <param name="businessObject">CMr object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CMr businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CMr by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CMr GetByPrimaryKey(CMrKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CMrs
        /// </summary>
        /// <returns>list</returns>
        public List<CMr> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CMrs
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CMr by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CMr> GetAllBy(CMr.CMrFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CMrKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CMr by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CMr.CMrFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
