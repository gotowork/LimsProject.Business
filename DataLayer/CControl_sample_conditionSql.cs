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
	/// Data access layer class for CControl_sample_condition
	/// </summary>
	partial class CControl_sample_conditionSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CControl_sample_conditionSql()
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
		public bool Insert(CControl_sample_condition businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_control_sample_condition_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idcontrol_sample_condition", businessObject.Idcontrol_sample_condition);
				sqlCommand.Parameters["p_idcontrol_sample_condition"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters["p_idcontrol_sample_condition"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_idcontrol_sample", businessObject.Idcontrol_sample);
				sqlCommand.Parameters["p_idcontrol_sample"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_matchsample", businessObject.Matchsample);
				sqlCommand.Parameters["p_matchsample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_test", businessObject.Test);
				sqlCommand.Parameters["p_test"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idcondition", businessObject.Idcondition);
				sqlCommand.Parameters["p_idcondition"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_msgok", businessObject.Msgok);
				sqlCommand.Parameters["p_msgok"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_msgerror", businessObject.Msgerror);
				sqlCommand.Parameters["p_msgerror"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_flag_apply", businessObject.Flag_apply);
				sqlCommand.Parameters["p_flag_apply"].NpgsqlDbType = NpgsqlDbType.Boolean;
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
                businessObject.Idcontrol_sample_condition = Convert.ToInt32(sqlCommand.Parameters["p_idcontrol_sample_condition"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CControl_sample_condition::Insert::Error occured.", ex);
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
        public bool Update(CControl_sample_condition businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_control_sample_condition_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idcontrol_sample_condition", businessObject.Idcontrol_sample_condition);
				sqlCommand.Parameters["p_idcontrol_sample_condition"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_idcontrol_sample", businessObject.Idcontrol_sample);
				sqlCommand.Parameters["p_idcontrol_sample"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_matchsample", businessObject.Matchsample);
				sqlCommand.Parameters["p_matchsample"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_test", businessObject.Test);
				sqlCommand.Parameters["p_test"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_idcondition", businessObject.Idcondition);
				sqlCommand.Parameters["p_idcondition"].NpgsqlDbType = NpgsqlDbType.Integer;
				sqlCommand.Parameters.AddWithValue("p_msgok", businessObject.Msgok);
				sqlCommand.Parameters["p_msgok"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_msgerror", businessObject.Msgerror);
				sqlCommand.Parameters["p_msgerror"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_flag_apply", businessObject.Flag_apply);
				sqlCommand.Parameters["p_flag_apply"].NpgsqlDbType = NpgsqlDbType.Boolean;
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
                throw new Exception("CControl_sample_condition::Update::Error occured.", ex);
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
        /// <returns>CControl_sample_condition business object</returns>
        public CControl_sample_condition SelectByPrimaryKey(CControl_sample_conditionKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_control_sample_condition_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idcontrol_sample_condition", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idcontrol_sample_condition));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CControl_sample_condition businessObject = new CControl_sample_condition();

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
                throw new Exception("CControl_sample_condition::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CControl_sample_condition</returns>
        public List<CControl_sample_condition> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_control_sample_condition_SelectAll";
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
                throw new Exception("CControl_sample_condition::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_control_sample_condition_SelectAll";
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
                throw new Exception("CControl_sample_condition::SelectAll::Error occured.", ex);
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
        /// <returns>list of CControl_sample_condition</returns>
        public List<CControl_sample_condition> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_control_sample_condition_SelectByField";
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
                throw new Exception("CControl_sample_condition::SelectByField::Error occured.", ex);
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
        public bool Delete(CControl_sample_conditionKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_control_sample_condition_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idcontrol_sample_condition", NpgsqlDbType.Integer, 4, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idcontrol_sample_condition));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CControl_sample_condition::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_control_sample_condition_DeleteByField";
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
                throw new Exception("CControl_sample_condition::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CControl_sample_condition businessObject, IDataReader dataReader)
        {


				businessObject.Idcontrol_sample_condition = dataReader.GetInt32(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Idcontrol_sample_condition.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Idcontrol_sample.ToString())))
				{
					businessObject.Idcontrol_sample = dataReader.GetInt32(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Idcontrol_sample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Matchsample.ToString())))
				{
					businessObject.Matchsample = dataReader.GetString(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Matchsample.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Test.ToString())))
				{
					businessObject.Test = dataReader.GetString(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Test.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Idcondition.ToString())))
				{
					businessObject.Idcondition = dataReader.GetInt32(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Idcondition.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Msgok.ToString())))
				{
					businessObject.Msgok = dataReader.GetString(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Msgok.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Msgerror.ToString())))
				{
					businessObject.Msgerror = dataReader.GetString(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Msgerror.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Flag_apply.ToString())))
				{
					businessObject.Flag_apply = dataReader.GetBoolean(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Flag_apply.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CControl_sample_condition.CControl_sample_conditionFields.Status.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CControl_sample_condition</returns>
        internal List<CControl_sample_condition> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CControl_sample_condition> list = new List<CControl_sample_condition>();

            while (dataReader.Read())
            {
                CControl_sample_condition businessObject = new CControl_sample_condition();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
