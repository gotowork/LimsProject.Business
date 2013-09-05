using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDestiny_sample_recep: BusinessObjectBase
	{

		#region InnerClass
		public enum CDestiny_sample_recepFields
		{
			Iddestiny_sample_recep,
			Idrecep_sample,
			Return_after_a_cs,
			Return_after_a_re,
			Return_after_t_cs,
			Return_after_t_re,
			Discard_after_t_cs,
			Discard_after_t_re,
			Charge_after_t_cs,
			Charge_after_t_re,
			Percent_discount,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _iddestiny_sample_recep;
			long? _idrecep_sample;
			bool? _return_after_a_cs;
			bool? _return_after_a_re;
			bool? _return_after_t_cs;
			bool? _return_after_t_re;
			bool? _discard_after_t_cs;
			bool? _discard_after_t_re;
			bool? _charge_after_t_cs;
			bool? _charge_after_t_re;
			decimal? _percent_discount;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public int  Iddestiny_sample_recep
		{
			 get { return _iddestiny_sample_recep; }
			 set
			 {
				 if (_iddestiny_sample_recep != value)
				 {
					_iddestiny_sample_recep = value;
					 PropertyHasChanged("Iddestiny_sample_recep");
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

		public bool?  Return_after_a_cs
		{
			 get { return _return_after_a_cs; }
			 set
			 {
				 if (_return_after_a_cs != value)
				 {
					_return_after_a_cs = value;
					 PropertyHasChanged("Return_after_a_cs");
				 }
			 }
		}

		public bool?  Return_after_a_re
		{
			 get { return _return_after_a_re; }
			 set
			 {
				 if (_return_after_a_re != value)
				 {
					_return_after_a_re = value;
					 PropertyHasChanged("Return_after_a_re");
				 }
			 }
		}

		public bool?  Return_after_t_cs
		{
			 get { return _return_after_t_cs; }
			 set
			 {
				 if (_return_after_t_cs != value)
				 {
					_return_after_t_cs = value;
					 PropertyHasChanged("Return_after_t_cs");
				 }
			 }
		}

		public bool?  Return_after_t_re
		{
			 get { return _return_after_t_re; }
			 set
			 {
				 if (_return_after_t_re != value)
				 {
					_return_after_t_re = value;
					 PropertyHasChanged("Return_after_t_re");
				 }
			 }
		}

		public bool?  Discard_after_t_cs
		{
			 get { return _discard_after_t_cs; }
			 set
			 {
				 if (_discard_after_t_cs != value)
				 {
					_discard_after_t_cs = value;
					 PropertyHasChanged("Discard_after_t_cs");
				 }
			 }
		}

		public bool?  Discard_after_t_re
		{
			 get { return _discard_after_t_re; }
			 set
			 {
				 if (_discard_after_t_re != value)
				 {
					_discard_after_t_re = value;
					 PropertyHasChanged("Discard_after_t_re");
				 }
			 }
		}

		public bool?  Charge_after_t_cs
		{
			 get { return _charge_after_t_cs; }
			 set
			 {
				 if (_charge_after_t_cs != value)
				 {
					_charge_after_t_cs = value;
					 PropertyHasChanged("Charge_after_t_cs");
				 }
			 }
		}

		public bool?  Charge_after_t_re
		{
			 get { return _charge_after_t_re; }
			 set
			 {
				 if (_charge_after_t_re != value)
				 {
					_charge_after_t_re = value;
					 PropertyHasChanged("Charge_after_t_re");
				 }
			 }
		}

		public decimal?  Percent_discount
		{
			 get { return _percent_discount; }
			 set
			 {
				 if (_percent_discount != value)
				 {
					_percent_discount = value;
					 PropertyHasChanged("Percent_discount");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Iddestiny_sample_recep", "Iddestiny_sample_recep"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
