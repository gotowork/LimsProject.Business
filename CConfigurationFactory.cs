using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CConfigurationFactory
    {

        #region data Members

        CConfigurationSql _dataObject = null;

        #endregion

        #region Constructor

        public CConfigurationFactory()
        {
            _dataObject = new CConfigurationSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CConfiguration
        /// </summary>
        /// <param name="businessObject">CConfiguration object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CConfiguration businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CConfiguration
        /// </summary>
        /// <param name="businessObject">CConfiguration object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CConfiguration businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CConfiguration by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CConfiguration GetByPrimaryKey(CConfigurationKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CConfigurations
        /// </summary>
        /// <returns>list</returns>
        public List<CConfiguration> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CConfigurations
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CConfiguration by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CConfiguration> GetAllBy(CConfiguration.CConfigurationFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CConfigurationKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CConfiguration by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CConfiguration.CConfigurationFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
