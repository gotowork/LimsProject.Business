using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CMatrix_groupFactory
    {

        #region data Members

        CMatrix_groupSql _dataObject = null;

        #endregion

        #region Constructor

        public CMatrix_groupFactory()
        {
            _dataObject = new CMatrix_groupSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CMatrix_group
        /// </summary>
        /// <param name="businessObject">CMatrix_group object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CMatrix_group businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CMatrix_group
        /// </summary>
        /// <param name="businessObject">CMatrix_group object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CMatrix_group businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CMatrix_group by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CMatrix_group GetByPrimaryKey(CMatrix_groupKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CMatrix_groups
        /// </summary>
        /// <returns>list</returns>
        public List<CMatrix_group> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CMatrix_groups
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CMatrix_group by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CMatrix_group> GetAllBy(CMatrix_group.CMatrix_groupFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CMatrix_groupKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CMatrix_group by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CMatrix_group.CMatrix_groupFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
