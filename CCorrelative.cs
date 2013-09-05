using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCorrelative: BusinessObjectBase
	{

		#region InnerClass
		public enum CCorrelativeFields
		{
			Cod_type_sample,
			Cod_serie,
			Prefix,
			Correlative,
			Mreach15,
			Num_digits,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			string _cod_type_sample;
			string _cod_serie;
			string _prefix;
			int? _correlative;
			bool? _mreach15;
			short? _num_digits;
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

		public bool?  Mreach15
		{
			 get { return _mreach15; }
			 set
			 {
				 if (_mreach15 != value)
				 {
					_mreach15 = value;
					 PropertyHasChanged("Mreach15");
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Cod_type_sample", "Cod_type_sample"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_type_sample", "Cod_type_sample",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_serie", "Cod_serie",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Prefix", "Prefix",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",50));
		}

		#endregion

	}
}
