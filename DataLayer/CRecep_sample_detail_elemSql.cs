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
	/// Data access layer class for CRecep_sample_detail_elem
	/// </summary>
	partial class CRecep_sample_detail_elemSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CRecep_sample_detail_elemSql()
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
		public bool Insert(CRecep_sample_detail_elem businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_recep_sample_detail_elem_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail_elem", businessObject.Idrecep_sample_detail_elem);
				sqlCommand.Parameters["p_idrecep_sample_detail_elem"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters["p_idrecep_sample_detail_elem"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail", businessObject.Idrecep_sample_detail);
				sqlCommand.Parameters["p_idrecep_sample_detail"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idelement", businessObject.Idelement);
				sqlCommand.Parameters["p_idelement"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_cost_method", businessObject.Cost_method);
				sqlCommand.Parameters["p_cost_method"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_analysis_time", businessObject.Analysis_time);
				sqlCommand.Parameters["p_analysis_time"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_str_result_analysis", businessObject.Str_result_analysis);
				sqlCommand.Parameters["p_str_result_analysis"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_result_analysis", businessObject.Result_analysis);
				sqlCommand.Parameters["p_result_analysis"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idunit", businessObject.Idunit);
				sqlCommand.Parameters["p_idunit"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idcompany", businessObject.Idcompany);
				sqlCommand.Parameters["p_idcompany"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_with_result", businessObject.With_result);
				sqlCommand.Parameters["p_with_result"].NpgsqlDbType = NpgsqlDbType.Boolean;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idrecep_sample_detail_elem = Convert.ToInt64(sqlCommand.Parameters["p_idrecep_sample_detail_elem"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CRecep_sample_detail_elem::Insert::Error occured.", ex);
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
        public bool Update(CRecep_sample_detail_elem businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_detail_elem_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail_elem", businessObject.Idrecep_sample_detail_elem);
				sqlCommand.Parameters["p_idrecep_sample_detail_elem"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample_detail", businessObject.Idrecep_sample_detail);
				sqlCommand.Parameters["p_idrecep_sample_detail"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idelement", businessObject.Idelement);
				sqlCommand.Parameters["p_idelement"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_cost_method", businessObject.Cost_method);
				sqlCommand.Parameters["p_cost_method"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_analysis_time", businessObject.Analysis_time);
				sqlCommand.Parameters["p_analysis_time"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_str_result_analysis", businessObject.Str_result_analysis);
				sqlCommand.Parameters["p_str_result_analysis"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_result_analysis", businessObject.Result_analysis);
				sqlCommand.Parameters["p_result_analysis"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idunit", businessObject.Idunit);
				sqlCommand.Parameters["p_idunit"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idcompany", businessObject.Idcompany);
				sqlCommand.Parameters["p_idcompany"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_with_result", businessObject.With_result);
				sqlCommand.Parameters["p_with_result"].NpgsqlDbType = NpgsqlDbType.Boolean;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CRecep_sample_detail_elem::Update::Error occured.", ex);
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
        /// <returns>CRecep_sample_detail_elem business object</returns>
        public CRecep_sample_detail_elem SelectByPrimaryKey(CRecep_sample_detail_elemKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_detail_elem_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idrecep_sample_detail_elem", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idrecep_sample_detail_elem));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CRecep_sample_detail_elem businessObject = new CRecep_sample_detail_elem();

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
                throw new Exception("CRecep_sample_detail_elem::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CRecep_sample_detail_elem</returns>
        public List<CRecep_sample_detail_elem> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_detail_elem_SelectAll";
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
                throw new Exception("CRecep_sample_detail_elem::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_recep_sample_detail_elem_SelectAll";
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
                throw new Exception("CRecep_sample_detail_elem::SelectAll::Error occured.", ex);
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
        /// <returns>list of CRecep_sample_detail_elem</returns>
        public List<CRecep_sample_detail_elem> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_detail_elem_SelectByField";
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
                throw new Exception("CRecep_sample_detail_elem::SelectByField::Error occured.", ex);
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
        public bool Delete(CRecep_sample_detail_elemKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_sample_detail_elem_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idrecep_sample_detail_elem", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idrecep_sample_detail_elem));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CRecep_sample_detail_elem::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_recep_sample_detail_elem_DeleteByField";
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
                throw new Exception("CRecep_sample_detail_elem::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CRecep_sample_detail_elem businessObject, IDataReader dataReader)
        {


				businessObject.Idrecep_sample_detail_elem = dataReader.GetInt64(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Idrecep_sample_detail_elem.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Idrecep_sample.ToString())))
				{
					businessObject.Idrecep_sample = dataReader.GetInt64(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Idrecep_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Idrecep_sample_detail.ToString())))
				{
					businessObject.Idrecep_sample_detail = dataReader.GetInt64(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Idrecep_sample_detail.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Idelement.ToString())))
				{
					businessObject.Idelement = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Idelement.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Idtemplate_method.ToString())))
				{
					businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Idtemplate_method.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Cost_method.ToString())))
				{
					businessObject.Cost_method = dataReader.GetDecimal(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Cost_method.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Analysis_time.ToString())))
				{
					businessObject.Analysis_time = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Analysis_time.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Str_result_analysis.ToString())))
				{
					businessObject.Str_result_analysis = dataReader.GetString(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Str_result_analysis.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Result_analysis.ToString())))
				{
					businessObject.Result_analysis = dataReader.GetDecimal(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Result_analysis.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Idunit.ToString())))
				{
					businessObject.Idunit = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Idunit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Idcompany.ToString())))
				{
					businessObject.Idcompany = dataReader.GetInt32(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.Idcompany.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.With_result.ToString())))
				{
					businessObject.With_result = dataReader.GetBoolean(dataReader.GetOrdinal(CRecep_sample_detail_elem.CRecep_sample_detail_elemFields.With_result.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CRecep_sample_detail_elem</returns>
        internal List<CRecep_sample_detail_elem> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CRecep_sample_detail_elem> list = new List<CRecep_sample_detail_elem>();

            while (dataReader.Read())
            {
                CRecep_sample_detail_elem businessObject = new CRecep_sample_detail_elem();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
