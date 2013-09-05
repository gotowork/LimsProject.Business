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
	/// Data access layer class for CGroup_solution
	/// </summary>
	partial class CGroup_solutionSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CGroup_solutionSql()
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
		public bool Insert(CGroup_solution businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_group_solution_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idgroup_solution", businessObject.Idgroup_solution);
				sqlCommand.Parameters["p_idgroup_solution"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idgroup_solution"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_cod_solution", businessObject.Cod_solution);
				sqlCommand.Parameters["p_cod_solution"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idelement", businessObject.Idelement);
				sqlCommand.Parameters["p_idelement"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idmr_detail", businessObject.Idmr_detail);
				sqlCommand.Parameters["p_idmr_detail"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idreactive_medium", businessObject.Idreactive_medium);
				sqlCommand.Parameters["p_idreactive_medium"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idreactive_modif", businessObject.Idreactive_modif);
				sqlCommand.Parameters["p_idreactive_modif"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_type_solution", businessObject.Type_solution);
				sqlCommand.Parameters["p_type_solution"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_type_pattern", businessObject.Type_pattern);
				sqlCommand.Parameters["p_type_pattern"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_flag_selected_methods", businessObject.Flag_selected_methods);
				sqlCommand.Parameters["p_flag_selected_methods"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_user_sign_calib", businessObject.User_sign_calib);
				sqlCommand.Parameters["p_user_sign_calib"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_sign_calib", businessObject.Date_sign_calib);
				sqlCommand.Parameters["p_date_sign_calib"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_flag_sign_calib", businessObject.Flag_sign_calib);
				sqlCommand.Parameters["p_flag_sign_calib"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_close_calib", businessObject.Flag_close_calib);
				sqlCommand.Parameters["p_flag_close_calib"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_idgroup_solution_previus", businessObject.Idgroup_solution_previus);
				sqlCommand.Parameters["p_idgroup_solution_previus"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_date_ini", businessObject.Date_ini);
				sqlCommand.Parameters["p_date_ini"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_date_end", businessObject.Date_end);
				sqlCommand.Parameters["p_date_end"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_flag_sol_intermedia1", businessObject.Flag_sol_intermedia1);
				sqlCommand.Parameters["p_flag_sol_intermedia1"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_sol_intermedia2", businessObject.Flag_sol_intermedia2);
				sqlCommand.Parameters["p_flag_sol_intermedia2"].NpgsqlDbType = NpgsqlDbType.Boolean;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idgroup_solution = Convert.ToInt32(sqlCommand.Parameters["p_idgroup_solution"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CGroup_solution::Insert::Error occured.", ex);
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
        public bool Update(CGroup_solution businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_group_solution_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idgroup_solution", businessObject.Idgroup_solution);
				sqlCommand.Parameters["p_idgroup_solution"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_cod_solution", businessObject.Cod_solution);
				sqlCommand.Parameters["p_cod_solution"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idelement", businessObject.Idelement);
				sqlCommand.Parameters["p_idelement"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idmr_detail", businessObject.Idmr_detail);
				sqlCommand.Parameters["p_idmr_detail"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idreactive_medium", businessObject.Idreactive_medium);
				sqlCommand.Parameters["p_idreactive_medium"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idreactive_modif", businessObject.Idreactive_modif);
				sqlCommand.Parameters["p_idreactive_modif"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_type_solution", businessObject.Type_solution);
				sqlCommand.Parameters["p_type_solution"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_type_pattern", businessObject.Type_pattern);
				sqlCommand.Parameters["p_type_pattern"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_flag_selected_methods", businessObject.Flag_selected_methods);
				sqlCommand.Parameters["p_flag_selected_methods"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_user_sign_calib", businessObject.User_sign_calib);
				sqlCommand.Parameters["p_user_sign_calib"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_date_sign_calib", businessObject.Date_sign_calib);
				sqlCommand.Parameters["p_date_sign_calib"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_flag_sign_calib", businessObject.Flag_sign_calib);
				sqlCommand.Parameters["p_flag_sign_calib"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_close_calib", businessObject.Flag_close_calib);
				sqlCommand.Parameters["p_flag_close_calib"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_idgroup_solution_previus", businessObject.Idgroup_solution_previus);
				sqlCommand.Parameters["p_idgroup_solution_previus"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_date_ini", businessObject.Date_ini);
				sqlCommand.Parameters["p_date_ini"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_date_end", businessObject.Date_end);
				sqlCommand.Parameters["p_date_end"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_flag_sol_intermedia1", businessObject.Flag_sol_intermedia1);
				sqlCommand.Parameters["p_flag_sol_intermedia1"].NpgsqlDbType = NpgsqlDbType.Boolean;
				sqlCommand.Parameters.AddWithValue("p_flag_sol_intermedia2", businessObject.Flag_sol_intermedia2);
				sqlCommand.Parameters["p_flag_sol_intermedia2"].NpgsqlDbType = NpgsqlDbType.Boolean;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CGroup_solution::Update::Error occured.", ex);
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
        /// <returns>CGroup_solution business object</returns>
        public CGroup_solution SelectByPrimaryKey(CGroup_solutionKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_group_solution_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idgroup_solution", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idgroup_solution));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CGroup_solution businessObject = new CGroup_solution();

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
                throw new Exception("CGroup_solution::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CGroup_solution</returns>
        public List<CGroup_solution> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_group_solution_SelectAll";
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
                throw new Exception("CGroup_solution::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_group_solution_SelectAll";
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
                throw new Exception("CGroup_solution::SelectAll::Error occured.", ex);
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
        /// <returns>list of CGroup_solution</returns>
        public List<CGroup_solution> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_group_solution_SelectByField";
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
                throw new Exception("CGroup_solution::SelectByField::Error occured.", ex);
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
        public bool Delete(CGroup_solutionKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_group_solution_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idgroup_solution", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idgroup_solution));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CGroup_solution::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_group_solution_DeleteByField";
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
                throw new Exception("CGroup_solution::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CGroup_solution businessObject, IDataReader dataReader)
        {


				businessObject.Idgroup_solution = dataReader.GetInt32(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Idgroup_solution.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Cod_solution.ToString())))
				{
					businessObject.Cod_solution = dataReader.GetString(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Cod_solution.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Idelement.ToString())))
				{
					businessObject.Idelement = dataReader.GetInt32(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Idelement.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Idmr_detail.ToString())))
				{
					businessObject.Idmr_detail = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Idmr_detail.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Idreactive_medium.ToString())))
				{
					businessObject.Idreactive_medium = dataReader.GetInt32(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Idreactive_medium.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Idreactive_modif.ToString())))
				{
					businessObject.Idreactive_modif = dataReader.GetInt32(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Idreactive_modif.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Idtemplate_method.ToString())))
				{
					businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Idtemplate_method.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Type_solution.ToString())))
				{
					businessObject.Type_solution = dataReader.GetInt32(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Type_solution.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Type_pattern.ToString())))
				{
					businessObject.Type_pattern = dataReader.GetInt32(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Type_pattern.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Flag_selected_methods.ToString())))
				{
					businessObject.Flag_selected_methods = dataReader.GetBoolean(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Flag_selected_methods.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.User_sign_calib.ToString())))
				{
					businessObject.User_sign_calib = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.User_sign_calib.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Date_sign_calib.ToString())))
				{
					businessObject.Date_sign_calib = dataReader.GetDateTime(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Date_sign_calib.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Flag_sign_calib.ToString())))
				{
					businessObject.Flag_sign_calib = dataReader.GetBoolean(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Flag_sign_calib.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Flag_close_calib.ToString())))
				{
					businessObject.Flag_close_calib = dataReader.GetBoolean(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Flag_close_calib.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Idgroup_solution_previus.ToString())))
				{
					businessObject.Idgroup_solution_previus = dataReader.GetInt32(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Idgroup_solution_previus.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Date_ini.ToString())))
				{
					businessObject.Date_ini = dataReader.GetDateTime(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Date_ini.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Date_end.ToString())))
				{
					businessObject.Date_end = dataReader.GetDateTime(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Date_end.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Flag_sol_intermedia1.ToString())))
				{
					businessObject.Flag_sol_intermedia1 = dataReader.GetBoolean(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Flag_sol_intermedia1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Flag_sol_intermedia2.ToString())))
				{
					businessObject.Flag_sol_intermedia2 = dataReader.GetBoolean(dataReader.GetOrdinal(CGroup_solution.CGroup_solutionFields.Flag_sol_intermedia2.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CGroup_solution</returns>
        internal List<CGroup_solution> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CGroup_solution> list = new List<CGroup_solution>();

            while (dataReader.Read())
            {
                CGroup_solution businessObject = new CGroup_solution();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
