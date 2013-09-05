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
	/// Data access layer class for CControl_sample
	/// </summary>
	partial class CControl_sampleSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CControl_sampleSql()
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
		public bool Insert(CControl_sample businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_control_sample_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idcontrol_sample", businessObject.Idcontrol_sample);
				sqlCommand.Parameters["p_idcontrol_sample"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idcontrol_sample"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idtype_sample_control", businessObject.Idtype_sample_control);
				sqlCommand.Parameters["p_idtype_sample_control"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_type_analisys", businessObject.Type_analisys);
				sqlCommand.Parameters["p_type_analisys"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_name_cs", businessObject.Name_cs);
				sqlCommand.Parameters["p_name_cs"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_description", businessObject.Description);
				sqlCommand.Parameters["p_description"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_name_value_prefijo", businessObject.Name_value_prefijo);
				sqlCommand.Parameters["p_name_value_prefijo"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_value1", businessObject.Value1);
				sqlCommand.Parameters["p_value1"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_name_value_sufijo", businessObject.Name_value_sufijo);
				sqlCommand.Parameters["p_name_value_sufijo"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_name_frec_prefijo", businessObject.Name_frec_prefijo);
				sqlCommand.Parameters["p_name_frec_prefijo"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_frecuency", businessObject.Frecuency);
				sqlCommand.Parameters["p_frecuency"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_name_frec_sufijo", businessObject.Name_frec_sufijo);
				sqlCommand.Parameters["p_name_frec_sufijo"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_flag_frec_by_batch", businessObject.Flag_frec_by_batch);
				sqlCommand.Parameters["p_flag_frec_by_batch"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_frec_by_sample", businessObject.Flag_frec_by_sample);
				sqlCommand.Parameters["p_flag_frec_by_sample"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_priority", businessObject.Priority);
				sqlCommand.Parameters["p_priority"].NpgsqlDbType = NpgsqlDbType.Integer;
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
                businessObject.Idcontrol_sample = Convert.ToInt32(sqlCommand.Parameters["p_idcontrol_sample"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CControl_sample::Insert::Error occured.", ex);
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
        public bool Update(CControl_sample businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_control_sample_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idcontrol_sample", businessObject.Idcontrol_sample);
				sqlCommand.Parameters["p_idcontrol_sample"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idtype_sample_control", businessObject.Idtype_sample_control);
				sqlCommand.Parameters["p_idtype_sample_control"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_type_analisys", businessObject.Type_analisys);
				sqlCommand.Parameters["p_type_analisys"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_name_cs", businessObject.Name_cs);
				sqlCommand.Parameters["p_name_cs"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_description", businessObject.Description);
				sqlCommand.Parameters["p_description"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_name_value_prefijo", businessObject.Name_value_prefijo);
				sqlCommand.Parameters["p_name_value_prefijo"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_value1", businessObject.Value1);
				sqlCommand.Parameters["p_value1"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_name_value_sufijo", businessObject.Name_value_sufijo);
				sqlCommand.Parameters["p_name_value_sufijo"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_name_frec_prefijo", businessObject.Name_frec_prefijo);
				sqlCommand.Parameters["p_name_frec_prefijo"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_frecuency", businessObject.Frecuency);
				sqlCommand.Parameters["p_frecuency"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_name_frec_sufijo", businessObject.Name_frec_sufijo);
				sqlCommand.Parameters["p_name_frec_sufijo"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_flag_frec_by_batch", businessObject.Flag_frec_by_batch);
				sqlCommand.Parameters["p_flag_frec_by_batch"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_frec_by_sample", businessObject.Flag_frec_by_sample);
				sqlCommand.Parameters["p_flag_frec_by_sample"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_priority", businessObject.Priority);
				sqlCommand.Parameters["p_priority"].NpgsqlDbType = NpgsqlDbType.Integer;
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
                throw new Exception("CControl_sample::Update::Error occured.", ex);
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
        /// <returns>CControl_sample business object</returns>
        public CControl_sample SelectByPrimaryKey(CControl_sampleKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_control_sample_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idcontrol_sample", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idcontrol_sample));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CControl_sample businessObject = new CControl_sample();

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
                throw new Exception("CControl_sample::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CControl_sample</returns>
        public List<CControl_sample> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_control_sample_SelectAll";
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
                throw new Exception("CControl_sample::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_control_sample_SelectAll";
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
                throw new Exception("CControl_sample::SelectAll::Error occured.", ex);
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
        /// <returns>list of CControl_sample</returns>
        public List<CControl_sample> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_control_sample_SelectByField";
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
                throw new Exception("CControl_sample::SelectByField::Error occured.", ex);
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
        public bool Delete(CControl_sampleKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_control_sample_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idcontrol_sample", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idcontrol_sample));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CControl_sample::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_control_sample_DeleteByField";
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
                throw new Exception("CControl_sample::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CControl_sample businessObject, IDataReader dataReader)
        {


				businessObject.Idcontrol_sample = dataReader.GetInt32(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Idcontrol_sample.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Idtype_sample_control.ToString())))
				{
					businessObject.Idtype_sample_control = dataReader.GetInt32(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Idtype_sample_control.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Idtemplate_method.ToString())))
				{
					businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Idtemplate_method.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Type_analisys.ToString())))
				{
					businessObject.Type_analisys = dataReader.GetInt32(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Type_analisys.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Name_cs.ToString())))
				{
					businessObject.Name_cs = dataReader.GetString(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Name_cs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Description.ToString())))
				{
					businessObject.Description = dataReader.GetString(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Description.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Name_value_prefijo.ToString())))
				{
					businessObject.Name_value_prefijo = dataReader.GetString(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Name_value_prefijo.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Value1.ToString())))
				{
					businessObject.Value1 = dataReader.GetDecimal(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Value1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Name_value_sufijo.ToString())))
				{
					businessObject.Name_value_sufijo = dataReader.GetString(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Name_value_sufijo.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Name_frec_prefijo.ToString())))
				{
					businessObject.Name_frec_prefijo = dataReader.GetString(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Name_frec_prefijo.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Frecuency.ToString())))
				{
					businessObject.Frecuency = dataReader.GetInt32(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Frecuency.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Name_frec_sufijo.ToString())))
				{
					businessObject.Name_frec_sufijo = dataReader.GetString(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Name_frec_sufijo.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Flag_frec_by_batch.ToString())))
				{
					businessObject.Flag_frec_by_batch = dataReader.GetBoolean(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Flag_frec_by_batch.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Flag_frec_by_sample.ToString())))
				{
					businessObject.Flag_frec_by_sample = dataReader.GetBoolean(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Flag_frec_by_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Priority.ToString())))
				{
					businessObject.Priority = dataReader.GetInt32(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Priority.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CControl_sample.CControl_sampleFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CControl_sample</returns>
        internal List<CControl_sample> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CControl_sample> list = new List<CControl_sample>();

            while (dataReader.Read())
            {
                CControl_sample businessObject = new CControl_sample();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
