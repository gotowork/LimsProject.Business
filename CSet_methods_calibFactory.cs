using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CSet_methods_calibFactory
    {

        #region data Members

        CSet_methods_calibSql _dataObject = null;

        #endregion

        #region Constructor

        public CSet_methods_calibFactory()
        {
            _dataObject = new CSet_methods_calibSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CSet_methods_calib
        /// </summary>
        /// <param name="businessObject">CSet_methods_calib object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CSet_methods_calib businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CSet_methods_calib
        /// </summary>
        /// <param name="businessObject">CSet_methods_calib object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CSet_methods_calib businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CSet_methods_calib by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CSet_methods_calib GetByPrimaryKey(CSet_methods_calibKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CSet_methods_calibs
        /// </summary>
        /// <returns>list</returns>
        public List<CSet_methods_calib> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CSet_methods_calibs
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CSet_methods_calib by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CSet_methods_calib> GetAllBy(CSet_methods_calib.CSet_methods_calibFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CSet_methods_calibKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CSet_methods_calib by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CSet_methods_calib.CSet_methods_calibFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
