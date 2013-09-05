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
	/// Data access layer class for CDocumentation
	/// </summary>
	partial class CDocumentationSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CDocumentationSql()
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
		public bool Insert(CDocumentation businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_documentation_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_iddocumentation", businessObject.Iddocumentation);
				sqlCommand.Parameters["p_iddocumentation"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters["p_iddocumentation"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idconfiguration_folder", businessObject.Idconfiguration_folder);
				sqlCommand.Parameters["p_idconfiguration_folder"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_procedure_type", businessObject.Procedure_type);
				sqlCommand.Parameters["p_procedure_type"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_code", businessObject.Code);
				sqlCommand.Parameters["p_code"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_name_doc", businessObject.Name_doc);
				sqlCommand.Parameters["p_name_doc"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_type_doc", businessObject.Type_doc);
				sqlCommand.Parameters["p_type_doc"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_id", businessObject.Id);
				sqlCommand.Parameters["p_id"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_parentid", businessObject.Parentid);
				sqlCommand.Parameters["p_parentid"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_flag_enabled", businessObject.Flag_enabled);
				sqlCommand.Parameters["p_flag_enabled"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_image_index", businessObject.Image_index);
				sqlCommand.Parameters["p_image_index"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_usernew", businessObject.Usernew);
				sqlCommand.Parameters["p_usernew"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_datenew", businessObject.Datenew);
				sqlCommand.Parameters["p_datenew"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_useredit", businessObject.Useredit);
				sqlCommand.Parameters["p_useredit"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dateedit", businessObject.Dateedit);
				sqlCommand.Parameters["p_dateedit"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Iddocumentation = Convert.ToInt16(sqlCommand.Parameters["p_iddocumentation"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CDocumentation::Insert::Error occured.", ex);
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
        public bool Update(CDocumentation businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_documentation_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_iddocumentation", businessObject.Iddocumentation);
				sqlCommand.Parameters["p_iddocumentation"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idconfiguration_folder", businessObject.Idconfiguration_folder);
				sqlCommand.Parameters["p_idconfiguration_folder"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_procedure_type", businessObject.Procedure_type);
				sqlCommand.Parameters["p_procedure_type"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_code", businessObject.Code);
				sqlCommand.Parameters["p_code"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_name_doc", businessObject.Name_doc);
				sqlCommand.Parameters["p_name_doc"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_type_doc", businessObject.Type_doc);
				sqlCommand.Parameters["p_type_doc"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_id", businessObject.Id);
				sqlCommand.Parameters["p_id"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_parentid", businessObject.Parentid);
				sqlCommand.Parameters["p_parentid"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_flag_enabled", businessObject.Flag_enabled);
				sqlCommand.Parameters["p_flag_enabled"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_image_index", businessObject.Image_index);
				sqlCommand.Parameters["p_image_index"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_usernew", businessObject.Usernew);
				sqlCommand.Parameters["p_usernew"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_datenew", businessObject.Datenew);
				sqlCommand.Parameters["p_datenew"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_useredit", businessObject.Useredit);
				sqlCommand.Parameters["p_useredit"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dateedit", businessObject.Dateedit);
				sqlCommand.Parameters["p_dateedit"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CDocumentation::Update::Error occured.", ex);
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
        /// <returns>CDocumentation business object</returns>
        public CDocumentation SelectByPrimaryKey(CDocumentationKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_documentation_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_iddocumentation", NpgsqlDbType.Smallint, 2, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Iddocumentation));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CDocumentation businessObject = new CDocumentation();

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
                throw new Exception("CDocumentation::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CDocumentation</returns>
        public List<CDocumentation> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_documentation_SelectAll";
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
                throw new Exception("CDocumentation::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_documentation_SelectAll";
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
                throw new Exception("CDocumentation::SelectAll::Error occured.", ex);
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
        /// <returns>list of CDocumentation</returns>
        public List<CDocumentation> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_documentation_SelectByField";
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
                throw new Exception("CDocumentation::SelectByField::Error occured.", ex);
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
        public bool Delete(CDocumentationKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_documentation_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_iddocumentation", NpgsqlDbType.Smallint, 2, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Iddocumentation));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CDocumentation::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_documentation_DeleteByField";
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
                throw new Exception("CDocumentation::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CDocumentation businessObject, IDataReader dataReader)
        {


				businessObject.Iddocumentation = (short)dataReader.GetInt16(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Iddocumentation.ToString()));

				businessObject.Idconfiguration_folder = (short)dataReader.GetInt16(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Idconfiguration_folder.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Idtemplate_method.ToString())))
				{
					businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Idtemplate_method.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Procedure_type.ToString())))
				{
					businessObject.Procedure_type = dataReader.GetChar(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Procedure_type.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Code.ToString())))
				{
					businessObject.Code = dataReader.GetInt32(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Code.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Name_doc.ToString())))
				{
					businessObject.Name_doc = dataReader.GetString(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Name_doc.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Type_doc.ToString())))
				{
					businessObject.Type_doc = dataReader.GetChar(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Type_doc.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Id.ToString())))
				{
					businessObject.Id = dataReader.GetInt32(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Id.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Parentid.ToString())))
				{
					businessObject.Parentid = dataReader.GetInt32(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Parentid.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Flag_enabled.ToString())))
				{
					businessObject.Flag_enabled = dataReader.GetBoolean(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Flag_enabled.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Image_index.ToString())))
				{
					businessObject.Image_index = dataReader.GetInt32(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Image_index.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CDocumentation.CDocumentationFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CDocumentation</returns>
        internal List<CDocumentation> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CDocumentation> list = new List<CDocumentation>();

            while (dataReader.Read())
            {
                CDocumentation businessObject = new CDocumentation();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
