using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CConfiguration_folderFactory
    {

        #region data Members

        CConfiguration_folderSql _dataObject = null;

        #endregion

        #region Constructor

        public CConfiguration_folderFactory()
        {
            _dataObject = new CConfiguration_folderSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CConfiguration_folder
        /// </summary>
        /// <param name="businessObject">CConfiguration_folder object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CConfiguration_folder businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CConfiguration_folder
        /// </summary>
        /// <param name="businessObject">CConfiguration_folder object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CConfiguration_folder businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CConfiguration_folder by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CConfiguration_folder GetByPrimaryKey(CConfiguration_folderKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CConfiguration_folders
        /// </summary>
        /// <returns>list</returns>
        public List<CConfiguration_folder> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CConfiguration_folders
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CConfiguration_folder by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CConfiguration_folder> GetAllBy(CConfiguration_folder.CConfiguration_folderFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CConfiguration_folderKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CConfiguration_folder by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CConfiguration_folder.CConfiguration_folderFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
