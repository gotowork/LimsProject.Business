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
	/// Data access layer class for CMr_detail
	/// </summary>
	partial class CMr_detailSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CMr_detailSql()
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
		public bool Insert(CMr_detail businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_mr_detail_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idmr_detail", businessObject.Idmr_detail);
				sqlCommand.Parameters["p_idmr_detail"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters["p_idmr_detail"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idmr", businessObject.Idmr);
				sqlCommand.Parameters["p_idmr"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_analyte", businessObject.Analyte);
				sqlCommand.Parameters["p_analyte"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_cod_element", businessObject.Cod_element);
				sqlCommand.Parameters["p_cod_element"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_nom_detail", businessObject.Nom_detail);
				sqlCommand.Parameters["p_nom_detail"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_incertitude", businessObject.Incertitude);
				sqlCommand.Parameters["p_incertitude"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_nominal_value", businessObject.Nominal_value);
				sqlCommand.Parameters["p_nominal_value"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idunit1", businessObject.Idunit1);
				sqlCommand.Parameters["p_idunit1"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_document_ref", businessObject.Document_ref);
				sqlCommand.Parameters["p_document_ref"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dev", businessObject.Dev);
				sqlCommand.Parameters["p_dev"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_dev_labs", businessObject.Dev_labs);
				sqlCommand.Parameters["p_dev_labs"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flag_provitional", businessObject.Flag_provitional);
				sqlCommand.Parameters["p_flag_provitional"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_cod_digestion_method", businessObject.Cod_digestion_method);
				sqlCommand.Parameters["p_cod_digestion_method"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_observation", businessObject.Observation);
				sqlCommand.Parameters["p_observation"].NpgsqlDbType = NpgsqlDbType.Varchar;
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
                businessObject.Idmr_detail = Convert.ToInt16(sqlCommand.Parameters["p_idmr_detail"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CMr_detail::Insert::Error occured.", ex);
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
        public bool Update(CMr_detail businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_mr_detail_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idmr_detail", businessObject.Idmr_detail);
				sqlCommand.Parameters["p_idmr_detail"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idmr", businessObject.Idmr);
				sqlCommand.Parameters["p_idmr"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_analyte", businessObject.Analyte);
				sqlCommand.Parameters["p_analyte"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_cod_element", businessObject.Cod_element);
				sqlCommand.Parameters["p_cod_element"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_nom_detail", businessObject.Nom_detail);
				sqlCommand.Parameters["p_nom_detail"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_incertitude", businessObject.Incertitude);
				sqlCommand.Parameters["p_incertitude"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_nominal_value", businessObject.Nominal_value);
				sqlCommand.Parameters["p_nominal_value"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idunit1", businessObject.Idunit1);
				sqlCommand.Parameters["p_idunit1"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_document_ref", businessObject.Document_ref);
				sqlCommand.Parameters["p_document_ref"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dev", businessObject.Dev);
				sqlCommand.Parameters["p_dev"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_dev_labs", businessObject.Dev_labs);
				sqlCommand.Parameters["p_dev_labs"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_flag_provitional", businessObject.Flag_provitional);
				sqlCommand.Parameters["p_flag_provitional"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_cod_digestion_method", businessObject.Cod_digestion_method);
				sqlCommand.Parameters["p_cod_digestion_method"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_observation", businessObject.Observation);
				sqlCommand.Parameters["p_observation"].NpgsqlDbType = NpgsqlDbType.Varchar;
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
                throw new Exception("CMr_detail::Update::Error occured.", ex);
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
        /// <returns>CMr_detail business object</returns>
        public CMr_detail SelectByPrimaryKey(CMr_detailKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_mr_detail_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idmr_detail", NpgsqlDbType.Smallint, 2, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idmr_detail));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CMr_detail businessObject = new CMr_detail();

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
                throw new Exception("CMr_detail::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CMr_detail</returns>
        public List<CMr_detail> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_mr_detail_SelectAll";
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
                throw new Exception("CMr_detail::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_mr_detail_SelectAll";
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
                throw new Exception("CMr_detail::SelectAll::Error occured.", ex);
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
        /// <returns>list of CMr_detail</returns>
        public List<CMr_detail> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_mr_detail_SelectByField";
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
                throw new Exception("CMr_detail::SelectByField::Error occured.", ex);
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
        public bool Delete(CMr_detailKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_mr_detail_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idmr_detail", NpgsqlDbType.Smallint, 2, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idmr_detail));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CMr_detail::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_mr_detail_DeleteByField";
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
                throw new Exception("CMr_detail::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CMr_detail businessObject, IDataReader dataReader)
        {


				businessObject.Idmr_detail = (short)dataReader.GetInt16(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Idmr_detail.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Idmr.ToString())))
				{
					businessObject.Idmr = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Idmr.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Analyte.ToString())))
				{
					businessObject.Analyte = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Analyte.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Cod_element.ToString())))
				{
					businessObject.Cod_element = dataReader.GetString(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Cod_element.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Nom_detail.ToString())))
				{
					businessObject.Nom_detail = dataReader.GetString(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Nom_detail.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Incertitude.ToString())))
				{
					businessObject.Incertitude = dataReader.GetDecimal(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Incertitude.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Nominal_value.ToString())))
				{
					businessObject.Nominal_value = dataReader.GetDecimal(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Nominal_value.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Idunit1.ToString())))
				{
					businessObject.Idunit1 = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Idunit1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Document_ref.ToString())))
				{
					businessObject.Document_ref = dataReader.GetString(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Document_ref.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Dev.ToString())))
				{
					businessObject.Dev = dataReader.GetDecimal(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Dev.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Dev_labs.ToString())))
				{
					businessObject.Dev_labs = dataReader.GetDecimal(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Dev_labs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Flag_provitional.ToString())))
				{
					businessObject.Flag_provitional = dataReader.GetBoolean(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Flag_provitional.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Cod_digestion_method.ToString())))
				{
					businessObject.Cod_digestion_method = dataReader.GetString(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Cod_digestion_method.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Observation.ToString())))
				{
					businessObject.Observation = dataReader.GetString(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Observation.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CMr_detail.CMr_detailFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CMr_detail</returns>
        internal List<CMr_detail> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CMr_detail> list = new List<CMr_detail>();

            while (dataReader.Read())
            {
                CMr_detail businessObject = new CMr_detail();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
