using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CMatrix_itemFactory
    {

        #region data Members

        CMatrix_itemSql _dataObject = null;

        #endregion

        #region Constructor

        public CMatrix_itemFactory()
        {
            _dataObject = new CMatrix_itemSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CMatrix_item
        /// </summary>
        /// <param name="businessObject">CMatrix_item object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CMatrix_item businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CMatrix_item
        /// </summary>
        /// <param name="businessObject">CMatrix_item object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CMatrix_item businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CMatrix_item by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CMatrix_item GetByPrimaryKey(CMatrix_itemKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CMatrix_items
        /// </summary>
        /// <returns>list</returns>
        public List<CMatrix_item> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CMatrix_items
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CMatrix_item by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CMatrix_item> GetAllBy(CMatrix_item.CMatrix_itemFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CMatrix_itemKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CMatrix_item by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CMatrix_item.CMatrix_itemFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
