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
	/// Data access layer class for CTemplate_method_detail
	/// </summary>
	partial class CTemplate_method_detailSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CTemplate_method_detailSql()
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
		public bool Insert(CTemplate_method_detail businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_template_method_detail_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method_detail", businessObject.Idtemplate_method_detail);
				sqlCommand.Parameters["p_idtemplate_method_detail"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idtemplate_method_detail"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_name_variable", businessObject.Name_variable);
				sqlCommand.Parameters["p_name_variable"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_alias_variable", businessObject.Alias_variable);
				sqlCommand.Parameters["p_alias_variable"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_value_variable", businessObject.Value_variable);
				sqlCommand.Parameters["p_value_variable"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_type_variable", businessObject.Type_variable);
				sqlCommand.Parameters["p_type_variable"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_group_variable", businessObject.Group_variable);
				sqlCommand.Parameters["p_group_variable"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_visible", businessObject.Visible);
				sqlCommand.Parameters["p_visible"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idtemplate_method_detail = Convert.ToInt32(sqlCommand.Parameters["p_idtemplate_method_detail"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CTemplate_method_detail::Insert::Error occured.", ex);
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
        public bool Update(CTemplate_method_detail businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_detail_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method_detail", businessObject.Idtemplate_method_detail);
				sqlCommand.Parameters["p_idtemplate_method_detail"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_name_variable", businessObject.Name_variable);
				sqlCommand.Parameters["p_name_variable"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_alias_variable", businessObject.Alias_variable);
				sqlCommand.Parameters["p_alias_variable"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_value_variable", businessObject.Value_variable);
				sqlCommand.Parameters["p_value_variable"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_type_variable", businessObject.Type_variable);
				sqlCommand.Parameters["p_type_variable"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_group_variable", businessObject.Group_variable);
				sqlCommand.Parameters["p_group_variable"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_visible", businessObject.Visible);
				sqlCommand.Parameters["p_visible"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CTemplate_method_detail::Update::Error occured.", ex);
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
        /// <returns>CTemplate_method_detail business object</returns>
        public CTemplate_method_detail SelectByPrimaryKey(CTemplate_method_detailKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_detail_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idtemplate_method_detail", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idtemplate_method_detail));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CTemplate_method_detail businessObject = new CTemplate_method_detail();

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
                throw new Exception("CTemplate_method_detail::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CTemplate_method_detail</returns>
        public List<CTemplate_method_detail> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_detail_SelectAll";
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
                throw new Exception("CTemplate_method_detail::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_template_method_detail_SelectAll";
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
                throw new Exception("CTemplate_method_detail::SelectAll::Error occured.", ex);
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
        /// <returns>list of CTemplate_method_detail</returns>
        public List<CTemplate_method_detail> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_detail_SelectByField";
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
                throw new Exception("CTemplate_method_detail::SelectByField::Error occured.", ex);
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
        public bool Delete(CTemplate_method_detailKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_detail_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idtemplate_method_detail", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idtemplate_method_detail));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTemplate_method_detail::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_template_method_detail_DeleteByField";
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
                throw new Exception("CTemplate_method_detail::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CTemplate_method_detail businessObject, IDataReader dataReader)
        {


				businessObject.Idtemplate_method_detail = dataReader.GetInt32(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Idtemplate_method_detail.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Name_variable.ToString())))
				{
					businessObject.Name_variable = dataReader.GetString(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Name_variable.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Alias_variable.ToString())))
				{
					businessObject.Alias_variable = dataReader.GetString(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Alias_variable.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Value_variable.ToString())))
				{
					businessObject.Value_variable = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Value_variable.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Type_variable.ToString())))
				{
					businessObject.Type_variable = dataReader.GetChar(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Type_variable.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Group_variable.ToString())))
				{
					businessObject.Group_variable = dataReader.GetChar(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Group_variable.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Visible.ToString())))
				{
					businessObject.Visible = dataReader.GetBoolean(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Visible.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Idtemplate_method.ToString())))
				{
					businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Idtemplate_method.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CTemplate_method_detail.CTemplate_method_detailFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CTemplate_method_detail</returns>
        internal List<CTemplate_method_detail> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CTemplate_method_detail> list = new List<CTemplate_method_detail>();

            while (dataReader.Read())
            {
                CTemplate_method_detail businessObject = new CTemplate_method_detail();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
