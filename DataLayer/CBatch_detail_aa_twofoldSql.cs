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
	/// Data access layer class for CBatch_detail_aa_twofold
	/// </summary>
	partial class CBatch_detail_aa_twofoldSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CBatch_detail_aa_twofoldSql()
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
		public bool Insert(CBatch_detail_aa_twofold businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_batch_detail_aa_twofold_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idbatch_detail_aa", businessObject.Idbatch_detail_aa);
				sqlCommand.Parameters["p_idbatch_detail_aa"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters["p_idbatch_detail_aa"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_num_repetition", businessObject.Num_repetition);
				sqlCommand.Parameters["p_num_repetition"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail_elem", businessObject.Idrecep_sample_detail_elem);
				sqlCommand.Parameters["p_idrecep_sample_detail_elem"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail", businessObject.Idrecep_sample_detail);
				sqlCommand.Parameters["p_idrecep_sample_detail"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_cod_des_sample", businessObject.Cod_des_sample);
				sqlCommand.Parameters["p_cod_des_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_order_des_sample", businessObject.Order_des_sample);
				sqlCommand.Parameters["p_order_des_sample"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_cod_sample", businessObject.Cod_sample);
				sqlCommand.Parameters["p_cod_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_cod_interno", businessObject.Cod_interno);
				sqlCommand.Parameters["p_cod_interno"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_order_sample_batch", businessObject.Order_sample_batch);
				sqlCommand.Parameters["p_order_sample_batch"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_flag_mri", businessObject.Flag_mri);
				sqlCommand.Parameters["p_flag_mri"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_weight1", businessObject.Weight1);
				sqlCommand.Parameters["p_weight1"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reading1", businessObject.Reading1);
				sqlCommand.Parameters["p_reading1"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_volumen1", businessObject.Volumen1);
				sqlCommand.Parameters["p_volumen1"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_factor1", businessObject.Factor1);
				sqlCommand.Parameters["p_factor1"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_law1", businessObject.Law1);
				sqlCommand.Parameters["p_law1"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_law1_long", businessObject.Law1_long);
				sqlCommand.Parameters["p_law1_long"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_sample_mr_blk1", businessObject.Sample_mr_blk1);
				sqlCommand.Parameters["p_sample_mr_blk1"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_weight2", businessObject.Weight2);
				sqlCommand.Parameters["p_weight2"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reading2", businessObject.Reading2);
				sqlCommand.Parameters["p_reading2"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_volumen2", businessObject.Volumen2);
				sqlCommand.Parameters["p_volumen2"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_factor2", businessObject.Factor2);
				sqlCommand.Parameters["p_factor2"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_law2", businessObject.Law2);
				sqlCommand.Parameters["p_law2"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_law2_long", businessObject.Law2_long);
				sqlCommand.Parameters["p_law2_long"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_sample_mr_blk2", businessObject.Sample_mr_blk2);
				sqlCommand.Parameters["p_sample_mr_blk2"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_dilu2", businessObject.Dilu2);
				sqlCommand.Parameters["p_dilu2"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flag_dilu2", businessObject.Flag_dilu2);
				sqlCommand.Parameters["p_flag_dilu2"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_dilu3", businessObject.Dilu3);
				sqlCommand.Parameters["p_dilu3"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flag_dilu3", businessObject.Flag_dilu3);
				sqlCommand.Parameters["p_flag_dilu3"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_idbatch", businessObject.Idbatch);
				sqlCommand.Parameters["p_idbatch"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_verify_equip", businessObject.Verify_equip);
				sqlCommand.Parameters["p_verify_equip"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_verify_curve", businessObject.Verify_curve);
				sqlCommand.Parameters["p_verify_curve"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idtype_rep", businessObject.Idtype_rep);
				sqlCommand.Parameters["p_idtype_rep"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_idmr_detail", businessObject.Idmr_detail);
				sqlCommand.Parameters["p_idmr_detail"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idmr_jar", businessObject.Idmr_jar);
				sqlCommand.Parameters["p_idmr_jar"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_usernew", businessObject.Usernew);
				sqlCommand.Parameters["p_usernew"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_datenew", businessObject.Datenew);
				sqlCommand.Parameters["p_datenew"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_useredit", businessObject.Useredit);
				sqlCommand.Parameters["p_useredit"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dateedit", businessObject.Dateedit);
				sqlCommand.Parameters["p_dateedit"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_idequipment1", businessObject.Idequipment1);
				sqlCommand.Parameters["p_idequipment1"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_str_result_analysis", businessObject.Str_result_analysis);
				sqlCommand.Parameters["p_str_result_analysis"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_result_analysis", businessObject.Result_analysis);
				sqlCommand.Parameters["p_result_analysis"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_fum", businessObject.Fum);
				sqlCommand.Parameters["p_fum"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idunit_result", businessObject.Idunit_result);
				sqlCommand.Parameters["p_idunit_result"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_qaqc_status_result", businessObject.Qaqc_status_result);
				sqlCommand.Parameters["p_qaqc_status_result"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_blk", businessObject.Qaqc_blk);
				sqlCommand.Parameters["p_qaqc_blk"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_par", businessObject.Qaqc_par);
				sqlCommand.Parameters["p_qaqc_par"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_mr", businessObject.Qaqc_mr);
				sqlCommand.Parameters["p_qaqc_mr"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_approve_text", businessObject.Qaqc_approve_text);
				sqlCommand.Parameters["p_qaqc_approve_text"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_qaqc_approve", businessObject.Qaqc_approve);
				sqlCommand.Parameters["p_qaqc_approve"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_qaqc_error", businessObject.Qaqc_error);
				sqlCommand.Parameters["p_qaqc_error"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_review_text", businessObject.Qaqc_review_text);
				sqlCommand.Parameters["p_qaqc_review_text"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_qaqc_review", businessObject.Qaqc_review);
				sqlCommand.Parameters["p_qaqc_review"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_qaqc_par_prev_batch", businessObject.Qaqc_par_prev_batch);
				sqlCommand.Parameters["p_qaqc_par_prev_batch"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_tmp_retest_idmethod", businessObject.Qaqc_tmp_retest_idmethod);
				sqlCommand.Parameters["p_qaqc_tmp_retest_idmethod"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_tmp_retest", businessObject.Qaqc_tmp_retest);
				sqlCommand.Parameters["p_qaqc_tmp_retest"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_has_retest", businessObject.Qaqc_has_retest);
				sqlCommand.Parameters["p_qaqc_has_retest"].NpgsqlDbType = NpgsqlDbType.Integer;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idbatch_detail_aa = Convert.ToInt64(sqlCommand.Parameters["p_idbatch_detail_aa"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CBatch_detail_aa_twofold::Insert::Error occured.", ex);
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
        public bool Update(CBatch_detail_aa_twofold businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_detail_aa_twofold_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idbatch_detail_aa", businessObject.Idbatch_detail_aa);
				sqlCommand.Parameters["p_idbatch_detail_aa"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_num_repetition", businessObject.Num_repetition);
				sqlCommand.Parameters["p_num_repetition"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail_elem", businessObject.Idrecep_sample_detail_elem);
				sqlCommand.Parameters["p_idrecep_sample_detail_elem"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail", businessObject.Idrecep_sample_detail);
				sqlCommand.Parameters["p_idrecep_sample_detail"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_cod_des_sample", businessObject.Cod_des_sample);
				sqlCommand.Parameters["p_cod_des_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_order_des_sample", businessObject.Order_des_sample);
				sqlCommand.Parameters["p_order_des_sample"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_cod_sample", businessObject.Cod_sample);
				sqlCommand.Parameters["p_cod_sample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_cod_interno", businessObject.Cod_interno);
				sqlCommand.Parameters["p_cod_interno"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_order_sample_batch", businessObject.Order_sample_batch);
				sqlCommand.Parameters["p_order_sample_batch"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_flag_mri", businessObject.Flag_mri);
				sqlCommand.Parameters["p_flag_mri"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_weight1", businessObject.Weight1);
				sqlCommand.Parameters["p_weight1"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reading1", businessObject.Reading1);
				sqlCommand.Parameters["p_reading1"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_volumen1", businessObject.Volumen1);
				sqlCommand.Parameters["p_volumen1"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_factor1", businessObject.Factor1);
				sqlCommand.Parameters["p_factor1"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_law1", businessObject.Law1);
				sqlCommand.Parameters["p_law1"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_law1_long", businessObject.Law1_long);
				sqlCommand.Parameters["p_law1_long"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_sample_mr_blk1", businessObject.Sample_mr_blk1);
				sqlCommand.Parameters["p_sample_mr_blk1"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_weight2", businessObject.Weight2);
				sqlCommand.Parameters["p_weight2"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_reading2", businessObject.Reading2);
				sqlCommand.Parameters["p_reading2"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_volumen2", businessObject.Volumen2);
				sqlCommand.Parameters["p_volumen2"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_factor2", businessObject.Factor2);
				sqlCommand.Parameters["p_factor2"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_law2", businessObject.Law2);
				sqlCommand.Parameters["p_law2"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_law2_long", businessObject.Law2_long);
				sqlCommand.Parameters["p_law2_long"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_sample_mr_blk2", businessObject.Sample_mr_blk2);
				sqlCommand.Parameters["p_sample_mr_blk2"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_dilu2", businessObject.Dilu2);
				sqlCommand.Parameters["p_dilu2"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flag_dilu2", businessObject.Flag_dilu2);
				sqlCommand.Parameters["p_flag_dilu2"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_dilu3", businessObject.Dilu3);
				sqlCommand.Parameters["p_dilu3"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flag_dilu3", businessObject.Flag_dilu3);
				sqlCommand.Parameters["p_flag_dilu3"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_idbatch", businessObject.Idbatch);
				sqlCommand.Parameters["p_idbatch"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_verify_equip", businessObject.Verify_equip);
				sqlCommand.Parameters["p_verify_equip"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_verify_curve", businessObject.Verify_curve);
				sqlCommand.Parameters["p_verify_curve"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idtype_rep", businessObject.Idtype_rep);
				sqlCommand.Parameters["p_idtype_rep"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_idmr_detail", businessObject.Idmr_detail);
				sqlCommand.Parameters["p_idmr_detail"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idmr_jar", businessObject.Idmr_jar);
				sqlCommand.Parameters["p_idmr_jar"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_usernew", businessObject.Usernew);
				sqlCommand.Parameters["p_usernew"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_datenew", businessObject.Datenew);
				sqlCommand.Parameters["p_datenew"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_useredit", businessObject.Useredit);
				sqlCommand.Parameters["p_useredit"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dateedit", businessObject.Dateedit);
				sqlCommand.Parameters["p_dateedit"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_idequipment1", businessObject.Idequipment1);
				sqlCommand.Parameters["p_idequipment1"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_str_result_analysis", businessObject.Str_result_analysis);
				sqlCommand.Parameters["p_str_result_analysis"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_result_analysis", businessObject.Result_analysis);
				sqlCommand.Parameters["p_result_analysis"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_fum", businessObject.Fum);
				sqlCommand.Parameters["p_fum"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idunit_result", businessObject.Idunit_result);
				sqlCommand.Parameters["p_idunit_result"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_qaqc_status_result", businessObject.Qaqc_status_result);
				sqlCommand.Parameters["p_qaqc_status_result"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_blk", businessObject.Qaqc_blk);
				sqlCommand.Parameters["p_qaqc_blk"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_par", businessObject.Qaqc_par);
				sqlCommand.Parameters["p_qaqc_par"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_mr", businessObject.Qaqc_mr);
				sqlCommand.Parameters["p_qaqc_mr"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_approve_text", businessObject.Qaqc_approve_text);
				sqlCommand.Parameters["p_qaqc_approve_text"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_qaqc_approve", businessObject.Qaqc_approve);
				sqlCommand.Parameters["p_qaqc_approve"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_qaqc_error", businessObject.Qaqc_error);
				sqlCommand.Parameters["p_qaqc_error"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_review_text", businessObject.Qaqc_review_text);
				sqlCommand.Parameters["p_qaqc_review_text"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_qaqc_review", businessObject.Qaqc_review);
				sqlCommand.Parameters["p_qaqc_review"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_qaqc_par_prev_batch", businessObject.Qaqc_par_prev_batch);
				sqlCommand.Parameters["p_qaqc_par_prev_batch"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_tmp_retest_idmethod", businessObject.Qaqc_tmp_retest_idmethod);
				sqlCommand.Parameters["p_qaqc_tmp_retest_idmethod"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_tmp_retest", businessObject.Qaqc_tmp_retest);
				sqlCommand.Parameters["p_qaqc_tmp_retest"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_qaqc_has_retest", businessObject.Qaqc_has_retest);
				sqlCommand.Parameters["p_qaqc_has_retest"].NpgsqlDbType = NpgsqlDbType.Integer;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatch_detail_aa_twofold::Update::Error occured.", ex);
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
        /// <returns>CBatch_detail_aa_twofold business object</returns>
        public CBatch_detail_aa_twofold SelectByPrimaryKey(CBatch_detail_aa_twofoldKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_detail_aa_twofold_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idbatch_detail_aa", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idbatch_detail_aa));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CBatch_detail_aa_twofold businessObject = new CBatch_detail_aa_twofold();

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
                throw new Exception("CBatch_detail_aa_twofold::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CBatch_detail_aa_twofold</returns>
        public List<CBatch_detail_aa_twofold> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_detail_aa_twofold_SelectAll";
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
                throw new Exception("CBatch_detail_aa_twofold::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_batch_detail_aa_twofold_SelectAll";
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
                throw new Exception("CBatch_detail_aa_twofold::SelectAll::Error occured.", ex);
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
        /// <returns>list of CBatch_detail_aa_twofold</returns>
        public List<CBatch_detail_aa_twofold> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_detail_aa_twofold_SelectByField";
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
                throw new Exception("CBatch_detail_aa_twofold::SelectByField::Error occured.", ex);
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
        public bool Delete(CBatch_detail_aa_twofoldKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_detail_aa_twofold_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idbatch_detail_aa", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idbatch_detail_aa));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatch_detail_aa_twofold::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_batch_detail_aa_twofold_DeleteByField";
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
                throw new Exception("CBatch_detail_aa_twofold::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CBatch_detail_aa_twofold businessObject, IDataReader dataReader)
        {


				businessObject.Idbatch_detail_aa = dataReader.GetInt64(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idbatch_detail_aa.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Num_repetition.ToString())))
				{
					businessObject.Num_repetition = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Num_repetition.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idtemplate_method.ToString())))
				{
					businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idtemplate_method.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idrecep_sample.ToString())))
				{
					businessObject.Idrecep_sample = dataReader.GetInt64(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idrecep_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idrecep_sample_detail_elem.ToString())))
				{
					businessObject.Idrecep_sample_detail_elem = dataReader.GetInt64(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idrecep_sample_detail_elem.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idrecep_sample_detail.ToString())))
				{
					businessObject.Idrecep_sample_detail = dataReader.GetInt64(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idrecep_sample_detail.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Cod_des_sample.ToString())))
				{
					businessObject.Cod_des_sample = dataReader.GetString(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Cod_des_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Order_des_sample.ToString())))
				{
					businessObject.Order_des_sample = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Order_des_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Cod_sample.ToString())))
				{
					businessObject.Cod_sample = dataReader.GetString(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Cod_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Cod_interno.ToString())))
				{
					businessObject.Cod_interno = dataReader.GetInt64(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Cod_interno.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Order_sample_batch.ToString())))
				{
					businessObject.Order_sample_batch = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Order_sample_batch.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Flag_mri.ToString())))
				{
					businessObject.Flag_mri = dataReader.GetInt32(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Flag_mri.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Weight1.ToString())))
				{
					businessObject.Weight1 = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Weight1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Reading1.ToString())))
				{
					businessObject.Reading1 = dataReader.GetString(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Reading1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Volumen1.ToString())))
				{
					businessObject.Volumen1 = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Volumen1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Factor1.ToString())))
				{
					businessObject.Factor1 = dataReader.GetString(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Factor1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Law1.ToString())))
				{
					businessObject.Law1 = dataReader.GetString(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Law1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Law1_long.ToString())))
				{
					businessObject.Law1_long = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Law1_long.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Sample_mr_blk1.ToString())))
				{
					businessObject.Sample_mr_blk1 = dataReader.GetChar(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Sample_mr_blk1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Weight2.ToString())))
				{
					businessObject.Weight2 = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Weight2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Reading2.ToString())))
				{
					businessObject.Reading2 = dataReader.GetString(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Reading2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Volumen2.ToString())))
				{
					businessObject.Volumen2 = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Volumen2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Factor2.ToString())))
				{
					businessObject.Factor2 = dataReader.GetString(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Factor2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Law2.ToString())))
				{
					businessObject.Law2 = dataReader.GetString(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Law2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Law2_long.ToString())))
				{
					businessObject.Law2_long = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Law2_long.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Sample_mr_blk2.ToString())))
				{
					businessObject.Sample_mr_blk2 = dataReader.GetChar(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Sample_mr_blk2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Dilu2.ToString())))
				{
					businessObject.Dilu2 = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Dilu2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Flag_dilu2.ToString())))
				{
					businessObject.Flag_dilu2 = dataReader.GetBoolean(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Flag_dilu2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Dilu3.ToString())))
				{
					businessObject.Dilu3 = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Dilu3.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Flag_dilu3.ToString())))
				{
					businessObject.Flag_dilu3 = dataReader.GetBoolean(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Flag_dilu3.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idbatch.ToString())))
				{
					businessObject.Idbatch = dataReader.GetInt64(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idbatch.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Verify_equip.ToString())))
				{
					businessObject.Verify_equip = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Verify_equip.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Verify_curve.ToString())))
				{
					businessObject.Verify_curve = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Verify_curve.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idtype_rep.ToString())))
				{
					businessObject.Idtype_rep = dataReader.GetChar(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idtype_rep.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idmr_detail.ToString())))
				{
					businessObject.Idmr_detail = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idmr_detail.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idmr_jar.ToString())))
				{
					businessObject.Idmr_jar = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idmr_jar.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idequipment1.ToString())))
				{
					businessObject.Idequipment1 = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idequipment1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Status.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Str_result_analysis.ToString())))
				{
					businessObject.Str_result_analysis = dataReader.GetString(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Str_result_analysis.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Result_analysis.ToString())))
				{
					businessObject.Result_analysis = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Result_analysis.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Fum.ToString())))
				{
					businessObject.Fum = dataReader.GetDecimal(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Fum.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idunit_result.ToString())))
				{
					businessObject.Idunit_result = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Idunit_result.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_status_result.ToString())))
				{
					businessObject.Qaqc_status_result = dataReader.GetInt32(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_status_result.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_blk.ToString())))
				{
					businessObject.Qaqc_blk = dataReader.GetInt32(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_blk.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_par.ToString())))
				{
					businessObject.Qaqc_par = dataReader.GetInt32(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_par.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_mr.ToString())))
				{
					businessObject.Qaqc_mr = dataReader.GetInt32(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_mr.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_approve_text.ToString())))
				{
					businessObject.Qaqc_approve_text = dataReader.GetString(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_approve_text.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_approve.ToString())))
				{
					businessObject.Qaqc_approve = dataReader.GetBoolean(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_approve.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_error.ToString())))
				{
					businessObject.Qaqc_error = dataReader.GetInt32(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_error.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_review_text.ToString())))
				{
					businessObject.Qaqc_review_text = dataReader.GetString(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_review_text.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_review.ToString())))
				{
					businessObject.Qaqc_review = dataReader.GetBoolean(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_review.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_par_prev_batch.ToString())))
				{
					businessObject.Qaqc_par_prev_batch = dataReader.GetInt32(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_par_prev_batch.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_tmp_retest_idmethod.ToString())))
				{
					businessObject.Qaqc_tmp_retest_idmethod = dataReader.GetInt32(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_tmp_retest_idmethod.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_tmp_retest.ToString())))
				{
					businessObject.Qaqc_tmp_retest = dataReader.GetInt32(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_tmp_retest.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_has_retest.ToString())))
				{
					businessObject.Qaqc_has_retest = dataReader.GetInt32(dataReader.GetOrdinal(CBatch_detail_aa_twofold.CBatch_detail_aa_twofoldFields.Qaqc_has_retest.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CBatch_detail_aa_twofold</returns>
        internal List<CBatch_detail_aa_twofold> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CBatch_detail_aa_twofold> list = new List<CBatch_detail_aa_twofold>();

            while (dataReader.Read())
            {
                CBatch_detail_aa_twofold businessObject = new CBatch_detail_aa_twofold();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
