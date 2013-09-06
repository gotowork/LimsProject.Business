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
	/// Data access layer class for CType_preparation_sample
	/// </summary>
	partial class CType_preparation_sampleSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CType_preparation_sampleSql()
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
		public bool Insert(CType_preparation_sample businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_type_preparation_sample_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idtype_preparation_sample", businessObject.Idtype_preparation_sample);
				sqlCommand.Parameters["p_idtype_preparation_sample"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idtype_preparation_sample"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_name_preparation", businessObject.Name_preparation);
				sqlCommand.Parameters["p_name_preparation"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_description", businessObject.Description);
				sqlCommand.Parameters["p_description"].NpgsqlDbType = NpgsqlDbType.Varchar;
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
                businessObject.Idtype_preparation_sample = Convert.ToInt32(sqlCommand.Parameters["p_idtype_preparation_sample"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CType_preparation_sample::Insert::Error occured.", ex);
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
        public bool Update(CType_preparation_sample businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_type_preparation_sample_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idtype_preparation_sample", businessObject.Idtype_preparation_sample);
				sqlCommand.Parameters["p_idtype_preparation_sample"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_name_preparation", businessObject.Name_preparation);
				sqlCommand.Parameters["p_name_preparation"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_description", businessObject.Description);
				sqlCommand.Parameters["p_description"].NpgsqlDbType = NpgsqlDbType.Varchar;
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
                throw new Exception("CType_preparation_sample::Update::Error occured.", ex);
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
        /// <returns>CType_preparation_sample business object</returns>
        public CType_preparation_sample SelectByPrimaryKey(CType_preparation_sampleKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_type_preparation_sample_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idtype_preparation_sample", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idtype_preparation_sample));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CType_preparation_sample businessObject = new CType_preparation_sample();

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
                throw new Exception("CType_preparation_sample::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CType_preparation_sample</returns>
        public List<CType_preparation_sample> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_type_preparation_sample_SelectAll";
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
                throw new Exception("CType_preparation_sample::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_type_preparation_sample_SelectAll";
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
                throw new Exception("CType_preparation_sample::SelectAll::Error occured.", ex);
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
        /// <returns>list of CType_preparation_sample</returns>
        public List<CType_preparation_sample> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_type_preparation_sample_SelectByField";
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
                throw new Exception("CType_preparation_sample::SelectByField::Error occured.", ex);
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
        public bool Delete(CType_preparation_sampleKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_type_preparation_sample_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idtype_preparation_sample", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idtype_preparation_sample));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CType_preparation_sample::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_type_preparation_sample_DeleteByField";
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
                throw new Exception("CType_preparation_sample::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CType_preparation_sample businessObject, IDataReader dataReader)
        {


				businessObject.Idtype_preparation_sample = dataReader.GetInt32(dataReader.GetOrdinal(CType_preparation_sample.CType_preparation_sampleFields.Idtype_preparation_sample.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CType_preparation_sample.CType_preparation_sampleFields.Name_preparation.ToString())))
				{
					businessObject.Name_preparation = dataReader.GetString(dataReader.GetOrdinal(CType_preparation_sample.CType_preparation_sampleFields.Name_preparation.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CType_preparation_sample.CType_preparation_sampleFields.Description.ToString())))
				{
					businessObject.Description = dataReader.GetString(dataReader.GetOrdinal(CType_preparation_sample.CType_preparation_sampleFields.Description.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CType_preparation_sample.CType_preparation_sampleFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CType_preparation_sample.CType_preparation_sampleFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CType_preparation_sample.CType_preparation_sampleFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CType_preparation_sample.CType_preparation_sampleFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CType_preparation_sample.CType_preparation_sampleFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CType_preparation_sample.CType_preparation_sampleFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CType_preparation_sample.CType_preparation_sampleFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CType_preparation_sample.CType_preparation_sampleFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CType_preparation_sample.CType_preparation_sampleFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CType_preparation_sample.CType_preparation_sampleFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CType_preparation_sample</returns>
        internal List<CType_preparation_sample> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CType_preparation_sample> list = new List<CType_preparation_sample>();

            while (dataReader.Read())
            {
                CType_preparation_sample businessObject = new CType_preparation_sample();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
