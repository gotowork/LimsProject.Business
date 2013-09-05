using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CIcpimportFactory
    {

        #region data Members

        CIcpimportSql _dataObject = null;

        #endregion

        #region Constructor

        public CIcpimportFactory()
        {
            _dataObject = new CIcpimportSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CIcpimport
        /// </summary>
        /// <param name="businessObject">CIcpimport object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CIcpimport businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CIcpimport
        /// </summary>
        /// <param name="businessObject">CIcpimport object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CIcpimport businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CIcpimport by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CIcpimport GetByPrimaryKey(CIcpimportKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CIcpimports
        /// </summary>
        /// <returns>list</returns>
        public List<CIcpimport> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CIcpimports
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CIcpimport by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CIcpimport> GetAllBy(CIcpimport.CIcpimportFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CIcpimportKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CIcpimport by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CIcpimport.CIcpimportFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
