using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CPrice_version: BusinessObjectBase
	{

		#region InnerClass
		public enum CPrice_versionFields
		{
			Idprice_version,
			Idprice,
			Idrecep_sample,
			Num_version,
			Cod_type_sample,
			Idcompany,
			Attention,
			Iduser,
			Num_days_post,
			Date_creation,
			User_creation,
			Num_days_valid,
			Status_price,
			Observation
		}
		#endregion

		#region Data Members

			int _idprice_version;
			int? _idprice;
			long? _idrecep_sample;
			int? _num_version;
			string _cod_type_sample;
			short? _idcompany;
			short? _attention;
			short? _iduser;
			int? _num_days_post;
			DateTime? _date_creation;
			string _user_creation;
			short? _num_days_valid;
			int? _status_price;
			string _observation;

		#endregion

		#region Properties

		public int  Idprice_version
		{
			 get { return _idprice_version; }
			 set
			 {
				 if (_idprice_version != value)
				 {
					_idprice_version = value;
					 PropertyHasChanged("Idprice_version");
				 }
			 }
		}

		public int?  Idprice
		{
			 get { return _idprice; }
			 set
			 {
				 if (_idprice != value)
				 {
					_idprice = value;
					 PropertyHasChanged("Idprice");
				 }
			 }
		}

		public long?  Idrecep_sample
		{
			 get { return _idrecep_sample; }
			 set
			 {
				 if (_idrecep_sample != value)
				 {
					_idrecep_sample = value;
					 PropertyHasChanged("Idrecep_sample");
				 }
			 }
		}

		public int?  Num_version
		{
			 get { return _num_version; }
			 set
			 {
				 if (_num_version != value)
				 {
					_num_version = value;
					 PropertyHasChanged("Num_version");
				 }
			 }
		}

		public string  Cod_type_sample
		{
			 get { return _cod_type_sample; }
			 set
			 {
				 if (_cod_type_sample != value)
				 {
					_cod_type_sample = value;
					 PropertyHasChanged("Cod_type_sample");
				 }
			 }
		}

		public short?  Idcompany
		{
			 get { return _idcompany; }
			 set
			 {
				 if (_idcompany != value)
				 {
					_idcompany = value;
					 PropertyHasChanged("Idcompany");
				 }
			 }
		}

		public short?  Attention
		{
			 get { return _attention; }
			 set
			 {
				 if (_attention != value)
				 {
					_attention = value;
					 PropertyHasChanged("Attention");
				 }
			 }
		}

		public short?  Iduser
		{
			 get { return _iduser; }
			 set
			 {
				 if (_iduser != value)
				 {
					_iduser = value;
					 PropertyHasChanged("Iduser");
				 }
			 }
		}

		public int?  Num_days_post
		{
			 get { return _num_days_post; }
			 set
			 {
				 if (_num_days_post != value)
				 {
					_num_days_post = value;
					 PropertyHasChanged("Num_days_post");
				 }
			 }
		}

		public DateTime?  Date_creation
		{
			 get { return _date_creation; }
			 set
			 {
				 if (_date_creation != value)
				 {
					_date_creation = value;
					 PropertyHasChanged("Date_creation");
				 }
			 }
		}

		public string  User_creation
		{
			 get { return _user_creation; }
			 set
			 {
				 if (_user_creation != value)
				 {
					_user_creation = value;
					 PropertyHasChanged("User_creation");
				 }
			 }
		}

		public short?  Num_days_valid
		{
			 get { return _num_days_valid; }
			 set
			 {
				 if (_num_days_valid != value)
				 {
					_num_days_valid = value;
					 PropertyHasChanged("Num_days_valid");
				 }
			 }
		}

		public int?  Status_price
		{
			 get { return _status_price; }
			 set
			 {
				 if (_status_price != value)
				 {
					_status_price = value;
					 PropertyHasChanged("Status_price");
				 }
			 }
		}

		public string  Observation
		{
			 get { return _observation; }
			 set
			 {
				 if (_observation != value)
				 {
					_observation = value;
					 PropertyHasChanged("Observation");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idprice_version", "Idprice_version"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_type_sample", "Cod_type_sample",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("User_creation", "User_creation",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Observation", "Observation",3000));
		}

		#endregion

	}
}
