using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDestiny_samples: BusinessObjectBase
	{

		#region InnerClass
		public enum CDestiny_samplesFields
		{
			Iddestiny_samples,
			Description,
			Cost_counter_sample,
			Cost_reject_sample,
			Time_without_cost,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _iddestiny_samples;
			string _description;
			decimal? _cost_counter_sample;
			decimal? _cost_reject_sample;
			int? _time_without_cost;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public int  Iddestiny_samples
		{
			 get { return _iddestiny_samples; }
			 set
			 {
				 if (_iddestiny_samples != value)
				 {
					_iddestiny_samples = value;
					 PropertyHasChanged("Iddestiny_samples");
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

		public decimal?  Cost_counter_sample
		{
			 get { return _cost_counter_sample; }
			 set
			 {
				 if (_cost_counter_sample != value)
				 {
					_cost_counter_sample = value;
					 PropertyHasChanged("Cost_counter_sample");
				 }
			 }
		}

		public decimal?  Cost_reject_sample
		{
			 get { return _cost_reject_sample; }
			 set
			 {
				 if (_cost_reject_sample != value)
				 {
					_cost_reject_sample = value;
					 PropertyHasChanged("Cost_reject_sample");
				 }
			 }
		}

		public int?  Time_without_cost
		{
			 get { return _time_without_cost; }
			 set
			 {
				 if (_time_without_cost != value)
				 {
					_time_without_cost = value;
					 PropertyHasChanged("Time_without_cost");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Iddestiny_samples", "Iddestiny_samples"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",30));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
