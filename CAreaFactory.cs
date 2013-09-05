using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CAreaFactory
    {

        #region data Members

        CAreaSql _dataObject = null;

        #endregion

        #region Constructor

        public CAreaFactory()
        {
            _dataObject = new CAreaSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CArea
        /// </summary>
        /// <param name="businessObject">CArea object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CArea businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CArea
        /// </summary>
        /// <param name="businessObject">CArea object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CArea businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CArea by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CArea GetByPrimaryKey(CAreaKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CAreas
        /// </summary>
        /// <returns>list</returns>
        public List<CArea> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CAreas
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CArea by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CArea> GetAllBy(CArea.CAreaFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CAreaKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CArea by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CArea.CAreaFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
