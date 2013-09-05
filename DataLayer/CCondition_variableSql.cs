using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using Npgsql;
using NpgsqlTypes;

namespace LimsProject.BusinessLayer.DataLayer
{
	/// <summary>
	/// Data access layer class for CCondition_variable
	/// </summary>
	partial class CCondition_variableSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CCondition_variableSql()
		{
			// Nothing for now.
		}

        #endregion

        #region Public Methods

        /// <summary>
        /// insert new row in the table
        /// </summary>
		/// <param name="businessObject">business object</param>
		/// <returns>true of successfully insert</returns>
		public bool Insert(CCondition_variable businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_condition_variable_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idcondition_variable", businessObject.Idcondition_variable);
				sqlCommand.Parameters["p_idcondition_variable"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idcondition_variable"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_name_variable", businessObject.Name_variable);
				sqlCommand.Parameters["p_name_variable"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_operation", businessObject.Operation);
				sqlCommand.Parameters["p_operation"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_name_value1", businessObject.Name_value1);
				sqlCommand.Parameters["p_name_value1"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_name_value2", businessObject.Name_value2);
				sqlCommand.Parameters["p_name_value2"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idvalue1", businessObject.Idvalue1);
				sqlCommand.Parameters["p_idvalue1"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idvalue2", businessObject.Idvalue2);
				sqlCommand.Parameters["p_idvalue2"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_message", businessObject.Message);
				sqlCommand.Parameters["p_message"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method_detail", businessObject.Idtemplate_method_detail);
				sqlCommand.Parameters["p_idtemplate_method_detail"].NpgsqlDbType = NpgsqlDbType.Bigint;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idcondition_variable = Convert.ToInt32(sqlCommand.Parameters["p_idcondition_variable"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CCondition_variable::Insert::Error occured.", ex);
			}
			finally
			{			
				MainConnection.Close();
				sqlCommand.Dispose();
			}
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(CCondition_variable businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_condition_variable_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idcondition_variable", businessObject.Idcondition_variable);
				sqlCommand.Parameters["p_idcondition_variable"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_name_variable", businessObject.Name_variable);
				sqlCommand.Parameters["p_name_variable"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_operation", businessObject.Operation);
				sqlCommand.Parameters["p_operation"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_name_value1", businessObject.Name_value1);
				sqlCommand.Parameters["p_name_value1"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_name_value2", businessObject.Name_value2);
				sqlCommand.Parameters["p_name_value2"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idvalue1", businessObject.Idvalue1);
				sqlCommand.Parameters["p_idvalue1"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idvalue2", businessObject.Idvalue2);
				sqlCommand.Parameters["p_idvalue2"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_message", businessObject.Message);
				sqlCommand.Parameters["p_message"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method_detail", businessObject.Idtemplate_method_detail);
				sqlCommand.Parameters["p_idtemplate_method_detail"].NpgsqlDbType = NpgsqlDbType.Bigint;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CCondition_variable::Update::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>CCondition_variable business object</returns>
        public CCondition_variable SelectByPrimaryKey(CCondition_variableKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_condition_variable_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idcondition_variable", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idcondition_variable));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CCondition_variable businessObject = new CCondition_variable();

                    PopulateBusinessObjectFromReader(businessObject, dataReader);

                    return businessObject;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("CCondition_variable::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of CCondition_variable</returns>
        public List<CCondition_variable> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_condition_variable_SelectAll";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {                
                throw new Exception("CCondition_variable::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public DataTable SelectAllDataTable()
        {
            
            DataTable dt = new DataTable();
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_condition_variable_SelectAll";
            sqlCommand.CommandType = CommandType.StoredProcedure;                        
            sqlCommand.Connection = MainConnection;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlCommand);

            try
            {                
                MainConnection.Open();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("CCondition_variable::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Select records by field
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>list of CCondition_variable</returns>
        public List<CCondition_variable> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_condition_variable_SelectByField";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new NpgsqlParameter("FieldName", fieldName));
                sqlCommand.Parameters.Add(new NpgsqlParameter("Value", value));

                MainConnection.Open();
                
                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {
                throw new Exception("CCondition_variable::SelectByField::Error occured.", ex);
            }
            finally
            {

                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Delete by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CCondition_variableKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_condition_variable_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idcondition_variable", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idcondition_variable));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CCondition_variable::DeleteByKey::Error occured.", ex);
            }
            finally
            {                
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Delete records by field
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>true for successfully deleted</returns>
        public bool DeleteByField(string fieldName, object value)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_condition_variable_DeleteByField";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new NpgsqlParameter("FieldName", fieldName));
                sqlCommand.Parameters.Add(new NpgsqlParameter("Value", value));
                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {                
                throw new Exception("CCondition_variable::DeleteByField::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Populate business object from data reader
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <param name="dataReader">data reader</param>
        internal void PopulateBusinessObjectFromReader(CCondition_variable businessObject, IDataReader dataReader)
        {


				businessObject.Idcondition_variable = dataReader.GetInt32(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Idcondition_variable.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Name_variable.ToString())))
				{
					businessObject.Name_variable = dataReader.GetString(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Name_variable.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Operation.ToString())))
				{
					businessObject.Operation = dataReader.GetString(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Operation.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Name_value1.ToString())))
				{
					businessObject.Name_value1 = dataReader.GetString(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Name_value1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Name_value2.ToString())))
				{
					businessObject.Name_value2 = dataReader.GetString(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Name_value2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Idvalue1.ToString())))
				{
					businessObject.Idvalue1 = dataReader.GetInt32(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Idvalue1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Idvalue2.ToString())))
				{
					businessObject.Idvalue2 = dataReader.GetInt32(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Idvalue2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Message.ToString())))
				{
					businessObject.Message = dataReader.GetString(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Message.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Status.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Idtemplate_method.ToString())))
				{
					businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Idtemplate_method.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Idtemplate_method_detail.ToString())))
				{
					businessObject.Idtemplate_method_detail = dataReader.GetInt64(dataReader.GetOrdinal(CCondition_variable.CCondition_variableFields.Idtemplate_method_detail.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CCondition_variable</returns>
        internal List<CCondition_variable> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CCondition_variable> list = new List<CCondition_variable>();

            while (dataReader.Read())
            {
                CCondition_variable businessObject = new CCondition_variable();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
