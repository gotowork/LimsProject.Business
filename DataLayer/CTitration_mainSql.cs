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
	/// Data access layer class for CTitration_main
	/// </summary>
	partial class CTitration_mainSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CTitration_mainSql()
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
		public bool Insert(CTitration_main businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_titration_main_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idtitration_main", businessObject.Idtitration_main);
				sqlCommand.Parameters["p_idtitration_main"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_num_analyst", businessObject.Num_analyst);
				sqlCommand.Parameters["p_num_analyst"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_type_average", businessObject.Type_average);
				sqlCommand.Parameters["p_type_average"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_num_test", businessObject.Num_test);
				sqlCommand.Parameters["p_num_test"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_concentration_unit", businessObject.Concentration_unit);
				sqlCommand.Parameters["p_concentration_unit"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_concentration_value", businessObject.Concentration_value);
				sqlCommand.Parameters["p_concentration_value"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_factor", businessObject.Factor);
				sqlCommand.Parameters["p_factor"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idunit_measure_factor", businessObject.Idunit_measure_factor);
				sqlCommand.Parameters["p_idunit_measure_factor"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_status_process", businessObject.Status_process);
				sqlCommand.Parameters["p_status_process"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_analyst1", businessObject.Analyst1);
				sqlCommand.Parameters["p_analyst1"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_analyst1", businessObject.Date_analyst1);
				sqlCommand.Parameters["p_date_analyst1"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_analyst2", businessObject.Analyst2);
				sqlCommand.Parameters["p_analyst2"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_analyst2", businessObject.Date_analyst2);
				sqlCommand.Parameters["p_date_analyst2"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_analyst3", businessObject.Analyst3);
				sqlCommand.Parameters["p_analyst3"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_analyst3", businessObject.Date_analyst3);
				sqlCommand.Parameters["p_date_analyst3"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_analyst4", businessObject.Analyst4);
				sqlCommand.Parameters["p_analyst4"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_analyst4", businessObject.Date_analyst4);
				sqlCommand.Parameters["p_date_analyst4"].NpgsqlDbType = NpgsqlDbType.Timestamp;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                
				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CTitration_main::Insert::Error occured.", ex);
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
        public bool Update(CTitration_main businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_titration_main_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idtitration_main", businessObject.Idtitration_main);
				sqlCommand.Parameters["p_idtitration_main"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_num_analyst", businessObject.Num_analyst);
				sqlCommand.Parameters["p_num_analyst"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_type_average", businessObject.Type_average);
				sqlCommand.Parameters["p_type_average"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_num_test", businessObject.Num_test);
				sqlCommand.Parameters["p_num_test"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_concentration_unit", businessObject.Concentration_unit);
				sqlCommand.Parameters["p_concentration_unit"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_concentration_value", businessObject.Concentration_value);
				sqlCommand.Parameters["p_concentration_value"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_factor", businessObject.Factor);
				sqlCommand.Parameters["p_factor"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idunit_measure_factor", businessObject.Idunit_measure_factor);
				sqlCommand.Parameters["p_idunit_measure_factor"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_status_process", businessObject.Status_process);
				sqlCommand.Parameters["p_status_process"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_analyst1", businessObject.Analyst1);
				sqlCommand.Parameters["p_analyst1"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_analyst1", businessObject.Date_analyst1);
				sqlCommand.Parameters["p_date_analyst1"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_analyst2", businessObject.Analyst2);
				sqlCommand.Parameters["p_analyst2"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_analyst2", businessObject.Date_analyst2);
				sqlCommand.Parameters["p_date_analyst2"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_analyst3", businessObject.Analyst3);
				sqlCommand.Parameters["p_analyst3"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_analyst3", businessObject.Date_analyst3);
				sqlCommand.Parameters["p_date_analyst3"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_analyst4", businessObject.Analyst4);
				sqlCommand.Parameters["p_analyst4"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_analyst4", businessObject.Date_analyst4);
				sqlCommand.Parameters["p_date_analyst4"].NpgsqlDbType = NpgsqlDbType.Timestamp;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CTitration_main::Update::Error occured.", ex);
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
        /// <returns>CTitration_main business object</returns>
        public CTitration_main SelectByPrimaryKey(CTitration_mainKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_titration_main_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idtitration_main", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idtitration_main));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CTitration_main businessObject = new CTitration_main();

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
                throw new Exception("CTitration_main::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CTitration_main</returns>
        public List<CTitration_main> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_titration_main_SelectAll";
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
                throw new Exception("CTitration_main::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_titration_main_SelectAll";
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
                throw new Exception("CTitration_main::SelectAll::Error occured.", ex);
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
        /// <returns>list of CTitration_main</returns>
        public List<CTitration_main> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_titration_main_SelectByField";
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
                throw new Exception("CTitration_main::SelectByField::Error occured.", ex);
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
        public bool Delete(CTitration_mainKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_titration_main_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idtitration_main", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idtitration_main));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTitration_main::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_titration_main_DeleteByField";
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
                throw new Exception("CTitration_main::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CTitration_main businessObject, IDataReader dataReader)
        {


				businessObject.Idtitration_main = dataReader.GetInt32(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Idtitration_main.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Num_analyst.ToString())))
				{
					businessObject.Num_analyst = dataReader.GetInt32(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Num_analyst.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Type_average.ToString())))
				{
					businessObject.Type_average = dataReader.GetInt32(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Type_average.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Num_test.ToString())))
				{
					businessObject.Num_test = dataReader.GetInt32(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Num_test.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Concentration_unit.ToString())))
				{
					businessObject.Concentration_unit = dataReader.GetInt32(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Concentration_unit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Concentration_value.ToString())))
				{
					businessObject.Concentration_value = dataReader.GetDecimal(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Concentration_value.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Factor.ToString())))
				{
					businessObject.Factor = dataReader.GetDecimal(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Factor.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Idunit_measure_factor.ToString())))
				{
					businessObject.Idunit_measure_factor = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Idunit_measure_factor.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Status_process.ToString())))
				{
					businessObject.Status_process = dataReader.GetInt32(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Status_process.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Analyst1.ToString())))
				{
					businessObject.Analyst1 = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Analyst1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Date_analyst1.ToString())))
				{
					businessObject.Date_analyst1 = dataReader.GetDateTime(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Date_analyst1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Analyst2.ToString())))
				{
					businessObject.Analyst2 = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Analyst2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Date_analyst2.ToString())))
				{
					businessObject.Date_analyst2 = dataReader.GetDateTime(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Date_analyst2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Analyst3.ToString())))
				{
					businessObject.Analyst3 = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Analyst3.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Date_analyst3.ToString())))
				{
					businessObject.Date_analyst3 = dataReader.GetDateTime(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Date_analyst3.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Analyst4.ToString())))
				{
					businessObject.Analyst4 = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Analyst4.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Date_analyst4.ToString())))
				{
					businessObject.Date_analyst4 = dataReader.GetDateTime(dataReader.GetOrdinal(CTitration_main.CTitration_mainFields.Date_analyst4.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CTitration_main</returns>
        internal List<CTitration_main> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CTitration_main> list = new List<CTitration_main>();

            while (dataReader.Read())
            {
                CTitration_main businessObject = new CTitration_main();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
