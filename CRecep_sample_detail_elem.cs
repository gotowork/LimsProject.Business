using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_sample_detail_elem: BusinessObjectBase
	{

		#region InnerClass
		public enum CRecep_sample_detail_elemFields
		{
			Idrecep_sample_detail_elem,
			Idrecep_sample,
			Idrecep_sample_detail,
			Idelement,
			Idtemplate_method,
			Cost_method,
			Analysis_time,
			Str_result_analysis,
			Result_analysis,
			Idunit,
			Idcompany,
			With_result
		}
		#endregion

		#region Data Members

			long _idrecep_sample_detail_elem;
			long? _idrecep_sample;
			long? _idrecep_sample_detail;
			short? _idelement;
			int? _idtemplate_method;
			decimal? _cost_method;
			short? _analysis_time;
			string _str_result_analysis;
			decimal? _result_analysis;
			short? _idunit;
			int? _idcompany;
			bool? _with_result;

		#endregion

		#region Properties

		public long  Idrecep_sample_detail_elem
		{
			 get { return _idrecep_sample_detail_elem; }
			 set
			 {
				 if (_idrecep_sample_detail_elem != value)
				 {
					_idrecep_sample_detail_elem = value;
					 PropertyHasChanged("Idrecep_sample_detail_elem");
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

		public long?  Idrecep_sample_detail
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

		public short?  Idelement
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

		public int?  Idtemplate_method
		{
			 get { return _idtemplate_method; }
			 set
			 {
				 if (_idtemplate_method != value)
				 {
					_idtemplate_method = value;
					 PropertyHasChanged("Idtemplate_method");
				 }
			 }
		}

		public decimal?  Cost_method
		{
			 get { return _cost_method; }
			 set
			 {
				 if (_cost_method != value)
				 {
					_cost_method = value;
					 PropertyHasChanged("Cost_method");
				 }
			 }
		}

		public short?  Analysis_time
		{
			 get { return _analysis_time; }
			 set
			 {
				 if (_analysis_time != value)
				 {
					_analysis_time = value;
					 PropertyHasChanged("Analysis_time");
				 }
			 }
		}

		public string  Str_result_analysis
		{
			 get { return _str_result_analysis; }
			 set
			 {
				 if (_str_result_analysis != value)
				 {
					_str_result_analysis = value;
					 PropertyHasChanged("Str_result_analysis");
				 }
			 }
		}

		public decimal?  Result_analysis
		{
			 get { return _result_analysis; }
			 set
			 {
				 if (_result_analysis != value)
				 {
					_result_analysis = value;
					 PropertyHasChanged("Result_analysis");
				 }
			 }
		}

		public short?  Idunit
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

		public int?  Idcompany
		{
			 get { return _idcompany; }
			 set
			 {
				 if (_idcompany != value)
				 {
					_idcompany = value;
					 PropertyHasChanged("Idcompany");
				 }
			 }
		}

		public bool?  With_result
		{
			 get { return _with_result; }
			 set
			 {
				 if (_with_result != value)
				 {
					_with_result = value;
					 PropertyHasChanged("With_result");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idrecep_sample_detail_elem", "Idrecep_sample_detail_elem"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Str_result_analysis", "Str_result_analysis",15));
		}

		#endregion

	}
}
