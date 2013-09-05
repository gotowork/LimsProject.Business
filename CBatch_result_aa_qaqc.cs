using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CBatch_result_aa_qaqc: BusinessObjectBase
	{

		#region InnerClass
		public enum CBatch_result_aa_qaqcFields
		{
			Idbatch_result_aa_qaqc,
			Idbatch,
			Idrecep_sample_detail_elem,
			Idrecep_sample_detail,
			Idrecep_sample,
			Str_result_analysis,
			Result_analysis,
			Status_result,
			Idunit,
			Qaqc_blk,
			Qaqc_par,
			Qaqc_mr,
			Qaqc_approve_retest,
			Qaqc_text_obs,
			Qaqc_error,
			Qaqc_flag_checked
		}
		#endregion

		#region Data Members

			long _idbatch_result_aa_qaqc;
			long? _idbatch;
			long? _idrecep_sample_detail_elem;
			long? _idrecep_sample_detail;
			long? _idrecep_sample;
			string _str_result_analysis;
			decimal? _result_analysis;
			short? _status_result;
			short? _idunit;
			short? _qaqc_blk;
			short? _qaqc_par;
			short? _qaqc_mr;
			short? _qaqc_approve_retest;
			string _qaqc_text_obs;
			short? _qaqc_error;
			bool? _qaqc_flag_checked;

		#endregion

		#region Properties

		public long  Idbatch_result_aa_qaqc
		{
			 get { return _idbatch_result_aa_qaqc; }
			 set
			 {
				 if (_idbatch_result_aa_qaqc != value)
				 {
					_idbatch_result_aa_qaqc = value;
					 PropertyHasChanged("Idbatch_result_aa_qaqc");
				 }
			 }
		}

		public long?  Idbatch
		{
			 get { return _idbatch; }
			 set
			 {
				 if (_idbatch != value)
				 {
					_idbatch = value;
					 PropertyHasChanged("Idbatch");
				 }
			 }
		}

		public long?  Idrecep_sample_detail_elem
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

		public short?  Status_result
		{
			 get { return _status_result; }
			 set
			 {
				 if (_status_result != value)
				 {
					_status_result = value;
					 PropertyHasChanged("Status_result");
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

		public short?  Qaqc_blk
		{
			 get { return _qaqc_blk; }
			 set
			 {
				 if (_qaqc_blk != value)
				 {
					_qaqc_blk = value;
					 PropertyHasChanged("Qaqc_blk");
				 }
			 }
		}

		public short?  Qaqc_par
		{
			 get { return _qaqc_par; }
			 set
			 {
				 if (_qaqc_par != value)
				 {
					_qaqc_par = value;
					 PropertyHasChanged("Qaqc_par");
				 }
			 }
		}

		public short?  Qaqc_mr
		{
			 get { return _qaqc_mr; }
			 set
			 {
				 if (_qaqc_mr != value)
				 {
					_qaqc_mr = value;
					 PropertyHasChanged("Qaqc_mr");
				 }
			 }
		}

		public short?  Qaqc_approve_retest
		{
			 get { return _qaqc_approve_retest; }
			 set
			 {
				 if (_qaqc_approve_retest != value)
				 {
					_qaqc_approve_retest = value;
					 PropertyHasChanged("Qaqc_approve_retest");
				 }
			 }
		}

		public string  Qaqc_text_obs
		{
			 get { return _qaqc_text_obs; }
			 set
			 {
				 if (_qaqc_text_obs != value)
				 {
					_qaqc_text_obs = value;
					 PropertyHasChanged("Qaqc_text_obs");
				 }
			 }
		}

		public short?  Qaqc_error
		{
			 get { return _qaqc_error; }
			 set
			 {
				 if (_qaqc_error != value)
				 {
					_qaqc_error = value;
					 PropertyHasChanged("Qaqc_error");
				 }
			 }
		}

		public bool?  Qaqc_flag_checked
		{
			 get { return _qaqc_flag_checked; }
			 set
			 {
				 if (_qaqc_flag_checked != value)
				 {
					_qaqc_flag_checked = value;
					 PropertyHasChanged("Qaqc_flag_checked");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idbatch_result_aa_qaqc", "Idbatch_result_aa_qaqc"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Str_result_analysis", "Str_result_analysis",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Qaqc_text_obs", "Qaqc_text_obs",200));
		}

		#endregion

	}
}
