using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CMeasurement_unitFactory
    {

        #region data Members

        CMeasurement_unitSql _dataObject = null;

        #endregion

        #region Constructor

        public CMeasurement_unitFactory()
        {
            _dataObject = new CMeasurement_unitSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CMeasurement_unit
        /// </summary>
        /// <param name="businessObject">CMeasurement_unit object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CMeasurement_unit businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CMeasurement_unit
        /// </summary>
        /// <param name="businessObject">CMeasurement_unit object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CMeasurement_unit businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CMeasurement_unit by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CMeasurement_unit GetByPrimaryKey(CMeasurement_unitKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CMeasurement_units
        /// </summary>
        /// <returns>list</returns>
        public List<CMeasurement_unit> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CMeasurement_units
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CMeasurement_unit by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CMeasurement_unit> GetAllBy(CMeasurement_unit.CMeasurement_unitFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CMeasurement_unitKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CMeasurement_unit by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CMeasurement_unit.CMeasurement_unitFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
