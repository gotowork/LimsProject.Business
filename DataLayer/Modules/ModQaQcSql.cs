using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using Npgsql;
using NpgsqlTypes;

namespace LimsProject.BusinessLayer.DataLayer.Modules
{
	/// <summary>
	/// Data access layer class for CBatch_detail_aa
	/// </summary>
	partial class ModQaQcSql : DataLayerBase 
	{
        #region Public Methods
        
        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of CBatch_detail_aa</returns>
        public DataTable SelectAllTree(string p_cod_area, string p_cod_module, bool p_enabled_history, DateTime p_date_ini, DateTime p_date_end, long? p_cod_interno, long? p_idcompany)
        {
            DataTable dt = new DataTable();
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_batch_detail_SelectTree";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Connection = MainConnection;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlCommand);

            try
            {
                sqlCommand.Parameters.AddWithValue("p_status_batch", p_cod_area);
                sqlCommand.Parameters["p_status_batch"].NpgsqlDbType = NpgsqlDbType.Varchar;

                sqlCommand.Parameters.AddWithValue("p_date_ini", p_cod_module);
                sqlCommand.Parameters["p_date_ini"].NpgsqlDbType = NpgsqlDbType.Varchar;

                sqlCommand.Parameters.AddWithValue("p_date_end", p_enabled_history);
                sqlCommand.Parameters["p_date_end"].NpgsqlDbType = NpgsqlDbType.Boolean;

                sqlCommand.Parameters.AddWithValue("p_enabled_date", p_date_ini);
                sqlCommand.Parameters["p_enabled_date"].NpgsqlDbType = NpgsqlDbType.Date;

                sqlCommand.Parameters.AddWithValue("p_revised", p_date_end);
                sqlCommand.Parameters["p_revised"].NpgsqlDbType = NpgsqlDbType.Date;

                sqlCommand.Parameters.AddWithValue("p_cod_interno", p_cod_interno);
                sqlCommand.Parameters["p_cod_interno"].NpgsqlDbType = NpgsqlDbType.Bigint;

                sqlCommand.Parameters.AddWithValue("p_tray", p_idcompany);
                sqlCommand.Parameters["p_tray"].NpgsqlDbType = NpgsqlDbType.Bigint;


                MainConnection.Open();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatch_detail_aa::public.sp_batch_detail_SelectTree::Error occured.", ex);
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
