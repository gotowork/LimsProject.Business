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
	/// Data access layer class for CBatch
	/// </summary>
	partial class CReportTestSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
        public CReportTestSql()
		{
			// Nothing for now.
		}

        #endregion

        #region Public Methods        

        public DataTable SelectReportHead(long p_idrecep_sample_report)
        {

            DataTable dt = new DataTable();
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_rpt_report_head";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Connection = MainConnection;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlCommand);

            try
            {
                sqlCommand.Parameters.AddWithValue("p_idrecep_sample_report", p_idrecep_sample_report);
                sqlCommand.Parameters["p_idrecep_sample_report"].NpgsqlDbType = NpgsqlDbType.Bigint;

                MainConnection.Open();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatch::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public DataTable SelectReportMethods(long p_idrecep_sample_report)
        {

            DataTable dt = new DataTable();
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_rpt_report_methods";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Connection = MainConnection;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlCommand);

            try
            {
                sqlCommand.Parameters.AddWithValue("p_idrecep_sample_report", p_idrecep_sample_report);
                sqlCommand.Parameters["p_idrecep_sample_report"].NpgsqlDbType = NpgsqlDbType.Bigint;

                MainConnection.Open();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatch::sp_rpt_report_methods::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public DataTable SelectReportResults(long p_idrecep_sample_report)
        {
            
            DataTable dt = new DataTable();
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_rpt_report_results";
            sqlCommand.CommandType = CommandType.StoredProcedure;                        
            sqlCommand.Connection = MainConnection;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlCommand);

            try
            {           
                sqlCommand.Parameters.AddWithValue("p_idrecep_sample_report", p_idrecep_sample_report);
				sqlCommand.Parameters["p_idrecep_sample_report"].NpgsqlDbType = NpgsqlDbType.Bigint;

                MainConnection.Open();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatch::sp_rpt_report_results::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        


        #endregion
        

	}
}
