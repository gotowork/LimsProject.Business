using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CTitration_mainFactory
    {

        #region data Members

        CTitration_mainSql _dataObject = null;

        #endregion

        #region Constructor

        public CTitration_mainFactory()
        {
            _dataObject = new CTitration_mainSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CTitration_main
        /// </summary>
        /// <param name="businessObject">CTitration_main object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CTitration_main businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CTitration_main
        /// </summary>
        /// <param name="businessObject">CTitration_main object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CTitration_main businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CTitration_main by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CTitration_main GetByPrimaryKey(CTitration_mainKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CTitration_mains
        /// </summary>
        /// <returns>list</returns>
        public List<CTitration_main> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CTitration_mains
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CTitration_main by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CTitration_main> GetAllBy(CTitration_main.CTitration_mainFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CTitration_mainKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CTitration_main by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CTitration_main.CTitration_mainFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
