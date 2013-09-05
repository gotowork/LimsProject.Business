using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CUser_systemFactory
    {

        #region data Members

        CUser_systemSql _dataObject = null;

        #endregion

        #region Constructor

        public CUser_systemFactory()
        {
            _dataObject = new CUser_systemSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CUser_system
        /// </summary>
        /// <param name="businessObject">CUser_system object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CUser_system businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CUser_system
        /// </summary>
        /// <param name="businessObject">CUser_system object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CUser_system businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CUser_system by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CUser_system GetByPrimaryKey(CUser_systemKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CUser_systems
        /// </summary>
        /// <returns>list</returns>
        public List<CUser_system> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CUser_systems
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CUser_system by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CUser_system> GetAllBy(CUser_system.CUser_systemFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CUser_systemKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CUser_system by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CUser_system.CUser_systemFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
