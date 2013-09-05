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
	/// Data access layer class for CDocumentation_user
	/// </summary>
	partial class CDocumentation_userSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CDocumentation_userSql()
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
		public bool Insert(CDocumentation_user businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_documentation_user_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_iddocumentation_user", businessObject.Iddocumentation_user);
				sqlCommand.Parameters["p_iddocumentation_user"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters["p_iddocumentation_user"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_iddocumentation", businessObject.Iddocumentation);
				sqlCommand.Parameters["p_iddocumentation"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_iduser", businessObject.Iduser);
				sqlCommand.Parameters["p_iduser"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_ini", businessObject.Date_ini);
				sqlCommand.Parameters["p_date_ini"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_date_end", businessObject.Date_end);
				sqlCommand.Parameters["p_date_end"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_name_file", businessObject.Name_file);
				sqlCommand.Parameters["p_name_file"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_order_file", businessObject.Order_file);
				sqlCommand.Parameters["p_order_file"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_extension_file", businessObject.Extension_file);
				sqlCommand.Parameters["p_extension_file"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_prev_authorized", businessObject.Prev_authorized);
				sqlCommand.Parameters["p_prev_authorized"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_rank_valid_inmonth", businessObject.Rank_valid_inmonth);
				sqlCommand.Parameters["p_rank_valid_inmonth"].NpgsqlDbType = NpgsqlDbType.Integer;
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
                businessObject.Iddocumentation_user = Convert.ToInt64(sqlCommand.Parameters["p_iddocumentation_user"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CDocumentation_user::Insert::Error occured.", ex);
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
        public bool Update(CDocumentation_user businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_documentation_user_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_iddocumentation_user", businessObject.Iddocumentation_user);
				sqlCommand.Parameters["p_iddocumentation_user"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_iddocumentation", businessObject.Iddocumentation);
				sqlCommand.Parameters["p_iddocumentation"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_iduser", businessObject.Iduser);
				sqlCommand.Parameters["p_iduser"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_ini", businessObject.Date_ini);
				sqlCommand.Parameters["p_date_ini"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_date_end", businessObject.Date_end);
				sqlCommand.Parameters["p_date_end"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_name_file", businessObject.Name_file);
				sqlCommand.Parameters["p_name_file"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_order_file", businessObject.Order_file);
				sqlCommand.Parameters["p_order_file"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_extension_file", businessObject.Extension_file);
				sqlCommand.Parameters["p_extension_file"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_prev_authorized", businessObject.Prev_authorized);
				sqlCommand.Parameters["p_prev_authorized"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_rank_valid_inmonth", businessObject.Rank_valid_inmonth);
				sqlCommand.Parameters["p_rank_valid_inmonth"].NpgsqlDbType = NpgsqlDbType.Integer;
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
                throw new Exception("CDocumentation_user::Update::Error occured.", ex);
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
        /// <returns>CDocumentation_user business object</returns>
        public CDocumentation_user SelectByPrimaryKey(CDocumentation_userKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_documentation_user_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_iddocumentation_user", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Iddocumentation_user));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CDocumentation_user businessObject = new CDocumentation_user();

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
                throw new Exception("CDocumentation_user::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CDocumentation_user</returns>
        public List<CDocumentation_user> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_documentation_user_SelectAll";
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
                throw new Exception("CDocumentation_user::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_documentation_user_SelectAll";
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
                throw new Exception("CDocumentation_user::SelectAll::Error occured.", ex);
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
        /// <returns>list of CDocumentation_user</returns>
        public List<CDocumentation_user> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_documentation_user_SelectByField";
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
                throw new Exception("CDocumentation_user::SelectByField::Error occured.", ex);
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
        public bool Delete(CDocumentation_userKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_documentation_user_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_iddocumentation_user", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Iddocumentation_user));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CDocumentation_user::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_documentation_user_DeleteByField";
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
                throw new Exception("CDocumentation_user::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CDocumentation_user businessObject, IDataReader dataReader)
        {


				businessObject.Iddocumentation_user = dataReader.GetInt64(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Iddocumentation_user.ToString()));

				businessObject.Iddocumentation = (short)dataReader.GetInt16(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Iddocumentation.ToString()));

				businessObject.Iduser = (short)dataReader.GetInt16(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Iduser.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Date_ini.ToString())))
				{
					businessObject.Date_ini = dataReader.GetDateTime(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Date_ini.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Date_end.ToString())))
				{
					businessObject.Date_end = dataReader.GetDateTime(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Date_end.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Name_file.ToString())))
				{
					businessObject.Name_file = dataReader.GetString(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Name_file.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Order_file.ToString())))
				{
					businessObject.Order_file = dataReader.GetInt64(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Order_file.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Extension_file.ToString())))
				{
					businessObject.Extension_file = dataReader.GetString(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Extension_file.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Prev_authorized.ToString())))
				{
					businessObject.Prev_authorized = dataReader.GetBoolean(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Prev_authorized.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Rank_valid_inmonth.ToString())))
				{
					businessObject.Rank_valid_inmonth = dataReader.GetInt32(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Rank_valid_inmonth.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CDocumentation_user.CDocumentation_userFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CDocumentation_user</returns>
        internal List<CDocumentation_user> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CDocumentation_user> list = new List<CDocumentation_user>();

            while (dataReader.Read())
            {
                CDocumentation_user businessObject = new CDocumentation_user();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
