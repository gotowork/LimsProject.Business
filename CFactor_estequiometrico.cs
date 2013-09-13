using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CFactor_estequiometrico: BusinessObjectBase
	{

		#region InnerClass
		public enum CFactor_estequiometricoFields
		{
			Idfactor_estequiometrico,
			Idcompound,
			Idelement,
			Factor,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _idfactor_estequiometrico;
			int? _idcompound;
			int? _idelement;
			decimal? _factor;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public int  Idfactor_estequiometrico
		{
			 get { return _idfactor_estequiometrico; }
			 set
			 {
				 if (_idfactor_estequiometrico != value)
				 {
					_idfactor_estequiometrico = value;
					 PropertyHasChanged("Idfactor_estequiometrico");
				 }
			 }
		}

		public int?  Idcompound
		{
			 get { return _idcompound; }
			 set
			 {
				 if (_idcompound != value)
				 {
					_idcompound = value;
					 PropertyHasChanged("Idcompound");
				 }
			 }
		}

		public int?  Idelement
		{
			 get { return _idelement; }
			 set
			 {
				 if (_idelement != value)
				 {
					_idelement = value;
					 PropertyHasChanged("Idelement");
				 }
			 }
		}

		public decimal?  Factor
		{
			 get { return _factor; }
			 set
			 {
				 if (_factor != value)
				 {
					_factor = value;
					 PropertyHasChanged("Factor");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idfactor_estequiometrico", "Idfactor_estequiometrico"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
