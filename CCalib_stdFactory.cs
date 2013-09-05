using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CCalib_stdFactory
    {

        #region data Members

        CCalib_stdSql _dataObject = null;

        #endregion

        #region Constructor

        public CCalib_stdFactory()
        {
            _dataObject = new CCalib_stdSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CCalib_std
        /// </summary>
        /// <param name="businessObject">CCalib_std object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CCalib_std businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CCalib_std
        /// </summary>
        /// <param name="businessObject">CCalib_std object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CCalib_std businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CCalib_std by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CCalib_std GetByPrimaryKey(CCalib_stdKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CCalib_stds
        /// </summary>
        /// <returns>list</returns>
        public List<CCalib_std> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CCalib_stds
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CCalib_std by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CCalib_std> GetAllBy(CCalib_std.CCalib_stdFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CCalib_stdKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CCalib_std by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CCalib_std.CCalib_stdFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
