using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CControl_sample_condition: BusinessObjectBase
	{

		#region InnerClass
		public enum CControl_sample_conditionFields
		{
			Idcontrol_sample_condition,
			Idcontrol_sample,
			Matchsample,
			Test,
			Idcondition,
			Msgok,
			Msgerror,
			Flag_apply,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _idcontrol_sample_condition;
			int? _idcontrol_sample;
			string _matchsample;
			string _test;
			int? _idcondition;
			string _msgok;
			string _msgerror;
			bool? _flag_apply;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public int  Idcontrol_sample_condition
		{
			 get { return _idcontrol_sample_condition; }
			 set
			 {
				 if (_idcontrol_sample_condition != value)
				 {
					_idcontrol_sample_condition = value;
					 PropertyHasChanged("Idcontrol_sample_condition");
				 }
			 }
		}

		public int?  Idcontrol_sample
		{
			 get { return _idcontrol_sample; }
			 set
			 {
				 if (_idcontrol_sample != value)
				 {
					_idcontrol_sample = value;
					 PropertyHasChanged("Idcontrol_sample");
				 }
			 }
		}

		public string  Matchsample
		{
			 get { return _matchsample; }
			 set
			 {
				 if (_matchsample != value)
				 {
					_matchsample = value;
					 PropertyHasChanged("Matchsample");
				 }
			 }
		}

		public string  Test
		{
			 get { return _test; }
			 set
			 {
				 if (_test != value)
				 {
					_test = value;
					 PropertyHasChanged("Test");
				 }
			 }
		}

		public int?  Idcondition
		{
			 get { return _idcondition; }
			 set
			 {
				 if (_idcondition != value)
				 {
					_idcondition = value;
					 PropertyHasChanged("Idcondition");
				 }
			 }
		}

		public string  Msgok
		{
			 get { return _msgok; }
			 set
			 {
				 if (_msgok != value)
				 {
					_msgok = value;
					 PropertyHasChanged("Msgok");
				 }
			 }
		}

		public string  Msgerror
		{
			 get { return _msgerror; }
			 set
			 {
				 if (_msgerror != value)
				 {
					_msgerror = value;
					 PropertyHasChanged("Msgerror");
				 }
			 }
		}

		public bool?  Flag_apply
		{
			 get { return _flag_apply; }
			 set
			 {
				 if (_flag_apply != value)
				 {
					_flag_apply = value;
					 PropertyHasChanged("Flag_apply");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idcontrol_sample_condition", "Idcontrol_sample_condition"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Matchsample", "Matchsample",200));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Test", "Test",200));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Msgok", "Msgok",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Msgerror", "Msgerror",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
