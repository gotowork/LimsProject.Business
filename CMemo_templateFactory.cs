using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CMemo_templateFactory
    {

        #region data Members

        CMemo_templateSql _dataObject = null;

        #endregion

        #region Constructor

        public CMemo_templateFactory()
        {
            _dataObject = new CMemo_templateSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CMemo_template
        /// </summary>
        /// <param name="businessObject">CMemo_template object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CMemo_template businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CMemo_template
        /// </summary>
        /// <param name="businessObject">CMemo_template object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CMemo_template businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CMemo_template by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CMemo_template GetByPrimaryKey(CMemo_templateKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CMemo_templates
        /// </summary>
        /// <returns>list</returns>
        public List<CMemo_template> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CMemo_templates
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CMemo_template by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CMemo_template> GetAllBy(CMemo_template.CMemo_templateFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CMemo_templateKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CMemo_template by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CMemo_template.CMemo_templateFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
