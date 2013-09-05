using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CTablempnFactory
    {

        #region data Members

        CTablempnSql _dataObject = null;

        #endregion

        #region Constructor

        public CTablempnFactory()
        {
            _dataObject = new CTablempnSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CTablempn
        /// </summary>
        /// <param name="businessObject">CTablempn object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CTablempn businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CTablempn
        /// </summary>
        /// <param name="businessObject">CTablempn object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CTablempn businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CTablempn by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CTablempn GetByPrimaryKey(CTablempnKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CTablempns
        /// </summary>
        /// <returns>list</returns>
        public List<CTablempn> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CTablempns
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CTablempn by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CTablempn> GetAllBy(CTablempn.CTablempnFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CTablempnKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CTablempn by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CTablempn.CTablempnFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
