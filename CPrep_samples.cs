using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CPrep_samples: BusinessObjectBase
	{

		#region InnerClass
		public enum CPrep_samplesFields
		{
			Idrecep_sample_detail,
			Flag_humidity_analysis,
			Flag_reject,
			Flag_counter_sample,
			Flag_60celsius,
			Date_creation,
			Input_sample_date,
			Input_sample_user,
			Weight_gross,
			Weight_gross_date,
			Weight_gross_user,
			Weight_moisture,
			Weight_moisture_date,
			Weight_moisture_user,
			Weight_dry,
			Weight_dry_date,
			Weight_dry_user,
			Percent_moisture,
			Moisture_reject,
			Moisture_reject_date,
			Moisture_reject_user,
			Weight_gross_reject,
			Weight_gross_reject_date,
			Weight_gross_reject_user,
			Output_date_sample,
			Output_user_sample,
			Output_date_cs,
			Output_user_cs,
			Output_date_re,
			Output_user_re,
			Observation1,
			Store_input_date_cs,
			Store_input_user_cs,
			Store_input_date_re,
			Store_input_user_re,
			Store_output_date_cs,
			Store_output_user_cs,
			Store_output_date_re,
			Store_output_user_re,
			Observation2
		}
		#endregion

		#region Data Members

			long _idrecep_sample_detail;
			bool? _flag_humidity_analysis;
			bool? _flag_reject;
			short? _flag_counter_sample;
			bool? _flag_60celsius;
			DateTime? _date_creation;
			DateTime? _input_sample_date;
			string _input_sample_user;
			decimal? _weight_gross;
			DateTime? _weight_gross_date;
			string _weight_gross_user;
			decimal? _weight_moisture;
			DateTime? _weight_moisture_date;
			string _weight_moisture_user;
			decimal? _weight_dry;
			DateTime? _weight_dry_date;
			string _weight_dry_user;
			decimal? _percent_moisture;
			bool? _moisture_reject;
			DateTime? _moisture_reject_date;
			string _moisture_reject_user;
			decimal? _weight_gross_reject;
			DateTime? _weight_gross_reject_date;
			string _weight_gross_reject_user;
			DateTime? _output_date_sample;
			DateTime? _output_user_sample;
			DateTime? _output_date_cs;
			string _output_user_cs;
			DateTime? _output_date_re;
			string _output_user_re;
			string _observation1;
			DateTime? _store_input_date_cs;
			string _store_input_user_cs;
			DateTime? _store_input_date_re;
			string _store_input_user_re;
			DateTime? _store_output_date_cs;
			string _store_output_user_cs;
			DateTime? _store_output_date_re;
			string _store_output_user_re;
			string _observation2;

		#endregion

		#region Properties

		public long  Idrecep_sample_detail
		{
			 get { return _idrecep_sample_detail; }
			 set
			 {
				 if (_idrecep_sample_detail != value)
				 {
					_idrecep_sample_detail = value;
					 PropertyHasChanged("Idrecep_sample_detail");
				 }
			 }
		}

		public bool?  Flag_humidity_analysis
		{
			 get { return _flag_humidity_analysis; }
			 set
			 {
				 if (_flag_humidity_analysis != value)
				 {
					_flag_humidity_analysis = value;
					 PropertyHasChanged("Flag_humidity_analysis");
				 }
			 }
		}

		public bool?  Flag_reject
		{
			 get { return _flag_reject; }
			 set
			 {
				 if (_flag_reject != value)
				 {
					_flag_reject = value;
					 PropertyHasChanged("Flag_reject");
				 }
			 }
		}

		public short?  Flag_counter_sample
		{
			 get { return _flag_counter_sample; }
			 set
			 {
				 if (_flag_counter_sample != value)
				 {
					_flag_counter_sample = value;
					 PropertyHasChanged("Flag_counter_sample");
				 }
			 }
		}

		public bool?  Flag_60celsius
		{
			 get { return _flag_60celsius; }
			 set
			 {
				 if (_flag_60celsius != value)
				 {
					_flag_60celsius = value;
					 PropertyHasChanged("Flag_60celsius");
				 }
			 }
		}

		public DateTime?  Date_creation
		{
			 get { return _date_creation; }
			 set
			 {
				 if (_date_creation != value)
				 {
					_date_creation = value;
					 PropertyHasChanged("Date_creation");
				 }
			 }
		}

		public DateTime?  Input_sample_date
		{
			 get { return _input_sample_date; }
			 set
			 {
				 if (_input_sample_date != value)
				 {
					_input_sample_date = value;
					 PropertyHasChanged("Input_sample_date");
				 }
			 }
		}

		public string  Input_sample_user
		{
			 get { return _input_sample_user; }
			 set
			 {
				 if (_input_sample_user != value)
				 {
					_input_sample_user = value;
					 PropertyHasChanged("Input_sample_user");
				 }
			 }
		}

		public decimal?  Weight_gross
		{
			 get { return _weight_gross; }
			 set
			 {
				 if (_weight_gross != value)
				 {
					_weight_gross = value;
					 PropertyHasChanged("Weight_gross");
				 }
			 }
		}

		public DateTime?  Weight_gross_date
		{
			 get { return _weight_gross_date; }
			 set
			 {
				 if (_weight_gross_date != value)
				 {
					_weight_gross_date = value;
					 PropertyHasChanged("Weight_gross_date");
				 }
			 }
		}

		public string  Weight_gross_user
		{
			 get { return _weight_gross_user; }
			 set
			 {
				 if (_weight_gross_user != value)
				 {
					_weight_gross_user = value;
					 PropertyHasChanged("Weight_gross_user");
				 }
			 }
		}

		public decimal?  Weight_moisture
		{
			 get { return _weight_moisture; }
			 set
			 {
				 if (_weight_moisture != value)
				 {
					_weight_moisture = value;
					 PropertyHasChanged("Weight_moisture");
				 }
			 }
		}

		public DateTime?  Weight_moisture_date
		{
			 get { return _weight_moisture_date; }
			 set
			 {
				 if (_weight_moisture_date != value)
				 {
					_weight_moisture_date = value;
					 PropertyHasChanged("Weight_moisture_date");
				 }
			 }
		}

		public string  Weight_moisture_user
		{
			 get { return _weight_moisture_user; }
			 set
			 {
				 if (_weight_moisture_user != value)
				 {
					_weight_moisture_user = value;
					 PropertyHasChanged("Weight_moisture_user");
				 }
			 }
		}

		public decimal?  Weight_dry
		{
			 get { return _weight_dry; }
			 set
			 {
				 if (_weight_dry != value)
				 {
					_weight_dry = value;
					 PropertyHasChanged("Weight_dry");
				 }
			 }
		}

		public DateTime?  Weight_dry_date
		{
			 get { return _weight_dry_date; }
			 set
			 {
				 if (_weight_dry_date != value)
				 {
					_weight_dry_date = value;
					 PropertyHasChanged("Weight_dry_date");
				 }
			 }
		}

		public string  Weight_dry_user
		{
			 get { return _weight_dry_user; }
			 set
			 {
				 if (_weight_dry_user != value)
				 {
					_weight_dry_user = value;
					 PropertyHasChanged("Weight_dry_user");
				 }
			 }
		}

		public decimal?  Percent_moisture
		{
			 get { return _percent_moisture; }
			 set
			 {
				 if (_percent_moisture != value)
				 {
					_percent_moisture = value;
					 PropertyHasChanged("Percent_moisture");
				 }
			 }
		}

		public bool?  Moisture_reject
		{
			 get { return _moisture_reject; }
			 set
			 {
				 if (_moisture_reject != value)
				 {
					_moisture_reject = value;
					 PropertyHasChanged("Moisture_reject");
				 }
			 }
		}

		public DateTime?  Moisture_reject_date
		{
			 get { return _moisture_reject_date; }
			 set
			 {
				 if (_moisture_reject_date != value)
				 {
					_moisture_reject_date = value;
					 PropertyHasChanged("Moisture_reject_date");
				 }
			 }
		}

		public string  Moisture_reject_user
		{
			 get { return _moisture_reject_user; }
			 set
			 {
				 if (_moisture_reject_user != value)
				 {
					_moisture_reject_user = value;
					 PropertyHasChanged("Moisture_reject_user");
				 }
			 }
		}

		public decimal?  Weight_gross_reject
		{
			 get { return _weight_gross_reject; }
			 set
			 {
				 if (_weight_gross_reject != value)
				 {
					_weight_gross_reject = value;
					 PropertyHasChanged("Weight_gross_reject");
				 }
			 }
		}

		public DateTime?  Weight_gross_reject_date
		{
			 get { return _weight_gross_reject_date; }
			 set
			 {
				 if (_weight_gross_reject_date != value)
				 {
					_weight_gross_reject_date = value;
					 PropertyHasChanged("Weight_gross_reject_date");
				 }
			 }
		}

		public string  Weight_gross_reject_user
		{
			 get { return _weight_gross_reject_user; }
			 set
			 {
				 if (_weight_gross_reject_user != value)
				 {
					_weight_gross_reject_user = value;
					 PropertyHasChanged("Weight_gross_reject_user");
				 }
			 }
		}

		public DateTime?  Output_date_sample
		{
			 get { return _output_date_sample; }
			 set
			 {
				 if (_output_date_sample != value)
				 {
					_output_date_sample = value;
					 PropertyHasChanged("Output_date_sample");
				 }
			 }
		}

		public DateTime?  Output_user_sample
		{
			 get { return _output_user_sample; }
			 set
			 {
				 if (_output_user_sample != value)
				 {
					_output_user_sample = value;
					 PropertyHasChanged("Output_user_sample");
				 }
			 }
		}

		public DateTime?  Output_date_cs
		{
			 get { return _output_date_cs; }
			 set
			 {
				 if (_output_date_cs != value)
				 {
					_output_date_cs = value;
					 PropertyHasChanged("Output_date_cs");
				 }
			 }
		}

		public string  Output_user_cs
		{
			 get { return _output_user_cs; }
			 set
			 {
				 if (_output_user_cs != value)
				 {
					_output_user_cs = value;
					 PropertyHasChanged("Output_user_cs");
				 }
			 }
		}

		public DateTime?  Output_date_re
		{
			 get { return _output_date_re; }
			 set
			 {
				 if (_output_date_re != value)
				 {
					_output_date_re = value;
					 PropertyHasChanged("Output_date_re");
				 }
			 }
		}

		public string  Output_user_re
		{
			 get { return _output_user_re; }
			 set
			 {
				 if (_output_user_re != value)
				 {
					_output_user_re = value;
					 PropertyHasChanged("Output_user_re");
				 }
			 }
		}

		public string  Observation1
		{
			 get { return _observation1; }
			 set
			 {
				 if (_observation1 != value)
				 {
					_observation1 = value;
					 PropertyHasChanged("Observation1");
				 }
			 }
		}

		public DateTime?  Store_input_date_cs
		{
			 get { return _store_input_date_cs; }
			 set
			 {
				 if (_store_input_date_cs != value)
				 {
					_store_input_date_cs = value;
					 PropertyHasChanged("Store_input_date_cs");
				 }
			 }
		}

		public string  Store_input_user_cs
		{
			 get { return _store_input_user_cs; }
			 set
			 {
				 if (_store_input_user_cs != value)
				 {
					_store_input_user_cs = value;
					 PropertyHasChanged("Store_input_user_cs");
				 }
			 }
		}

		public DateTime?  Store_input_date_re
		{
			 get { return _store_input_date_re; }
			 set
			 {
				 if (_store_input_date_re != value)
				 {
					_store_input_date_re = value;
					 PropertyHasChanged("Store_input_date_re");
				 }
			 }
		}

		public string  Store_input_user_re
		{
			 get { return _store_input_user_re; }
			 set
			 {
				 if (_store_input_user_re != value)
				 {
					_store_input_user_re = value;
					 PropertyHasChanged("Store_input_user_re");
				 }
			 }
		}

		public DateTime?  Store_output_date_cs
		{
			 get { return _store_output_date_cs; }
			 set
			 {
				 if (_store_output_date_cs != value)
				 {
					_store_output_date_cs = value;
					 PropertyHasChanged("Store_output_date_cs");
				 }
			 }
		}

		public string  Store_output_user_cs
		{
			 get { return _store_output_user_cs; }
			 set
			 {
				 if (_store_output_user_cs != value)
				 {
					_store_output_user_cs = value;
					 PropertyHasChanged("Store_output_user_cs");
				 }
			 }
		}

		public DateTime?  Store_output_date_re
		{
			 get { return _store_output_date_re; }
			 set
			 {
				 if (_store_output_date_re != value)
				 {
					_store_output_date_re = value;
					 PropertyHasChanged("Store_output_date_re");
				 }
			 }
		}

		public string  Store_output_user_re
		{
			 get { return _store_output_user_re; }
			 set
			 {
				 if (_store_output_user_re != value)
				 {
					_store_output_user_re = value;
					 PropertyHasChanged("Store_output_user_re");
				 }
			 }
		}

		public string  Observation2
		{
			 get { return _observation2; }
			 set
			 {
				 if (_observation2 != value)
				 {
					_observation2 = value;
					 PropertyHasChanged("Observation2");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idrecep_sample_detail", "Idrecep_sample_detail"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Input_sample_user", "Input_sample_user",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Weight_gross_user", "Weight_gross_user",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Weight_moisture_user", "Weight_moisture_user",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Weight_dry_user", "Weight_dry_user",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Moisture_reject_user", "Moisture_reject_user",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Weight_gross_reject_user", "Weight_gross_reject_user",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Output_user_cs", "Output_user_cs",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Output_user_re", "Output_user_re",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Observation1", "Observation1",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Store_input_user_cs", "Store_input_user_cs",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Store_input_user_re", "Store_input_user_re",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Store_output_user_cs", "Store_output_user_cs",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Store_output_user_re", "Store_output_user_re",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Observation2", "Observation2",50));
		}

		#endregion

	}
}
