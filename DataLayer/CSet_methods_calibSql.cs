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
	/// Data access layer class for CSet_methods_calib
	/// </summary>
	partial class CSet_methods_calibSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CSet_methods_calibSql()
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
		public bool Insert(CSet_methods_calib businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_set_methods_calib_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idset_methods_calib", businessObject.Idset_methods_calib);
				sqlCommand.Parameters["p_idset_methods_calib"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idset_methods_calib"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idsolution_pattern", businessObject.Idsolution_pattern);
				sqlCommand.Parameters["p_idsolution_pattern"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idelement", businessObject.Idelement);
				sqlCommand.Parameters["p_idelement"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idmr_detail", businessObject.Idmr_detail);
				sqlCommand.Parameters["p_idmr_detail"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idreactive_medium", businessObject.Idreactive_medium);
				sqlCommand.Parameters["p_idreactive_medium"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idreactive_modif", businessObject.Idreactive_modif);
				sqlCommand.Parameters["p_idreactive_modif"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_order_set", businessObject.Order_set);
				sqlCommand.Parameters["p_order_set"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_name_methods_calib", businessObject.Name_methods_calib);
				sqlCommand.Parameters["p_name_methods_calib"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_user_calib", businessObject.User_calib);
				sqlCommand.Parameters["p_user_calib"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_calib", businessObject.Date_calib);
				sqlCommand.Parameters["p_date_calib"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_status_set", businessObject.Status_set);
				sqlCommand.Parameters["p_status_set"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_date_ini", businessObject.Date_ini);
				sqlCommand.Parameters["p_date_ini"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_date_end", businessObject.Date_end);
				sqlCommand.Parameters["p_date_end"].NpgsqlDbType = NpgsqlDbType.Timestamp;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idset_methods_calib = Convert.ToInt32(sqlCommand.Parameters["p_idset_methods_calib"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CSet_methods_calib::Insert::Error occured.", ex);
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
        public bool Update(CSet_methods_calib businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_set_methods_calib_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idset_methods_calib", businessObject.Idset_methods_calib);
				sqlCommand.Parameters["p_idset_methods_calib"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idsolution_pattern", businessObject.Idsolution_pattern);
				sqlCommand.Parameters["p_idsolution_pattern"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idelement", businessObject.Idelement);
				sqlCommand.Parameters["p_idelement"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idmr_detail", businessObject.Idmr_detail);
				sqlCommand.Parameters["p_idmr_detail"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idreactive_medium", businessObject.Idreactive_medium);
				sqlCommand.Parameters["p_idreactive_medium"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idreactive_modif", businessObject.Idreactive_modif);
				sqlCommand.Parameters["p_idreactive_modif"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_order_set", businessObject.Order_set);
				sqlCommand.Parameters["p_order_set"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_name_methods_calib", businessObject.Name_methods_calib);
				sqlCommand.Parameters["p_name_methods_calib"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_user_calib", businessObject.User_calib);
				sqlCommand.Parameters["p_user_calib"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_calib", businessObject.Date_calib);
				sqlCommand.Parameters["p_date_calib"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_status_set", businessObject.Status_set);
				sqlCommand.Parameters["p_status_set"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_date_ini", businessObject.Date_ini);
				sqlCommand.Parameters["p_date_ini"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_date_end", businessObject.Date_end);
				sqlCommand.Parameters["p_date_end"].NpgsqlDbType = NpgsqlDbType.Timestamp;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CSet_methods_calib::Update::Error occured.", ex);
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
        /// <returns>CSet_methods_calib business object</returns>
        public CSet_methods_calib SelectByPrimaryKey(CSet_methods_calibKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_set_methods_calib_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idset_methods_calib", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idset_methods_calib));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CSet_methods_calib businessObject = new CSet_methods_calib();

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
                throw new Exception("CSet_methods_calib::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CSet_methods_calib</returns>
        public List<CSet_methods_calib> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_set_methods_calib_SelectAll";
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
                throw new Exception("CSet_methods_calib::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_set_methods_calib_SelectAll";
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
                throw new Exception("CSet_methods_calib::SelectAll::Error occured.", ex);
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
        /// <returns>list of CSet_methods_calib</returns>
        public List<CSet_methods_calib> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_set_methods_calib_SelectByField";
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
                throw new Exception("CSet_methods_calib::SelectByField::Error occured.", ex);
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
        public bool Delete(CSet_methods_calibKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_set_methods_calib_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idset_methods_calib", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idset_methods_calib));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CSet_methods_calib::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_set_methods_calib_DeleteByField";
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
                throw new Exception("CSet_methods_calib::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CSet_methods_calib businessObject, IDataReader dataReader)
        {


				businessObject.Idset_methods_calib = dataReader.GetInt32(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Idset_methods_calib.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Idsolution_pattern.ToString())))
				{
					businessObject.Idsolution_pattern = dataReader.GetInt32(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Idsolution_pattern.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Idelement.ToString())))
				{
					businessObject.Idelement = dataReader.GetInt32(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Idelement.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Idmr_detail.ToString())))
				{
					businessObject.Idmr_detail = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Idmr_detail.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Idreactive_medium.ToString())))
				{
					businessObject.Idreactive_medium = dataReader.GetInt32(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Idreactive_medium.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Idreactive_modif.ToString())))
				{
					businessObject.Idreactive_modif = dataReader.GetInt32(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Idreactive_modif.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Order_set.ToString())))
				{
					businessObject.Order_set = dataReader.GetInt32(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Order_set.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Name_methods_calib.ToString())))
				{
					businessObject.Name_methods_calib = dataReader.GetString(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Name_methods_calib.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.User_calib.ToString())))
				{
					businessObject.User_calib = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.User_calib.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Date_calib.ToString())))
				{
					businessObject.Date_calib = dataReader.GetDateTime(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Date_calib.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Status_set.ToString())))
				{
					businessObject.Status_set = dataReader.GetInt32(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Status_set.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Date_ini.ToString())))
				{
					businessObject.Date_ini = dataReader.GetDateTime(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Date_ini.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Date_end.ToString())))
				{
					businessObject.Date_end = dataReader.GetDateTime(dataReader.GetOrdinal(CSet_methods_calib.CSet_methods_calibFields.Date_end.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CSet_methods_calib</returns>
        internal List<CSet_methods_calib> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CSet_methods_calib> list = new List<CSet_methods_calib>();

            while (dataReader.Read())
            {
                CSet_methods_calib businessObject = new CSet_methods_calib();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
