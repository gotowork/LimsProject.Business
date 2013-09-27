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
	/// Data access layer class for CCalib_std
	/// </summary>
	partial class CCalib_stdSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CCalib_stdSql()
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
		public bool Insert(CCalib_std businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_calib_std_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idcalib_std", businessObject.Idcalib_std);
				sqlCommand.Parameters["p_idcalib_std"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters["p_idcalib_std"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idcalib", businessObject.Idcalib);
				sqlCommand.Parameters["p_idcalib"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_absorbance", businessObject.Absorbance);
				sqlCommand.Parameters["p_absorbance"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_absorbance_previus", businessObject.Absorbance_previus);
				sqlCommand.Parameters["p_absorbance_previus"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_concentration", businessObject.Concentration);
				sqlCommand.Parameters["p_concentration"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idset_calibs", businessObject.Idset_calibs);
				sqlCommand.Parameters["p_idset_calibs"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idsolution_interm", businessObject.Idsolution_interm);
				sqlCommand.Parameters["p_idsolution_interm"].NpgsqlDbType = NpgsqlDbType.Integer;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idcalib_std = Convert.ToInt64(sqlCommand.Parameters["p_idcalib_std"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CCalib_std::Insert::Error occured.", ex);
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
        public bool Update(CCalib_std businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_calib_std_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idcalib_std", businessObject.Idcalib_std);
				sqlCommand.Parameters["p_idcalib_std"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_idcalib", businessObject.Idcalib);
				sqlCommand.Parameters["p_idcalib"].NpgsqlDbType = NpgsqlDbType.Bigint;
				sqlCommand.Parameters.AddWithValue("p_absorbance", businessObject.Absorbance);
				sqlCommand.Parameters["p_absorbance"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_absorbance_previus", businessObject.Absorbance_previus);
				sqlCommand.Parameters["p_absorbance_previus"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_concentration", businessObject.Concentration);
				sqlCommand.Parameters["p_concentration"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idset_calibs", businessObject.Idset_calibs);
				sqlCommand.Parameters["p_idset_calibs"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idsolution_interm", businessObject.Idsolution_interm);
				sqlCommand.Parameters["p_idsolution_interm"].NpgsqlDbType = NpgsqlDbType.Integer;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CCalib_std::Update::Error occured.", ex);
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
        /// <returns>CCalib_std business object</returns>
        public CCalib_std SelectByPrimaryKey(CCalib_stdKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_calib_std_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idcalib_std", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idcalib_std));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CCalib_std businessObject = new CCalib_std();

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
                throw new Exception("CCalib_std::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CCalib_std</returns>
        public List<CCalib_std> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_calib_std_SelectAll";
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
                throw new Exception("CCalib_std::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_calib_std_SelectAll";
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
                throw new Exception("CCalib_std::SelectAll::Error occured.", ex);
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
        /// <returns>list of CCalib_std</returns>
        public List<CCalib_std> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_calib_std_SelectByField";
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
                throw new Exception("CCalib_std::SelectByField::Error occured.", ex);
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
        public bool Delete(CCalib_stdKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_calib_std_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idcalib_std", NpgsqlDbType.Bigint, 8, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idcalib_std));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CCalib_std::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_calib_std_DeleteByField";
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
                throw new Exception("CCalib_std::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CCalib_std businessObject, IDataReader dataReader)
        {


				businessObject.Idcalib_std = dataReader.GetInt64(dataReader.GetOrdinal(CCalib_std.CCalib_stdFields.Idcalib_std.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCalib_std.CCalib_stdFields.Idcalib.ToString())))
				{
					businessObject.Idcalib = dataReader.GetInt64(dataReader.GetOrdinal(CCalib_std.CCalib_stdFields.Idcalib.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCalib_std.CCalib_stdFields.Absorbance.ToString())))
				{
					businessObject.Absorbance = dataReader.GetDecimal(dataReader.GetOrdinal(CCalib_std.CCalib_stdFields.Absorbance.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCalib_std.CCalib_stdFields.Absorbance_previus.ToString())))
				{
					businessObject.Absorbance_previus = dataReader.GetDecimal(dataReader.GetOrdinal(CCalib_std.CCalib_stdFields.Absorbance_previus.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCalib_std.CCalib_stdFields.Concentration.ToString())))
				{
					businessObject.Concentration = dataReader.GetDecimal(dataReader.GetOrdinal(CCalib_std.CCalib_stdFields.Concentration.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCalib_std.CCalib_stdFields.Idset_calibs.ToString())))
				{
					businessObject.Idset_calibs = dataReader.GetInt32(dataReader.GetOrdinal(CCalib_std.CCalib_stdFields.Idset_calibs.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCalib_std.CCalib_stdFields.Idtemplate_method.ToString())))
				{
					businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CCalib_std.CCalib_stdFields.Idtemplate_method.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CCalib_std.CCalib_stdFields.Idsolution_interm.ToString())))
				{
					businessObject.Idsolution_interm = dataReader.GetInt32(dataReader.GetOrdinal(CCalib_std.CCalib_stdFields.Idsolution_interm.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CCalib_std</returns>
        internal List<CCalib_std> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CCalib_std> list = new List<CCalib_std>();

            while (dataReader.Read())
            {
                CCalib_std businessObject = new CCalib_std();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
