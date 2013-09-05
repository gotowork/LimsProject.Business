using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CCalibFactory
    {

        #region data Members

        CCalibSql _dataObject = null;

        #endregion

        #region Constructor

        public CCalibFactory()
        {
            _dataObject = new CCalibSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CCalib
        /// </summary>
        /// <param name="businessObject">CCalib object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CCalib businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CCalib
        /// </summary>
        /// <param name="businessObject">CCalib object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CCalib businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CCalib by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CCalib GetByPrimaryKey(CCalibKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CCalibs
        /// </summary>
        /// <returns>list</returns>
        public List<CCalib> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CCalibs
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CCalib by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CCalib> GetAllBy(CCalib.CCalibFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CCalibKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CCalib by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CCalib.CCalibFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
