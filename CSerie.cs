using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CSerie: BusinessObjectBase
	{

		#region InnerClass
		public enum CSerieFields
		{
			Cod_serie,
			Nom_serie,
			Num_digits,
			Dateinit,
			Dateend,
			Status_serie,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			string _cod_serie;
			string _nom_serie;
			short? _num_digits;
			DateTime? _dateinit;
			DateTime? _dateend;
			bool? _status_serie;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

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

		public string  Nom_serie
		{
			 get { return _nom_serie; }
			 set
			 {
				 if (_nom_serie != value)
				 {
					_nom_serie = value;
					 PropertyHasChanged("Nom_serie");
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

		public DateTime?  Dateinit
		{
			 get { return _dateinit; }
			 set
			 {
				 if (_dateinit != value)
				 {
					_dateinit = value;
					 PropertyHasChanged("Dateinit");
				 }
			 }
		}

		public DateTime?  Dateend
		{
			 get { return _dateend; }
			 set
			 {
				 if (_dateend != value)
				 {
					_dateend = value;
					 PropertyHasChanged("Dateend");
				 }
			 }
		}

		public bool?  Status_serie
		{
			 get { return _status_serie; }
			 set
			 {
				 if (_status_serie != value)
				 {
					_status_serie = value;
					 PropertyHasChanged("Status_serie");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Cod_serie", "Cod_serie"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_serie", "Cod_serie",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Nom_serie", "Nom_serie",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
