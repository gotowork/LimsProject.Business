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
	/// Data access layer class for CRecep_sample_dispatch
	/// </summary>
	partial class CRecep_sample_dispatchSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CRecep_sample_dispatchSql()
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
		public bool Insert(CRecep_sample_dispatch businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_recep_sample_dispatch_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_dispatch_person", businessObject.Dispatch_person);
				sqlCommand.Parameters["p_dispatch_person"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_dispatch_mail", businessObject.Dispatch_mail);
				sqlCommand.Parameters["p_dispatch_mail"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_dispatch_curier", businessObject.Dispatch_curier);
				sqlCommand.Parameters["p_dispatch_curier"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_dispatch_transport", businessObject.Dispatch_transport);
				sqlCommand.Parameters["p_dispatch_transport"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_dispatch_fax", businessObject.Dispatch_fax);
				sqlCommand.Parameters["p_dispatch_fax"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_dispatch_otro", businessObject.Dispatch_otro);
				sqlCommand.Parameters["p_dispatch_otro"].NpgsqlDbType = NpgsqlDbType.Smallint;
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
                
				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CRecep_sample_dispatch::Insert::Error occured.", ex);
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
        public bool Update(CRecep_sample_dispatch businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_dispatch_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_dispatch_person", businessObject.Dispatch_person);
				sqlCommand.Parameters["p_dispatch_person"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_dispatch_mail", businessObject.Dispatch_mail);
				sqlCommand.Parameters["p_dispatch_mail"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_dispatch_curier", businessObject.Dispatch_curier);
				sqlCommand.Parameters["p_dispatch_curier"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_dispatch_transport", businessObject.Dispatch_transport);
				sqlCommand.Parameters["p_dispatch_transport"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_dispatch_fax", businessObject.Dispatch_fax);
				sqlCommand.Parameters["p_dispatch_fax"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_dispatch_otro", businessObject.Dispatch_otro);
				sqlCommand.Parameters["p_dispatch_otro"].NpgsqlDbType = NpgsqlDbType.Smallint;
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
                throw new Exception("CRecep_sample_dispatch::Update::Error occured.", ex);
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
        /// <returns>CRecep_sample_dispatch business object</returns>
        public CRecep_sample_dispatch SelectByPrimaryKey(CRecep_sample_dispatchKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_dispatch_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idrecep_sample", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idrecep_sample));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CRecep_sample_dispatch businessObject = new CRecep_sample_dispatch();

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
                throw new Exception("CRecep_sample_dispatch::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CRecep_sample_dispatch</returns>
        public List<CRecep_sample_dispatch> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_dispatch_SelectAll";
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
                throw new Exception("CRecep_sample_dispatch::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_recep_sample_dispatch_SelectAll";
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
                throw new Exception("CRecep_sample_dispatch::SelectAll::Error occured.", ex);
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
        /// <returns>list of CRecep_sample_dispatch</returns>
        public List<CRecep_sample_dispatch> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_dispatch_SelectByField";
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
                throw new Exception("CRecep_sample_dispatch::SelectByField::Error occured.", ex);
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
        public bool Delete(CRecep_sample_dispatchKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_dispatch_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idrecep_sample", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idrecep_sample));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CRecep_sample_dispatch::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_recep_sample_dispatch_DeleteByField";
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
                throw new Exception("CRecep_sample_dispatch::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CRecep_sample_dispatch businessObject, IDataReader dataReader)
        {


				businessObject.Idrecep_sample = dataReader.GetInt64(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Idrecep_sample.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Dispatch_person.ToString())))
				{
					businessObject.Dispatch_person = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Dispatch_person.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Dispatch_mail.ToString())))
				{
					businessObject.Dispatch_mail = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Dispatch_mail.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Dispatch_curier.ToString())))
				{
					businessObject.Dispatch_curier = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Dispatch_curier.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Dispatch_transport.ToString())))
				{
					businessObject.Dispatch_transport = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Dispatch_transport.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Dispatch_fax.ToString())))
				{
					businessObject.Dispatch_fax = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Dispatch_fax.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Dispatch_otro.ToString())))
				{
					businessObject.Dispatch_otro = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Dispatch_otro.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CRecep_sample_dispatch.CRecep_sample_dispatchFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CRecep_sample_dispatch</returns>
        internal List<CRecep_sample_dispatch> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CRecep_sample_dispatch> list = new List<CRecep_sample_dispatch>();

            while (dataReader.Read())
            {
                CRecep_sample_dispatch businessObject = new CRecep_sample_dispatch();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
