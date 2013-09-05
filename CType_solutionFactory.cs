using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CType_solutionFactory
    {

        #region data Members

        CType_solutionSql _dataObject = null;

        #endregion

        #region Constructor

        public CType_solutionFactory()
        {
            _dataObject = new CType_solutionSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CType_solution
        /// </summary>
        /// <param name="businessObject">CType_solution object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CType_solution businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CType_solution
        /// </summary>
        /// <param name="businessObject">CType_solution object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CType_solution businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CType_solution by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CType_solution GetByPrimaryKey(CType_solutionKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CType_solutions
        /// </summary>
        /// <returns>list</returns>
        public List<CType_solution> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CType_solutions
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CType_solution by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CType_solution> GetAllBy(CType_solution.CType_solutionFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CType_solutionKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CType_solution by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CType_solution.CType_solutionFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
