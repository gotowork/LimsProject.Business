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
	/// Data access layer class for CRecep_sample
	/// </summary>
	partial class CRecep_sampleSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CRecep_sampleSql()
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
		public bool Insert(CRecep_sample businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_recep_sample_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters["p_idrecep_sample"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_cod_recep_sample", businessObject.Cod_recep_sample);
				sqlCommand.Parameters["p_cod_recep_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_date_reception", businessObject.Date_reception);
				sqlCommand.Parameters["p_date_reception"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_type_post", businessObject.Type_post);
				sqlCommand.Parameters["p_type_post"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_phone_client", businessObject.Phone_client);
				sqlCommand.Parameters["p_phone_client"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idcompany", businessObject.Idcompany);
				sqlCommand.Parameters["p_idcompany"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idcontact1", businessObject.Idcontact1);
				sqlCommand.Parameters["p_idcontact1"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idcontact2", businessObject.Idcontact2);
				sqlCommand.Parameters["p_idcontact2"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_cod_serie", businessObject.Cod_serie);
				sqlCommand.Parameters["p_cod_serie"].NpgsqlDbType = NpgsqlDbType.Varchar;
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
				sqlCommand.Parameters.AddWithValue("p_date_result", businessObject.Date_result);
				sqlCommand.Parameters["p_date_result"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_cod_type_sample", businessObject.Cod_type_sample);
				sqlCommand.Parameters["p_cod_type_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_total_amount", businessObject.Total_amount);
				sqlCommand.Parameters["p_total_amount"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_total_igv", businessObject.Total_igv);
				sqlCommand.Parameters["p_total_igv"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_total_amount_igv", businessObject.Total_amount_igv);
				sqlCommand.Parameters["p_total_amount_igv"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_amortization", businessObject.Amortization);
				sqlCommand.Parameters["p_amortization"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flag_isprice", businessObject.Flag_isprice);
				sqlCommand.Parameters["p_flag_isprice"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_discount", businessObject.Discount);
				sqlCommand.Parameters["p_discount"].NpgsqlDbType = NpgsqlDbType.Numeric;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idrecep_sample = Convert.ToInt64(sqlCommand.Parameters["p_idrecep_sample"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CRecep_sample::Insert::Error occured.", ex);
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
        public bool Update(CRecep_sample businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_cod_recep_sample", businessObject.Cod_recep_sample);
				sqlCommand.Parameters["p_cod_recep_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_date_reception", businessObject.Date_reception);
				sqlCommand.Parameters["p_date_reception"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_type_post", businessObject.Type_post);
				sqlCommand.Parameters["p_type_post"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_phone_client", businessObject.Phone_client);
				sqlCommand.Parameters["p_phone_client"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idcompany", businessObject.Idcompany);
				sqlCommand.Parameters["p_idcompany"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idcontact1", businessObject.Idcontact1);
				sqlCommand.Parameters["p_idcontact1"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idcontact2", businessObject.Idcontact2);
				sqlCommand.Parameters["p_idcontact2"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_cod_serie", businessObject.Cod_serie);
				sqlCommand.Parameters["p_cod_serie"].NpgsqlDbType = NpgsqlDbType.Varchar;
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
				sqlCommand.Parameters.AddWithValue("p_date_result", businessObject.Date_result);
				sqlCommand.Parameters["p_date_result"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_cod_type_sample", businessObject.Cod_type_sample);
				sqlCommand.Parameters["p_cod_type_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_total_amount", businessObject.Total_amount);
				sqlCommand.Parameters["p_total_amount"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_total_igv", businessObject.Total_igv);
				sqlCommand.Parameters["p_total_igv"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_total_amount_igv", businessObject.Total_amount_igv);
				sqlCommand.Parameters["p_total_amount_igv"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_amortization", businessObject.Amortization);
				sqlCommand.Parameters["p_amortization"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flag_isprice", businessObject.Flag_isprice);
				sqlCommand.Parameters["p_flag_isprice"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_discount", businessObject.Discount);
				sqlCommand.Parameters["p_discount"].NpgsqlDbType = NpgsqlDbType.Numeric;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CRecep_sample::Update::Error occured.", ex);
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
        /// <returns>CRecep_sample business object</returns>
        public CRecep_sample SelectByPrimaryKey(CRecep_sampleKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_SelectByPrimaryKey";
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
                    CRecep_sample businessObject = new CRecep_sample();

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
                throw new Exception("CRecep_sample::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CRecep_sample</returns>
        public List<CRecep_sample> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_SelectAll";
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
                throw new Exception("CRecep_sample::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_recep_sample_SelectAll";
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
                throw new Exception("CRecep_sample::SelectAll::Error occured.", ex);
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
        /// <returns>list of CRecep_sample</returns>
        public List<CRecep_sample> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_SelectByField";
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
                throw new Exception("CRecep_sample::SelectByField::Error occured.", ex);
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
        public bool Delete(CRecep_sampleKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_DeleteByPrimaryKey";
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
                throw new Exception("CRecep_sample::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_recep_sample_DeleteByField";
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
                throw new Exception("CRecep_sample::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CRecep_sample businessObject, IDataReader dataReader)
        {


				businessObject.Idrecep_sample = dataReader.GetInt64(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Idrecep_sample.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Cod_recep_sample.ToString())))
				{
					businessObject.Cod_recep_sample = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Cod_recep_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Date_reception.ToString())))
				{
					businessObject.Date_reception = dataReader.GetDateTime(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Date_reception.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Type_post.ToString())))
				{
					businessObject.Type_post = dataReader.GetChar(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Type_post.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Phone_client.ToString())))
				{
					businessObject.Phone_client = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Phone_client.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Idcompany.ToString())))
				{
					businessObject.Idcompany = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Idcompany.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Idcontact1.ToString())))
				{
					businessObject.Idcontact1 = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Idcontact1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Idcontact2.ToString())))
				{
					businessObject.Idcontact2 = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Idcontact2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Cod_serie.ToString())))
				{
					businessObject.Cod_serie = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Cod_serie.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Status.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Date_result.ToString())))
				{
					businessObject.Date_result = dataReader.GetDateTime(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Date_result.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Cod_type_sample.ToString())))
				{
					businessObject.Cod_type_sample = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Cod_type_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Total_amount.ToString())))
				{
					businessObject.Total_amount = dataReader.GetDecimal(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Total_amount.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Total_igv.ToString())))
				{
					businessObject.Total_igv = dataReader.GetDecimal(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Total_igv.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Total_amount_igv.ToString())))
				{
					businessObject.Total_amount_igv = dataReader.GetDecimal(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Total_amount_igv.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Amortization.ToString())))
				{
					businessObject.Amortization = dataReader.GetDecimal(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Amortization.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Flag_isprice.ToString())))
				{
					businessObject.Flag_isprice = dataReader.GetBoolean(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Flag_isprice.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Discount.ToString())))
				{
					businessObject.Discount = dataReader.GetDecimal(dataReader.GetOrdinal(CRecep_sample.CRecep_sampleFields.Discount.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CRecep_sample</returns>
        internal List<CRecep_sample> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CRecep_sample> list = new List<CRecep_sample>();

            while (dataReader.Read())
            {
                CRecep_sample businessObject = new CRecep_sample();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
