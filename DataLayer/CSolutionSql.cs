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
	/// Data access layer class for CSolution
	/// </summary>
	partial class CSolutionSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CSolutionSql()
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
		public bool Insert(CSolution businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_solution_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idsolution", businessObject.Idsolution);
				sqlCommand.Parameters["p_idsolution"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idsolution"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_id", businessObject.Id);
				sqlCommand.Parameters["p_id"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_parentid", businessObject.Parentid);
				sqlCommand.Parameters["p_parentid"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idgroup_solution", businessObject.Idgroup_solution);
				sqlCommand.Parameters["p_idgroup_solution"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idelement", businessObject.Idelement);
				sqlCommand.Parameters["p_idelement"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_cod_solution", businessObject.Cod_solution);
				sqlCommand.Parameters["p_cod_solution"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_type_sol", businessObject.Type_sol);
				sqlCommand.Parameters["p_type_sol"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_solution_name", businessObject.Solution_name);
				sqlCommand.Parameters["p_solution_name"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_purity", businessObject.Purity);
				sqlCommand.Parameters["p_purity"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_concentration", businessObject.Concentration);
				sqlCommand.Parameters["p_concentration"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_aliquot", businessObject.Aliquot);
				sqlCommand.Parameters["p_aliquot"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_volumen", businessObject.Volumen);
				sqlCommand.Parameters["p_volumen"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_date_begin", businessObject.Date_begin);
				sqlCommand.Parameters["p_date_begin"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_date_end", businessObject.Date_end);
				sqlCommand.Parameters["p_date_end"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_num_months", businessObject.Num_months);
				sqlCommand.Parameters["p_num_months"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_prepared_by", businessObject.Prepared_by);
				sqlCommand.Parameters["p_prepared_by"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_observation", businessObject.Observation);
				sqlCommand.Parameters["p_observation"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_lote", businessObject.Lote);
				sqlCommand.Parameters["p_lote"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_solution_status", businessObject.Solution_status);
				sqlCommand.Parameters["p_solution_status"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_idreactive_medium", businessObject.Idreactive_medium);
				sqlCommand.Parameters["p_idreactive_medium"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_reactive_medium_value", businessObject.Reactive_medium_value);
				sqlCommand.Parameters["p_reactive_medium_value"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idreactive_modif", businessObject.Idreactive_modif);
				sqlCommand.Parameters["p_idreactive_modif"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_reactive_modif_value", businessObject.Reactive_modif_value);
				sqlCommand.Parameters["p_reactive_modif_value"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_concat_cod_methods", businessObject.Concat_cod_methods);
				sqlCommand.Parameters["p_concat_cod_methods"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_image_index", businessObject.Image_index);
				sqlCommand.Parameters["p_image_index"].NpgsqlDbType = NpgsqlDbType.Integer;
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
                businessObject.Idsolution = Convert.ToInt32(sqlCommand.Parameters["p_idsolution"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CSolution::Insert::Error occured.", ex);
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
        public bool Update(CSolution businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_solution_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idsolution", businessObject.Idsolution);
				sqlCommand.Parameters["p_idsolution"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_id", businessObject.Id);
				sqlCommand.Parameters["p_id"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_parentid", businessObject.Parentid);
				sqlCommand.Parameters["p_parentid"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idgroup_solution", businessObject.Idgroup_solution);
				sqlCommand.Parameters["p_idgroup_solution"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idelement", businessObject.Idelement);
				sqlCommand.Parameters["p_idelement"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_cod_solution", businessObject.Cod_solution);
				sqlCommand.Parameters["p_cod_solution"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_type_sol", businessObject.Type_sol);
				sqlCommand.Parameters["p_type_sol"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_solution_name", businessObject.Solution_name);
				sqlCommand.Parameters["p_solution_name"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_purity", businessObject.Purity);
				sqlCommand.Parameters["p_purity"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_concentration", businessObject.Concentration);
				sqlCommand.Parameters["p_concentration"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_aliquot", businessObject.Aliquot);
				sqlCommand.Parameters["p_aliquot"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_volumen", businessObject.Volumen);
				sqlCommand.Parameters["p_volumen"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_date_begin", businessObject.Date_begin);
				sqlCommand.Parameters["p_date_begin"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_date_end", businessObject.Date_end);
				sqlCommand.Parameters["p_date_end"].NpgsqlDbType = NpgsqlDbType.Date;
				sqlCommand.Parameters.AddWithValue("p_num_months", businessObject.Num_months);
				sqlCommand.Parameters["p_num_months"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_prepared_by", businessObject.Prepared_by);
				sqlCommand.Parameters["p_prepared_by"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_observation", businessObject.Observation);
				sqlCommand.Parameters["p_observation"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_lote", businessObject.Lote);
				sqlCommand.Parameters["p_lote"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_solution_status", businessObject.Solution_status);
				sqlCommand.Parameters["p_solution_status"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_idreactive_medium", businessObject.Idreactive_medium);
				sqlCommand.Parameters["p_idreactive_medium"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_reactive_medium_value", businessObject.Reactive_medium_value);
				sqlCommand.Parameters["p_reactive_medium_value"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idreactive_modif", businessObject.Idreactive_modif);
				sqlCommand.Parameters["p_idreactive_modif"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_reactive_modif_value", businessObject.Reactive_modif_value);
				sqlCommand.Parameters["p_reactive_modif_value"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_concat_cod_methods", businessObject.Concat_cod_methods);
				sqlCommand.Parameters["p_concat_cod_methods"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_image_index", businessObject.Image_index);
				sqlCommand.Parameters["p_image_index"].NpgsqlDbType = NpgsqlDbType.Integer;
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
                throw new Exception("CSolution::Update::Error occured.", ex);
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
        /// <returns>CSolution business object</returns>
        public CSolution SelectByPrimaryKey(CSolutionKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_solution_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idsolution", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idsolution));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CSolution businessObject = new CSolution();

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
                throw new Exception("CSolution::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CSolution</returns>
        public List<CSolution> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_solution_SelectAll";
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
                throw new Exception("CSolution::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_solution_SelectAll";
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
                throw new Exception("CSolution::SelectAll::Error occured.", ex);
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
        /// <returns>list of CSolution</returns>
        public List<CSolution> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_solution_SelectByField";
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
                throw new Exception("CSolution::SelectByField::Error occured.", ex);
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
        public bool Delete(CSolutionKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_solution_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idsolution", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idsolution));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CSolution::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_solution_DeleteByField";
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
                throw new Exception("CSolution::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CSolution businessObject, IDataReader dataReader)
        {


				businessObject.Idsolution = dataReader.GetInt32(dataReader.GetOrdinal(CSolution.CSolutionFields.Idsolution.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Id.ToString())))
				{
					businessObject.Id = dataReader.GetInt32(dataReader.GetOrdinal(CSolution.CSolutionFields.Id.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Parentid.ToString())))
				{
					businessObject.Parentid = dataReader.GetInt32(dataReader.GetOrdinal(CSolution.CSolutionFields.Parentid.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Idgroup_solution.ToString())))
				{
					businessObject.Idgroup_solution = dataReader.GetInt32(dataReader.GetOrdinal(CSolution.CSolutionFields.Idgroup_solution.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Idelement.ToString())))
				{
					businessObject.Idelement = dataReader.GetInt32(dataReader.GetOrdinal(CSolution.CSolutionFields.Idelement.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Cod_solution.ToString())))
				{
					businessObject.Cod_solution = dataReader.GetString(dataReader.GetOrdinal(CSolution.CSolutionFields.Cod_solution.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Type_sol.ToString())))
				{
					businessObject.Type_sol = dataReader.GetInt32(dataReader.GetOrdinal(CSolution.CSolutionFields.Type_sol.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Solution_name.ToString())))
				{
					businessObject.Solution_name = dataReader.GetString(dataReader.GetOrdinal(CSolution.CSolutionFields.Solution_name.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Purity.ToString())))
				{
					businessObject.Purity = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution.CSolutionFields.Purity.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Concentration.ToString())))
				{
					businessObject.Concentration = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution.CSolutionFields.Concentration.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Aliquot.ToString())))
				{
					businessObject.Aliquot = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution.CSolutionFields.Aliquot.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Volumen.ToString())))
				{
					businessObject.Volumen = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution.CSolutionFields.Volumen.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Date_begin.ToString())))
				{
					businessObject.Date_begin = dataReader.GetDateTime(dataReader.GetOrdinal(CSolution.CSolutionFields.Date_begin.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Date_end.ToString())))
				{
					businessObject.Date_end = dataReader.GetDateTime(dataReader.GetOrdinal(CSolution.CSolutionFields.Date_end.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Num_months.ToString())))
				{
					businessObject.Num_months = dataReader.GetInt32(dataReader.GetOrdinal(CSolution.CSolutionFields.Num_months.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Prepared_by.ToString())))
				{
					businessObject.Prepared_by = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CSolution.CSolutionFields.Prepared_by.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Observation.ToString())))
				{
					businessObject.Observation = dataReader.GetString(dataReader.GetOrdinal(CSolution.CSolutionFields.Observation.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Lote.ToString())))
				{
					businessObject.Lote = dataReader.GetString(dataReader.GetOrdinal(CSolution.CSolutionFields.Lote.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Solution_status.ToString())))
				{
					businessObject.Solution_status = dataReader.GetBoolean(dataReader.GetOrdinal(CSolution.CSolutionFields.Solution_status.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Idreactive_medium.ToString())))
				{
					businessObject.Idreactive_medium = dataReader.GetInt32(dataReader.GetOrdinal(CSolution.CSolutionFields.Idreactive_medium.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Reactive_medium_value.ToString())))
				{
					businessObject.Reactive_medium_value = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution.CSolutionFields.Reactive_medium_value.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Idreactive_modif.ToString())))
				{
					businessObject.Idreactive_modif = dataReader.GetInt32(dataReader.GetOrdinal(CSolution.CSolutionFields.Idreactive_modif.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Reactive_modif_value.ToString())))
				{
					businessObject.Reactive_modif_value = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution.CSolutionFields.Reactive_modif_value.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Concat_cod_methods.ToString())))
				{
					businessObject.Concat_cod_methods = dataReader.GetString(dataReader.GetOrdinal(CSolution.CSolutionFields.Concat_cod_methods.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Image_index.ToString())))
				{
					businessObject.Image_index = dataReader.GetInt32(dataReader.GetOrdinal(CSolution.CSolutionFields.Image_index.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CSolution.CSolutionFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CSolution.CSolutionFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CSolution.CSolutionFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CSolution.CSolutionFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution.CSolutionFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CSolution.CSolutionFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CSolution</returns>
        internal List<CSolution> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CSolution> list = new List<CSolution>();

            while (dataReader.Read())
            {
                CSolution businessObject = new CSolution();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
