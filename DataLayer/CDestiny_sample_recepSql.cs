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
	/// Data access layer class for CDestiny_sample_recep
	/// </summary>
	partial class CDestiny_sample_recepSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CDestiny_sample_recepSql()
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
		public bool Insert(CDestiny_sample_recep businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_destiny_sample_recep_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_iddestiny_sample_recep", businessObject.Iddestiny_sample_recep);
				sqlCommand.Parameters["p_iddestiny_sample_recep"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_iddestiny_sample_recep"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_return_after_a_cs", businessObject.Return_after_a_cs);
				sqlCommand.Parameters["p_return_after_a_cs"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_return_after_a_re", businessObject.Return_after_a_re);
				sqlCommand.Parameters["p_return_after_a_re"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_return_after_t_cs", businessObject.Return_after_t_cs);
				sqlCommand.Parameters["p_return_after_t_cs"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_return_after_t_re", businessObject.Return_after_t_re);
				sqlCommand.Parameters["p_return_after_t_re"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_discard_after_t_cs", businessObject.Discard_after_t_cs);
				sqlCommand.Parameters["p_discard_after_t_cs"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_discard_after_t_re", businessObject.Discard_after_t_re);
				sqlCommand.Parameters["p_discard_after_t_re"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_charge_after_t_cs", businessObject.Charge_after_t_cs);
				sqlCommand.Parameters["p_charge_after_t_cs"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_charge_after_t_re", businessObject.Charge_after_t_re);
				sqlCommand.Parameters["p_charge_after_t_re"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_percent_discount", businessObject.Percent_discount);
				sqlCommand.Parameters["p_percent_discount"].NpgsqlDbType = NpgsqlDbType.Numeric;
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
                businessObject.Iddestiny_sample_recep = Convert.ToInt32(sqlCommand.Parameters["p_iddestiny_sample_recep"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CDestiny_sample_recep::Insert::Error occured.", ex);
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
        public bool Update(CDestiny_sample_recep businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_destiny_sample_recep_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_iddestiny_sample_recep", businessObject.Iddestiny_sample_recep);
				sqlCommand.Parameters["p_iddestiny_sample_recep"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_return_after_a_cs", businessObject.Return_after_a_cs);
				sqlCommand.Parameters["p_return_after_a_cs"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_return_after_a_re", businessObject.Return_after_a_re);
				sqlCommand.Parameters["p_return_after_a_re"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_return_after_t_cs", businessObject.Return_after_t_cs);
				sqlCommand.Parameters["p_return_after_t_cs"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_return_after_t_re", businessObject.Return_after_t_re);
				sqlCommand.Parameters["p_return_after_t_re"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_discard_after_t_cs", businessObject.Discard_after_t_cs);
				sqlCommand.Parameters["p_discard_after_t_cs"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_discard_after_t_re", businessObject.Discard_after_t_re);
				sqlCommand.Parameters["p_discard_after_t_re"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_charge_after_t_cs", businessObject.Charge_after_t_cs);
				sqlCommand.Parameters["p_charge_after_t_cs"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_charge_after_t_re", businessObject.Charge_after_t_re);
				sqlCommand.Parameters["p_charge_after_t_re"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_percent_discount", businessObject.Percent_discount);
				sqlCommand.Parameters["p_percent_discount"].NpgsqlDbType = NpgsqlDbType.Numeric;
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
                throw new Exception("CDestiny_sample_recep::Update::Error occured.", ex);
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
        /// <returns>CDestiny_sample_recep business object</returns>
        public CDestiny_sample_recep SelectByPrimaryKey(CDestiny_sample_recepKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_destiny_sample_recep_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_iddestiny_sample_recep", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Iddestiny_sample_recep));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CDestiny_sample_recep businessObject = new CDestiny_sample_recep();

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
                throw new Exception("CDestiny_sample_recep::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CDestiny_sample_recep</returns>
        public List<CDestiny_sample_recep> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_destiny_sample_recep_SelectAll";
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
                throw new Exception("CDestiny_sample_recep::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_destiny_sample_recep_SelectAll";
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
                throw new Exception("CDestiny_sample_recep::SelectAll::Error occured.", ex);
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
        /// <returns>list of CDestiny_sample_recep</returns>
        public List<CDestiny_sample_recep> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_destiny_sample_recep_SelectByField";
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
                throw new Exception("CDestiny_sample_recep::SelectByField::Error occured.", ex);
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
        public bool Delete(CDestiny_sample_recepKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_destiny_sample_recep_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_iddestiny_sample_recep", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Iddestiny_sample_recep));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CDestiny_sample_recep::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_destiny_sample_recep_DeleteByField";
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
                throw new Exception("CDestiny_sample_recep::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CDestiny_sample_recep businessObject, IDataReader dataReader)
        {


				businessObject.Iddestiny_sample_recep = dataReader.GetInt32(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Iddestiny_sample_recep.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Idrecep_sample.ToString())))
				{
					businessObject.Idrecep_sample = dataReader.GetInt64(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Idrecep_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Return_after_a_cs.ToString())))
				{
					businessObject.Return_after_a_cs = dataReader.GetBoolean(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Return_after_a_cs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Return_after_a_re.ToString())))
				{
					businessObject.Return_after_a_re = dataReader.GetBoolean(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Return_after_a_re.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Return_after_t_cs.ToString())))
				{
					businessObject.Return_after_t_cs = dataReader.GetBoolean(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Return_after_t_cs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Return_after_t_re.ToString())))
				{
					businessObject.Return_after_t_re = dataReader.GetBoolean(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Return_after_t_re.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Discard_after_t_cs.ToString())))
				{
					businessObject.Discard_after_t_cs = dataReader.GetBoolean(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Discard_after_t_cs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Discard_after_t_re.ToString())))
				{
					businessObject.Discard_after_t_re = dataReader.GetBoolean(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Discard_after_t_re.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Charge_after_t_cs.ToString())))
				{
					businessObject.Charge_after_t_cs = dataReader.GetBoolean(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Charge_after_t_cs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Charge_after_t_re.ToString())))
				{
					businessObject.Charge_after_t_re = dataReader.GetBoolean(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Charge_after_t_re.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Percent_discount.ToString())))
				{
					businessObject.Percent_discount = dataReader.GetDecimal(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Percent_discount.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CDestiny_sample_recep.CDestiny_sample_recepFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CDestiny_sample_recep</returns>
        internal List<CDestiny_sample_recep> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CDestiny_sample_recep> list = new List<CDestiny_sample_recep>();

            while (dataReader.Read())
            {
                CDestiny_sample_recep businessObject = new CDestiny_sample_recep();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
