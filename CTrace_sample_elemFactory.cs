using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CTrace_sample_elemFactory
    {

        #region data Members

        CTrace_sample_elemSql _dataObject = null;

        #endregion

        #region Constructor

        public CTrace_sample_elemFactory()
        {
            _dataObject = new CTrace_sample_elemSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CTrace_sample_elem
        /// </summary>
        /// <param name="businessObject">CTrace_sample_elem object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CTrace_sample_elem businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CTrace_sample_elem
        /// </summary>
        /// <param name="businessObject">CTrace_sample_elem object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CTrace_sample_elem businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CTrace_sample_elem by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CTrace_sample_elem GetByPrimaryKey(CTrace_sample_elemKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CTrace_sample_elems
        /// </summary>
        /// <returns>list</returns>
        public List<CTrace_sample_elem> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CTrace_sample_elems
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CTrace_sample_elem by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CTrace_sample_elem> GetAllBy(CTrace_sample_elem.CTrace_sample_elemFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CTrace_sample_elemKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CTrace_sample_elem by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CTrace_sample_elem.CTrace_sample_elemFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
