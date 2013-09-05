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
	/// Data access layer class for CRecep_sample_report
	/// </summary>
	partial class CRecep_sample_reportSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CRecep_sample_reportSql()
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
		public bool Insert(CRecep_sample_report businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_recep_sample_report_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_report", businessObject.Idrecep_sample_report);
				sqlCommand.Parameters["p_idrecep_sample_report"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters["p_idrecep_sample_report"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_order_report", businessObject.Order_report);
				sqlCommand.Parameters["p_order_report"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_cod_recep_sample_report", businessObject.Cod_recep_sample_report);
				sqlCommand.Parameters["p_cod_recep_sample_report"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_report_status", businessObject.Report_status);
				sqlCommand.Parameters["p_report_status"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_type_report", businessObject.Type_report);
				sqlCommand.Parameters["p_type_report"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_flag_rpt_email", businessObject.Flag_rpt_email);
				sqlCommand.Parameters["p_flag_rpt_email"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_rpt_print", businessObject.Flag_rpt_print);
				sqlCommand.Parameters["p_flag_rpt_print"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_rpt_pdf", businessObject.Flag_rpt_pdf);
				sqlCommand.Parameters["p_flag_rpt_pdf"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_date_report", businessObject.Date_report);
				sqlCommand.Parameters["p_date_report"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_time_report", businessObject.Time_report);
				sqlCommand.Parameters["p_time_report"].NpgsqlDbType = NpgsqlDbType.Timestamp;
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
                businessObject.Idrecep_sample_report = Convert.ToInt64(sqlCommand.Parameters["p_idrecep_sample_report"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CRecep_sample_report::Insert::Error occured.", ex);
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
        public bool Update(CRecep_sample_report businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_report_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_report", businessObject.Idrecep_sample_report);
				sqlCommand.Parameters["p_idrecep_sample_report"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_order_report", businessObject.Order_report);
				sqlCommand.Parameters["p_order_report"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_cod_recep_sample_report", businessObject.Cod_recep_sample_report);
				sqlCommand.Parameters["p_cod_recep_sample_report"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_report_status", businessObject.Report_status);
				sqlCommand.Parameters["p_report_status"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_type_report", businessObject.Type_report);
				sqlCommand.Parameters["p_type_report"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_flag_rpt_email", businessObject.Flag_rpt_email);
				sqlCommand.Parameters["p_flag_rpt_email"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_rpt_print", businessObject.Flag_rpt_print);
				sqlCommand.Parameters["p_flag_rpt_print"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_rpt_pdf", businessObject.Flag_rpt_pdf);
				sqlCommand.Parameters["p_flag_rpt_pdf"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_date_report", businessObject.Date_report);
				sqlCommand.Parameters["p_date_report"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_time_report", businessObject.Time_report);
				sqlCommand.Parameters["p_time_report"].NpgsqlDbType = NpgsqlDbType.Timestamp;
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
                throw new Exception("CRecep_sample_report::Update::Error occured.", ex);
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
        /// <returns>CRecep_sample_report business object</returns>
        public CRecep_sample_report SelectByPrimaryKey(CRecep_sample_reportKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_report_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idrecep_sample_report", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idrecep_sample_report));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CRecep_sample_report businessObject = new CRecep_sample_report();

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
                throw new Exception("CRecep_sample_report::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CRecep_sample_report</returns>
        public List<CRecep_sample_report> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_report_SelectAll";
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
                throw new Exception("CRecep_sample_report::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_recep_sample_report_SelectAll";
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
                throw new Exception("CRecep_sample_report::SelectAll::Error occured.", ex);
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
        /// <returns>list of CRecep_sample_report</returns>
        public List<CRecep_sample_report> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_report_SelectByField";
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
                throw new Exception("CRecep_sample_report::SelectByField::Error occured.", ex);
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
        public bool Delete(CRecep_sample_reportKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_report_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idrecep_sample_report", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idrecep_sample_report));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CRecep_sample_report::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_recep_sample_report_DeleteByField";
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
                throw new Exception("CRecep_sample_report::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CRecep_sample_report businessObject, IDataReader dataReader)
        {


				businessObject.Idrecep_sample_report = dataReader.GetInt64(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Idrecep_sample_report.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Order_report.ToString())))
				{
					businessObject.Order_report = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Order_report.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Cod_recep_sample_report.ToString())))
				{
					businessObject.Cod_recep_sample_report = dataReader.GetInt64(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Cod_recep_sample_report.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Report_status.ToString())))
				{
					businessObject.Report_status = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Report_status.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Type_report.ToString())))
				{
					businessObject.Type_report = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Type_report.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Idrecep_sample.ToString())))
				{
					businessObject.Idrecep_sample = dataReader.GetInt64(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Idrecep_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Flag_rpt_email.ToString())))
				{
					businessObject.Flag_rpt_email = dataReader.GetBoolean(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Flag_rpt_email.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Flag_rpt_print.ToString())))
				{
					businessObject.Flag_rpt_print = dataReader.GetBoolean(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Flag_rpt_print.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Flag_rpt_pdf.ToString())))
				{
					businessObject.Flag_rpt_pdf = dataReader.GetBoolean(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Flag_rpt_pdf.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Date_report.ToString())))
				{
					businessObject.Date_report = dataReader.GetDateTime(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Date_report.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Time_report.ToString())))
				{
					businessObject.Time_report = dataReader.GetDateTime(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Time_report.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CRecep_sample_report.CRecep_sample_reportFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CRecep_sample_report</returns>
        internal List<CRecep_sample_report> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CRecep_sample_report> list = new List<CRecep_sample_report>();

            while (dataReader.Read())
            {
                CRecep_sample_report businessObject = new CRecep_sample_report();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
