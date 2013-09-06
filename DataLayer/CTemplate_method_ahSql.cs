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
	/// Data access layer class for CTemplate_method_ah
	/// </summary>
	partial class CTemplate_method_ahSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CTemplate_method_ahSql()
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
		public bool Insert(CTemplate_method_ah businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_template_method_ah_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_symbol", businessObject.Symbol);
				sqlCommand.Parameters["p_symbol"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idunit_result", businessObject.Idunit_result);
				sqlCommand.Parameters["p_idunit_result"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_usernew", businessObject.Usernew);
				sqlCommand.Parameters["p_usernew"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_datenew", businessObject.Datenew);
				sqlCommand.Parameters["p_datenew"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_useredit", businessObject.Useredit);
				sqlCommand.Parameters["p_useredit"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dateedit", businessObject.Dateedit);
				sqlCommand.Parameters["p_dateedit"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                
				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CTemplate_method_ah::Insert::Error occured.", ex);
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
        public bool Update(CTemplate_method_ah businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_ah_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_symbol", businessObject.Symbol);
				sqlCommand.Parameters["p_symbol"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idunit_result", businessObject.Idunit_result);
				sqlCommand.Parameters["p_idunit_result"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_usernew", businessObject.Usernew);
				sqlCommand.Parameters["p_usernew"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_datenew", businessObject.Datenew);
				sqlCommand.Parameters["p_datenew"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_useredit", businessObject.Useredit);
				sqlCommand.Parameters["p_useredit"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dateedit", businessObject.Dateedit);
				sqlCommand.Parameters["p_dateedit"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CTemplate_method_ah::Update::Error occured.", ex);
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
        /// <returns>CTemplate_method_ah business object</returns>
        public CTemplate_method_ah SelectByPrimaryKey(CTemplate_method_ahKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_ah_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idtemplate_method", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idtemplate_method));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CTemplate_method_ah businessObject = new CTemplate_method_ah();

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
                throw new Exception("CTemplate_method_ah::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CTemplate_method_ah</returns>
        public List<CTemplate_method_ah> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_ah_SelectAll";
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
                throw new Exception("CTemplate_method_ah::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_template_method_ah_SelectAll";
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
                throw new Exception("CTemplate_method_ah::SelectAll::Error occured.", ex);
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
        /// <returns>list of CTemplate_method_ah</returns>
        public List<CTemplate_method_ah> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_ah_SelectByField";
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
                throw new Exception("CTemplate_method_ah::SelectByField::Error occured.", ex);
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
        public bool Delete(CTemplate_method_ahKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_ah_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idtemplate_method", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idtemplate_method));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTemplate_method_ah::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_template_method_ah_DeleteByField";
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
                throw new Exception("CTemplate_method_ah::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CTemplate_method_ah businessObject, IDataReader dataReader)
        {


				businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CTemplate_method_ah.CTemplate_method_ahFields.Idtemplate_method.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_ah.CTemplate_method_ahFields.Symbol.ToString())))
				{
					businessObject.Symbol = dataReader.GetString(dataReader.GetOrdinal(CTemplate_method_ah.CTemplate_method_ahFields.Symbol.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_ah.CTemplate_method_ahFields.Idunit_result.ToString())))
				{
					businessObject.Idunit_result = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_ah.CTemplate_method_ahFields.Idunit_result.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_ah.CTemplate_method_ahFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CTemplate_method_ah.CTemplate_method_ahFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_ah.CTemplate_method_ahFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CTemplate_method_ah.CTemplate_method_ahFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_ah.CTemplate_method_ahFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CTemplate_method_ah.CTemplate_method_ahFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_ah.CTemplate_method_ahFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CTemplate_method_ah.CTemplate_method_ahFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_ah.CTemplate_method_ahFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CTemplate_method_ah.CTemplate_method_ahFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CTemplate_method_ah</returns>
        internal List<CTemplate_method_ah> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CTemplate_method_ah> list = new List<CTemplate_method_ah>();

            while (dataReader.Read())
            {
                CTemplate_method_ah businessObject = new CTemplate_method_ah();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
