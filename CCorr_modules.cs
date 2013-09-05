using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCorr_modules: BusinessObjectBase
	{

		#region InnerClass
		public enum CCorr_modulesFields
		{
			Cod_module,
			Name_module,
			Prefix,
			Correlative,
			Num_digits,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status,
			Cod_serie
		}
		#endregion

		#region Data Members

			string _cod_module;
			string _name_module;
			string _prefix;
			int? _correlative;
			short? _num_digits;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;
			string _cod_serie;

		#endregion

		#region Properties

		public string  Cod_module
		{
			 get { return _cod_module; }
			 set
			 {
				 if (_cod_module != value)
				 {
					_cod_module = value;
					 PropertyHasChanged("Cod_module");
				 }
			 }
		}

		public string  Name_module
		{
			 get { return _name_module; }
			 set
			 {
				 if (_name_module != value)
				 {
					_name_module = value;
					 PropertyHasChanged("Name_module");
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

		public int?  Correlative
		{
			 get { return _correlative; }
			 set
			 {
				 if (_correlative != value)
				 {
					_correlative = value;
					 PropertyHasChanged("Correlative");
				 }
			 }
		}

		public short?  Num_digits
		{
			 get { return _num_digits; }
			 set
			 {
				 if (_num_digits != value)
				 {
					_num_digits = value;
					 PropertyHasChanged("Num_digits");
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

		public string  Cod_serie
		{
			 get { return _cod_serie; }
			 set
			 {
				 if (_cod_serie != value)
				 {
					_cod_serie = value;
					 PropertyHasChanged("Cod_serie");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Cod_module", "Cod_module"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_module", "Cod_module",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_module", "Name_module",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Prefix", "Prefix",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_serie", "Cod_serie",10));
		}

		#endregion

	}
}
