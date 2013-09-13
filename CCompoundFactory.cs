using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CCompoundFactory
    {

        #region data Members

        CCompoundSql _dataObject = null;

        #endregion

        #region Constructor

        public CCompoundFactory()
        {
            _dataObject = new CCompoundSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CCompound
        /// </summary>
        /// <param name="businessObject">CCompound object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CCompound businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CCompound
        /// </summary>
        /// <param name="businessObject">CCompound object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CCompound businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CCompound by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CCompound GetByPrimaryKey(CCompoundKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CCompounds
        /// </summary>
        /// <returns>list</returns>
        public List<CCompound> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CCompounds
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CCompound by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CCompound> GetAllBy(CCompound.CCompoundFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CCompoundKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CCompound by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CCompound.CCompoundFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
