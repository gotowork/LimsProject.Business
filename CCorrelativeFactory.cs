using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CCorrelativeFactory
    {

        #region data Members

        CCorrelativeSql _dataObject = null;

        #endregion

        #region Constructor

        public CCorrelativeFactory()
        {
            _dataObject = new CCorrelativeSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CCorrelative
        /// </summary>
        /// <param name="businessObject">CCorrelative object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CCorrelative businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CCorrelative
        /// </summary>
        /// <param name="businessObject">CCorrelative object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CCorrelative businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CCorrelative by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CCorrelative GetByPrimaryKey(CCorrelativeKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CCorrelatives
        /// </summary>
        /// <returns>list</returns>
        public List<CCorrelative> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CCorrelatives
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CCorrelative by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CCorrelative> GetAllBy(CCorrelative.CCorrelativeFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CCorrelativeKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CCorrelative by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CCorrelative.CCorrelativeFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
