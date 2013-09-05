using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer;

namespace LimsProject.BusinessLayer
{
    public partial class CGroup_solutionFactory
    {

        #region data Members

        CGroup_solutionSql _dataObject = null;

        #endregion

        #region Constructor

        public CGroup_solutionFactory()
        {
            _dataObject = new CGroup_solutionSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CGroup_solution
        /// </summary>
        /// <param name="businessObject">CGroup_solution object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CGroup_solution businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CGroup_solution
        /// </summary>
        /// <param name="businessObject">CGroup_solution object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CGroup_solution businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CGroup_solution by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CGroup_solution GetByPrimaryKey(CGroup_solutionKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CGroup_solutions
        /// </summary>
        /// <returns>list</returns>
        public List<CGroup_solution> GetAll()
        {
            return _dataObject.SelectAll(); 
        }


        /// <summary>
        /// get datatable of all CGroup_solutions
        /// </summary>
        /// <returns>list</returns>
        public DataTable GetAllDataTable()
        {
            return _dataObject.SelectAllDataTable(); 
        }
        /// <summary>
        /// get list of CGroup_solution by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CGroup_solution> GetAllBy(CGroup_solution.CGroup_solutionFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CGroup_solutionKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CGroup_solution by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CGroup_solution.CGroup_solutionFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
