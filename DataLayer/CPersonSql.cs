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
	/// Data access layer class for CPerson
	/// </summary>
	partial class CPersonSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CPersonSql()
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
		public bool Insert(CPerson businessObject)
		{
			NpgsqlCommand	sqlCommand = new NpgsqlCommand();
			sqlCommand.CommandText = "public.sp_person_Insert";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.AddWithValue("p_idperson", businessObject.Idperson);
				sqlCommand.Parameters["p_idperson"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters["p_idperson"].Direction = ParameterDirection.InputOutput;

				sqlCommand.Parameters.AddWithValue("p_cod_person", businessObject.Cod_person);
				sqlCommand.Parameters["p_cod_person"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_type_document", businessObject.Type_document);
				sqlCommand.Parameters["p_type_document"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_last_name1", businessObject.Last_name1);
				sqlCommand.Parameters["p_last_name1"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_last_name2", businessObject.Last_name2);
				sqlCommand.Parameters["p_last_name2"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_names_person", businessObject.Names_person);
				sqlCommand.Parameters["p_names_person"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_allname", businessObject.Allname);
				sqlCommand.Parameters["p_allname"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_gender", businessObject.Gender);
				sqlCommand.Parameters["p_gender"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_domicile", businessObject.Domicile);
				sqlCommand.Parameters["p_domicile"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_mail", businessObject.Mail);
				sqlCommand.Parameters["p_mail"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_phone", businessObject.Phone);
				sqlCommand.Parameters["p_phone"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_cellphone", businessObject.Cellphone);
				sqlCommand.Parameters["p_cellphone"].NpgsqlDbType = NpgsqlDbType.Varchar;
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
				sqlCommand.Parameters.AddWithValue("p_person_type", businessObject.Person_type);
				sqlCommand.Parameters["p_person_type"].NpgsqlDbType = NpgsqlDbType.Integer;

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Idperson = Convert.ToInt16(sqlCommand.Parameters["p_idperson"].Value);

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CPerson::Insert::Error occured.", ex);
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
        public bool Update(CPerson businessObject)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_person_Update";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.AddWithValue("p_idperson", businessObject.Idperson);
				sqlCommand.Parameters["p_idperson"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_cod_person", businessObject.Cod_person);
				sqlCommand.Parameters["p_cod_person"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_type_document", businessObject.Type_document);
				sqlCommand.Parameters["p_type_document"].NpgsqlDbType = NpgsqlDbType.Smallint;
				sqlCommand.Parameters.AddWithValue("p_last_name1", businessObject.Last_name1);
				sqlCommand.Parameters["p_last_name1"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_last_name2", businessObject.Last_name2);
				sqlCommand.Parameters["p_last_name2"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_names_person", businessObject.Names_person);
				sqlCommand.Parameters["p_names_person"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_allname", businessObject.Allname);
				sqlCommand.Parameters["p_allname"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_gender", businessObject.Gender);
				sqlCommand.Parameters["p_gender"].NpgsqlDbType = NpgsqlDbType.Char;
				sqlCommand.Parameters.AddWithValue("p_domicile", businessObject.Domicile);
				sqlCommand.Parameters["p_domicile"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_mail", businessObject.Mail);
				sqlCommand.Parameters["p_mail"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_phone", businessObject.Phone);
				sqlCommand.Parameters["p_phone"].NpgsqlDbType = NpgsqlDbType.Varchar;
				sqlCommand.Parameters.AddWithValue("p_cellphone", businessObject.Cellphone);
				sqlCommand.Parameters["p_cellphone"].NpgsqlDbType = NpgsqlDbType.Varchar;
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
				sqlCommand.Parameters.AddWithValue("p_person_type", businessObject.Person_type);
				sqlCommand.Parameters["p_person_type"].NpgsqlDbType = NpgsqlDbType.Integer;

                
                MainConnection.Open();

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CPerson::Update::Error occured.", ex);
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
        /// <returns>CPerson business object</returns>
        public CPerson SelectByPrimaryKey(CPersonKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_person_SelectByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idperson", NpgsqlDbType.Smallint, 2, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idperson));

                
                MainConnection.Open();

                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    CPerson businessObject = new CPerson();

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
                throw new Exception("CPerson::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CPerson</returns>
        public List<CPerson> SelectAll()
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_person_SelectAll";
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
                throw new Exception("CPerson::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_person_SelectAll";
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
                throw new Exception("CPerson::SelectAll::Error occured.", ex);
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
        /// <returns>list of CPerson</returns>
        public List<CPerson> SelectByField(string fieldName, object value)
        {

            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_person_SelectByField";
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
                throw new Exception("CPerson::SelectByField::Error occured.", ex);
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
        public bool Delete(CPersonKeys keys)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.CommandText = "public.sp_person_DeleteByPrimaryKey";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new NpgsqlParameter("p_idperson", NpgsqlDbType.Smallint, 2, "", ParameterDirection.Input, false, 0, 0, DataRowVersion.Proposed, keys.Idperson));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CPerson::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "public.sp_person_DeleteByField";
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
                throw new Exception("CPerson::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CPerson businessObject, IDataReader dataReader)
        {


				businessObject.Idperson = (short)dataReader.GetInt16(dataReader.GetOrdinal(CPerson.CPersonFields.Idperson.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Cod_person.ToString())))
				{
					businessObject.Cod_person = dataReader.GetString(dataReader.GetOrdinal(CPerson.CPersonFields.Cod_person.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Type_document.ToString())))
				{
					businessObject.Type_document = (short?)dataReader.GetInt16(dataReader.GetOrdinal(CPerson.CPersonFields.Type_document.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Last_name1.ToString())))
				{
					businessObject.Last_name1 = dataReader.GetString(dataReader.GetOrdinal(CPerson.CPersonFields.Last_name1.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Last_name2.ToString())))
				{
					businessObject.Last_name2 = dataReader.GetString(dataReader.GetOrdinal(CPerson.CPersonFields.Last_name2.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Names_person.ToString())))
				{
					businessObject.Names_person = dataReader.GetString(dataReader.GetOrdinal(CPerson.CPersonFields.Names_person.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Allname.ToString())))
				{
					businessObject.Allname = dataReader.GetString(dataReader.GetOrdinal(CPerson.CPersonFields.Allname.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Gender.ToString())))
				{
					businessObject.Gender = dataReader.GetChar(dataReader.GetOrdinal(CPerson.CPersonFields.Gender.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Domicile.ToString())))
				{
					businessObject.Domicile = dataReader.GetString(dataReader.GetOrdinal(CPerson.CPersonFields.Domicile.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Mail.ToString())))
				{
					businessObject.Mail = dataReader.GetString(dataReader.GetOrdinal(CPerson.CPersonFields.Mail.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Phone.ToString())))
				{
					businessObject.Phone = dataReader.GetString(dataReader.GetOrdinal(CPerson.CPersonFields.Phone.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Cellphone.ToString())))
				{
					businessObject.Cellphone = dataReader.GetString(dataReader.GetOrdinal(CPerson.CPersonFields.Cellphone.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Usernew.ToString())))
				{
					businessObject.Usernew = dataReader.GetString(dataReader.GetOrdinal(CPerson.CPersonFields.Usernew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Datenew.ToString())))
				{
					businessObject.Datenew = dataReader.GetDateTime(dataReader.GetOrdinal(CPerson.CPersonFields.Datenew.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Useredit.ToString())))
				{
					businessObject.Useredit = dataReader.GetString(dataReader.GetOrdinal(CPerson.CPersonFields.Useredit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Dateedit.ToString())))
				{
					businessObject.Dateedit = dataReader.GetDateTime(dataReader.GetOrdinal(CPerson.CPersonFields.Dateedit.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Status.ToString())))
				{
					businessObject.Status = dataReader.GetBoolean(dataReader.GetOrdinal(CPerson.CPersonFields.Status.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(CPerson.CPersonFields.Person_type.ToString())))
				{
					businessObject.Person_type = dataReader.GetInt32(dataReader.GetOrdinal(CPerson.CPersonFields.Person_type.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CPerson</returns>
        internal List<CPerson> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CPerson> list = new List<CPerson>();

            while (dataReader.Read())
            {
                CPerson businessObject = new CPerson();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
