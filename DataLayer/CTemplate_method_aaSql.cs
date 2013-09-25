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
	/// Data access layer class for CTemplate_method_aa
	/// </summary>
	partial class CTemplate_method_aaSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CTemplate_method_aaSql()
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
		public bool Insert(CTemplate_method_aa businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_template_method_aa_Insert";
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
				sqlCommand.Parameters.AddWithValue("p_volumen", businessObject.Volumen);
				sqlCommand.Parameters["p_volumen"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reading_min", businessObject.Reading_min);
				sqlCommand.Parameters["p_reading_min"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reading_max", businessObject.Reading_max);
				sqlCommand.Parameters["p_reading_max"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_dilution2", businessObject.Dilution2);
				sqlCommand.Parameters["p_dilution2"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_dilution3", businessObject.Dilution3);
				sqlCommand.Parameters["p_dilution3"].NpgsqlDbType = NpgsqlDbType.Numeric;
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
				sqlCommand.Parameters.AddWithValue("p_idunit_calib", businessObject.Idunit_calib);
				sqlCommand.Parameters["p_idunit_calib"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_absorvance", businessObject.Absorvance);
				sqlCommand.Parameters["p_absorvance"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_abs_incertitude", businessObject.Abs_incertitude);
				sqlCommand.Parameters["p_abs_incertitude"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_verif", businessObject.Std_verif);
				sqlCommand.Parameters["p_std_verif"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_verif_incertitude", businessObject.Std_verif_incertitude);
				sqlCommand.Parameters["p_std_verif_incertitude"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_wave_long", businessObject.Wave_long);
				sqlCommand.Parameters["p_wave_long"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_num_decimal", businessObject.Num_decimal);
				sqlCommand.Parameters["p_num_decimal"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idmr_detail", businessObject.Idmr_detail);
				sqlCommand.Parameters["p_idmr_detail"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_mr_incertitude", businessObject.Mr_incertitude);
				sqlCommand.Parameters["p_mr_incertitude"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_blk_max", businessObject.Blk_max);
				sqlCommand.Parameters["p_blk_max"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reproducibility", businessObject.Reproducibility);
				sqlCommand.Parameters["p_reproducibility"].NpgsqlDbType = NpgsqlDbType.Numeric;
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
				sqlCommand.Parameters.AddWithValue("p_date_allowed_error", businessObject.Date_allowed_error);
				sqlCommand.Parameters["p_date_allowed_error"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_mrorpattern", businessObject.Mrorpattern);
				sqlCommand.Parameters["p_mrorpattern"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_rexp2", businessObject.Rexp2);
				sqlCommand.Parameters["p_rexp2"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_medium", businessObject.Medium);
				sqlCommand.Parameters["p_medium"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_medium_conc", businessObject.Medium_conc);
				sqlCommand.Parameters["p_medium_conc"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_modif", businessObject.Modif);
				sqlCommand.Parameters["p_modif"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_modif_conc", businessObject.Modif_conc);
				sqlCommand.Parameters["p_modif_conc"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_validity_calib", businessObject.Validity_calib);
				sqlCommand.Parameters["p_validity_calib"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_type_pattern", businessObject.Type_pattern);
				sqlCommand.Parameters["p_type_pattern"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_flag_sol_intermedia", businessObject.Flag_sol_intermedia);
				sqlCommand.Parameters["p_flag_sol_intermedia"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_sol_concentration", businessObject.Sol_concentration);
				sqlCommand.Parameters["p_sol_concentration"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_sol_status", businessObject.Sol_status);
				sqlCommand.Parameters["p_sol_status"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_sol_date_preparation", businessObject.Sol_date_preparation);
				sqlCommand.Parameters["p_sol_date_preparation"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_sol_date_expiration", businessObject.Sol_date_expiration);
				sqlCommand.Parameters["p_sol_date_expiration"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_std_mrorpattern", businessObject.Std_mrorpattern);
				sqlCommand.Parameters["p_std_mrorpattern"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_std_type_pattern", businessObject.Std_type_pattern);
				sqlCommand.Parameters["p_std_type_pattern"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_std_flag_sol_intermedia1", businessObject.Std_flag_sol_intermedia1);
				sqlCommand.Parameters["p_std_flag_sol_intermedia1"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_std_flag_sol_intermedia2", businessObject.Std_flag_sol_intermedia2);
				sqlCommand.Parameters["p_std_flag_sol_intermedia2"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_std_concentration", businessObject.Std_concentration);
				sqlCommand.Parameters["p_std_concentration"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_concentration_sol1", businessObject.Std_concentration_sol1);
				sqlCommand.Parameters["p_std_concentration_sol1"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_concentration_sol2", businessObject.Std_concentration_sol2);
				sqlCommand.Parameters["p_std_concentration_sol2"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_status", businessObject.Std_status);
				sqlCommand.Parameters["p_std_status"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_std_sol1_medium", businessObject.Std_sol1_medium);
				sqlCommand.Parameters["p_std_sol1_medium"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_sol2_medium", businessObject.Std_sol2_medium);
				sqlCommand.Parameters["p_std_sol2_medium"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_stdverif_medium", businessObject.Std_stdverif_medium);
				sqlCommand.Parameters["p_std_stdverif_medium"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idunit_result", businessObject.Idunit_result);
				sqlCommand.Parameters["p_idunit_result"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_num_samples", businessObject.Num_samples);
				sqlCommand.Parameters["p_num_samples"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_num_days", businessObject.Num_days);
				sqlCommand.Parameters["p_num_days"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_limit_samples", businessObject.Limit_samples);
				sqlCommand.Parameters["p_limit_samples"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_std_validity_sol1", businessObject.Std_validity_sol1);
				sqlCommand.Parameters["p_std_validity_sol1"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_std_validity_sol2", businessObject.Std_validity_sol2);
				sqlCommand.Parameters["p_std_validity_sol2"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_std_validity_sv", businessObject.Std_validity_sv);
				sqlCommand.Parameters["p_std_validity_sv"].NpgsqlDbType = NpgsqlDbType.Smallint;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                
				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CTemplate_method_aa::Insert::Error occured.", ex);
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
        public bool Update(CTemplate_method_aa businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_aa_Update";
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
				sqlCommand.Parameters.AddWithValue("p_volumen", businessObject.Volumen);
				sqlCommand.Parameters["p_volumen"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reading_min", businessObject.Reading_min);
				sqlCommand.Parameters["p_reading_min"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reading_max", businessObject.Reading_max);
				sqlCommand.Parameters["p_reading_max"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_dilution2", businessObject.Dilution2);
				sqlCommand.Parameters["p_dilution2"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_dilution3", businessObject.Dilution3);
				sqlCommand.Parameters["p_dilution3"].NpgsqlDbType = NpgsqlDbType.Numeric;
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
				sqlCommand.Parameters.AddWithValue("p_idunit_calib", businessObject.Idunit_calib);
				sqlCommand.Parameters["p_idunit_calib"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_absorvance", businessObject.Absorvance);
				sqlCommand.Parameters["p_absorvance"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_abs_incertitude", businessObject.Abs_incertitude);
				sqlCommand.Parameters["p_abs_incertitude"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_verif", businessObject.Std_verif);
				sqlCommand.Parameters["p_std_verif"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_verif_incertitude", businessObject.Std_verif_incertitude);
				sqlCommand.Parameters["p_std_verif_incertitude"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_wave_long", businessObject.Wave_long);
				sqlCommand.Parameters["p_wave_long"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_num_decimal", businessObject.Num_decimal);
				sqlCommand.Parameters["p_num_decimal"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idmr_detail", businessObject.Idmr_detail);
				sqlCommand.Parameters["p_idmr_detail"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_mr_incertitude", businessObject.Mr_incertitude);
				sqlCommand.Parameters["p_mr_incertitude"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_blk_max", businessObject.Blk_max);
				sqlCommand.Parameters["p_blk_max"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reproducibility", businessObject.Reproducibility);
				sqlCommand.Parameters["p_reproducibility"].NpgsqlDbType = NpgsqlDbType.Numeric;
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
				sqlCommand.Parameters.AddWithValue("p_date_allowed_error", businessObject.Date_allowed_error);
				sqlCommand.Parameters["p_date_allowed_error"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_mrorpattern", businessObject.Mrorpattern);
				sqlCommand.Parameters["p_mrorpattern"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_rexp2", businessObject.Rexp2);
				sqlCommand.Parameters["p_rexp2"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_medium", businessObject.Medium);
				sqlCommand.Parameters["p_medium"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_medium_conc", businessObject.Medium_conc);
				sqlCommand.Parameters["p_medium_conc"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_modif", businessObject.Modif);
				sqlCommand.Parameters["p_modif"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_modif_conc", businessObject.Modif_conc);
				sqlCommand.Parameters["p_modif_conc"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_validity_calib", businessObject.Validity_calib);
				sqlCommand.Parameters["p_validity_calib"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_type_pattern", businessObject.Type_pattern);
				sqlCommand.Parameters["p_type_pattern"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_flag_sol_intermedia", businessObject.Flag_sol_intermedia);
				sqlCommand.Parameters["p_flag_sol_intermedia"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_sol_concentration", businessObject.Sol_concentration);
				sqlCommand.Parameters["p_sol_concentration"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_sol_status", businessObject.Sol_status);
				sqlCommand.Parameters["p_sol_status"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_sol_date_preparation", businessObject.Sol_date_preparation);
				sqlCommand.Parameters["p_sol_date_preparation"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_sol_date_expiration", businessObject.Sol_date_expiration);
				sqlCommand.Parameters["p_sol_date_expiration"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_std_mrorpattern", businessObject.Std_mrorpattern);
				sqlCommand.Parameters["p_std_mrorpattern"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_std_type_pattern", businessObject.Std_type_pattern);
				sqlCommand.Parameters["p_std_type_pattern"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_std_flag_sol_intermedia1", businessObject.Std_flag_sol_intermedia1);
				sqlCommand.Parameters["p_std_flag_sol_intermedia1"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_std_flag_sol_intermedia2", businessObject.Std_flag_sol_intermedia2);
				sqlCommand.Parameters["p_std_flag_sol_intermedia2"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_std_concentration", businessObject.Std_concentration);
				sqlCommand.Parameters["p_std_concentration"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_concentration_sol1", businessObject.Std_concentration_sol1);
				sqlCommand.Parameters["p_std_concentration_sol1"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_concentration_sol2", businessObject.Std_concentration_sol2);
				sqlCommand.Parameters["p_std_concentration_sol2"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_status", businessObject.Std_status);
				sqlCommand.Parameters["p_std_status"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_std_sol1_medium", businessObject.Std_sol1_medium);
				sqlCommand.Parameters["p_std_sol1_medium"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_sol2_medium", businessObject.Std_sol2_medium);
				sqlCommand.Parameters["p_std_sol2_medium"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std_stdverif_medium", businessObject.Std_stdverif_medium);
				sqlCommand.Parameters["p_std_stdverif_medium"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idunit_result", businessObject.Idunit_result);
				sqlCommand.Parameters["p_idunit_result"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_num_samples", businessObject.Num_samples);
				sqlCommand.Parameters["p_num_samples"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_num_days", businessObject.Num_days);
				sqlCommand.Parameters["p_num_days"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_limit_samples", businessObject.Limit_samples);
				sqlCommand.Parameters["p_limit_samples"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_std_validity_sol1", businessObject.Std_validity_sol1);
				sqlCommand.Parameters["p_std_validity_sol1"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_std_validity_sol2", businessObject.Std_validity_sol2);
				sqlCommand.Parameters["p_std_validity_sol2"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_std_validity_sv", businessObject.Std_validity_sv);
				sqlCommand.Parameters["p_std_validity_sv"].NpgsqlDbType = NpgsqlDbType.Smallint;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CTemplate_method_aa::Update::Error occured.", ex);
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
        /// <returns>CTemplate_method_aa business object</returns>
        public CTemplate_method_aa SelectByPrimaryKey(CTemplate_method_aaKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_aa_SelectByPrimaryKey";
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
                    CTemplate_method_aa businessObject = new CTemplate_method_aa();

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
                throw new Exception("CTemplate_method_aa::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CTemplate_method_aa</returns>
        public List<CTemplate_method_aa> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_aa_SelectAll";
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
                throw new Exception("CTemplate_method_aa::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_template_method_aa_SelectAll";
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
                throw new Exception("CTemplate_method_aa::SelectAll::Error occured.", ex);
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
        /// <returns>list of CTemplate_method_aa</returns>
        public List<CTemplate_method_aa> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_aa_SelectByField";
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
                throw new Exception("CTemplate_method_aa::SelectByField::Error occured.", ex);
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
        public bool Delete(CTemplate_method_aaKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_aa_DeleteByPrimaryKey";
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
                throw new Exception("CTemplate_method_aa::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_template_method_aa_DeleteByField";
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
                throw new Exception("CTemplate_method_aa::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CTemplate_method_aa businessObject, IDataReader dataReader)
        {


				businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Idtemplate_method.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Weight.ToString())))
				{
					businessObject.Weight = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Weight.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Weight_incertitude.ToString())))
				{
					businessObject.Weight_incertitude = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Weight_incertitude.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Volumen.ToString())))
				{
					businessObject.Volumen = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Volumen.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Reading_min.ToString())))
				{
					businessObject.Reading_min = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Reading_min.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Reading_max.ToString())))
				{
					businessObject.Reading_max = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Reading_max.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Dilution2.ToString())))
				{
					businessObject.Dilution2 = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Dilution2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Dilution3.ToString())))
				{
					businessObject.Dilution3 = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Dilution3.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Reason_rep.ToString())))
				{
					businessObject.Reason_rep = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Reason_rep.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Error_allowed.ToString())))
				{
					businessObject.Error_allowed = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Error_allowed.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Symbol.ToString())))
				{
					businessObject.Symbol = dataReader.GetString(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Symbol.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Law_limit_bottom.ToString())))
				{
					businessObject.Law_limit_bottom = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Law_limit_bottom.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Law_limit_top.ToString())))
				{
					businessObject.Law_limit_top = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Law_limit_top.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Idunit_calib.ToString())))
				{
					businessObject.Idunit_calib = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Idunit_calib.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Absorvance.ToString())))
				{
					businessObject.Absorvance = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Absorvance.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Abs_incertitude.ToString())))
				{
					businessObject.Abs_incertitude = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Abs_incertitude.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_verif.ToString())))
				{
					businessObject.Std_verif = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_verif.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_verif_incertitude.ToString())))
				{
					businessObject.Std_verif_incertitude = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_verif_incertitude.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Wave_long.ToString())))
				{
					businessObject.Wave_long = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Wave_long.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Num_decimal.ToString())))
				{
					businessObject.Num_decimal = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Num_decimal.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Idmr_detail.ToString())))
				{
					businessObject.Idmr_detail = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Idmr_detail.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Mr_incertitude.ToString())))
				{
					businessObject.Mr_incertitude = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Mr_incertitude.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Blk_max.ToString())))
				{
					businessObject.Blk_max = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Blk_max.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Reproducibility.ToString())))
				{
					businessObject.Reproducibility = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Reproducibility.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Status.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Date_allowed_error.ToString())))
				{
					businessObject.Date_allowed_error = dataReader.GetDateTime(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Date_allowed_error.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Mrorpattern.ToString())))
				{
					businessObject.Mrorpattern = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Mrorpattern.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Rexp2.ToString())))
				{
					businessObject.Rexp2 = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Rexp2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Medium.ToString())))
				{
					businessObject.Medium = dataReader.GetInt32(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Medium.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Medium_conc.ToString())))
				{
					businessObject.Medium_conc = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Medium_conc.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Modif.ToString())))
				{
					businessObject.Modif = dataReader.GetInt32(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Modif.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Modif_conc.ToString())))
				{
					businessObject.Modif_conc = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Modif_conc.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Validity_calib.ToString())))
				{
					businessObject.Validity_calib = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Validity_calib.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Type_pattern.ToString())))
				{
					businessObject.Type_pattern = dataReader.GetInt32(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Type_pattern.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Flag_sol_intermedia.ToString())))
				{
					businessObject.Flag_sol_intermedia = dataReader.GetBoolean(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Flag_sol_intermedia.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Sol_concentration.ToString())))
				{
					businessObject.Sol_concentration = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Sol_concentration.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Sol_status.ToString())))
				{
					businessObject.Sol_status = dataReader.GetBoolean(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Sol_status.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Sol_date_preparation.ToString())))
				{
					businessObject.Sol_date_preparation = dataReader.GetDateTime(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Sol_date_preparation.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Sol_date_expiration.ToString())))
				{
					businessObject.Sol_date_expiration = dataReader.GetDateTime(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Sol_date_expiration.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_mrorpattern.ToString())))
				{
					businessObject.Std_mrorpattern = dataReader.GetInt32(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_mrorpattern.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_type_pattern.ToString())))
				{
					businessObject.Std_type_pattern = dataReader.GetInt32(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_type_pattern.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_flag_sol_intermedia1.ToString())))
				{
					businessObject.Std_flag_sol_intermedia1 = dataReader.GetBoolean(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_flag_sol_intermedia1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_flag_sol_intermedia2.ToString())))
				{
					businessObject.Std_flag_sol_intermedia2 = dataReader.GetBoolean(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_flag_sol_intermedia2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_concentration.ToString())))
				{
					businessObject.Std_concentration = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_concentration.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_concentration_sol1.ToString())))
				{
					businessObject.Std_concentration_sol1 = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_concentration_sol1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_concentration_sol2.ToString())))
				{
					businessObject.Std_concentration_sol2 = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_concentration_sol2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_status.ToString())))
				{
					businessObject.Std_status = dataReader.GetBoolean(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_status.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_sol1_medium.ToString())))
				{
					businessObject.Std_sol1_medium = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_sol1_medium.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_sol2_medium.ToString())))
				{
					businessObject.Std_sol2_medium = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_sol2_medium.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_stdverif_medium.ToString())))
				{
					businessObject.Std_stdverif_medium = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_stdverif_medium.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Idunit_result.ToString())))
				{
					businessObject.Idunit_result = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Idunit_result.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Num_samples.ToString())))
				{
					businessObject.Num_samples = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Num_samples.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Num_days.ToString())))
				{
					businessObject.Num_days = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Num_days.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Limit_samples.ToString())))
				{
					businessObject.Limit_samples = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Limit_samples.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_validity_sol1.ToString())))
				{
					businessObject.Std_validity_sol1 = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_validity_sol1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_validity_sol2.ToString())))
				{
					businessObject.Std_validity_sol2 = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_validity_sol2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_validity_sv.ToString())))
				{
					businessObject.Std_validity_sv = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_aa.CTemplate_method_aaFields.Std_validity_sv.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CTemplate_method_aa</returns>
        internal List<CTemplate_method_aa> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CTemplate_method_aa> list = new List<CTemplate_method_aa>();

            while (dataReader.Read())
            {
                CTemplate_method_aa businessObject = new CTemplate_method_aa();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
