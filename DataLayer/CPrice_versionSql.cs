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
	/// Data access layer class for CPrice_version
	/// </summary>
	partial class CPrice_versionSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CPrice_versionSql()
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
		public bool Insert(CPrice_version businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_price_version_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idprice_version", businessObject.Idprice_version);
				sqlCommand.Parameters["p_idprice_version"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idprice_version"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idprice", businessObject.Idprice);
				sqlCommand.Parameters["p_idprice"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_num_version", businessObject.Num_version);
				sqlCommand.Parameters["p_num_version"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_cod_type_sample", businessObject.Cod_type_sample);
				sqlCommand.Parameters["p_cod_type_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idcompany", businessObject.Idcompany);
				sqlCommand.Parameters["p_idcompany"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_attention", businessObject.Attention);
				sqlCommand.Parameters["p_attention"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_iduser", businessObject.Iduser);
				sqlCommand.Parameters["p_iduser"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_num_days_post", businessObject.Num_days_post);
				sqlCommand.Parameters["p_num_days_post"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_date_creation", businessObject.Date_creation);
				sqlCommand.Parameters["p_date_creation"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_user_creation", businessObject.User_creation);
				sqlCommand.Parameters["p_user_creation"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_num_days_valid", businessObject.Num_days_valid);
				sqlCommand.Parameters["p_num_days_valid"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_status_price", businessObject.Status_price);
				sqlCommand.Parameters["p_status_price"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_observation", businessObject.Observation);
				sqlCommand.Parameters["p_observation"].NpgsqlDbType = NpgsqlDbType.Varchar;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idprice_version = Convert.ToInt32(sqlCommand.Parameters["p_idprice_version"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CPrice_version::Insert::Error occured.", ex);
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
        public bool Update(CPrice_version businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_price_version_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idprice_version", businessObject.Idprice_version);
				sqlCommand.Parameters["p_idprice_version"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idprice", businessObject.Idprice);
				sqlCommand.Parameters["p_idprice"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_num_version", businessObject.Num_version);
				sqlCommand.Parameters["p_num_version"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_cod_type_sample", businessObject.Cod_type_sample);
				sqlCommand.Parameters["p_cod_type_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idcompany", businessObject.Idcompany);
				sqlCommand.Parameters["p_idcompany"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_attention", businessObject.Attention);
				sqlCommand.Parameters["p_attention"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_iduser", businessObject.Iduser);
				sqlCommand.Parameters["p_iduser"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_num_days_post", businessObject.Num_days_post);
				sqlCommand.Parameters["p_num_days_post"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_date_creation", businessObject.Date_creation);
				sqlCommand.Parameters["p_date_creation"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_user_creation", businessObject.User_creation);
				sqlCommand.Parameters["p_user_creation"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_num_days_valid", businessObject.Num_days_valid);
				sqlCommand.Parameters["p_num_days_valid"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_status_price", businessObject.Status_price);
				sqlCommand.Parameters["p_status_price"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_observation", businessObject.Observation);
				sqlCommand.Parameters["p_observation"].NpgsqlDbType = NpgsqlDbType.Varchar;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CPrice_version::Update::Error occured.", ex);
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
        /// <returns>CPrice_version business object</returns>
        public CPrice_version SelectByPrimaryKey(CPrice_versionKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_price_version_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idprice_version", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idprice_version));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CPrice_version businessObject = new CPrice_version();

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
                throw new Exception("CPrice_version::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CPrice_version</returns>
        public List<CPrice_version> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_price_version_SelectAll";
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
                throw new Exception("CPrice_version::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_price_version_SelectAll";
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
                throw new Exception("CPrice_version::SelectAll::Error occured.", ex);
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
        /// <returns>list of CPrice_version</returns>
        public List<CPrice_version> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_price_version_SelectByField";
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
                throw new Exception("CPrice_version::SelectByField::Error occured.", ex);
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
        public bool Delete(CPrice_versionKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_price_version_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idprice_version", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idprice_version));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CPrice_version::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_price_version_DeleteByField";
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
                throw new Exception("CPrice_version::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CPrice_version businessObject, IDataReader dataReader)
        {


				businessObject.Idprice_version = dataReader.GetInt32(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Idprice_version.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Idprice.ToString())))
				{
					businessObject.Idprice = dataReader.GetInt32(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Idprice.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Idrecep_sample.ToString())))
				{
					businessObject.Idrecep_sample = dataReader.GetInt64(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Idrecep_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Num_version.ToString())))
				{
					businessObject.Num_version = dataReader.GetInt32(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Num_version.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Cod_type_sample.ToString())))
				{
					businessObject.Cod_type_sample = dataReader.GetString(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Cod_type_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Idcompany.ToString())))
				{
					businessObject.Idcompany = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Idcompany.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Attention.ToString())))
				{
					businessObject.Attention = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Attention.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Iduser.ToString())))
				{
					businessObject.Iduser = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Iduser.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Num_days_post.ToString())))
				{
					businessObject.Num_days_post = dataReader.GetInt32(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Num_days_post.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Date_creation.ToString())))
				{
					businessObject.Date_creation = dataReader.GetDateTime(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Date_creation.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.User_creation.ToString())))
				{
					businessObject.User_creation = dataReader.GetString(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.User_creation.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Num_days_valid.ToString())))
				{
					businessObject.Num_days_valid = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Num_days_valid.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Status_price.ToString())))
				{
					businessObject.Status_price = dataReader.GetInt32(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Status_price.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Observation.ToString())))
				{
					businessObject.Observation = dataReader.GetString(dataReader.GetOrdinal(CPrice_version.CPrice_versionFields.Observation.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CPrice_version</returns>
        internal List<CPrice_version> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CPrice_version> list = new List<CPrice_version>();

            while (dataReader.Read())
            {
                CPrice_version businessObject = new CPrice_version();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
