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
	/// Data access layer class for CMethods_multi
	/// </summary>
	partial class CMethods_multiSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CMethods_multiSql()
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
		public bool Insert(CMethods_multi businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_methods_multi_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_id", businessObject.Id);
				sqlCommand.Parameters["p_id"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_id"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_elemento_longitud", businessObject.Elemento_longitud);
				sqlCommand.Parameters["p_elemento_longitud"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_elemento", businessObject.Elemento);
				sqlCommand.Parameters["p_elemento"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_prioridad", businessObject.Prioridad);
				sqlCommand.Parameters["p_prioridad"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_longitud", businessObject.Longitud);
				sqlCommand.Parameters["p_longitud"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idl", businessObject.Idl);
				sqlCommand.Parameters["p_idl"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_mdl", businessObject.Mdl);
				sqlCommand.Parameters["p_mdl"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_linealidad", businessObject.Linealidad);
				sqlCommand.Parameters["p_linealidad"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_num_decimal", businessObject.Num_decimal);
				sqlCommand.Parameters["p_num_decimal"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std1", businessObject.Std1);
				sqlCommand.Parameters["p_std1"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std2", businessObject.Std2);
				sqlCommand.Parameters["p_std2"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_ipc", businessObject.Ipc);
				sqlCommand.Parameters["p_ipc"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_lfb", businessObject.Lfb);
				sqlCommand.Parameters["p_lfb"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_lfm", businessObject.Lfm);
				sqlCommand.Parameters["p_lfm"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_limite_inferior_md", businessObject.Limite_inferior_md);
				sqlCommand.Parameters["p_limite_inferior_md"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_limite_inferior_mt", businessObject.Limite_inferior_mt);
				sqlCommand.Parameters["p_limite_inferior_mt"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_limite_superior", businessObject.Limite_superior);
				sqlCommand.Parameters["p_limite_superior"].NpgsqlDbType = NpgsqlDbType.Numeric;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Id = Convert.ToInt32(sqlCommand.Parameters["p_id"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CMethods_multi::Insert::Error occured.", ex);
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
        public bool Update(CMethods_multi businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_methods_multi_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_id", businessObject.Id);
				sqlCommand.Parameters["p_id"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_elemento_longitud", businessObject.Elemento_longitud);
				sqlCommand.Parameters["p_elemento_longitud"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_elemento", businessObject.Elemento);
				sqlCommand.Parameters["p_elemento"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_prioridad", businessObject.Prioridad);
				sqlCommand.Parameters["p_prioridad"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_longitud", businessObject.Longitud);
				sqlCommand.Parameters["p_longitud"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idl", businessObject.Idl);
				sqlCommand.Parameters["p_idl"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_mdl", businessObject.Mdl);
				sqlCommand.Parameters["p_mdl"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_linealidad", businessObject.Linealidad);
				sqlCommand.Parameters["p_linealidad"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_num_decimal", businessObject.Num_decimal);
				sqlCommand.Parameters["p_num_decimal"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std1", businessObject.Std1);
				sqlCommand.Parameters["p_std1"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_std2", businessObject.Std2);
				sqlCommand.Parameters["p_std2"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_ipc", businessObject.Ipc);
				sqlCommand.Parameters["p_ipc"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_lfb", businessObject.Lfb);
				sqlCommand.Parameters["p_lfb"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_lfm", businessObject.Lfm);
				sqlCommand.Parameters["p_lfm"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_limite_inferior_md", businessObject.Limite_inferior_md);
				sqlCommand.Parameters["p_limite_inferior_md"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_limite_inferior_mt", businessObject.Limite_inferior_mt);
				sqlCommand.Parameters["p_limite_inferior_mt"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_limite_superior", businessObject.Limite_superior);
				sqlCommand.Parameters["p_limite_superior"].NpgsqlDbType = NpgsqlDbType.Numeric;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CMethods_multi::Update::Error occured.", ex);
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
        /// <returns>CMethods_multi business object</returns>
        public CMethods_multi SelectByPrimaryKey(CMethods_multiKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_methods_multi_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_id", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Id));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CMethods_multi businessObject = new CMethods_multi();

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
                throw new Exception("CMethods_multi::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CMethods_multi</returns>
        public List<CMethods_multi> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_methods_multi_SelectAll";
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
                throw new Exception("CMethods_multi::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_methods_multi_SelectAll";
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
                throw new Exception("CMethods_multi::SelectAll::Error occured.", ex);
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
        /// <returns>list of CMethods_multi</returns>
        public List<CMethods_multi> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_methods_multi_SelectByField";
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
                throw new Exception("CMethods_multi::SelectByField::Error occured.", ex);
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
        public bool Delete(CMethods_multiKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_methods_multi_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_id", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Id));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CMethods_multi::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_methods_multi_DeleteByField";
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
                throw new Exception("CMethods_multi::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CMethods_multi businessObject, IDataReader dataReader)
        {


				businessObject.Id = dataReader.GetInt32(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Id.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Elemento_longitud.ToString())))
				{
					businessObject.Elemento_longitud = dataReader.GetString(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Elemento_longitud.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Elemento.ToString())))
				{
					businessObject.Elemento = dataReader.GetString(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Elemento.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Prioridad.ToString())))
				{
					businessObject.Prioridad = dataReader.GetInt32(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Prioridad.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Longitud.ToString())))
				{
					businessObject.Longitud = dataReader.GetDecimal(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Longitud.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Idl.ToString())))
				{
					businessObject.Idl = dataReader.GetDecimal(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Idl.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Mdl.ToString())))
				{
					businessObject.Mdl = dataReader.GetDecimal(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Mdl.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Linealidad.ToString())))
				{
					businessObject.Linealidad = dataReader.GetDecimal(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Linealidad.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Num_decimal.ToString())))
				{
					businessObject.Num_decimal = dataReader.GetDecimal(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Num_decimal.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Std1.ToString())))
				{
					businessObject.Std1 = dataReader.GetDecimal(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Std1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Std2.ToString())))
				{
					businessObject.Std2 = dataReader.GetDecimal(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Std2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Ipc.ToString())))
				{
					businessObject.Ipc = dataReader.GetDecimal(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Ipc.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Lfb.ToString())))
				{
					businessObject.Lfb = dataReader.GetDecimal(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Lfb.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Lfm.ToString())))
				{
					businessObject.Lfm = dataReader.GetDecimal(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Lfm.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Limite_inferior_md.ToString())))
				{
					businessObject.Limite_inferior_md = dataReader.GetDecimal(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Limite_inferior_md.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Limite_inferior_mt.ToString())))
				{
					businessObject.Limite_inferior_mt = dataReader.GetDecimal(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Limite_inferior_mt.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Limite_superior.ToString())))
				{
					businessObject.Limite_superior = dataReader.GetDecimal(dataReader.GetOrdinal(CMethods_multi.CMethods_multiFields.Limite_superior.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CMethods_multi</returns>
        internal List<CMethods_multi> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CMethods_multi> list = new List<CMethods_multi>();

            while (dataReader.Read())
            {
                CMethods_multi businessObject = new CMethods_multi();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
