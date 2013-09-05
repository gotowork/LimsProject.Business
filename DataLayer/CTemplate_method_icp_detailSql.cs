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
	/// Data access layer class for CTemplate_method_icp_detail
	/// </summary>
	partial class CTemplate_method_icp_detailSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CTemplate_method_icp_detailSql()
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
		public bool Insert(CTemplate_method_icp_detail businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_template_method_icp_detail_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method_icp_detail", businessObject.Idtemplate_method_icp_detail);
				sqlCommand.Parameters["p_idtemplate_method_icp_detail"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idtemplate_method_icp_detail"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idelement", businessObject.Idelement);
				sqlCommand.Parameters["p_idelement"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_wavelenght", businessObject.Wavelenght);
				sqlCommand.Parameters["p_wavelenght"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_element_wavelenght", businessObject.Element_wavelenght);
				sqlCommand.Parameters["p_element_wavelenght"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idl", businessObject.Idl);
				sqlCommand.Parameters["p_idl"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_mdl", businessObject.Mdl);
				sqlCommand.Parameters["p_mdl"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_ldr", businessObject.Ldr);
				sqlCommand.Parameters["p_ldr"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_ldr_aux", businessObject.Ldr_aux);
				sqlCommand.Parameters["p_ldr_aux"].NpgsqlDbType = NpgsqlDbType.Numeric;
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
				sqlCommand.Parameters.AddWithValue("p_limit_top", businessObject.Limit_top);
				sqlCommand.Parameters["p_limit_top"].NpgsqlDbType = NpgsqlDbType.Numeric;
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
                businessObject.Idtemplate_method_icp_detail = Convert.ToInt32(sqlCommand.Parameters["p_idtemplate_method_icp_detail"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CTemplate_method_icp_detail::Insert::Error occured.", ex);
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
        public bool Update(CTemplate_method_icp_detail businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_icp_detail_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method_icp_detail", businessObject.Idtemplate_method_icp_detail);
				sqlCommand.Parameters["p_idtemplate_method_icp_detail"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idtemplate_method", businessObject.Idtemplate_method);
				sqlCommand.Parameters["p_idtemplate_method"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idelement", businessObject.Idelement);
				sqlCommand.Parameters["p_idelement"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_wavelenght", businessObject.Wavelenght);
				sqlCommand.Parameters["p_wavelenght"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_element_wavelenght", businessObject.Element_wavelenght);
				sqlCommand.Parameters["p_element_wavelenght"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idl", businessObject.Idl);
				sqlCommand.Parameters["p_idl"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_mdl", businessObject.Mdl);
				sqlCommand.Parameters["p_mdl"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_ldr", businessObject.Ldr);
				sqlCommand.Parameters["p_ldr"].NpgsqlDbType = NpgsqlDbType.Numeric;
				sqlCommand.Parameters.AddWithValue("p_ldr_aux", businessObject.Ldr_aux);
				sqlCommand.Parameters["p_ldr_aux"].NpgsqlDbType = NpgsqlDbType.Numeric;
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
				sqlCommand.Parameters.AddWithValue("p_limit_top", businessObject.Limit_top);
				sqlCommand.Parameters["p_limit_top"].NpgsqlDbType = NpgsqlDbType.Numeric;
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
                throw new Exception("CTemplate_method_icp_detail::Update::Error occured.", ex);
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
        /// <returns>CTemplate_method_icp_detail business object</returns>
        public CTemplate_method_icp_detail SelectByPrimaryKey(CTemplate_method_icp_detailKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_icp_detail_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idtemplate_method_icp_detail", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idtemplate_method_icp_detail));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CTemplate_method_icp_detail businessObject = new CTemplate_method_icp_detail();

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
                throw new Exception("CTemplate_method_icp_detail::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CTemplate_method_icp_detail</returns>
        public List<CTemplate_method_icp_detail> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_icp_detail_SelectAll";
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
                throw new Exception("CTemplate_method_icp_detail::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_template_method_icp_detail_SelectAll";
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
                throw new Exception("CTemplate_method_icp_detail::SelectAll::Error occured.", ex);
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
        /// <returns>list of CTemplate_method_icp_detail</returns>
        public List<CTemplate_method_icp_detail> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_icp_detail_SelectByField";
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
                throw new Exception("CTemplate_method_icp_detail::SelectByField::Error occured.", ex);
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
        public bool Delete(CTemplate_method_icp_detailKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_template_method_icp_detail_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idtemplate_method_icp_detail", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idtemplate_method_icp_detail));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTemplate_method_icp_detail::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_template_method_icp_detail_DeleteByField";
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
                throw new Exception("CTemplate_method_icp_detail::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CTemplate_method_icp_detail businessObject, IDataReader dataReader)
        {


				businessObject.Idtemplate_method_icp_detail = dataReader.GetInt32(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Idtemplate_method_icp_detail.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Idtemplate_method.ToString())))
				{
					businessObject.Idtemplate_method = dataReader.GetInt32(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Idtemplate_method.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Idelement.ToString())))
				{
					businessObject.Idelement = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Idelement.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Wavelenght.ToString())))
				{
					businessObject.Wavelenght = dataReader.GetInt32(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Wavelenght.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Element_wavelenght.ToString())))
				{
					businessObject.Element_wavelenght = dataReader.GetString(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Element_wavelenght.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Idl.ToString())))
				{
					businessObject.Idl = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Idl.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Mdl.ToString())))
				{
					businessObject.Mdl = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Mdl.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Ldr.ToString())))
				{
					businessObject.Ldr = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Ldr.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Ldr_aux.ToString())))
				{
					businessObject.Ldr_aux = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Ldr_aux.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Num_decimal.ToString())))
				{
					businessObject.Num_decimal = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Num_decimal.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Std1.ToString())))
				{
					businessObject.Std1 = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Std1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Std2.ToString())))
				{
					businessObject.Std2 = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Std2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Ipc.ToString())))
				{
					businessObject.Ipc = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Ipc.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Lfb.ToString())))
				{
					businessObject.Lfb = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Lfb.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Lfm.ToString())))
				{
					businessObject.Lfm = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Lfm.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Limit_top.ToString())))
				{
					businessObject.Limit_top = dataReader.GetDecimal(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Limit_top.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CTemplate_method_icp_detail.CTemplate_method_icp_detailFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CTemplate_method_icp_detail</returns>
        internal List<CTemplate_method_icp_detail> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CTemplate_method_icp_detail> list = new List<CTemplate_method_icp_detail>();

            while (dataReader.Read())
            {
                CTemplate_method_icp_detail businessObject = new CTemplate_method_icp_detail();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
