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
	/// Data access layer class for CTemplate_method_gr
	/// </summary>
	partial class CTemplate_method_grSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CTemplate_method_grSql()
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
		public bool Insert(CTemplate_method_gr businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_template_method_gr_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_weight", businessObject.Weight);
				sqlCommand.Parameters["p_weight"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_weight_incertitude", businessObject.Weight_incertitude);
				sqlCommand.Parameters["p_weight_incertitude"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reading_min", businessObject.Reading_min);
				sqlCommand.Parameters["p_reading_min"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reading_max", businessObject.Reading_max);
				sqlCommand.Parameters["p_reading_max"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reason_rep", businessObject.Reason_rep);
				sqlCommand.Parameters["p_reason_rep"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_error_allowed", businessObject.Error_allowed);
				sqlCommand.Parameters["p_error_allowed"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_symbol", businessObject.Symbol);
				sqlCommand.Parameters["p_symbol"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_law_limit_bottom", businessObject.Law_limit_bottom);
				sqlCommand.Parameters["p_law_limit_bottom"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_law_limit_top", businessObject.Law_limit_top);
				sqlCommand.Parameters["p_law_limit_top"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_num_decimal", businessObject.Num_decimal);
				sqlCommand.Parameters["p_num_decimal"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_flag_mr", businessObject.Flag_mr);
				sqlCommand.Parameters["p_flag_mr"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_idmr_detail", businessObject.Idmr_detail);
				sqlCommand.Parameters["p_idmr_detail"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_mr_incertitude", businessObject.Mr_incertitude);
				sqlCommand.Parameters["p_mr_incertitude"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_blk_max", businessObject.Blk_max);
				sqlCommand.Parameters["p_blk_max"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reproducibility", businessObject.Reproducibility);
				sqlCommand.Parameters["p_reproducibility"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flagsamfortify", businessObject.Flagsamfortify);
				sqlCommand.Parameters["p_flagsamfortify"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_samfortisol", businessObject.Samfortisol);
				sqlCommand.Parameters["p_samfortisol"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_samfortialiquot", businessObject.Samfortialiquot);
				sqlCommand.Parameters["p_samfortialiquot"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_samfortireproducibility", businessObject.Samfortireproducibility);
				sqlCommand.Parameters["p_samfortireproducibility"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flagblkfortify", businessObject.Flagblkfortify);
				sqlCommand.Parameters["p_flagblkfortify"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_blkfortisol", businessObject.Blkfortisol);
				sqlCommand.Parameters["p_blkfortisol"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_blkfortialiquot", businessObject.Blkfortialiquot);
				sqlCommand.Parameters["p_blkfortialiquot"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_blkfortireproducibility", businessObject.Blkfortireproducibility);
				sqlCommand.Parameters["p_blkfortireproducibility"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_date_allowed_error", businessObject.Date_allowed_error);
				sqlCommand.Parameters["p_date_allowed_error"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_idunit_result", businessObject.Idunit_result);
				sqlCommand.Parameters["p_idunit_result"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_num_samples", businessObject.Num_samples);
				sqlCommand.Parameters["p_num_samples"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_num_days", businessObject.Num_days);
				sqlCommand.Parameters["p_num_days"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_limit_samples", businessObject.Limit_samples);
				sqlCommand.Parameters["p_limit_samples"].NpgsqlDbType = NpgsqlDbType.Smallint;
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
				throw new Exception("CTemplate_method_gr::Insert::Error occured.", ex);
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
        public bool Update(CTemplate_method_gr businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_gr_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_weight", businessObject.Weight);
				sqlCommand.Parameters["p_weight"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_weight_incertitude", businessObject.Weight_incertitude);
				sqlCommand.Parameters["p_weight_incertitude"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reading_min", businessObject.Reading_min);
				sqlCommand.Parameters["p_reading_min"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reading_max", businessObject.Reading_max);
				sqlCommand.Parameters["p_reading_max"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reason_rep", businessObject.Reason_rep);
				sqlCommand.Parameters["p_reason_rep"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_error_allowed", businessObject.Error_allowed);
				sqlCommand.Parameters["p_error_allowed"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_symbol", businessObject.Symbol);
				sqlCommand.Parameters["p_symbol"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_law_limit_bottom", businessObject.Law_limit_bottom);
				sqlCommand.Parameters["p_law_limit_bottom"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_law_limit_top", businessObject.Law_limit_top);
				sqlCommand.Parameters["p_law_limit_top"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_num_decimal", businessObject.Num_decimal);
				sqlCommand.Parameters["p_num_decimal"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_flag_mr", businessObject.Flag_mr);
				sqlCommand.Parameters["p_flag_mr"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_idmr_detail", businessObject.Idmr_detail);
				sqlCommand.Parameters["p_idmr_detail"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_mr_incertitude", businessObject.Mr_incertitude);
				sqlCommand.Parameters["p_mr_incertitude"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_blk_max", businessObject.Blk_max);
				sqlCommand.Parameters["p_blk_max"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reproducibility", businessObject.Reproducibility);
				sqlCommand.Parameters["p_reproducibility"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flagsamfortify", businessObject.Flagsamfortify);
				sqlCommand.Parameters["p_flagsamfortify"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_samfortisol", businessObject.Samfortisol);
				sqlCommand.Parameters["p_samfortisol"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_samfortialiquot", businessObject.Samfortialiquot);
				sqlCommand.Parameters["p_samfortialiquot"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_samfortireproducibility", businessObject.Samfortireproducibility);
				sqlCommand.Parameters["p_samfortireproducibility"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flagblkfortify", businessObject.Flagblkfortify);
				sqlCommand.Parameters["p_flagblkfortify"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_blkfortisol", businessObject.Blkfortisol);
				sqlCommand.Parameters["p_blkfortisol"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_blkfortialiquot", businessObject.Blkfortialiquot);
				sqlCommand.Parameters["p_blkfortialiquot"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_blkfortireproducibility", businessObject.Blkfortireproducibility);
				sqlCommand.Parameters["p_blkfortireproducibility"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_date_allowed_error", businessObject.Date_allowed_error);
				sqlCommand.Parameters["p_date_allowed_error"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_idunit_result", businessObject.Idunit_result);
				sqlCommand.Parameters["p_idunit_result"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_num_samples", businessObject.Num_samples);
				sqlCommand.Parameters["p_num_samples"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_num_days", businessObject.Num_days);
				sqlCommand.Parameters["p_num_days"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_limit_samples", businessObject.Limit_samples);
				sqlCommand.Parameters["p_limit_samples"].NpgsqlDbType = NpgsqlDbType.Smallint;
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
                throw new Exception("CTemplate_method_gr::Update::Error occured.", ex);
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
        /// <returns>CTemplate_method_gr business object</returns>
        public CTemplate_method_gr SelectByPrimaryKey(CTemplate_method_grKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_gr_SelectByPrimaryKey";
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
                    CTemplate_method_gr businessObject = new CTemplate_method_gr();

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
                throw new Exception("CTemplate_method_gr::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CTemplate_method_gr</returns>
        public List<CTemplate_method_gr> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_gr_SelectAll";
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
                throw new Exception("CTemplate_method_gr::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_template_method_gr_SelectAll";
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
                throw new Exception("CTemplate_method_gr::SelectAll::Error occured.", ex);
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
        /// <returns>list of CTemplate_method_gr</returns>
        public List<CTemplate_method_gr> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_gr_SelectByField";
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
                throw new Exception("CTemplate_method_gr::SelectByField::Error occured.", ex);
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
        public bool Delete(CTemplate_method_grKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_gr_DeleteByPrimaryKey";
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
                throw new Exception("CTemplate_method_gr::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_template_method_gr_DeleteByField";
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
                throw new Exception("CTemplate_method_gr::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CTemplate_method_gr businessObject, IDataReader dataReader)
        {


				businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Idtemplate_method.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Weight.ToString())))
				{
					businessObject.Weight = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Weight.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Weight_incertitude.ToString())))
				{
					businessObject.Weight_incertitude = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Weight_incertitude.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Reading_min.ToString())))
				{
					businessObject.Reading_min = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Reading_min.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Reading_max.ToString())))
				{
					businessObject.Reading_max = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Reading_max.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Reason_rep.ToString())))
				{
					businessObject.Reason_rep = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Reason_rep.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Error_allowed.ToString())))
				{
					businessObject.Error_allowed = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Error_allowed.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Symbol.ToString())))
				{
					businessObject.Symbol = dataReader.GetString(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Symbol.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Law_limit_bottom.ToString())))
				{
					businessObject.Law_limit_bottom = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Law_limit_bottom.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Law_limit_top.ToString())))
				{
					businessObject.Law_limit_top = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Law_limit_top.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Num_decimal.ToString())))
				{
					businessObject.Num_decimal = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Num_decimal.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Flag_mr.ToString())))
				{
					businessObject.Flag_mr = dataReader.GetBoolean(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Flag_mr.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Idmr_detail.ToString())))
				{
					businessObject.Idmr_detail = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Idmr_detail.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Mr_incertitude.ToString())))
				{
					businessObject.Mr_incertitude = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Mr_incertitude.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Blk_max.ToString())))
				{
					businessObject.Blk_max = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Blk_max.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Reproducibility.ToString())))
				{
					businessObject.Reproducibility = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Reproducibility.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Flagsamfortify.ToString())))
				{
					businessObject.Flagsamfortify = dataReader.GetBoolean(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Flagsamfortify.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Samfortisol.ToString())))
				{
					businessObject.Samfortisol = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Samfortisol.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Samfortialiquot.ToString())))
				{
					businessObject.Samfortialiquot = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Samfortialiquot.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Samfortireproducibility.ToString())))
				{
					businessObject.Samfortireproducibility = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Samfortireproducibility.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Flagblkfortify.ToString())))
				{
					businessObject.Flagblkfortify = dataReader.GetBoolean(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Flagblkfortify.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Blkfortisol.ToString())))
				{
					businessObject.Blkfortisol = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Blkfortisol.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Blkfortialiquot.ToString())))
				{
					businessObject.Blkfortialiquot = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Blkfortialiquot.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Blkfortireproducibility.ToString())))
				{
					businessObject.Blkfortireproducibility = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Blkfortireproducibility.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Date_allowed_error.ToString())))
				{
					businessObject.Date_allowed_error = dataReader.GetDateTime(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Date_allowed_error.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Idunit_result.ToString())))
				{
					businessObject.Idunit_result = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Idunit_result.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Num_samples.ToString())))
				{
					businessObject.Num_samples = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Num_samples.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Num_days.ToString())))
				{
					businessObject.Num_days = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Num_days.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Limit_samples.ToString())))
				{
					businessObject.Limit_samples = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Limit_samples.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CTemplate_method_gr.CTemplate_method_grFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CTemplate_method_gr</returns>
        internal List<CTemplate_method_gr> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CTemplate_method_gr> list = new List<CTemplate_method_gr>();

            while (dataReader.Read())
            {
                CTemplate_method_gr businessObject = new CTemplate_method_gr();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
