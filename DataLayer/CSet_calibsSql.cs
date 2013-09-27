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
	/// Data access layer class for CSet_calibs
	/// </summary>
	partial class CSet_calibsSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CSet_calibsSql()
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
		public bool Insert(CSet_calibs businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_set_calibs_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idset_calibs", businessObject.Idset_calibs);
				sqlCommand.Parameters["p_idset_calibs"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idset_calibs"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_calib_group_name", businessObject.Calib_group_name);
				sqlCommand.Parameters["p_calib_group_name"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_r", businessObject.R);
				sqlCommand.Parameters["p_r"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_a", businessObject.A);
				sqlCommand.Parameters["p_a"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_b", businessObject.B);
				sqlCommand.Parameters["p_b"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idsolution_interm", businessObject.Idsolution_interm);
				sqlCommand.Parameters["p_idsolution_interm"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_usersign", businessObject.Usersign);
				sqlCommand.Parameters["p_usersign"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_datesign", businessObject.Datesign);
				sqlCommand.Parameters["p_datesign"].NpgsqlDbType = NpgsqlDbType.Timestamp;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idset_calibs = Convert.ToInt32(sqlCommand.Parameters["p_idset_calibs"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CSet_calibs::Insert::Error occured.", ex);
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
        public bool Update(CSet_calibs businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_set_calibs_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idset_calibs", businessObject.Idset_calibs);
				sqlCommand.Parameters["p_idset_calibs"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_calib_group_name", businessObject.Calib_group_name);
				sqlCommand.Parameters["p_calib_group_name"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_r", businessObject.R);
				sqlCommand.Parameters["p_r"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_a", businessObject.A);
				sqlCommand.Parameters["p_a"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_b", businessObject.B);
				sqlCommand.Parameters["p_b"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idsolution_interm", businessObject.Idsolution_interm);
				sqlCommand.Parameters["p_idsolution_interm"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_usersign", businessObject.Usersign);
				sqlCommand.Parameters["p_usersign"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_datesign", businessObject.Datesign);
				sqlCommand.Parameters["p_datesign"].NpgsqlDbType = NpgsqlDbType.Timestamp;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CSet_calibs::Update::Error occured.", ex);
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
        /// <returns>CSet_calibs business object</returns>
        public CSet_calibs SelectByPrimaryKey(CSet_calibsKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_set_calibs_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idset_calibs", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idset_calibs));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CSet_calibs businessObject = new CSet_calibs();

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
                throw new Exception("CSet_calibs::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CSet_calibs</returns>
        public List<CSet_calibs> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_set_calibs_SelectAll";
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
                throw new Exception("CSet_calibs::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_set_calibs_SelectAll";
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
                throw new Exception("CSet_calibs::SelectAll::Error occured.", ex);
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
        /// <returns>list of CSet_calibs</returns>
        public List<CSet_calibs> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_set_calibs_SelectByField";
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
                throw new Exception("CSet_calibs::SelectByField::Error occured.", ex);
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
        public bool Delete(CSet_calibsKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_set_calibs_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idset_calibs", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idset_calibs));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CSet_calibs::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_set_calibs_DeleteByField";
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
                throw new Exception("CSet_calibs::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CSet_calibs businessObject, IDataReader dataReader)
        {


				businessObject.Idset_calibs = dataReader.GetInt32(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.Idset_calibs.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.Calib_group_name.ToString())))
				{
					businessObject.Calib_group_name = dataReader.GetString(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.Calib_group_name.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.R.ToString())))
				{
					businessObject.R = dataReader.GetDecimal(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.R.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.A.ToString())))
				{
					businessObject.A = dataReader.GetDecimal(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.A.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.B.ToString())))
				{
					businessObject.B = dataReader.GetDecimal(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.B.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.Idtemplate_method.ToString())))
				{
					businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.Idtemplate_method.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.Idsolution_interm.ToString())))
				{
					businessObject.Idsolution_interm = dataReader.GetInt32(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.Idsolution_interm.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.Usersign.ToString())))
				{
					businessObject.Usersign = dataReader.GetString(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.Usersign.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.Datesign.ToString())))
				{
					businessObject.Datesign = dataReader.GetDateTime(dataReader.GetOrdinal(CSet_calibs.CSet_calibsFields.Datesign.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CSet_calibs</returns>
        internal List<CSet_calibs> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CSet_calibs> list = new List<CSet_calibs>();

            while (dataReader.Read())
            {
                CSet_calibs businessObject = new CSet_calibs();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
