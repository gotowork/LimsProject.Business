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
	/// Data access layer class for CIcp_lecturas
	/// </summary>
	partial class CIcp_lecturasSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CIcp_lecturasSql()
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
		public bool Insert(CIcp_lecturas businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_icp_lecturas_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_id", businessObject.Id);
				sqlCommand.Parameters["p_id"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_id"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_calibracion", businessObject.Calibracion);
				sqlCommand.Parameters["p_calibracion"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_elemento", businessObject.Elemento);
				sqlCommand.Parameters["p_elemento"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idmuestra", businessObject.Idmuestra);
				sqlCommand.Parameters["p_idmuestra"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_muestra", businessObject.Muestra);
				sqlCommand.Parameters["p_muestra"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_lectura", businessObject.Lectura);
				sqlCommand.Parameters["p_lectura"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dilucion2", businessObject.Dilucion2);
				sqlCommand.Parameters["p_dilucion2"].NpgsqlDbType = NpgsqlDbType.Varchar;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Id = Convert.ToInt32(sqlCommand.Parameters["p_id"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CIcp_lecturas::Insert::Error occured.", ex);
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
        public bool Update(CIcp_lecturas businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_icp_lecturas_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_id", businessObject.Id);
				sqlCommand.Parameters["p_id"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_calibracion", businessObject.Calibracion);
				sqlCommand.Parameters["p_calibracion"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_elemento", businessObject.Elemento);
				sqlCommand.Parameters["p_elemento"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idmuestra", businessObject.Idmuestra);
				sqlCommand.Parameters["p_idmuestra"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_muestra", businessObject.Muestra);
				sqlCommand.Parameters["p_muestra"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_lectura", businessObject.Lectura);
				sqlCommand.Parameters["p_lectura"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dilucion2", businessObject.Dilucion2);
				sqlCommand.Parameters["p_dilucion2"].NpgsqlDbType = NpgsqlDbType.Varchar;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CIcp_lecturas::Update::Error occured.", ex);
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
        /// <returns>CIcp_lecturas business object</returns>
        public CIcp_lecturas SelectByPrimaryKey(CIcp_lecturasKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_icp_lecturas_SelectByPrimaryKey";
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
                    CIcp_lecturas businessObject = new CIcp_lecturas();

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
                throw new Exception("CIcp_lecturas::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CIcp_lecturas</returns>
        public List<CIcp_lecturas> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_icp_lecturas_SelectAll";
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
                throw new Exception("CIcp_lecturas::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_icp_lecturas_SelectAll";
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
                throw new Exception("CIcp_lecturas::SelectAll::Error occured.", ex);
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
        /// <returns>list of CIcp_lecturas</returns>
        public List<CIcp_lecturas> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_icp_lecturas_SelectByField";
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
                throw new Exception("CIcp_lecturas::SelectByField::Error occured.", ex);
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
        public bool Delete(CIcp_lecturasKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_icp_lecturas_DeleteByPrimaryKey";
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
                throw new Exception("CIcp_lecturas::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_icp_lecturas_DeleteByField";
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
                throw new Exception("CIcp_lecturas::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CIcp_lecturas businessObject, IDataReader dataReader)
        {


				businessObject.Id = dataReader.GetInt32(dataReader.GetOrdinal(CIcp_lecturas.CIcp_lecturasFields.Id.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcp_lecturas.CIcp_lecturasFields.Calibracion.ToString())))
				{
					businessObject.Calibracion = dataReader.GetInt32(dataReader.GetOrdinal(CIcp_lecturas.CIcp_lecturasFields.Calibracion.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcp_lecturas.CIcp_lecturasFields.Elemento.ToString())))
				{
					businessObject.Elemento = dataReader.GetString(dataReader.GetOrdinal(CIcp_lecturas.CIcp_lecturasFields.Elemento.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcp_lecturas.CIcp_lecturasFields.Idmuestra.ToString())))
				{
					businessObject.Idmuestra = dataReader.GetInt32(dataReader.GetOrdinal(CIcp_lecturas.CIcp_lecturasFields.Idmuestra.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcp_lecturas.CIcp_lecturasFields.Muestra.ToString())))
				{
					businessObject.Muestra = dataReader.GetString(dataReader.GetOrdinal(CIcp_lecturas.CIcp_lecturasFields.Muestra.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcp_lecturas.CIcp_lecturasFields.Lectura.ToString())))
				{
					businessObject.Lectura = dataReader.GetString(dataReader.GetOrdinal(CIcp_lecturas.CIcp_lecturasFields.Lectura.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CIcp_lecturas.CIcp_lecturasFields.Dilucion2.ToString())))
				{
					businessObject.Dilucion2 = dataReader.GetString(dataReader.GetOrdinal(CIcp_lecturas.CIcp_lecturasFields.Dilucion2.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CIcp_lecturas</returns>
        internal List<CIcp_lecturas> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CIcp_lecturas> list = new List<CIcp_lecturas>();

            while (dataReader.Read())
            {
                CIcp_lecturas businessObject = new CIcp_lecturas();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
