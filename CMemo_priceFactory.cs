using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CMemo_priceFactory
    {

        #region data Members

        CMemo_priceSql _dataObject = null;

        #endregion

        #region Constructor

        public CMemo_priceFactory()
        {
            _dataObject = new CMemo_priceSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CMemo_price
        /// </summary>
        /// <param name="businessObject">CMemo_price object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CMemo_price businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CMemo_price
        /// </summary>
        /// <param name="businessObject">CMemo_price object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CMemo_price businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CMemo_price by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CMemo_price GetByPrimaryKey(CMemo_priceKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CMemo_prices
        /// </summary>
        /// <returns>list</returns>
        public List<CMemo_price> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CMemo_prices
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CMemo_price by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CMemo_price> GetAllBy(CMemo_price.CMemo_priceFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CMemo_priceKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CMemo_price by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CMemo_price.CMemo_priceFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
