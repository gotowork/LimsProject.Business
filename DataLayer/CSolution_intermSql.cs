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
	/// Data access layer class for CSolution_interm
	/// </summary>
	partial class CSolution_intermSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CSolution_intermSql()
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
		public bool Insert(CSolution_interm businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_solution_interm_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idsolution_interm", businessObject.Idsolution_interm);
				sqlCommand.Parameters["p_idsolution_interm"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idsolution_interm"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_id", businessObject.Id);
				sqlCommand.Parameters["p_id"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_parentid", businessObject.Parentid);
				sqlCommand.Parameters["p_parentid"].NpgsqlDbType = NpgsqlDbType.Integer;
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
				sqlCommand.Parameters.AddWithValue("p_root_type_pattern", businessObject.Root_type_pattern);
				sqlCommand.Parameters["p_root_type_pattern"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_root_idmr_detail", businessObject.Root_idmr_detail);
				sqlCommand.Parameters["p_root_idmr_detail"].NpgsqlDbType = NpgsqlDbType.Smallint;
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
                businessObject.Idsolution_interm = Convert.ToInt32(sqlCommand.Parameters["p_idsolution_interm"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CSolution_interm::Insert::Error occured.", ex);
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
        public bool Update(CSolution_interm businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_solution_interm_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idsolution_interm", businessObject.Idsolution_interm);
				sqlCommand.Parameters["p_idsolution_interm"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_id", businessObject.Id);
				sqlCommand.Parameters["p_id"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_parentid", businessObject.Parentid);
				sqlCommand.Parameters["p_parentid"].NpgsqlDbType = NpgsqlDbType.Integer;
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
				sqlCommand.Parameters.AddWithValue("p_root_type_pattern", businessObject.Root_type_pattern);
				sqlCommand.Parameters["p_root_type_pattern"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_root_idmr_detail", businessObject.Root_idmr_detail);
				sqlCommand.Parameters["p_root_idmr_detail"].NpgsqlDbType = NpgsqlDbType.Smallint;
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
                throw new Exception("CSolution_interm::Update::Error occured.", ex);
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
        /// <returns>CSolution_interm business object</returns>
        public CSolution_interm SelectByPrimaryKey(CSolution_intermKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_solution_interm_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idsolution_interm", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idsolution_interm));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CSolution_interm businessObject = new CSolution_interm();

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
                throw new Exception("CSolution_interm::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CSolution_interm</returns>
        public List<CSolution_interm> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_solution_interm_SelectAll";
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
                throw new Exception("CSolution_interm::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_solution_interm_SelectAll";
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
                throw new Exception("CSolution_interm::SelectAll::Error occured.", ex);
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
        /// <returns>list of CSolution_interm</returns>
        public List<CSolution_interm> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_solution_interm_SelectByField";
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
                throw new Exception("CSolution_interm::SelectByField::Error occured.", ex);
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
        public bool Delete(CSolution_intermKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_solution_interm_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idsolution_interm", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idsolution_interm));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CSolution_interm::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_solution_interm_DeleteByField";
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
                throw new Exception("CSolution_interm::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CSolution_interm businessObject, IDataReader dataReader)
        {


				businessObject.Idsolution_interm = dataReader.GetInt32(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Idsolution_interm.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Id.ToString())))
				{
					businessObject.Id = dataReader.GetInt32(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Id.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Parentid.ToString())))
				{
					businessObject.Parentid = dataReader.GetInt32(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Parentid.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Idelement.ToString())))
				{
					businessObject.Idelement = dataReader.GetInt32(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Idelement.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Cod_solution.ToString())))
				{
					businessObject.Cod_solution = dataReader.GetString(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Cod_solution.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Type_sol.ToString())))
				{
					businessObject.Type_sol = dataReader.GetInt32(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Type_sol.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Solution_name.ToString())))
				{
					businessObject.Solution_name = dataReader.GetString(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Solution_name.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Purity.ToString())))
				{
					businessObject.Purity = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Purity.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Concentration.ToString())))
				{
					businessObject.Concentration = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Concentration.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Aliquot.ToString())))
				{
					businessObject.Aliquot = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Aliquot.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Volumen.ToString())))
				{
					businessObject.Volumen = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Volumen.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Date_begin.ToString())))
				{
					businessObject.Date_begin = dataReader.GetDateTime(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Date_begin.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Date_end.ToString())))
				{
					businessObject.Date_end = dataReader.GetDateTime(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Date_end.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Num_months.ToString())))
				{
					businessObject.Num_months = dataReader.GetInt32(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Num_months.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Prepared_by.ToString())))
				{
					businessObject.Prepared_by = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Prepared_by.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Observation.ToString())))
				{
					businessObject.Observation = dataReader.GetString(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Observation.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Lote.ToString())))
				{
					businessObject.Lote = dataReader.GetString(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Lote.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Solution_status.ToString())))
				{
					businessObject.Solution_status = dataReader.GetBoolean(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Solution_status.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Root_type_pattern.ToString())))
				{
					businessObject.Root_type_pattern = dataReader.GetInt32(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Root_type_pattern.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Root_idmr_detail.ToString())))
				{
					businessObject.Root_idmr_detail = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Root_idmr_detail.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Idreactive_medium.ToString())))
				{
					businessObject.Idreactive_medium = dataReader.GetInt32(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Idreactive_medium.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Reactive_medium_value.ToString())))
				{
					businessObject.Reactive_medium_value = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Reactive_medium_value.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Idreactive_modif.ToString())))
				{
					businessObject.Idreactive_modif = dataReader.GetInt32(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Idreactive_modif.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Reactive_modif_value.ToString())))
				{
					businessObject.Reactive_modif_value = dataReader.GetDecimal(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Reactive_modif_value.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Concat_cod_methods.ToString())))
				{
					businessObject.Concat_cod_methods = dataReader.GetString(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Concat_cod_methods.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Image_index.ToString())))
				{
					businessObject.Image_index = dataReader.GetInt32(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Image_index.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CSolution_interm.CSolution_intermFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CSolution_interm</returns>
        internal List<CSolution_interm> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CSolution_interm> list = new List<CSolution_interm>();

            while (dataReader.Read())
            {
                CSolution_interm businessObject = new CSolution_interm();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
