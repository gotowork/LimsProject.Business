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
	/// Data access layer class for CBatch_result_aa_qaqc
	/// </summary>
	partial class CBatch_result_aa_qaqcSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CBatch_result_aa_qaqcSql()
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
		public bool Insert(CBatch_result_aa_qaqc businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_batch_result_aa_qaqc_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idbatch_result_aa_qaqc", businessObject.Idbatch_result_aa_qaqc);
				sqlCommand.Parameters["p_idbatch_result_aa_qaqc"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters["p_idbatch_result_aa_qaqc"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idbatch", businessObject.Idbatch);
				sqlCommand.Parameters["p_idbatch"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail_elem", businessObject.Idrecep_sample_detail_elem);
				sqlCommand.Parameters["p_idrecep_sample_detail_elem"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail", businessObject.Idrecep_sample_detail);
				sqlCommand.Parameters["p_idrecep_sample_detail"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_str_result_analysis", businessObject.Str_result_analysis);
				sqlCommand.Parameters["p_str_result_analysis"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_result_analysis", businessObject.Result_analysis);
				sqlCommand.Parameters["p_result_analysis"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_status_result", businessObject.Status_result);
				sqlCommand.Parameters["p_status_result"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idunit", businessObject.Idunit);
				sqlCommand.Parameters["p_idunit"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_qaqc_blk", businessObject.Qaqc_blk);
				sqlCommand.Parameters["p_qaqc_blk"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_qaqc_par", businessObject.Qaqc_par);
				sqlCommand.Parameters["p_qaqc_par"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_qaqc_mr", businessObject.Qaqc_mr);
				sqlCommand.Parameters["p_qaqc_mr"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_qaqc_approve_retest", businessObject.Qaqc_approve_retest);
				sqlCommand.Parameters["p_qaqc_approve_retest"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_qaqc_text_obs", businessObject.Qaqc_text_obs);
				sqlCommand.Parameters["p_qaqc_text_obs"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_qaqc_error", businessObject.Qaqc_error);
				sqlCommand.Parameters["p_qaqc_error"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_qaqc_flag_checked", businessObject.Qaqc_flag_checked);
				sqlCommand.Parameters["p_qaqc_flag_checked"].NpgsqlDbType = NpgsqlDbType.Boolean;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idbatch_result_aa_qaqc = Convert.ToInt64(sqlCommand.Parameters["p_idbatch_result_aa_qaqc"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CBatch_result_aa_qaqc::Insert::Error occured.", ex);
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
        public bool Update(CBatch_result_aa_qaqc businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_result_aa_qaqc_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idbatch_result_aa_qaqc", businessObject.Idbatch_result_aa_qaqc);
				sqlCommand.Parameters["p_idbatch_result_aa_qaqc"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idbatch", businessObject.Idbatch);
				sqlCommand.Parameters["p_idbatch"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail_elem", businessObject.Idrecep_sample_detail_elem);
				sqlCommand.Parameters["p_idrecep_sample_detail_elem"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail", businessObject.Idrecep_sample_detail);
				sqlCommand.Parameters["p_idrecep_sample_detail"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_str_result_analysis", businessObject.Str_result_analysis);
				sqlCommand.Parameters["p_str_result_analysis"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_result_analysis", businessObject.Result_analysis);
				sqlCommand.Parameters["p_result_analysis"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_status_result", businessObject.Status_result);
				sqlCommand.Parameters["p_status_result"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idunit", businessObject.Idunit);
				sqlCommand.Parameters["p_idunit"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_qaqc_blk", businessObject.Qaqc_blk);
				sqlCommand.Parameters["p_qaqc_blk"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_qaqc_par", businessObject.Qaqc_par);
				sqlCommand.Parameters["p_qaqc_par"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_qaqc_mr", businessObject.Qaqc_mr);
				sqlCommand.Parameters["p_qaqc_mr"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_qaqc_approve_retest", businessObject.Qaqc_approve_retest);
				sqlCommand.Parameters["p_qaqc_approve_retest"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_qaqc_text_obs", businessObject.Qaqc_text_obs);
				sqlCommand.Parameters["p_qaqc_text_obs"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_qaqc_error", businessObject.Qaqc_error);
				sqlCommand.Parameters["p_qaqc_error"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_qaqc_flag_checked", businessObject.Qaqc_flag_checked);
				sqlCommand.Parameters["p_qaqc_flag_checked"].NpgsqlDbType = NpgsqlDbType.Boolean;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatch_result_aa_qaqc::Update::Error occured.", ex);
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
        /// <returns>CBatch_result_aa_qaqc business object</returns>
        public CBatch_result_aa_qaqc SelectByPrimaryKey(CBatch_result_aa_qaqcKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_result_aa_qaqc_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idbatch_result_aa_qaqc", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idbatch_result_aa_qaqc));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CBatch_result_aa_qaqc businessObject = new CBatch_result_aa_qaqc();

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
                throw new Exception("CBatch_result_aa_qaqc::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CBatch_result_aa_qaqc</returns>
        public List<CBatch_result_aa_qaqc> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_result_aa_qaqc_SelectAll";
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
                throw new Exception("CBatch_result_aa_qaqc::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_batch_result_aa_qaqc_SelectAll";
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
                throw new Exception("CBatch_result_aa_qaqc::SelectAll::Error occured.", ex);
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
        /// <returns>list of CBatch_result_aa_qaqc</returns>
        public List<CBatch_result_aa_qaqc> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_result_aa_qaqc_SelectByField";
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
                throw new Exception("CBatch_result_aa_qaqc::SelectByField::Error occured.", ex);
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
        public bool Delete(CBatch_result_aa_qaqcKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_result_aa_qaqc_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idbatch_result_aa_qaqc", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idbatch_result_aa_qaqc));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatch_result_aa_qaqc::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_batch_result_aa_qaqc_DeleteByField";
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
                throw new Exception("CBatch_result_aa_qaqc::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CBatch_result_aa_qaqc businessObject, IDataReader dataReader)
        {


				businessObject.Idbatch_result_aa_qaqc = dataReader.GetInt64(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Idbatch_result_aa_qaqc.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Idbatch.ToString())))
				{
					businessObject.Idbatch = dataReader.GetInt64(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Idbatch.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Idrecep_sample_detail_elem.ToString())))
				{
					businessObject.Idrecep_sample_detail_elem = dataReader.GetInt64(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Idrecep_sample_detail_elem.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Idrecep_sample_detail.ToString())))
				{
					businessObject.Idrecep_sample_detail = dataReader.GetInt64(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Idrecep_sample_detail.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Idrecep_sample.ToString())))
				{
					businessObject.Idrecep_sample = dataReader.GetInt64(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Idrecep_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Str_result_analysis.ToString())))
				{
					businessObject.Str_result_analysis = dataReader.GetString(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Str_result_analysis.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Result_analysis.ToString())))
				{
					businessObject.Result_analysis = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Result_analysis.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Status_result.ToString())))
				{
					businessObject.Status_result = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Status_result.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Idunit.ToString())))
				{
					businessObject.Idunit = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Idunit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Qaqc_blk.ToString())))
				{
					businessObject.Qaqc_blk = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Qaqc_blk.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Qaqc_par.ToString())))
				{
					businessObject.Qaqc_par = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Qaqc_par.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Qaqc_mr.ToString())))
				{
					businessObject.Qaqc_mr = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Qaqc_mr.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Qaqc_approve_retest.ToString())))
				{
					businessObject.Qaqc_approve_retest = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Qaqc_approve_retest.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Qaqc_text_obs.ToString())))
				{
					businessObject.Qaqc_text_obs = dataReader.GetString(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Qaqc_text_obs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Qaqc_error.ToString())))
				{
					businessObject.Qaqc_error = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Qaqc_error.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Qaqc_flag_checked.ToString())))
				{
					businessObject.Qaqc_flag_checked = dataReader.GetBoolean(dataReader.GetOrdinal(CBatch_result_aa_qaqc.CBatch_result_aa_qaqcFields.Qaqc_flag_checked.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CBatch_result_aa_qaqc</returns>
        internal List<CBatch_result_aa_qaqc> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CBatch_result_aa_qaqc> list = new List<CBatch_result_aa_qaqc>();

            while (dataReader.Read())
            {
                CBatch_result_aa_qaqc businessObject = new CBatch_result_aa_qaqc();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
