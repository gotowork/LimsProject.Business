using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CConvert_unit_measurementFactory
    {

        #region data Members

        CConvert_unit_measurementSql _dataObject = null;

        #endregion

        #region Constructor

        public CConvert_unit_measurementFactory()
        {
            _dataObject = new CConvert_unit_measurementSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CConvert_unit_measurement
        /// </summary>
        /// <param name="businessObject">CConvert_unit_measurement object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CConvert_unit_measurement businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CConvert_unit_measurement
        /// </summary>
        /// <param name="businessObject">CConvert_unit_measurement object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CConvert_unit_measurement businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CConvert_unit_measurement by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CConvert_unit_measurement GetByPrimaryKey(CConvert_unit_measurementKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CConvert_unit_measurements
        /// </summary>
        /// <returns>list</returns>
        public List<CConvert_unit_measurement> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CConvert_unit_measurements
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CConvert_unit_measurement by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CConvert_unit_measurement> GetAllBy(CConvert_unit_measurement.CConvert_unit_measurementFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CConvert_unit_measurementKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CConvert_unit_measurement by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CConvert_unit_measurement.CConvert_unit_measurementFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
