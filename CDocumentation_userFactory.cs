using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CDocumentation_userFactory
    {

        #region data Members

        CDocumentation_userSql _dataObject = null;

        #endregion

        #region Constructor

        public CDocumentation_userFactory()
        {
            _dataObject = new CDocumentation_userSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CDocumentation_user
        /// </summary>
        /// <param name="businessObject">CDocumentation_user object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CDocumentation_user businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CDocumentation_user
        /// </summary>
        /// <param name="businessObject">CDocumentation_user object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CDocumentation_user businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CDocumentation_user by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CDocumentation_user GetByPrimaryKey(CDocumentation_userKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CDocumentation_users
        /// </summary>
        /// <returns>list</returns>
        public List<CDocumentation_user> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CDocumentation_users
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CDocumentation_user by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CDocumentation_user> GetAllBy(CDocumentation_user.CDocumentation_userFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CDocumentation_userKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CDocumentation_user by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CDocumentation_user.CDocumentation_userFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
