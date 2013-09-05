using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CProfile_systemFactory
    {

        #region data Members

        CProfile_systemSql _dataObject = null;

        #endregion

        #region Constructor

        public CProfile_systemFactory()
        {
            _dataObject = new CProfile_systemSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CProfile_system
        /// </summary>
        /// <param name="businessObject">CProfile_system object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CProfile_system businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CProfile_system
        /// </summary>
        /// <param name="businessObject">CProfile_system object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CProfile_system businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CProfile_system by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CProfile_system GetByPrimaryKey(CProfile_systemKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CProfile_systems
        /// </summary>
        /// <returns>list</returns>
        public List<CProfile_system> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CProfile_systems
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CProfile_system by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CProfile_system> GetAllBy(CProfile_system.CProfile_systemFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CProfile_systemKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CProfile_system by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CProfile_system.CProfile_systemFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
