using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CCompanyFactory
    {

        #region data Members

        CCompanySql _dataObject = null;

        #endregion

        #region Constructor

        public CCompanyFactory()
        {
            _dataObject = new CCompanySql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CCompany
        /// </summary>
        /// <param name="businessObject">CCompany object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CCompany businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CCompany
        /// </summary>
        /// <param name="businessObject">CCompany object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CCompany businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CCompany by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CCompany GetByPrimaryKey(CCompanyKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CCompanys
        /// </summary>
        /// <returns>list</returns>
        public List<CCompany> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CCompanys
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CCompany by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CCompany> GetAllBy(CCompany.CCompanyFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CCompanyKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CCompany by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CCompany.CCompanyFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
