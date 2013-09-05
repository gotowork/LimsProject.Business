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
	/// Data access layer class for CTrace_batch
	/// </summary>
	partial class CTrace_batchSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CTrace_batchSql()
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
		public bool Insert(CTrace_batch businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_trace_batch_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idtrace_batch", businessObject.Idtrace_batch);
				sqlCommand.Parameters["p_idtrace_batch"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters["p_idtrace_batch"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_cod_module", businessObject.Cod_module);
				sqlCommand.Parameters["p_cod_module"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_cod_process", businessObject.Cod_process);
				sqlCommand.Parameters["p_cod_process"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_cod_area", businessObject.Cod_area);
				sqlCommand.Parameters["p_cod_area"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idbatch", businessObject.Idbatch);
				sqlCommand.Parameters["p_idbatch"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_date_in", businessObject.Date_in);
				sqlCommand.Parameters["p_date_in"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_date_out", businessObject.Date_out);
				sqlCommand.Parameters["p_date_out"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_status_process", businessObject.Status_process);
				sqlCommand.Parameters["p_status_process"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_idtrace_prev", businessObject.Idtrace_prev);
				sqlCommand.Parameters["p_idtrace_prev"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idtrace_next", businessObject.Idtrace_next);
				sqlCommand.Parameters["p_idtrace_next"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_observation", businessObject.Observation);
				sqlCommand.Parameters["p_observation"].NpgsqlDbType = NpgsqlDbType.Varchar;
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
                businessObject.Idtrace_batch = Convert.ToInt64(sqlCommand.Parameters["p_idtrace_batch"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CTrace_batch::Insert::Error occured.", ex);
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
        public bool Update(CTrace_batch businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_trace_batch_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idtrace_batch", businessObject.Idtrace_batch);
				sqlCommand.Parameters["p_idtrace_batch"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_cod_module", businessObject.Cod_module);
				sqlCommand.Parameters["p_cod_module"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_cod_process", businessObject.Cod_process);
				sqlCommand.Parameters["p_cod_process"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_cod_area", businessObject.Cod_area);
				sqlCommand.Parameters["p_cod_area"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idbatch", businessObject.Idbatch);
				sqlCommand.Parameters["p_idbatch"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_date_in", businessObject.Date_in);
				sqlCommand.Parameters["p_date_in"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_date_out", businessObject.Date_out);
				sqlCommand.Parameters["p_date_out"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_status_process", businessObject.Status_process);
				sqlCommand.Parameters["p_status_process"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_idtrace_prev", businessObject.Idtrace_prev);
				sqlCommand.Parameters["p_idtrace_prev"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idtrace_next", businessObject.Idtrace_next);
				sqlCommand.Parameters["p_idtrace_next"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_observation", businessObject.Observation);
				sqlCommand.Parameters["p_observation"].NpgsqlDbType = NpgsqlDbType.Varchar;
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
                throw new Exception("CTrace_batch::Update::Error occured.", ex);
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
        /// <returns>CTrace_batch business object</returns>
        public CTrace_batch SelectByPrimaryKey(CTrace_batchKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_trace_batch_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idtrace_batch", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idtrace_batch));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CTrace_batch businessObject = new CTrace_batch();

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
                throw new Exception("CTrace_batch::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CTrace_batch</returns>
        public List<CTrace_batch> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_trace_batch_SelectAll";
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
                throw new Exception("CTrace_batch::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_trace_batch_SelectAll";
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
                throw new Exception("CTrace_batch::SelectAll::Error occured.", ex);
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
        /// <returns>list of CTrace_batch</returns>
        public List<CTrace_batch> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_trace_batch_SelectByField";
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
                throw new Exception("CTrace_batch::SelectByField::Error occured.", ex);
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
        public bool Delete(CTrace_batchKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_trace_batch_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idtrace_batch", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idtrace_batch));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTrace_batch::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_trace_batch_DeleteByField";
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
                throw new Exception("CTrace_batch::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CTrace_batch businessObject, IDataReader dataReader)
        {


				businessObject.Idtrace_batch = dataReader.GetInt64(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Idtrace_batch.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Cod_module.ToString())))
				{
					businessObject.Cod_module = dataReader.GetString(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Cod_module.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Cod_process.ToString())))
				{
					businessObject.Cod_process = dataReader.GetString(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Cod_process.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Cod_area.ToString())))
				{
					businessObject.Cod_area = dataReader.GetString(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Cod_area.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Idbatch.ToString())))
				{
					businessObject.Idbatch = dataReader.GetInt64(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Idbatch.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Date_in.ToString())))
				{
					businessObject.Date_in = dataReader.GetDateTime(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Date_in.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Date_out.ToString())))
				{
					businessObject.Date_out = dataReader.GetDateTime(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Date_out.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Status_process.ToString())))
				{
					businessObject.Status_process = dataReader.GetChar(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Status_process.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Idtrace_prev.ToString())))
				{
					businessObject.Idtrace_prev = dataReader.GetInt64(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Idtrace_prev.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Idtrace_next.ToString())))
				{
					businessObject.Idtrace_next = dataReader.GetInt64(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Idtrace_next.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Observation.ToString())))
				{
					businessObject.Observation = dataReader.GetString(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Observation.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CTrace_batch.CTrace_batchFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CTrace_batch</returns>
        internal List<CTrace_batch> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CTrace_batch> list = new List<CTrace_batch>();

            while (dataReader.Read())
            {
                CTrace_batch businessObject = new CTrace_batch();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
