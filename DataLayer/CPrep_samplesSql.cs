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
	/// Data access layer class for CPrep_samples
	/// </summary>
	partial class CPrep_samplesSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CPrep_samplesSql()
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
		public bool Insert(CPrep_samples businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_prep_samples_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail", businessObject.Idrecep_sample_detail);
				sqlCommand.Parameters["p_idrecep_sample_detail"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_flag_humidity_analysis", businessObject.Flag_humidity_analysis);
				sqlCommand.Parameters["p_flag_humidity_analysis"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_reject", businessObject.Flag_reject);
				sqlCommand.Parameters["p_flag_reject"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_counter_sample", businessObject.Flag_counter_sample);
				sqlCommand.Parameters["p_flag_counter_sample"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_flag_60celsius", businessObject.Flag_60celsius);
				sqlCommand.Parameters["p_flag_60celsius"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_date_creation", businessObject.Date_creation);
				sqlCommand.Parameters["p_date_creation"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_input_sample_date", businessObject.Input_sample_date);
				sqlCommand.Parameters["p_input_sample_date"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_input_sample_user", businessObject.Input_sample_user);
				sqlCommand.Parameters["p_input_sample_user"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_weight_gross", businessObject.Weight_gross);
				sqlCommand.Parameters["p_weight_gross"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_weight_gross_date", businessObject.Weight_gross_date);
				sqlCommand.Parameters["p_weight_gross_date"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_weight_gross_user", businessObject.Weight_gross_user);
				sqlCommand.Parameters["p_weight_gross_user"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_weight_moisture", businessObject.Weight_moisture);
				sqlCommand.Parameters["p_weight_moisture"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_weight_moisture_date", businessObject.Weight_moisture_date);
				sqlCommand.Parameters["p_weight_moisture_date"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_weight_moisture_user", businessObject.Weight_moisture_user);
				sqlCommand.Parameters["p_weight_moisture_user"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_weight_dry", businessObject.Weight_dry);
				sqlCommand.Parameters["p_weight_dry"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_weight_dry_date", businessObject.Weight_dry_date);
				sqlCommand.Parameters["p_weight_dry_date"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_weight_dry_user", businessObject.Weight_dry_user);
				sqlCommand.Parameters["p_weight_dry_user"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_percent_moisture", businessObject.Percent_moisture);
				sqlCommand.Parameters["p_percent_moisture"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_moisture_reject", businessObject.Moisture_reject);
				sqlCommand.Parameters["p_moisture_reject"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_moisture_reject_date", businessObject.Moisture_reject_date);
				sqlCommand.Parameters["p_moisture_reject_date"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_moisture_reject_user", businessObject.Moisture_reject_user);
				sqlCommand.Parameters["p_moisture_reject_user"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_weight_gross_reject", businessObject.Weight_gross_reject);
				sqlCommand.Parameters["p_weight_gross_reject"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_weight_gross_reject_date", businessObject.Weight_gross_reject_date);
				sqlCommand.Parameters["p_weight_gross_reject_date"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_weight_gross_reject_user", businessObject.Weight_gross_reject_user);
				sqlCommand.Parameters["p_weight_gross_reject_user"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_output_flag_sample", businessObject.Output_flag_sample);
				sqlCommand.Parameters["p_output_flag_sample"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_output_flag_cs", businessObject.Output_flag_cs);
				sqlCommand.Parameters["p_output_flag_cs"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_output_flag_re", businessObject.Output_flag_re);
				sqlCommand.Parameters["p_output_flag_re"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_output_date_sample", businessObject.Output_date_sample);
				sqlCommand.Parameters["p_output_date_sample"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_output_user_sample", businessObject.Output_user_sample);
				sqlCommand.Parameters["p_output_user_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_output_date_cs", businessObject.Output_date_cs);
				sqlCommand.Parameters["p_output_date_cs"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_output_user_cs", businessObject.Output_user_cs);
				sqlCommand.Parameters["p_output_user_cs"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_output_date_re", businessObject.Output_date_re);
				sqlCommand.Parameters["p_output_date_re"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_output_user_re", businessObject.Output_user_re);
				sqlCommand.Parameters["p_output_user_re"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_observation1", businessObject.Observation1);
				sqlCommand.Parameters["p_observation1"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_store_input_date_cs", businessObject.Store_input_date_cs);
				sqlCommand.Parameters["p_store_input_date_cs"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_store_input_user_cs", businessObject.Store_input_user_cs);
				sqlCommand.Parameters["p_store_input_user_cs"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_store_input_date_re", businessObject.Store_input_date_re);
				sqlCommand.Parameters["p_store_input_date_re"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_store_input_user_re", businessObject.Store_input_user_re);
				sqlCommand.Parameters["p_store_input_user_re"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_store_output_date_cs", businessObject.Store_output_date_cs);
				sqlCommand.Parameters["p_store_output_date_cs"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_store_output_user_cs", businessObject.Store_output_user_cs);
				sqlCommand.Parameters["p_store_output_user_cs"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_store_output_date_re", businessObject.Store_output_date_re);
				sqlCommand.Parameters["p_store_output_date_re"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_store_output_user_re", businessObject.Store_output_user_re);
				sqlCommand.Parameters["p_store_output_user_re"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_observation2", businessObject.Observation2);
				sqlCommand.Parameters["p_observation2"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_final_weight_gross", businessObject.Final_weight_gross);
				sqlCommand.Parameters["p_final_weight_gross"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_final_moisture", businessObject.Final_moisture);
				sqlCommand.Parameters["p_final_moisture"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_final_reject", businessObject.Final_reject);
				sqlCommand.Parameters["p_final_reject"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_final_sample_prepared", businessObject.Final_sample_prepared);
				sqlCommand.Parameters["p_final_sample_prepared"].NpgsqlDbType = NpgsqlDbType.Boolean;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                
				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CPrep_samples::Insert::Error occured.", ex);
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
        public bool Update(CPrep_samples businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_prep_samples_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail", businessObject.Idrecep_sample_detail);
				sqlCommand.Parameters["p_idrecep_sample_detail"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_flag_humidity_analysis", businessObject.Flag_humidity_analysis);
				sqlCommand.Parameters["p_flag_humidity_analysis"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_reject", businessObject.Flag_reject);
				sqlCommand.Parameters["p_flag_reject"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_counter_sample", businessObject.Flag_counter_sample);
				sqlCommand.Parameters["p_flag_counter_sample"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_flag_60celsius", businessObject.Flag_60celsius);
				sqlCommand.Parameters["p_flag_60celsius"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_date_creation", businessObject.Date_creation);
				sqlCommand.Parameters["p_date_creation"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_input_sample_date", businessObject.Input_sample_date);
				sqlCommand.Parameters["p_input_sample_date"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_input_sample_user", businessObject.Input_sample_user);
				sqlCommand.Parameters["p_input_sample_user"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_weight_gross", businessObject.Weight_gross);
				sqlCommand.Parameters["p_weight_gross"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_weight_gross_date", businessObject.Weight_gross_date);
				sqlCommand.Parameters["p_weight_gross_date"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_weight_gross_user", businessObject.Weight_gross_user);
				sqlCommand.Parameters["p_weight_gross_user"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_weight_moisture", businessObject.Weight_moisture);
				sqlCommand.Parameters["p_weight_moisture"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_weight_moisture_date", businessObject.Weight_moisture_date);
				sqlCommand.Parameters["p_weight_moisture_date"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_weight_moisture_user", businessObject.Weight_moisture_user);
				sqlCommand.Parameters["p_weight_moisture_user"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_weight_dry", businessObject.Weight_dry);
				sqlCommand.Parameters["p_weight_dry"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_weight_dry_date", businessObject.Weight_dry_date);
				sqlCommand.Parameters["p_weight_dry_date"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_weight_dry_user", businessObject.Weight_dry_user);
				sqlCommand.Parameters["p_weight_dry_user"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_percent_moisture", businessObject.Percent_moisture);
				sqlCommand.Parameters["p_percent_moisture"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_moisture_reject", businessObject.Moisture_reject);
				sqlCommand.Parameters["p_moisture_reject"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_moisture_reject_date", businessObject.Moisture_reject_date);
				sqlCommand.Parameters["p_moisture_reject_date"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_moisture_reject_user", businessObject.Moisture_reject_user);
				sqlCommand.Parameters["p_moisture_reject_user"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_weight_gross_reject", businessObject.Weight_gross_reject);
				sqlCommand.Parameters["p_weight_gross_reject"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_weight_gross_reject_date", businessObject.Weight_gross_reject_date);
				sqlCommand.Parameters["p_weight_gross_reject_date"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_weight_gross_reject_user", businessObject.Weight_gross_reject_user);
				sqlCommand.Parameters["p_weight_gross_reject_user"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_output_flag_sample", businessObject.Output_flag_sample);
				sqlCommand.Parameters["p_output_flag_sample"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_output_flag_cs", businessObject.Output_flag_cs);
				sqlCommand.Parameters["p_output_flag_cs"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_output_flag_re", businessObject.Output_flag_re);
				sqlCommand.Parameters["p_output_flag_re"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_output_date_sample", businessObject.Output_date_sample);
				sqlCommand.Parameters["p_output_date_sample"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_output_user_sample", businessObject.Output_user_sample);
				sqlCommand.Parameters["p_output_user_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_output_date_cs", businessObject.Output_date_cs);
				sqlCommand.Parameters["p_output_date_cs"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_output_user_cs", businessObject.Output_user_cs);
				sqlCommand.Parameters["p_output_user_cs"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_output_date_re", businessObject.Output_date_re);
				sqlCommand.Parameters["p_output_date_re"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_output_user_re", businessObject.Output_user_re);
				sqlCommand.Parameters["p_output_user_re"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_observation1", businessObject.Observation1);
				sqlCommand.Parameters["p_observation1"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_store_input_date_cs", businessObject.Store_input_date_cs);
				sqlCommand.Parameters["p_store_input_date_cs"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_store_input_user_cs", businessObject.Store_input_user_cs);
				sqlCommand.Parameters["p_store_input_user_cs"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_store_input_date_re", businessObject.Store_input_date_re);
				sqlCommand.Parameters["p_store_input_date_re"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_store_input_user_re", businessObject.Store_input_user_re);
				sqlCommand.Parameters["p_store_input_user_re"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_store_output_date_cs", businessObject.Store_output_date_cs);
				sqlCommand.Parameters["p_store_output_date_cs"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_store_output_user_cs", businessObject.Store_output_user_cs);
				sqlCommand.Parameters["p_store_output_user_cs"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_store_output_date_re", businessObject.Store_output_date_re);
				sqlCommand.Parameters["p_store_output_date_re"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_store_output_user_re", businessObject.Store_output_user_re);
				sqlCommand.Parameters["p_store_output_user_re"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_observation2", businessObject.Observation2);
				sqlCommand.Parameters["p_observation2"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_final_weight_gross", businessObject.Final_weight_gross);
				sqlCommand.Parameters["p_final_weight_gross"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_final_moisture", businessObject.Final_moisture);
				sqlCommand.Parameters["p_final_moisture"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_final_reject", businessObject.Final_reject);
				sqlCommand.Parameters["p_final_reject"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_final_sample_prepared", businessObject.Final_sample_prepared);
				sqlCommand.Parameters["p_final_sample_prepared"].NpgsqlDbType = NpgsqlDbType.Boolean;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CPrep_samples::Update::Error occured.", ex);
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
        /// <returns>CPrep_samples business object</returns>
        public CPrep_samples SelectByPrimaryKey(CPrep_samplesKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_prep_samples_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idrecep_sample_detail", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idrecep_sample_detail));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CPrep_samples businessObject = new CPrep_samples();

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
                throw new Exception("CPrep_samples::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CPrep_samples</returns>
        public List<CPrep_samples> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_prep_samples_SelectAll";
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
                throw new Exception("CPrep_samples::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_prep_samples_SelectAll";
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
                throw new Exception("CPrep_samples::SelectAll::Error occured.", ex);
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
        /// <returns>list of CPrep_samples</returns>
        public List<CPrep_samples> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_prep_samples_SelectByField";
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
                throw new Exception("CPrep_samples::SelectByField::Error occured.", ex);
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
        public bool Delete(CPrep_samplesKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_prep_samples_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idrecep_sample_detail", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idrecep_sample_detail));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CPrep_samples::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_prep_samples_DeleteByField";
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
                throw new Exception("CPrep_samples::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CPrep_samples businessObject, IDataReader dataReader)
        {


				businessObject.Idrecep_sample_detail = dataReader.GetInt64(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Idrecep_sample_detail.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Flag_humidity_analysis.ToString())))
				{
					businessObject.Flag_humidity_analysis = dataReader.GetBoolean(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Flag_humidity_analysis.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Flag_reject.ToString())))
				{
					businessObject.Flag_reject = dataReader.GetBoolean(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Flag_reject.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Flag_counter_sample.ToString())))
				{
					businessObject.Flag_counter_sample = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Flag_counter_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Flag_60celsius.ToString())))
				{
					businessObject.Flag_60celsius = dataReader.GetBoolean(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Flag_60celsius.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Date_creation.ToString())))
				{
					businessObject.Date_creation = dataReader.GetDateTime(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Date_creation.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Input_sample_date.ToString())))
				{
					businessObject.Input_sample_date = dataReader.GetDateTime(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Input_sample_date.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Input_sample_user.ToString())))
				{
					businessObject.Input_sample_user = dataReader.GetString(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Input_sample_user.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_gross.ToString())))
				{
					businessObject.Weight_gross = dataReader.GetDecimal(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_gross.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_gross_date.ToString())))
				{
					businessObject.Weight_gross_date = dataReader.GetDateTime(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_gross_date.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_gross_user.ToString())))
				{
					businessObject.Weight_gross_user = dataReader.GetString(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_gross_user.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_moisture.ToString())))
				{
					businessObject.Weight_moisture = dataReader.GetDecimal(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_moisture.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_moisture_date.ToString())))
				{
					businessObject.Weight_moisture_date = dataReader.GetDateTime(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_moisture_date.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_moisture_user.ToString())))
				{
					businessObject.Weight_moisture_user = dataReader.GetString(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_moisture_user.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_dry.ToString())))
				{
					businessObject.Weight_dry = dataReader.GetDecimal(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_dry.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_dry_date.ToString())))
				{
					businessObject.Weight_dry_date = dataReader.GetDateTime(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_dry_date.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_dry_user.ToString())))
				{
					businessObject.Weight_dry_user = dataReader.GetString(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_dry_user.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Percent_moisture.ToString())))
				{
					businessObject.Percent_moisture = dataReader.GetDecimal(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Percent_moisture.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Moisture_reject.ToString())))
				{
					businessObject.Moisture_reject = dataReader.GetBoolean(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Moisture_reject.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Moisture_reject_date.ToString())))
				{
					businessObject.Moisture_reject_date = dataReader.GetDateTime(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Moisture_reject_date.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Moisture_reject_user.ToString())))
				{
					businessObject.Moisture_reject_user = dataReader.GetString(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Moisture_reject_user.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_gross_reject.ToString())))
				{
					businessObject.Weight_gross_reject = dataReader.GetDecimal(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_gross_reject.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_gross_reject_date.ToString())))
				{
					businessObject.Weight_gross_reject_date = dataReader.GetDateTime(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_gross_reject_date.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_gross_reject_user.ToString())))
				{
					businessObject.Weight_gross_reject_user = dataReader.GetString(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Weight_gross_reject_user.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_flag_sample.ToString())))
				{
					businessObject.Output_flag_sample = dataReader.GetBoolean(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_flag_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_flag_cs.ToString())))
				{
					businessObject.Output_flag_cs = dataReader.GetBoolean(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_flag_cs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_flag_re.ToString())))
				{
					businessObject.Output_flag_re = dataReader.GetBoolean(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_flag_re.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_date_sample.ToString())))
				{
					businessObject.Output_date_sample = dataReader.GetDateTime(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_date_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_user_sample.ToString())))
				{
					businessObject.Output_user_sample = dataReader.GetString(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_user_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_date_cs.ToString())))
				{
					businessObject.Output_date_cs = dataReader.GetDateTime(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_date_cs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_user_cs.ToString())))
				{
					businessObject.Output_user_cs = dataReader.GetString(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_user_cs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_date_re.ToString())))
				{
					businessObject.Output_date_re = dataReader.GetDateTime(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_date_re.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_user_re.ToString())))
				{
					businessObject.Output_user_re = dataReader.GetString(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Output_user_re.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Observation1.ToString())))
				{
					businessObject.Observation1 = dataReader.GetString(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Observation1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_input_date_cs.ToString())))
				{
					businessObject.Store_input_date_cs = dataReader.GetDateTime(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_input_date_cs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_input_user_cs.ToString())))
				{
					businessObject.Store_input_user_cs = dataReader.GetString(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_input_user_cs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_input_date_re.ToString())))
				{
					businessObject.Store_input_date_re = dataReader.GetDateTime(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_input_date_re.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_input_user_re.ToString())))
				{
					businessObject.Store_input_user_re = dataReader.GetString(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_input_user_re.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_output_date_cs.ToString())))
				{
					businessObject.Store_output_date_cs = dataReader.GetDateTime(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_output_date_cs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_output_user_cs.ToString())))
				{
					businessObject.Store_output_user_cs = dataReader.GetString(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_output_user_cs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_output_date_re.ToString())))
				{
					businessObject.Store_output_date_re = dataReader.GetDateTime(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_output_date_re.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_output_user_re.ToString())))
				{
					businessObject.Store_output_user_re = dataReader.GetString(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Store_output_user_re.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Observation2.ToString())))
				{
					businessObject.Observation2 = dataReader.GetString(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Observation2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Final_weight_gross.ToString())))
				{
					businessObject.Final_weight_gross = dataReader.GetBoolean(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Final_weight_gross.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Final_moisture.ToString())))
				{
					businessObject.Final_moisture = dataReader.GetBoolean(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Final_moisture.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Final_reject.ToString())))
				{
					businessObject.Final_reject = dataReader.GetBoolean(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Final_reject.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Final_sample_prepared.ToString())))
				{
					businessObject.Final_sample_prepared = dataReader.GetBoolean(dataReader.GetOrdinal(CPrep_samples.CPrep_samplesFields.Final_sample_prepared.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CPrep_samples</returns>
        internal List<CPrep_samples> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CPrep_samples> list = new List<CPrep_samples>();

            while (dataReader.Read())
            {
                CPrep_samples businessObject = new CPrep_samples();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
