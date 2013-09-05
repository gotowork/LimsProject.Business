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
	/// Data access layer class for CBatch
	/// </summary>
	partial class CBatchSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CBatchSql()
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
		public bool Insert(CBatch businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_batch_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idbatch", businessObject.Idbatch);
				sqlCommand.Parameters["p_idbatch"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters["p_idbatch"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_name_batch", businessObject.Name_batch);
				sqlCommand.Parameters["p_name_batch"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_num_tray", businessObject.Num_tray);
				sqlCommand.Parameters["p_num_tray"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_cod_module", businessObject.Cod_module);
				sqlCommand.Parameters["p_cod_module"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_cod_process", businessObject.Cod_process);
				sqlCommand.Parameters["p_cod_process"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_cod_area", businessObject.Cod_area);
				sqlCommand.Parameters["p_cod_area"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_status_process", businessObject.Status_process);
				sqlCommand.Parameters["p_status_process"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_mri_value", businessObject.Mri_value);
				sqlCommand.Parameters["p_mri_value"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_description", businessObject.Description);
				sqlCommand.Parameters["p_description"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_date_creation_tray", businessObject.Date_creation_tray);
				sqlCommand.Parameters["p_date_creation_tray"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_user_creation_tray", businessObject.User_creation_tray);
				sqlCommand.Parameters["p_user_creation_tray"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_has_sample_control", businessObject.Has_sample_control);
				sqlCommand.Parameters["p_has_sample_control"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_absorvance", businessObject.Absorvance);
				sqlCommand.Parameters["p_absorvance"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_verification", businessObject.Std_verification);
				sqlCommand.Parameters["p_std_verification"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flag_abs_std", businessObject.Flag_abs_std);
				sqlCommand.Parameters["p_flag_abs_std"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_mri_measured", businessObject.Mri_measured);
				sqlCommand.Parameters["p_mri_measured"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_lrb_measured", businessObject.Lrb_measured);
				sqlCommand.Parameters["p_lrb_measured"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flag_correct_abs", businessObject.Flag_correct_abs);
				sqlCommand.Parameters["p_flag_correct_abs"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_correct_std", businessObject.Flag_correct_std);
				sqlCommand.Parameters["p_flag_correct_std"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_correct_mri", businessObject.Flag_correct_mri);
				sqlCommand.Parameters["p_flag_correct_mri"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_correct_lrb", businessObject.Flag_correct_lrb);
				sqlCommand.Parameters["p_flag_correct_lrb"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_user_close_tray", businessObject.User_close_tray);
				sqlCommand.Parameters["p_user_close_tray"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_date_close_tray", businessObject.Date_close_tray);
				sqlCommand.Parameters["p_date_close_tray"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_user_approve_tray", businessObject.User_approve_tray);
				sqlCommand.Parameters["p_user_approve_tray"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_date_approve_tray", businessObject.Date_approve_tray);
				sqlCommand.Parameters["p_date_approve_tray"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_user_review_tray", businessObject.User_review_tray);
				sqlCommand.Parameters["p_user_review_tray"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_date_review_tray", businessObject.Date_review_tray);
				sqlCommand.Parameters["p_date_review_tray"].NpgsqlDbType = NpgsqlDbType.Timestamp;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idbatch = Convert.ToInt64(sqlCommand.Parameters["p_idbatch"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CBatch::Insert::Error occured.", ex);
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
        public bool Update(CBatch businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idbatch", businessObject.Idbatch);
				sqlCommand.Parameters["p_idbatch"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_name_batch", businessObject.Name_batch);
				sqlCommand.Parameters["p_name_batch"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_num_tray", businessObject.Num_tray);
				sqlCommand.Parameters["p_num_tray"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_cod_module", businessObject.Cod_module);
				sqlCommand.Parameters["p_cod_module"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_cod_process", businessObject.Cod_process);
				sqlCommand.Parameters["p_cod_process"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_cod_area", businessObject.Cod_area);
				sqlCommand.Parameters["p_cod_area"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_status_process", businessObject.Status_process);
				sqlCommand.Parameters["p_status_process"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_mri_value", businessObject.Mri_value);
				sqlCommand.Parameters["p_mri_value"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_description", businessObject.Description);
				sqlCommand.Parameters["p_description"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_date_creation_tray", businessObject.Date_creation_tray);
				sqlCommand.Parameters["p_date_creation_tray"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_user_creation_tray", businessObject.User_creation_tray);
				sqlCommand.Parameters["p_user_creation_tray"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_has_sample_control", businessObject.Has_sample_control);
				sqlCommand.Parameters["p_has_sample_control"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_absorvance", businessObject.Absorvance);
				sqlCommand.Parameters["p_absorvance"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_verification", businessObject.Std_verification);
				sqlCommand.Parameters["p_std_verification"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flag_abs_std", businessObject.Flag_abs_std);
				sqlCommand.Parameters["p_flag_abs_std"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_mri_measured", businessObject.Mri_measured);
				sqlCommand.Parameters["p_mri_measured"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_lrb_measured", businessObject.Lrb_measured);
				sqlCommand.Parameters["p_lrb_measured"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flag_correct_abs", businessObject.Flag_correct_abs);
				sqlCommand.Parameters["p_flag_correct_abs"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_correct_std", businessObject.Flag_correct_std);
				sqlCommand.Parameters["p_flag_correct_std"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_correct_mri", businessObject.Flag_correct_mri);
				sqlCommand.Parameters["p_flag_correct_mri"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_correct_lrb", businessObject.Flag_correct_lrb);
				sqlCommand.Parameters["p_flag_correct_lrb"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_user_close_tray", businessObject.User_close_tray);
				sqlCommand.Parameters["p_user_close_tray"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_date_close_tray", businessObject.Date_close_tray);
				sqlCommand.Parameters["p_date_close_tray"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_user_approve_tray", businessObject.User_approve_tray);
				sqlCommand.Parameters["p_user_approve_tray"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_date_approve_tray", businessObject.Date_approve_tray);
				sqlCommand.Parameters["p_date_approve_tray"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_user_review_tray", businessObject.User_review_tray);
				sqlCommand.Parameters["p_user_review_tray"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_date_review_tray", businessObject.Date_review_tray);
				sqlCommand.Parameters["p_date_review_tray"].NpgsqlDbType = NpgsqlDbType.Timestamp;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatch::Update::Error occured.", ex);
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
        /// <returns>CBatch business object</returns>
        public CBatch SelectByPrimaryKey(CBatchKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idbatch", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idbatch));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CBatch businessObject = new CBatch();

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
                throw new Exception("CBatch::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CBatch</returns>
        public List<CBatch> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_SelectAll";
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
                throw new Exception("CBatch::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_batch_SelectAll";
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
                throw new Exception("CBatch::SelectAll::Error occured.", ex);
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
        /// <returns>list of CBatch</returns>
        public List<CBatch> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_SelectByField";
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
                throw new Exception("CBatch::SelectByField::Error occured.", ex);
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
        public bool Delete(CBatchKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idbatch", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idbatch));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatch::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_batch_DeleteByField";
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
                throw new Exception("CBatch::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CBatch businessObject, IDataReader dataReader)
        {


				businessObject.Idbatch = dataReader.GetInt64(dataReader.GetOrdinal(CBatch.CBatchFields.Idbatch.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Name_batch.ToString())))
				{
					businessObject.Name_batch = dataReader.GetString(dataReader.GetOrdinal(CBatch.CBatchFields.Name_batch.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Num_tray.ToString())))
				{
					businessObject.Num_tray = dataReader.GetInt64(dataReader.GetOrdinal(CBatch.CBatchFields.Num_tray.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Idtemplate_method.ToString())))
				{
					businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CBatch.CBatchFields.Idtemplate_method.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Cod_module.ToString())))
				{
					businessObject.Cod_module = dataReader.GetString(dataReader.GetOrdinal(CBatch.CBatchFields.Cod_module.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Cod_process.ToString())))
				{
					businessObject.Cod_process = dataReader.GetString(dataReader.GetOrdinal(CBatch.CBatchFields.Cod_process.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Cod_area.ToString())))
				{
					businessObject.Cod_area = dataReader.GetString(dataReader.GetOrdinal(CBatch.CBatchFields.Cod_area.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Status_process.ToString())))
				{
					businessObject.Status_process = dataReader.GetChar(dataReader.GetOrdinal(CBatch.CBatchFields.Status_process.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CBatch.CBatchFields.Status.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Mri_value.ToString())))
				{
					businessObject.Mri_value = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch.CBatchFields.Mri_value.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Description.ToString())))
				{
					businessObject.Description = dataReader.GetString(dataReader.GetOrdinal(CBatch.CBatchFields.Description.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Date_creation_tray.ToString())))
				{
					businessObject.Date_creation_tray = dataReader.GetDateTime(dataReader.GetOrdinal(CBatch.CBatchFields.Date_creation_tray.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.User_creation_tray.ToString())))
				{
					businessObject.User_creation_tray = dataReader.GetString(dataReader.GetOrdinal(CBatch.CBatchFields.User_creation_tray.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Has_sample_control.ToString())))
				{
					businessObject.Has_sample_control = dataReader.GetBoolean(dataReader.GetOrdinal(CBatch.CBatchFields.Has_sample_control.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Absorvance.ToString())))
				{
					businessObject.Absorvance = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch.CBatchFields.Absorvance.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Std_verification.ToString())))
				{
					businessObject.Std_verification = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch.CBatchFields.Std_verification.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Flag_abs_std.ToString())))
				{
					businessObject.Flag_abs_std = dataReader.GetBoolean(dataReader.GetOrdinal(CBatch.CBatchFields.Flag_abs_std.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Mri_measured.ToString())))
				{
					businessObject.Mri_measured = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch.CBatchFields.Mri_measured.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Lrb_measured.ToString())))
				{
					businessObject.Lrb_measured = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch.CBatchFields.Lrb_measured.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Flag_correct_abs.ToString())))
				{
					businessObject.Flag_correct_abs = dataReader.GetBoolean(dataReader.GetOrdinal(CBatch.CBatchFields.Flag_correct_abs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Flag_correct_std.ToString())))
				{
					businessObject.Flag_correct_std = dataReader.GetBoolean(dataReader.GetOrdinal(CBatch.CBatchFields.Flag_correct_std.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Flag_correct_mri.ToString())))
				{
					businessObject.Flag_correct_mri = dataReader.GetBoolean(dataReader.GetOrdinal(CBatch.CBatchFields.Flag_correct_mri.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Flag_correct_lrb.ToString())))
				{
					businessObject.Flag_correct_lrb = dataReader.GetBoolean(dataReader.GetOrdinal(CBatch.CBatchFields.Flag_correct_lrb.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.User_close_tray.ToString())))
				{
					businessObject.User_close_tray = dataReader.GetString(dataReader.GetOrdinal(CBatch.CBatchFields.User_close_tray.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Date_close_tray.ToString())))
				{
					businessObject.Date_close_tray = dataReader.GetDateTime(dataReader.GetOrdinal(CBatch.CBatchFields.Date_close_tray.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.User_approve_tray.ToString())))
				{
					businessObject.User_approve_tray = dataReader.GetString(dataReader.GetOrdinal(CBatch.CBatchFields.User_approve_tray.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Date_approve_tray.ToString())))
				{
					businessObject.Date_approve_tray = dataReader.GetDateTime(dataReader.GetOrdinal(CBatch.CBatchFields.Date_approve_tray.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.User_review_tray.ToString())))
				{
					businessObject.User_review_tray = dataReader.GetString(dataReader.GetOrdinal(CBatch.CBatchFields.User_review_tray.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch.CBatchFields.Date_review_tray.ToString())))
				{
					businessObject.Date_review_tray = dataReader.GetDateTime(dataReader.GetOrdinal(CBatch.CBatchFields.Date_review_tray.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CBatch</returns>
        internal List<CBatch> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CBatch> list = new List<CBatch>();

            while (dataReader.Read())
            {
                CBatch businessObject = new CBatch();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
