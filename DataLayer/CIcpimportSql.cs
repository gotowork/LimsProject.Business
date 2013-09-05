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
	/// Data access layer class for CIcpimport
	/// </summary>
	partial class CIcpimportSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CIcpimportSql()
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
		public bool Insert(CIcpimport businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_icpimport_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idicpimport", businessObject.Idicpimport);
				sqlCommand.Parameters["p_idicpimport"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idicpimport"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idbatchicp", businessObject.Idbatchicp);
				sqlCommand.Parameters["p_idbatchicp"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_methodid", businessObject.Methodid);
				sqlCommand.Parameters["p_methodid"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_version", businessObject.Version);
				sqlCommand.Parameters["p_version"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_storagedate", businessObject.Storagedate);
				sqlCommand.Parameters["p_storagedate"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_calibid", businessObject.Calibid);
				sqlCommand.Parameters["p_calibid"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_elementname", businessObject.Elementname);
				sqlCommand.Parameters["p_elementname"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_sampleid", businessObject.Sampleid);
				sqlCommand.Parameters["p_sampleid"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_name", businessObject.Name);
				sqlCommand.Parameters["p_name"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_averageresult", businessObject.Averageresult);
				sqlCommand.Parameters["p_averageresult"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_str_result", businessObject.Str_result);
				sqlCommand.Parameters["p_str_result"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dilution2", businessObject.Dilution2);
				sqlCommand.Parameters["p_dilution2"].NpgsqlDbType = NpgsqlDbType.Integer;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idicpimport = Convert.ToInt32(sqlCommand.Parameters["p_idicpimport"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CIcpimport::Insert::Error occured.", ex);
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
        public bool Update(CIcpimport businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_icpimport_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idicpimport", businessObject.Idicpimport);
				sqlCommand.Parameters["p_idicpimport"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idbatchicp", businessObject.Idbatchicp);
				sqlCommand.Parameters["p_idbatchicp"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_methodid", businessObject.Methodid);
				sqlCommand.Parameters["p_methodid"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_version", businessObject.Version);
				sqlCommand.Parameters["p_version"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_storagedate", businessObject.Storagedate);
				sqlCommand.Parameters["p_storagedate"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_calibid", businessObject.Calibid);
				sqlCommand.Parameters["p_calibid"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_elementname", businessObject.Elementname);
				sqlCommand.Parameters["p_elementname"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_sampleid", businessObject.Sampleid);
				sqlCommand.Parameters["p_sampleid"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_name", businessObject.Name);
				sqlCommand.Parameters["p_name"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_averageresult", businessObject.Averageresult);
				sqlCommand.Parameters["p_averageresult"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_str_result", businessObject.Str_result);
				sqlCommand.Parameters["p_str_result"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dilution2", businessObject.Dilution2);
				sqlCommand.Parameters["p_dilution2"].NpgsqlDbType = NpgsqlDbType.Integer;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CIcpimport::Update::Error occured.", ex);
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
        /// <returns>CIcpimport business object</returns>
        public CIcpimport SelectByPrimaryKey(CIcpimportKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_icpimport_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idicpimport", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idicpimport));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CIcpimport businessObject = new CIcpimport();

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
                throw new Exception("CIcpimport::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CIcpimport</returns>
        public List<CIcpimport> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_icpimport_SelectAll";
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
                throw new Exception("CIcpimport::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_icpimport_SelectAll";
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
                throw new Exception("CIcpimport::SelectAll::Error occured.", ex);
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
        /// <returns>list of CIcpimport</returns>
        public List<CIcpimport> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_icpimport_SelectByField";
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
                throw new Exception("CIcpimport::SelectByField::Error occured.", ex);
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
        public bool Delete(CIcpimportKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_icpimport_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idicpimport", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idicpimport));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CIcpimport::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_icpimport_DeleteByField";
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
                throw new Exception("CIcpimport::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CIcpimport businessObject, IDataReader dataReader)
        {


				businessObject.Idicpimport = dataReader.GetInt32(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Idicpimport.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Idbatchicp.ToString())))
				{
					businessObject.Idbatchicp = dataReader.GetInt32(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Idbatchicp.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Methodid.ToString())))
				{
					businessObject.Methodid = dataReader.GetInt32(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Methodid.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Version.ToString())))
				{
					businessObject.Version = dataReader.GetInt32(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Version.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Storagedate.ToString())))
				{
					businessObject.Storagedate = dataReader.GetDateTime(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Storagedate.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Calibid.ToString())))
				{
					businessObject.Calibid = dataReader.GetInt32(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Calibid.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Elementname.ToString())))
				{
					businessObject.Elementname = dataReader.GetString(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Elementname.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Sampleid.ToString())))
				{
					businessObject.Sampleid = dataReader.GetInt32(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Sampleid.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Name.ToString())))
				{
					businessObject.Name = dataReader.GetString(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Name.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Averageresult.ToString())))
				{
					businessObject.Averageresult = dataReader.GetDecimal(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Averageresult.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Str_result.ToString())))
				{
					businessObject.Str_result = dataReader.GetString(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Str_result.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Dilution2.ToString())))
				{
					businessObject.Dilution2 = dataReader.GetInt32(dataReader.GetOrdinal(CIcpimport.CIcpimportFields.Dilution2.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CIcpimport</returns>
        internal List<CIcpimport> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CIcpimport> list = new List<CIcpimport>();

            while (dataReader.Read())
            {
                CIcpimport businessObject = new CIcpimport();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
