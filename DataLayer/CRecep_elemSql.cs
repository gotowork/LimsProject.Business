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
	/// Data access layer class for CRecep_elem
	/// </summary>
	partial class CRecep_elemSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CRecep_elemSql()
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
		public bool Insert(CRecep_elem businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_recep_elem_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idrecep_elem", businessObject.Idrecep_elem);
				sqlCommand.Parameters["p_idrecep_elem"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters["p_idrecep_elem"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idelement", businessObject.Idelement);
				sqlCommand.Parameters["p_idelement"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idunit", businessObject.Idunit);
				sqlCommand.Parameters["p_idunit"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_abbreviation", businessObject.Abbreviation);
				sqlCommand.Parameters["p_abbreviation"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_name_unit", businessObject.Name_unit);
				sqlCommand.Parameters["p_name_unit"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_percent_repetition", businessObject.Percent_repetition);
				sqlCommand.Parameters["p_percent_repetition"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idrecep_elem = Convert.ToInt64(sqlCommand.Parameters["p_idrecep_elem"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CRecep_elem::Insert::Error occured.", ex);
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
        public bool Update(CRecep_elem businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_elem_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idrecep_elem", businessObject.Idrecep_elem);
				sqlCommand.Parameters["p_idrecep_elem"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idelement", businessObject.Idelement);
				sqlCommand.Parameters["p_idelement"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idunit", businessObject.Idunit);
				sqlCommand.Parameters["p_idunit"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_abbreviation", businessObject.Abbreviation);
				sqlCommand.Parameters["p_abbreviation"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_name_unit", businessObject.Name_unit);
				sqlCommand.Parameters["p_name_unit"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_percent_repetition", businessObject.Percent_repetition);
				sqlCommand.Parameters["p_percent_repetition"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idrecep_sample", businessObject.Idrecep_sample);
				sqlCommand.Parameters["p_idrecep_sample"].NpgsqlDbType = NpgsqlDbType.Bigint;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CRecep_elem::Update::Error occured.", ex);
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
        /// <returns>CRecep_elem business object</returns>
        public CRecep_elem SelectByPrimaryKey(CRecep_elemKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_elem_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idrecep_elem", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idrecep_elem));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CRecep_elem businessObject = new CRecep_elem();

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
                throw new Exception("CRecep_elem::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CRecep_elem</returns>
        public List<CRecep_elem> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_elem_SelectAll";
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
                throw new Exception("CRecep_elem::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_recep_elem_SelectAll";
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
                throw new Exception("CRecep_elem::SelectAll::Error occured.", ex);
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
        /// <returns>list of CRecep_elem</returns>
        public List<CRecep_elem> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_elem_SelectByField";
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
                throw new Exception("CRecep_elem::SelectByField::Error occured.", ex);
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
        public bool Delete(CRecep_elemKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_recep_elem_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idrecep_elem", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idrecep_elem));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CRecep_elem::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_recep_elem_DeleteByField";
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
                throw new Exception("CRecep_elem::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CRecep_elem businessObject, IDataReader dataReader)
        {


				businessObject.Idrecep_elem = dataReader.GetInt64(dataReader.GetOrdinal(CRecep_elem.CRecep_elemFields.Idrecep_elem.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_elem.CRecep_elemFields.Idelement.ToString())))
				{
					businessObject.Idelement = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_elem.CRecep_elemFields.Idelement.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_elem.CRecep_elemFields.Idtemplate_method.ToString())))
				{
					businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CRecep_elem.CRecep_elemFields.Idtemplate_method.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_elem.CRecep_elemFields.Idunit.ToString())))
				{
					businessObject.Idunit = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_elem.CRecep_elemFields.Idunit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_elem.CRecep_elemFields.Abbreviation.ToString())))
				{
					businessObject.Abbreviation = dataReader.GetString(dataReader.GetOrdinal(CRecep_elem.CRecep_elemFields.Abbreviation.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_elem.CRecep_elemFields.Name_unit.ToString())))
				{
					businessObject.Name_unit = dataReader.GetString(dataReader.GetOrdinal(CRecep_elem.CRecep_elemFields.Name_unit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_elem.CRecep_elemFields.Percent_repetition.ToString())))
				{
					businessObject.Percent_repetition = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CRecep_elem.CRecep_elemFields.Percent_repetition.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CRecep_elem.CRecep_elemFields.Idrecep_sample.ToString())))
				{
					businessObject.Idrecep_sample = dataReader.GetInt64(dataReader.GetOrdinal(CRecep_elem.CRecep_elemFields.Idrecep_sample.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CRecep_elem</returns>
        internal List<CRecep_elem> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CRecep_elem> list = new List<CRecep_elem>();

            while (dataReader.Read())
            {
                CRecep_elem businessObject = new CRecep_elem();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
