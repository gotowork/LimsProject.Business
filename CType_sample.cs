using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CType_sample: BusinessObjectBase
	{

		#region InnerClass
		public enum CType_sampleFields
		{
			Cod_type_sample,
			Prefix,
			Name_type_sample,
			Description,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			string _cod_type_sample;
			string _prefix;
			string _name_type_sample;
			string _description;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

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

		public string  Prefix
		{
			 get { return _prefix; }
			 set
			 {
				 if (_prefix != value)
				 {
					_prefix = value;
					 PropertyHasChanged("Prefix");
				 }
			 }
		}

		public string  Name_type_sample
		{
			 get { return _name_type_sample; }
			 set
			 {
				 if (_name_type_sample != value)
				 {
					_name_type_sample = value;
					 PropertyHasChanged("Name_type_sample");
				 }
			 }
		}

		public string  Description
		{
			 get { return _description; }
			 set
			 {
				 if (_description != value)
				 {
					_description = value;
					 PropertyHasChanged("Description");
				 }
			 }
		}

		public string  Usernew
		{
			 get { return _usernew; }
			 set
			 {
				 if (_usernew != value)
				 {
					_usernew = value;
					 PropertyHasChanged("Usernew");
				 }
			 }
		}

		public DateTime?  Datenew
		{
			 get { return _datenew; }
			 set
			 {
				 if (_datenew != value)
				 {
					_datenew = value;
					 PropertyHasChanged("Datenew");
				 }
			 }
		}

		public string  Useredit
		{
			 get { return _useredit; }
			 set
			 {
				 if (_useredit != value)
				 {
					_useredit = value;
					 PropertyHasChanged("Useredit");
				 }
			 }
		}

		public DateTime?  Dateedit
		{
			 get { return _dateedit; }
			 set
			 {
				 if (_dateedit != value)
				 {
					_dateedit = value;
					 PropertyHasChanged("Dateedit");
				 }
			 }
		}

		public bool?  Status
		{
			 get { return _status; }
			 set
			 {
				 if (_status != value)
				 {
					_status = value;
					 PropertyHasChanged("Status");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Cod_type_sample", "Cod_type_sample"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_type_sample", "Cod_type_sample",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Prefix", "Prefix",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_type_sample", "Name_type_sample",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",50));
		}

		#endregion

	}
}
