using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CCompany_personFactory
    {

        #region data Members

        CCompany_personSql _dataObject = null;

        #endregion

        #region Constructor

        public CCompany_personFactory()
        {
            _dataObject = new CCompany_personSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CCompany_person
        /// </summary>
        /// <param name="businessObject">CCompany_person object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CCompany_person businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CCompany_person
        /// </summary>
        /// <param name="businessObject">CCompany_person object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CCompany_person businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CCompany_person by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CCompany_person GetByPrimaryKey(CCompany_personKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CCompany_persons
        /// </summary>
        /// <returns>list</returns>
        public List<CCompany_person> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CCompany_persons
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CCompany_person by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CCompany_person> GetAllBy(CCompany_person.CCompany_personFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CCompany_personKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CCompany_person by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CCompany_person.CCompany_personFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
