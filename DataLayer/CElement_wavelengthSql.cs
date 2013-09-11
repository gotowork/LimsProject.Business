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
	/// Data access layer class for CElement_wavelength
	/// </summary>
	partial class CElement_wavelengthSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CElement_wavelengthSql()
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
		public bool Insert(CElement_wavelength businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_element_wavelength_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idelement_wavelength", businessObject.Idelement_wavelength);
				sqlCommand.Parameters["p_idelement_wavelength"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idelement_wavelength"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idelement", businessObject.Idelement);
				sqlCommand.Parameters["p_idelement"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_wavelength", businessObject.Wavelength);
				sqlCommand.Parameters["p_wavelength"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_lineorder", businessObject.Lineorder);
				sqlCommand.Parameters["p_lineorder"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_plasmaview", businessObject.Plasmaview);
				sqlCommand.Parameters["p_plasmaview"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idl_axial", businessObject.Idl_axial);
				sqlCommand.Parameters["p_idl_axial"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idl_radial", businessObject.Idl_radial);
				sqlCommand.Parameters["p_idl_radial"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_lineality_axial", businessObject.Lineality_axial);
				sqlCommand.Parameters["p_lineality_axial"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_lineality_radial", businessObject.Lineality_radial);
				sqlCommand.Parameters["p_lineality_radial"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_mdl_axial", businessObject.Mdl_axial);
				sqlCommand.Parameters["p_mdl_axial"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_mdl_radial", businessObject.Mdl_radial);
				sqlCommand.Parameters["p_mdl_radial"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_ipc", businessObject.Ipc);
				sqlCommand.Parameters["p_ipc"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_lfb", businessObject.Lfb);
				sqlCommand.Parameters["p_lfb"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_qc", businessObject.Qc);
				sqlCommand.Parameters["p_qc"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_priority", businessObject.Priority);
				sqlCommand.Parameters["p_priority"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_usernew", businessObject.Usernew);
				sqlCommand.Parameters["p_usernew"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_datenew", businessObject.Datenew);
				sqlCommand.Parameters["p_datenew"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_useredit", businessObject.Useredit);
				sqlCommand.Parameters["p_useredit"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dateedit", businessObject.Dateedit);
				sqlCommand.Parameters["p_dateedit"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idelement_wavelength = Convert.ToInt32(sqlCommand.Parameters["p_idelement_wavelength"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CElement_wavelength::Insert::Error occured.", ex);
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
        public bool Update(CElement_wavelength businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_element_wavelength_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idelement_wavelength", businessObject.Idelement_wavelength);
				sqlCommand.Parameters["p_idelement_wavelength"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idelement", businessObject.Idelement);
				sqlCommand.Parameters["p_idelement"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_wavelength", businessObject.Wavelength);
				sqlCommand.Parameters["p_wavelength"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_lineorder", businessObject.Lineorder);
				sqlCommand.Parameters["p_lineorder"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_plasmaview", businessObject.Plasmaview);
				sqlCommand.Parameters["p_plasmaview"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_idl_axial", businessObject.Idl_axial);
				sqlCommand.Parameters["p_idl_axial"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_idl_radial", businessObject.Idl_radial);
				sqlCommand.Parameters["p_idl_radial"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_lineality_axial", businessObject.Lineality_axial);
				sqlCommand.Parameters["p_lineality_axial"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_lineality_radial", businessObject.Lineality_radial);
				sqlCommand.Parameters["p_lineality_radial"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_mdl_axial", businessObject.Mdl_axial);
				sqlCommand.Parameters["p_mdl_axial"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_mdl_radial", businessObject.Mdl_radial);
				sqlCommand.Parameters["p_mdl_radial"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_ipc", businessObject.Ipc);
				sqlCommand.Parameters["p_ipc"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_lfb", businessObject.Lfb);
				sqlCommand.Parameters["p_lfb"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_qc", businessObject.Qc);
				sqlCommand.Parameters["p_qc"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_priority", businessObject.Priority);
				sqlCommand.Parameters["p_priority"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_usernew", businessObject.Usernew);
				sqlCommand.Parameters["p_usernew"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_datenew", businessObject.Datenew);
				sqlCommand.Parameters["p_datenew"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_useredit", businessObject.Useredit);
				sqlCommand.Parameters["p_useredit"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_dateedit", businessObject.Dateedit);
				sqlCommand.Parameters["p_dateedit"].NpgsqlDbType = NpgsqlDbType.Timestamp;
				sqlCommand.Parameters.AddWithValue("p_status", businessObject.Status);
				sqlCommand.Parameters["p_status"].NpgsqlDbType = NpgsqlDbType.Boolean;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CElement_wavelength::Update::Error occured.", ex);
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
        /// <returns>CElement_wavelength business object</returns>
        public CElement_wavelength SelectByPrimaryKey(CElement_wavelengthKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_element_wavelength_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idelement_wavelength", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idelement_wavelength));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CElement_wavelength businessObject = new CElement_wavelength();

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
                throw new Exception("CElement_wavelength::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CElement_wavelength</returns>
        public List<CElement_wavelength> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_element_wavelength_SelectAll";
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
                throw new Exception("CElement_wavelength::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_element_wavelength_SelectAll";
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
                throw new Exception("CElement_wavelength::SelectAll::Error occured.", ex);
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
        /// <returns>list of CElement_wavelength</returns>
        public List<CElement_wavelength> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_element_wavelength_SelectByField";
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
                throw new Exception("CElement_wavelength::SelectByField::Error occured.", ex);
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
        public bool Delete(CElement_wavelengthKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_element_wavelength_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idelement_wavelength", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idelement_wavelength));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CElement_wavelength::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_element_wavelength_DeleteByField";
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
                throw new Exception("CElement_wavelength::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CElement_wavelength businessObject, IDataReader dataReader)
        {


				businessObject.Idelement_wavelength = dataReader.GetInt32(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Idelement_wavelength.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Idelement.ToString())))
				{
					businessObject.Idelement = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Idelement.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Wavelength.ToString())))
				{
					businessObject.Wavelength = dataReader.GetString(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Wavelength.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Lineorder.ToString())))
				{
					businessObject.Lineorder = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Lineorder.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Plasmaview.ToString())))
				{
					businessObject.Plasmaview = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Plasmaview.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Idl_axial.ToString())))
				{
					businessObject.Idl_axial = dataReader.GetDecimal(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Idl_axial.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Idl_radial.ToString())))
				{
					businessObject.Idl_radial = dataReader.GetDecimal(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Idl_radial.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Lineality_axial.ToString())))
				{
					businessObject.Lineality_axial = dataReader.GetDecimal(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Lineality_axial.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Lineality_radial.ToString())))
				{
					businessObject.Lineality_radial = dataReader.GetDecimal(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Lineality_radial.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Mdl_axial.ToString())))
				{
					businessObject.Mdl_axial = dataReader.GetDecimal(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Mdl_axial.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Mdl_radial.ToString())))
				{
					businessObject.Mdl_radial = dataReader.GetDecimal(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Mdl_radial.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Ipc.ToString())))
				{
					businessObject.Ipc = dataReader.GetDecimal(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Ipc.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Lfb.ToString())))
				{
					businessObject.Lfb = dataReader.GetDecimal(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Lfb.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Qc.ToString())))
				{
					businessObject.Qc = dataReader.GetDecimal(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Qc.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Priority.ToString())))
				{
					businessObject.Priority = dataReader.GetDecimal(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Priority.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CElement_wavelength.CElement_wavelengthFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CElement_wavelength</returns>
        internal List<CElement_wavelength> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CElement_wavelength> list = new List<CElement_wavelength>();

            while (dataReader.Read())
            {
                CElement_wavelength businessObject = new CElement_wavelength();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
