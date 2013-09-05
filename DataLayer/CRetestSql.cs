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
	/// Data access layer class for CRetest
	/// </summary>
	partial class CRetestSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CRetestSql()
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
		public bool Insert(CRetest businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_retest_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idretest", businessObject.Idretest);
				sqlCommand.Parameters["p_idretest"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters["p_idretest"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail_elem", businessObject.Idrecep_sample_detail_elem);
				sqlCommand.Parameters["p_idrecep_sample_detail_elem"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail", businessObject.Idrecep_sample_detail);
				sqlCommand.Parameters["p_idrecep_sample_detail"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_origin_batch", businessObject.Origin_batch);
				sqlCommand.Parameters["p_origin_batch"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_destiny_batch", businessObject.Destiny_batch);
				sqlCommand.Parameters["p_destiny_batch"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_type_retest", businessObject.Type_retest);
				sqlCommand.Parameters["p_type_retest"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_date_retest", businessObject.Date_retest);
				sqlCommand.Parameters["p_date_retest"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_usernew", businessObject.Usernew);
				sqlCommand.Parameters["p_usernew"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_datenew", businessObject.Datenew);
				sqlCommand.Parameters["p_datenew"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_useredit1", businessObject.Useredit1);
				sqlCommand.Parameters["p_useredit1"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dateedit1", businessObject.Dateedit1);
				sqlCommand.Parameters["p_dateedit1"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_status_retest", businessObject.Status_retest);
				sqlCommand.Parameters["p_status_retest"].NpgsqlDbType = NpgsqlDbType.Smallint;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idretest = Convert.ToInt64(sqlCommand.Parameters["p_idretest"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CRetest::Insert::Error occured.", ex);
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
        public bool Update(CRetest businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_retest_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idretest", businessObject.Idretest);
				sqlCommand.Parameters["p_idretest"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail_elem", businessObject.Idrecep_sample_detail_elem);
				sqlCommand.Parameters["p_idrecep_sample_detail_elem"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail", businessObject.Idrecep_sample_detail);
				sqlCommand.Parameters["p_idrecep_sample_detail"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_origin_batch", businessObject.Origin_batch);
				sqlCommand.Parameters["p_origin_batch"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_destiny_batch", businessObject.Destiny_batch);
				sqlCommand.Parameters["p_destiny_batch"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_type_retest", businessObject.Type_retest);
				sqlCommand.Parameters["p_type_retest"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_date_retest", businessObject.Date_retest);
				sqlCommand.Parameters["p_date_retest"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_usernew", businessObject.Usernew);
				sqlCommand.Parameters["p_usernew"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_datenew", businessObject.Datenew);
				sqlCommand.Parameters["p_datenew"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_useredit1", businessObject.Useredit1);
				sqlCommand.Parameters["p_useredit1"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dateedit1", businessObject.Dateedit1);
				sqlCommand.Parameters["p_dateedit1"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_status_retest", businessObject.Status_retest);
				sqlCommand.Parameters["p_status_retest"].NpgsqlDbType = NpgsqlDbType.Smallint;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CRetest::Update::Error occured.", ex);
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
        /// <returns>CRetest business object</returns>
        public CRetest SelectByPrimaryKey(CRetestKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_retest_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idretest", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idretest));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CRetest businessObject = new CRetest();

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
                throw new Exception("CRetest::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CRetest</returns>
        public List<CRetest> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_retest_SelectAll";
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
                throw new Exception("CRetest::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_retest_SelectAll";
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
                throw new Exception("CRetest::SelectAll::Error occured.", ex);
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
        /// <returns>list of CRetest</returns>
        public List<CRetest> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_retest_SelectByField";
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
                throw new Exception("CRetest::SelectByField::Error occured.", ex);
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
        public bool Delete(CRetestKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_retest_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idretest", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idretest));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CRetest::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_retest_DeleteByField";
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
                throw new Exception("CRetest::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CRetest businessObject, IDataReader dataReader)
        {


				businessObject.Idretest = dataReader.GetInt64(dataReader.GetOrdinal(CRetest.CRetestFields.Idretest.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRetest.CRetestFields.Idrecep_sample_detail_elem.ToString())))
				{
					businessObject.Idrecep_sample_detail_elem = dataReader.GetInt64(dataReader.GetOrdinal(CRetest.CRetestFields.Idrecep_sample_detail_elem.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRetest.CRetestFields.Idrecep_sample_detail.ToString())))
				{
					businessObject.Idrecep_sample_detail = dataReader.GetInt64(dataReader.GetOrdinal(CRetest.CRetestFields.Idrecep_sample_detail.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRetest.CRetestFields.Origin_batch.ToString())))
				{
					businessObject.Origin_batch = dataReader.GetInt64(dataReader.GetOrdinal(CRetest.CRetestFields.Origin_batch.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRetest.CRetestFields.Destiny_batch.ToString())))
				{
					businessObject.Destiny_batch = dataReader.GetInt64(dataReader.GetOrdinal(CRetest.CRetestFields.Destiny_batch.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRetest.CRetestFields.Type_retest.ToString())))
				{
					businessObject.Type_retest = dataReader.GetChar(dataReader.GetOrdinal(CRetest.CRetestFields.Type_retest.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRetest.CRetestFields.Date_retest.ToString())))
				{
					businessObject.Date_retest = dataReader.GetDateTime(dataReader.GetOrdinal(CRetest.CRetestFields.Date_retest.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRetest.CRetestFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CRetest.CRetestFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRetest.CRetestFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CRetest.CRetestFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRetest.CRetestFields.Useredit1.ToString())))
				{
					businessObject.Useredit1 = dataReader.GetString(dataReader.GetOrdinal(CRetest.CRetestFields.Useredit1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRetest.CRetestFields.Dateedit1.ToString())))
				{
					businessObject.Dateedit1 = dataReader.GetDateTime(dataReader.GetOrdinal(CRetest.CRetestFields.Dateedit1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRetest.CRetestFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CRetest.CRetestFields.Status.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRetest.CRetestFields.Status_retest.ToString())))
				{
					businessObject.Status_retest = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRetest.CRetestFields.Status_retest.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CRetest</returns>
        internal List<CRetest> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CRetest> list = new List<CRetest>();

            while (dataReader.Read())
            {
                CRetest businessObject = new CRetest();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
