using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CBatch_detail_aa_twofold: BusinessObjectBase
	{

		#region InnerClass
		public enum CBatch_detail_aa_twofoldFields
		{
			Idbatch_detail_aa,
			Num_repetition,
			Idtemplate_method,
			Idrecep_sample,
			Idrecep_sample_detail_elem,
			Idrecep_sample_detail,
			Cod_des_sample,
			Order_des_sample,
			Cod_sample,
			Cod_interno,
			Order_sample_batch,
			Flag_mri,
			Weight1,
			Reading1,
			Volumen1,
			Factor1,
			Law1,
			Law1_long,
			Sample_mr_blk1,
			Weight2,
			Reading2,
			Volumen2,
			Factor2,
			Law2,
			Law2_long,
			Sample_mr_blk2,
			Dilu2,
			Flag_dilu2,
			Dilu3,
			Flag_dilu3,
			Idbatch,
			Verify_equip,
			Verify_curve,
			Idtype_rep,
			Idmr_detail,
			Idmr_jar,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Idequipment1,
			Status,
			Str_result_analysis,
			Result_analysis,
			Fum,
			Idunit_result,
			Qaqc_status_result,
			Qaqc_blk,
			Qaqc_par,
			Qaqc_mr,
			Qaqc_approve_text,
			Qaqc_approve,
			Qaqc_error,
			Qaqc_review_text,
			Qaqc_review,
			Qaqc_par_prev_batch,
			Qaqc_tmp_retest_idmethod,
			Qaqc_tmp_retest,
			Qaqc_has_retest
		}
		#endregion

		#region Data Members

			long _idbatch_detail_aa;
			short? _num_repetition;
			int? _idtemplate_method;
			long? _idrecep_sample;
			long? _idrecep_sample_detail_elem;
			long? _idrecep_sample_detail;
			string _cod_des_sample;
			short? _order_des_sample;
			string _cod_sample;
			long? _cod_interno;
			short? _order_sample_batch;
			int? _flag_mri;
			decimal? _weight1;
			string _reading1;
			decimal? _volumen1;
			string _factor1;
			string _law1;
			decimal? _law1_long;
			char? _sample_mr_blk1;
			decimal? _weight2;
			string _reading2;
			decimal? _volumen2;
			string _factor2;
			string _law2;
			decimal? _law2_long;
			char? _sample_mr_blk2;
			decimal? _dilu2;
			bool? _flag_dilu2;
			decimal? _dilu3;
			bool? _flag_dilu3;
			long? _idbatch;
			decimal? _verify_equip;
			decimal? _verify_curve;
			char? _idtype_rep;
			short? _idmr_detail;
			short? _idmr_jar;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			short? _idequipment1;
			bool? _status;
			string _str_result_analysis;
			decimal? _result_analysis;
			decimal? _fum;
			short? _idunit_result;
			int? _qaqc_status_result;
			int? _qaqc_blk;
			int? _qaqc_par;
			int? _qaqc_mr;
			string _qaqc_approve_text;
			bool? _qaqc_approve;
			int? _qaqc_error;
			string _qaqc_review_text;
			bool? _qaqc_review;
			int? _qaqc_par_prev_batch;
			int? _qaqc_tmp_retest_idmethod;
			int? _qaqc_tmp_retest;
			int? _qaqc_has_retest;

		#endregion

		#region Properties

		public long  Idbatch_detail_aa
		{
			 get { return _idbatch_detail_aa; }
			 set
			 {
				 if (_idbatch_detail_aa != value)
				 {
					_idbatch_detail_aa = value;
					 PropertyHasChanged("Idbatch_detail_aa");
				 }
			 }
		}

		public short?  Num_repetition
		{
			 get { return _num_repetition; }
			 set
			 {
				 if (_num_repetition != value)
				 {
					_num_repetition = value;
					 PropertyHasChanged("Num_repetition");
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

		public string  Cod_des_sample
		{
			 get { return _cod_des_sample; }
			 set
			 {
				 if (_cod_des_sample != value)
				 {
					_cod_des_sample = value;
					 PropertyHasChanged("Cod_des_sample");
				 }
			 }
		}

		public short?  Order_des_sample
		{
			 get { return _order_des_sample; }
			 set
			 {
				 if (_order_des_sample != value)
				 {
					_order_des_sample = value;
					 PropertyHasChanged("Order_des_sample");
				 }
			 }
		}

		public string  Cod_sample
		{
			 get { return _cod_sample; }
			 set
			 {
				 if (_cod_sample != value)
				 {
					_cod_sample = value;
					 PropertyHasChanged("Cod_sample");
				 }
			 }
		}

		public long?  Cod_interno
		{
			 get { return _cod_interno; }
			 set
			 {
				 if (_cod_interno != value)
				 {
					_cod_interno = value;
					 PropertyHasChanged("Cod_interno");
				 }
			 }
		}

		public short?  Order_sample_batch
		{
			 get { return _order_sample_batch; }
			 set
			 {
				 if (_order_sample_batch != value)
				 {
					_order_sample_batch = value;
					 PropertyHasChanged("Order_sample_batch");
				 }
			 }
		}

		public int?  Flag_mri
		{
			 get { return _flag_mri; }
			 set
			 {
				 if (_flag_mri != value)
				 {
					_flag_mri = value;
					 PropertyHasChanged("Flag_mri");
				 }
			 }
		}

		public decimal?  Weight1
		{
			 get { return _weight1; }
			 set
			 {
				 if (_weight1 != value)
				 {
					_weight1 = value;
					 PropertyHasChanged("Weight1");
				 }
			 }
		}

		public string  Reading1
		{
			 get { return _reading1; }
			 set
			 {
				 if (_reading1 != value)
				 {
					_reading1 = value;
					 PropertyHasChanged("Reading1");
				 }
			 }
		}

		public decimal?  Volumen1
		{
			 get { return _volumen1; }
			 set
			 {
				 if (_volumen1 != value)
				 {
					_volumen1 = value;
					 PropertyHasChanged("Volumen1");
				 }
			 }
		}

		public string  Factor1
		{
			 get { return _factor1; }
			 set
			 {
				 if (_factor1 != value)
				 {
					_factor1 = value;
					 PropertyHasChanged("Factor1");
				 }
			 }
		}

		public string  Law1
		{
			 get { return _law1; }
			 set
			 {
				 if (_law1 != value)
				 {
					_law1 = value;
					 PropertyHasChanged("Law1");
				 }
			 }
		}

		public decimal?  Law1_long
		{
			 get { return _law1_long; }
			 set
			 {
				 if (_law1_long != value)
				 {
					_law1_long = value;
					 PropertyHasChanged("Law1_long");
				 }
			 }
		}

		public char?  Sample_mr_blk1
		{
			 get { return _sample_mr_blk1; }
			 set
			 {
				 if (_sample_mr_blk1 != value)
				 {
					_sample_mr_blk1 = value;
					 PropertyHasChanged("Sample_mr_blk1");
				 }
			 }
		}

		public decimal?  Weight2
		{
			 get { return _weight2; }
			 set
			 {
				 if (_weight2 != value)
				 {
					_weight2 = value;
					 PropertyHasChanged("Weight2");
				 }
			 }
		}

		public string  Reading2
		{
			 get { return _reading2; }
			 set
			 {
				 if (_reading2 != value)
				 {
					_reading2 = value;
					 PropertyHasChanged("Reading2");
				 }
			 }
		}

		public decimal?  Volumen2
		{
			 get { return _volumen2; }
			 set
			 {
				 if (_volumen2 != value)
				 {
					_volumen2 = value;
					 PropertyHasChanged("Volumen2");
				 }
			 }
		}

		public string  Factor2
		{
			 get { return _factor2; }
			 set
			 {
				 if (_factor2 != value)
				 {
					_factor2 = value;
					 PropertyHasChanged("Factor2");
				 }
			 }
		}

		public string  Law2
		{
			 get { return _law2; }
			 set
			 {
				 if (_law2 != value)
				 {
					_law2 = value;
					 PropertyHasChanged("Law2");
				 }
			 }
		}

		public decimal?  Law2_long
		{
			 get { return _law2_long; }
			 set
			 {
				 if (_law2_long != value)
				 {
					_law2_long = value;
					 PropertyHasChanged("Law2_long");
				 }
			 }
		}

		public char?  Sample_mr_blk2
		{
			 get { return _sample_mr_blk2; }
			 set
			 {
				 if (_sample_mr_blk2 != value)
				 {
					_sample_mr_blk2 = value;
					 PropertyHasChanged("Sample_mr_blk2");
				 }
			 }
		}

		public decimal?  Dilu2
		{
			 get { return _dilu2; }
			 set
			 {
				 if (_dilu2 != value)
				 {
					_dilu2 = value;
					 PropertyHasChanged("Dilu2");
				 }
			 }
		}

		public bool?  Flag_dilu2
		{
			 get { return _flag_dilu2; }
			 set
			 {
				 if (_flag_dilu2 != value)
				 {
					_flag_dilu2 = value;
					 PropertyHasChanged("Flag_dilu2");
				 }
			 }
		}

		public decimal?  Dilu3
		{
			 get { return _dilu3; }
			 set
			 {
				 if (_dilu3 != value)
				 {
					_dilu3 = value;
					 PropertyHasChanged("Dilu3");
				 }
			 }
		}

		public bool?  Flag_dilu3
		{
			 get { return _flag_dilu3; }
			 set
			 {
				 if (_flag_dilu3 != value)
				 {
					_flag_dilu3 = value;
					 PropertyHasChanged("Flag_dilu3");
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

		public decimal?  Verify_equip
		{
			 get { return _verify_equip; }
			 set
			 {
				 if (_verify_equip != value)
				 {
					_verify_equip = value;
					 PropertyHasChanged("Verify_equip");
				 }
			 }
		}

		public decimal?  Verify_curve
		{
			 get { return _verify_curve; }
			 set
			 {
				 if (_verify_curve != value)
				 {
					_verify_curve = value;
					 PropertyHasChanged("Verify_curve");
				 }
			 }
		}

		public char?  Idtype_rep
		{
			 get { return _idtype_rep; }
			 set
			 {
				 if (_idtype_rep != value)
				 {
					_idtype_rep = value;
					 PropertyHasChanged("Idtype_rep");
				 }
			 }
		}

		public short?  Idmr_detail
		{
			 get { return _idmr_detail; }
			 set
			 {
				 if (_idmr_detail != value)
				 {
					_idmr_detail = value;
					 PropertyHasChanged("Idmr_detail");
				 }
			 }
		}

		public short?  Idmr_jar
		{
			 get { return _idmr_jar; }
			 set
			 {
				 if (_idmr_jar != value)
				 {
					_idmr_jar = value;
					 PropertyHasChanged("Idmr_jar");
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

		public short?  Idequipment1
		{
			 get { return _idequipment1; }
			 set
			 {
				 if (_idequipment1 != value)
				 {
					_idequipment1 = value;
					 PropertyHasChanged("Idequipment1");
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

		public decimal?  Fum
		{
			 get { return _fum; }
			 set
			 {
				 if (_fum != value)
				 {
					_fum = value;
					 PropertyHasChanged("Fum");
				 }
			 }
		}

		public short?  Idunit_result
		{
			 get { return _idunit_result; }
			 set
			 {
				 if (_idunit_result != value)
				 {
					_idunit_result = value;
					 PropertyHasChanged("Idunit_result");
				 }
			 }
		}

		public int?  Qaqc_status_result
		{
			 get { return _qaqc_status_result; }
			 set
			 {
				 if (_qaqc_status_result != value)
				 {
					_qaqc_status_result = value;
					 PropertyHasChanged("Qaqc_status_result");
				 }
			 }
		}

		public int?  Qaqc_blk
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

		public int?  Qaqc_par
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

		public int?  Qaqc_mr
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

		public string  Qaqc_approve_text
		{
			 get { return _qaqc_approve_text; }
			 set
			 {
				 if (_qaqc_approve_text != value)
				 {
					_qaqc_approve_text = value;
					 PropertyHasChanged("Qaqc_approve_text");
				 }
			 }
		}

		public bool?  Qaqc_approve
		{
			 get { return _qaqc_approve; }
			 set
			 {
				 if (_qaqc_approve != value)
				 {
					_qaqc_approve = value;
					 PropertyHasChanged("Qaqc_approve");
				 }
			 }
		}

		public int?  Qaqc_error
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

		public string  Qaqc_review_text
		{
			 get { return _qaqc_review_text; }
			 set
			 {
				 if (_qaqc_review_text != value)
				 {
					_qaqc_review_text = value;
					 PropertyHasChanged("Qaqc_review_text");
				 }
			 }
		}

		public bool?  Qaqc_review
		{
			 get { return _qaqc_review; }
			 set
			 {
				 if (_qaqc_review != value)
				 {
					_qaqc_review = value;
					 PropertyHasChanged("Qaqc_review");
				 }
			 }
		}

		public int?  Qaqc_par_prev_batch
		{
			 get { return _qaqc_par_prev_batch; }
			 set
			 {
				 if (_qaqc_par_prev_batch != value)
				 {
					_qaqc_par_prev_batch = value;
					 PropertyHasChanged("Qaqc_par_prev_batch");
				 }
			 }
		}

		public int?  Qaqc_tmp_retest_idmethod
		{
			 get { return _qaqc_tmp_retest_idmethod; }
			 set
			 {
				 if (_qaqc_tmp_retest_idmethod != value)
				 {
					_qaqc_tmp_retest_idmethod = value;
					 PropertyHasChanged("Qaqc_tmp_retest_idmethod");
				 }
			 }
		}

		public int?  Qaqc_tmp_retest
		{
			 get { return _qaqc_tmp_retest; }
			 set
			 {
				 if (_qaqc_tmp_retest != value)
				 {
					_qaqc_tmp_retest = value;
					 PropertyHasChanged("Qaqc_tmp_retest");
				 }
			 }
		}

		public int?  Qaqc_has_retest
		{
			 get { return _qaqc_has_retest; }
			 set
			 {
				 if (_qaqc_has_retest != value)
				 {
					_qaqc_has_retest = value;
					 PropertyHasChanged("Qaqc_has_retest");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idbatch_detail_aa", "Idbatch_detail_aa"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_des_sample", "Cod_des_sample",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_sample", "Cod_sample",12));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Reading1", "Reading1",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Factor1", "Factor1",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Law1", "Law1",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Reading2", "Reading2",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Factor2", "Factor2",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Law2", "Law2",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Str_result_analysis", "Str_result_analysis",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Qaqc_approve_text", "Qaqc_approve_text",200));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Qaqc_review_text", "Qaqc_review_text",200));
		}

		#endregion

	}
}
