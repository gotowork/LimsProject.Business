using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CElementFactory
    {

        #region data Members

        CElementSql _dataObject = null;

        #endregion

        #region Constructor

        public CElementFactory()
        {
            _dataObject = new CElementSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CElement
        /// </summary>
        /// <param name="businessObject">CElement object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CElement businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CElement
        /// </summary>
        /// <param name="businessObject">CElement object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CElement businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CElement by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CElement GetByPrimaryKey(CElementKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CElements
        /// </summary>
        /// <returns>list</returns>
        public List<CElement> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CElements
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CElement by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CElement> GetAllBy(CElement.CElementFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CElementKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CElement by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CElement.CElementFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
