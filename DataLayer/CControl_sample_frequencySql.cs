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
	/// Data access layer class for CControl_sample_frequency
	/// </summary>
	partial class CControl_sample_frequencySql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CControl_sample_frequencySql()
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
		public bool Insert(CControl_sample_frequency businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_control_sample_frequency_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idcontrol_sample_frequency", businessObject.Idcontrol_sample_frequency);
				sqlCommand.Parameters["p_idcontrol_sample_frequency"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idcontrol_sample_frequency"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idtype_sample_control", businessObject.Idtype_sample_control);
				sqlCommand.Parameters["p_idtype_sample_control"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_type_analisys", businessObject.Type_analisys);
				sqlCommand.Parameters["p_type_analisys"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_name_frequency", businessObject.Name_frequency);
				sqlCommand.Parameters["p_name_frequency"].NpgsqlDbType = NpgsqlDbType.Varchar;
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
                businessObject.Idcontrol_sample_frequency = Convert.ToInt32(sqlCommand.Parameters["p_idcontrol_sample_frequency"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CControl_sample_frequency::Insert::Error occured.", ex);
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
        public bool Update(CControl_sample_frequency businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_control_sample_frequency_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idcontrol_sample_frequency", businessObject.Idcontrol_sample_frequency);
				sqlCommand.Parameters["p_idcontrol_sample_frequency"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idtype_sample_control", businessObject.Idtype_sample_control);
				sqlCommand.Parameters["p_idtype_sample_control"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_type_analisys", businessObject.Type_analisys);
				sqlCommand.Parameters["p_type_analisys"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_name_frequency", businessObject.Name_frequency);
				sqlCommand.Parameters["p_name_frequency"].NpgsqlDbType = NpgsqlDbType.Varchar;
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
                throw new Exception("CControl_sample_frequency::Update::Error occured.", ex);
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
        /// <returns>CControl_sample_frequency business object</returns>
        public CControl_sample_frequency SelectByPrimaryKey(CControl_sample_frequencyKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_control_sample_frequency_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idcontrol_sample_frequency", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idcontrol_sample_frequency));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CControl_sample_frequency businessObject = new CControl_sample_frequency();

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
                throw new Exception("CControl_sample_frequency::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CControl_sample_frequency</returns>
        public List<CControl_sample_frequency> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_control_sample_frequency_SelectAll";
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
                throw new Exception("CControl_sample_frequency::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_control_sample_frequency_SelectAll";
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
                throw new Exception("CControl_sample_frequency::SelectAll::Error occured.", ex);
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
        /// <returns>list of CControl_sample_frequency</returns>
        public List<CControl_sample_frequency> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_control_sample_frequency_SelectByField";
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
                throw new Exception("CControl_sample_frequency::SelectByField::Error occured.", ex);
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
        public bool Delete(CControl_sample_frequencyKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_control_sample_frequency_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idcontrol_sample_frequency", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idcontrol_sample_frequency));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CControl_sample_frequency::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_control_sample_frequency_DeleteByField";
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
                throw new Exception("CControl_sample_frequency::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CControl_sample_frequency businessObject, IDataReader dataReader)
        {


				businessObject.Idcontrol_sample_frequency = dataReader.GetInt32(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Idcontrol_sample_frequency.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Idtype_sample_control.ToString())))
				{
					businessObject.Idtype_sample_control = dataReader.GetInt32(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Idtype_sample_control.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Idtemplate_method.ToString())))
				{
					businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Idtemplate_method.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Type_analisys.ToString())))
				{
					businessObject.Type_analisys = dataReader.GetInt32(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Type_analisys.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Name_frequency.ToString())))
				{
					businessObject.Name_frequency = dataReader.GetString(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Name_frequency.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Name_frec_prefijo.ToString())))
				{
					businessObject.Name_frec_prefijo = dataReader.GetString(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Name_frec_prefijo.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Frecuency.ToString())))
				{
					businessObject.Frecuency = dataReader.GetInt32(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Frecuency.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Name_frec_sufijo.ToString())))
				{
					businessObject.Name_frec_sufijo = dataReader.GetString(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Name_frec_sufijo.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Flag_frec_by_batch.ToString())))
				{
					businessObject.Flag_frec_by_batch = dataReader.GetBoolean(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Flag_frec_by_batch.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Flag_frec_by_sample.ToString())))
				{
					businessObject.Flag_frec_by_sample = dataReader.GetBoolean(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Flag_frec_by_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Priority.ToString())))
				{
					businessObject.Priority = dataReader.GetInt32(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Priority.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CControl_sample_frequency.CControl_sample_frequencyFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CControl_sample_frequency</returns>
        internal List<CControl_sample_frequency> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CControl_sample_frequency> list = new List<CControl_sample_frequency>();

            while (dataReader.Read())
            {
                CControl_sample_frequency businessObject = new CControl_sample_frequency();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
