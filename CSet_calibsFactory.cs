using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CSet_calibsFactory
    {

        #region data Members

        CSet_calibsSql _dataObject = null;

        #endregion

        #region Constructor

        public CSet_calibsFactory()
        {
            _dataObject = new CSet_calibsSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CSet_calibs
        /// </summary>
        /// <param name="businessObject">CSet_calibs object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CSet_calibs businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CSet_calibs
        /// </summary>
        /// <param name="businessObject">CSet_calibs object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CSet_calibs businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CSet_calibs by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CSet_calibs GetByPrimaryKey(CSet_calibsKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CSet_calibss
        /// </summary>
        /// <returns>list</returns>
        public List<CSet_calibs> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CSet_calibss
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CSet_calibs by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CSet_calibs> GetAllBy(CSet_calibs.CSet_calibsFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CSet_calibsKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CSet_calibs by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CSet_calibs.CSet_calibsFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
