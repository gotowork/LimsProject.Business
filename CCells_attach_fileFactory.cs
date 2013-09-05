using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CCells_attach_fileFactory
    {

        #region data Members

        CCells_attach_fileSql _dataObject = null;

        #endregion

        #region Constructor

        public CCells_attach_fileFactory()
        {
            _dataObject = new CCells_attach_fileSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CCells_attach_file
        /// </summary>
        /// <param name="businessObject">CCells_attach_file object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CCells_attach_file businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CCells_attach_file
        /// </summary>
        /// <param name="businessObject">CCells_attach_file object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CCells_attach_file businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CCells_attach_file by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CCells_attach_file GetByPrimaryKey(CCells_attach_fileKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CCells_attach_files
        /// </summary>
        /// <returns>list</returns>
        public List<CCells_attach_file> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CCells_attach_files
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CCells_attach_file by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CCells_attach_file> GetAllBy(CCells_attach_file.CCells_attach_fileFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CCells_attach_fileKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CCells_attach_file by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CCells_attach_file.CCells_attach_fileFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
