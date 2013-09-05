using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CElement_wavelengthFactory
    {

        #region data Members

        CElement_wavelengthSql _dataObject = null;

        #endregion

        #region Constructor

        public CElement_wavelengthFactory()
        {
            _dataObject = new CElement_wavelengthSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CElement_wavelength
        /// </summary>
        /// <param name="businessObject">CElement_wavelength object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CElement_wavelength businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CElement_wavelength
        /// </summary>
        /// <param name="businessObject">CElement_wavelength object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CElement_wavelength businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CElement_wavelength by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CElement_wavelength GetByPrimaryKey(CElement_wavelengthKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CElement_wavelengths
        /// </summary>
        /// <returns>list</returns>
        public List<CElement_wavelength> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CElement_wavelengths
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CElement_wavelength by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CElement_wavelength> GetAllBy(CElement_wavelength.CElement_wavelengthFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CElement_wavelengthKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CElement_wavelength by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CElement_wavelength.CElement_wavelengthFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
