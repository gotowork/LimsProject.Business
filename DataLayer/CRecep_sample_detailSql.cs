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
	/// Data access layer class for CRecep_sample_detail
	/// </summary>
	partial class CRecep_sample_detailSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CRecep_sample_detailSql()
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
		public bool Insert(CRecep_sample_detail businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_recep_sample_detail_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail", businessObject.Idrecep_sample_detail);
				sqlCommand.Parameters["p_idrecep_sample_detail"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters["p_idrecep_sample_detail"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_order_sample", businessObject.Order_sample);
				sqlCommand.Parameters["p_order_sample"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_cod_sample", businessObject.Cod_sample);
				sqlCommand.Parameters["p_cod_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_procedence", businessObject.Procedence);
				sqlCommand.Parameters["p_procedence"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_name_sample", businessObject.Name_sample);
				sqlCommand.Parameters["p_name_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_amount_weight", businessObject.Amount_weight);
				sqlCommand.Parameters["p_amount_weight"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_cod_interno", businessObject.Cod_interno);
				sqlCommand.Parameters["p_cod_interno"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_flag_reject", businessObject.Flag_reject);
				sqlCommand.Parameters["p_flag_reject"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_cost_sample", businessObject.Cost_sample);
				sqlCommand.Parameters["p_cost_sample"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_analisys_time", businessObject.Analisys_time);
				sqlCommand.Parameters["p_analisys_time"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flag_control_sample", businessObject.Flag_control_sample);
				sqlCommand.Parameters["p_flag_control_sample"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_cod_type_sample", businessObject.Cod_type_sample);
				sqlCommand.Parameters["p_cod_type_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_cod_des_sample", businessObject.Cod_des_sample);
				sqlCommand.Parameters["p_cod_des_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_flag_counter_sample", businessObject.Flag_counter_sample);
				sqlCommand.Parameters["p_flag_counter_sample"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_flag_envelope_sealed", businessObject.Flag_envelope_sealed);
				sqlCommand.Parameters["p_flag_envelope_sealed"].NpgsqlDbType = NpgsqlDbType.Boolean;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idrecep_sample_detail = Convert.ToInt64(sqlCommand.Parameters["p_idrecep_sample_detail"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CRecep_sample_detail::Insert::Error occured.", ex);
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
        public bool Update(CRecep_sample_detail businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_detail_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail", businessObject.Idrecep_sample_detail);
				sqlCommand.Parameters["p_idrecep_sample_detail"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_order_sample", businessObject.Order_sample);
				sqlCommand.Parameters["p_order_sample"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_cod_sample", businessObject.Cod_sample);
				sqlCommand.Parameters["p_cod_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_procedence", businessObject.Procedence);
				sqlCommand.Parameters["p_procedence"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_name_sample", businessObject.Name_sample);
				sqlCommand.Parameters["p_name_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_amount_weight", businessObject.Amount_weight);
				sqlCommand.Parameters["p_amount_weight"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_cod_interno", businessObject.Cod_interno);
				sqlCommand.Parameters["p_cod_interno"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_flag_reject", businessObject.Flag_reject);
				sqlCommand.Parameters["p_flag_reject"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_cost_sample", businessObject.Cost_sample);
				sqlCommand.Parameters["p_cost_sample"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_analisys_time", businessObject.Analisys_time);
				sqlCommand.Parameters["p_analisys_time"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flag_control_sample", businessObject.Flag_control_sample);
				sqlCommand.Parameters["p_flag_control_sample"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_cod_type_sample", businessObject.Cod_type_sample);
				sqlCommand.Parameters["p_cod_type_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_cod_des_sample", businessObject.Cod_des_sample);
				sqlCommand.Parameters["p_cod_des_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_flag_counter_sample", businessObject.Flag_counter_sample);
				sqlCommand.Parameters["p_flag_counter_sample"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_flag_envelope_sealed", businessObject.Flag_envelope_sealed);
				sqlCommand.Parameters["p_flag_envelope_sealed"].NpgsqlDbType = NpgsqlDbType.Boolean;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CRecep_sample_detail::Update::Error occured.", ex);
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
        /// <returns>CRecep_sample_detail business object</returns>
        public CRecep_sample_detail SelectByPrimaryKey(CRecep_sample_detailKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_detail_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idrecep_sample_detail", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idrecep_sample_detail));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CRecep_sample_detail businessObject = new CRecep_sample_detail();

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
                throw new Exception("CRecep_sample_detail::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CRecep_sample_detail</returns>
        public List<CRecep_sample_detail> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_detail_SelectAll";
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
                throw new Exception("CRecep_sample_detail::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_recep_sample_detail_SelectAll";
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
                throw new Exception("CRecep_sample_detail::SelectAll::Error occured.", ex);
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
        /// <returns>list of CRecep_sample_detail</returns>
        public List<CRecep_sample_detail> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_detail_SelectByField";
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
                throw new Exception("CRecep_sample_detail::SelectByField::Error occured.", ex);
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
        public bool Delete(CRecep_sample_detailKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_detail_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idrecep_sample_detail", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idrecep_sample_detail));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CRecep_sample_detail::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_recep_sample_detail_DeleteByField";
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
                throw new Exception("CRecep_sample_detail::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CRecep_sample_detail businessObject, IDataReader dataReader)
        {


				businessObject.Idrecep_sample_detail = dataReader.GetInt64(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Idrecep_sample_detail.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Order_sample.ToString())))
				{
					businessObject.Order_sample = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Order_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Cod_sample.ToString())))
				{
					businessObject.Cod_sample = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Cod_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Procedence.ToString())))
				{
					businessObject.Procedence = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Procedence.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Name_sample.ToString())))
				{
					businessObject.Name_sample = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Name_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Amount_weight.ToString())))
				{
					businessObject.Amount_weight = dataReader.GetDecimal(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Amount_weight.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Cod_interno.ToString())))
				{
					businessObject.Cod_interno = dataReader.GetInt64(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Cod_interno.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Flag_reject.ToString())))
				{
					businessObject.Flag_reject = dataReader.GetBoolean(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Flag_reject.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Cost_sample.ToString())))
				{
					businessObject.Cost_sample = dataReader.GetDecimal(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Cost_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Analisys_time.ToString())))
				{
					businessObject.Analisys_time = dataReader.GetDecimal(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Analisys_time.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Flag_control_sample.ToString())))
				{
					businessObject.Flag_control_sample = dataReader.GetBoolean(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Flag_control_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Cod_type_sample.ToString())))
				{
					businessObject.Cod_type_sample = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Cod_type_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Cod_des_sample.ToString())))
				{
					businessObject.Cod_des_sample = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Cod_des_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Idrecep_sample.ToString())))
				{
					businessObject.Idrecep_sample = dataReader.GetInt64(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Idrecep_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Flag_counter_sample.ToString())))
				{
					businessObject.Flag_counter_sample = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Flag_counter_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Flag_envelope_sealed.ToString())))
				{
					businessObject.Flag_envelope_sealed = dataReader.GetBoolean(dataReader.GetOrdinal(CRecep_sample_detail.CRecep_sample_detailFields.Flag_envelope_sealed.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CRecep_sample_detail</returns>
        internal List<CRecep_sample_detail> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CRecep_sample_detail> list = new List<CRecep_sample_detail>();

            while (dataReader.Read())
            {
                CRecep_sample_detail businessObject = new CRecep_sample_detail();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
