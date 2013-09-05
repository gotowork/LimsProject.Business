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
	/// Data access layer class for CSolution_titration
	/// </summary>
	partial class CSolution_titrationSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CSolution_titrationSql()
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
		public bool Insert(CSolution_titration businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_solution_titration_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idsolution_titration", businessObject.Idsolution_titration);
				sqlCommand.Parameters["p_idsolution_titration"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idsolution_titration"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idtitration_main", businessObject.Idtitration_main);
				sqlCommand.Parameters["p_idtitration_main"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idsolution", businessObject.Idsolution);
				sqlCommand.Parameters["p_idsolution"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_aliquot", businessObject.Aliquot);
				sqlCommand.Parameters["p_aliquot"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_theorical_reading", businessObject.Theorical_reading);
				sqlCommand.Parameters["p_theorical_reading"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_practice_reading", businessObject.Practice_reading);
				sqlCommand.Parameters["p_practice_reading"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_factor", businessObject.Factor);
				sqlCommand.Parameters["p_factor"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_prepared_by", businessObject.Prepared_by);
				sqlCommand.Parameters["p_prepared_by"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_prepared", businessObject.Date_prepared);
				sqlCommand.Parameters["p_date_prepared"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_status_titration", businessObject.Status_titration);
				sqlCommand.Parameters["p_status_titration"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_average", businessObject.Average);
				sqlCommand.Parameters["p_average"].NpgsqlDbType = NpgsqlDbType.Numeric;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idsolution_titration = Convert.ToInt32(sqlCommand.Parameters["p_idsolution_titration"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CSolution_titration::Insert::Error occured.", ex);
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
        public bool Update(CSolution_titration businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_solution_titration_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idsolution_titration", businessObject.Idsolution_titration);
				sqlCommand.Parameters["p_idsolution_titration"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idtitration_main", businessObject.Idtitration_main);
				sqlCommand.Parameters["p_idtitration_main"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idsolution", businessObject.Idsolution);
				sqlCommand.Parameters["p_idsolution"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_aliquot", businessObject.Aliquot);
				sqlCommand.Parameters["p_aliquot"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_theorical_reading", businessObject.Theorical_reading);
				sqlCommand.Parameters["p_theorical_reading"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_practice_reading", businessObject.Practice_reading);
				sqlCommand.Parameters["p_practice_reading"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_factor", businessObject.Factor);
				sqlCommand.Parameters["p_factor"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_prepared_by", businessObject.Prepared_by);
				sqlCommand.Parameters["p_prepared_by"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_prepared", businessObject.Date_prepared);
				sqlCommand.Parameters["p_date_prepared"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_status_titration", businessObject.Status_titration);
				sqlCommand.Parameters["p_status_titration"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_average", businessObject.Average);
				sqlCommand.Parameters["p_average"].NpgsqlDbType = NpgsqlDbType.Numeric;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CSolution_titration::Update::Error occured.", ex);
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
        /// <returns>CSolution_titration business object</returns>
        public CSolution_titration SelectByPrimaryKey(CSolution_titrationKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_solution_titration_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idsolution_titration", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idsolution_titration));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CSolution_titration businessObject = new CSolution_titration();

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
                throw new Exception("CSolution_titration::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CSolution_titration</returns>
        public List<CSolution_titration> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_solution_titration_SelectAll";
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
                throw new Exception("CSolution_titration::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_solution_titration_SelectAll";
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
                throw new Exception("CSolution_titration::SelectAll::Error occured.", ex);
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
        /// <returns>list of CSolution_titration</returns>
        public List<CSolution_titration> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_solution_titration_SelectByField";
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
                throw new Exception("CSolution_titration::SelectByField::Error occured.", ex);
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
        public bool Delete(CSolution_titrationKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_solution_titration_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idsolution_titration", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idsolution_titration));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CSolution_titration::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_solution_titration_DeleteByField";
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
                throw new Exception("CSolution_titration::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CSolution_titration businessObject, IDataReader dataReader)
        {


				businessObject.Idsolution_titration = dataReader.GetInt32(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Idsolution_titration.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Idtitration_main.ToString())))
				{
					businessObject.Idtitration_main = dataReader.GetInt32(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Idtitration_main.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Idsolution.ToString())))
				{
					businessObject.Idsolution = dataReader.GetInt32(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Idsolution.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Aliquot.ToString())))
				{
					businessObject.Aliquot = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Aliquot.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Theorical_reading.ToString())))
				{
					businessObject.Theorical_reading = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Theorical_reading.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Practice_reading.ToString())))
				{
					businessObject.Practice_reading = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Practice_reading.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Factor.ToString())))
				{
					businessObject.Factor = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Factor.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Prepared_by.ToString())))
				{
					businessObject.Prepared_by = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Prepared_by.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Date_prepared.ToString())))
				{
					businessObject.Date_prepared = dataReader.GetDateTime(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Date_prepared.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Status_titration.ToString())))
				{
					businessObject.Status_titration = dataReader.GetBoolean(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Status_titration.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Average.ToString())))
				{
					businessObject.Average = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution_titration.CSolution_titrationFields.Average.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CSolution_titration</returns>
        internal List<CSolution_titration> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CSolution_titration> list = new List<CSolution_titration>();

            while (dataReader.Read())
            {
                CSolution_titration businessObject = new CSolution_titration();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
