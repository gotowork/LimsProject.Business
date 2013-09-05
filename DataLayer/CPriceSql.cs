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
	/// Data access layer class for CPrice
	/// </summary>
	partial class CPriceSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CPriceSql()
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
		public bool Insert(CPrice businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_price_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idprice", businessObject.Idprice);
				sqlCommand.Parameters["p_idprice"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idprice"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_cod_price", businessObject.Cod_price);
				sqlCommand.Parameters["p_cod_price"].NpgsqlDbType = NpgsqlDbType.Varchar;
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
				sqlCommand.Parameters.AddWithValue("p_request_reference", businessObject.Request_reference);
				sqlCommand.Parameters["p_request_reference"].NpgsqlDbType = NpgsqlDbType.Integer;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idprice = Convert.ToInt32(sqlCommand.Parameters["p_idprice"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CPrice::Insert::Error occured.", ex);
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
        public bool Update(CPrice businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_price_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idprice", businessObject.Idprice);
				sqlCommand.Parameters["p_idprice"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_cod_price", businessObject.Cod_price);
				sqlCommand.Parameters["p_cod_price"].NpgsqlDbType = NpgsqlDbType.Varchar;
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
				sqlCommand.Parameters.AddWithValue("p_request_reference", businessObject.Request_reference);
				sqlCommand.Parameters["p_request_reference"].NpgsqlDbType = NpgsqlDbType.Integer;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CPrice::Update::Error occured.", ex);
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
        /// <returns>CPrice business object</returns>
        public CPrice SelectByPrimaryKey(CPriceKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_price_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idprice", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idprice));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CPrice businessObject = new CPrice();

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
                throw new Exception("CPrice::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CPrice</returns>
        public List<CPrice> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_price_SelectAll";
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
                throw new Exception("CPrice::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_price_SelectAll";
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
                throw new Exception("CPrice::SelectAll::Error occured.", ex);
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
        /// <returns>list of CPrice</returns>
        public List<CPrice> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_price_SelectByField";
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
                throw new Exception("CPrice::SelectByField::Error occured.", ex);
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
        public bool Delete(CPriceKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_price_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idprice", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idprice));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CPrice::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_price_DeleteByField";
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
                throw new Exception("CPrice::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CPrice businessObject, IDataReader dataReader)
        {


				businessObject.Idprice = dataReader.GetInt32(dataReader.GetOrdinal(CPrice.CPriceFields.Idprice.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice.CPriceFields.Cod_price.ToString())))
				{
					businessObject.Cod_price = dataReader.GetString(dataReader.GetOrdinal(CPrice.CPriceFields.Cod_price.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice.CPriceFields.Dispatch_person.ToString())))
				{
					businessObject.Dispatch_person = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CPrice.CPriceFields.Dispatch_person.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice.CPriceFields.Dispatch_mail.ToString())))
				{
					businessObject.Dispatch_mail = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CPrice.CPriceFields.Dispatch_mail.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice.CPriceFields.Dispatch_curier.ToString())))
				{
					businessObject.Dispatch_curier = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CPrice.CPriceFields.Dispatch_curier.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice.CPriceFields.Dispatch_transport.ToString())))
				{
					businessObject.Dispatch_transport = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CPrice.CPriceFields.Dispatch_transport.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice.CPriceFields.Dispatch_fax.ToString())))
				{
					businessObject.Dispatch_fax = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CPrice.CPriceFields.Dispatch_fax.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice.CPriceFields.Dispatch_otro.ToString())))
				{
					businessObject.Dispatch_otro = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CPrice.CPriceFields.Dispatch_otro.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPrice.CPriceFields.Request_reference.ToString())))
				{
					businessObject.Request_reference = dataReader.GetInt32(dataReader.GetOrdinal(CPrice.CPriceFields.Request_reference.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CPrice</returns>
        internal List<CPrice> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CPrice> list = new List<CPrice>();

            while (dataReader.Read())
            {
                CPrice businessObject = new CPrice();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
