using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMeasurement_unit: BusinessObjectBase
	{

		#region InnerClass
		public enum CMeasurement_unitFields
		{
			Idunit,
			Name_unit,
			Description,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status,
			Concentration_unit
		}
		#endregion

		#region Data Members

			short _idunit;
			string _name_unit;
			string _description;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;
			int? _concentration_unit;

		#endregion

		#region Properties

		public short  Idunit
		{
			 get { return _idunit; }
			 set
			 {
				 if (_idunit != value)
				 {
					_idunit = value;
					 PropertyHasChanged("Idunit");
				 }
			 }
		}

		public string  Name_unit
		{
			 get { return _name_unit; }
			 set
			 {
				 if (_name_unit != value)
				 {
					_name_unit = value;
					 PropertyHasChanged("Name_unit");
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

		public int?  Concentration_unit
		{
			 get { return _concentration_unit; }
			 set
			 {
				 if (_concentration_unit != value)
				 {
					_concentration_unit = value;
					 PropertyHasChanged("Concentration_unit");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idunit", "Idunit"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_unit", "Name_unit",6));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
