using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CPrice_company_personFactory
    {

        #region data Members

        CPrice_company_personSql _dataObject = null;

        #endregion

        #region Constructor

        public CPrice_company_personFactory()
        {
            _dataObject = new CPrice_company_personSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CPrice_company_person
        /// </summary>
        /// <param name="businessObject">CPrice_company_person object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CPrice_company_person businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CPrice_company_person
        /// </summary>
        /// <param name="businessObject">CPrice_company_person object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CPrice_company_person businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CPrice_company_person by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CPrice_company_person GetByPrimaryKey(CPrice_company_personKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CPrice_company_persons
        /// </summary>
        /// <returns>list</returns>
        public List<CPrice_company_person> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CPrice_company_persons
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CPrice_company_person by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CPrice_company_person> GetAllBy(CPrice_company_person.CPrice_company_personFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CPrice_company_personKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CPrice_company_person by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CPrice_company_person.CPrice_company_personFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
