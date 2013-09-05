using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CIcp_lecturasFactory
    {

        #region data Members

        CIcp_lecturasSql _dataObject = null;

        #endregion

        #region Constructor

        public CIcp_lecturasFactory()
        {
            _dataObject = new CIcp_lecturasSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CIcp_lecturas
        /// </summary>
        /// <param name="businessObject">CIcp_lecturas object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CIcp_lecturas businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CIcp_lecturas
        /// </summary>
        /// <param name="businessObject">CIcp_lecturas object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CIcp_lecturas businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CIcp_lecturas by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CIcp_lecturas GetByPrimaryKey(CIcp_lecturasKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CIcp_lecturass
        /// </summary>
        /// <returns>list</returns>
        public List<CIcp_lecturas> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CIcp_lecturass
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CIcp_lecturas by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CIcp_lecturas> GetAllBy(CIcp_lecturas.CIcp_lecturasFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CIcp_lecturasKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CIcp_lecturas by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CIcp_lecturas.CIcp_lecturasFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
