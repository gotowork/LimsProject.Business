using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CType_preparation_sample: BusinessObjectBase
	{

		#region InnerClass
		public enum CType_preparation_sampleFields
		{
			Idtype_preparation_sample,
			Name_preparation,
			Description,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _idtype_preparation_sample;
			string _name_preparation;
			string _description;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public int  Idtype_preparation_sample
		{
			 get { return _idtype_preparation_sample; }
			 set
			 {
				 if (_idtype_preparation_sample != value)
				 {
					_idtype_preparation_sample = value;
					 PropertyHasChanged("Idtype_preparation_sample");
				 }
			 }
		}

		public string  Name_preparation
		{
			 get { return _name_preparation; }
			 set
			 {
				 if (_name_preparation != value)
				 {
					_name_preparation = value;
					 PropertyHasChanged("Name_preparation");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idtype_preparation_sample", "Idtype_preparation_sample"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_preparation", "Name_preparation",30));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",500));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
