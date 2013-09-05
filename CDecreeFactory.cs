using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CDecreeFactory
    {

        #region data Members

        CDecreeSql _dataObject = null;

        #endregion

        #region Constructor

        public CDecreeFactory()
        {
            _dataObject = new CDecreeSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CDecree
        /// </summary>
        /// <param name="businessObject">CDecree object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CDecree businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CDecree
        /// </summary>
        /// <param name="businessObject">CDecree object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CDecree businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CDecree by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CDecree GetByPrimaryKey(CDecreeKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CDecrees
        /// </summary>
        /// <returns>list</returns>
        public List<CDecree> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CDecrees
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CDecree by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CDecree> GetAllBy(CDecree.CDecreeFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CDecreeKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CDecree by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CDecree.CDecreeFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
