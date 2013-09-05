using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CBatch_detail_aa: BusinessObjectBase
	{

		#region InnerClass
		public enum CBatch_detail_aaFields
		{
			Idbatch_detail_aa,
			Num_repetition,
			Idtemplate_method,
			Idrecep_sample,
			Idrecep_sample_detail_elem,
			Idrecep_sample_detail,
			Weight,
			Reading,
			Volumen,
			Dilua,
			Dilub,
			Factor,
			Rank,
			Law,
			Verify_equip,
			Verify_curve,
			Flag_dila,
			Flag_dilb,
			Idbatch,
			Idtype_rep,
			Sample_mr_blk,
			Idmr_detail,
			Idmr_jar,
			Usernew,
			Datenew,
			Useredit1,
			Dateedit1,
			Idequipment1,
			Status
		}
		#endregion

		#region Data Members

			long _idbatch_detail_aa;
			short? _num_repetition;
			int? _idtemplate_method;
			long? _idrecep_sample;
			long? _idrecep_sample_detail_elem;
			long? _idrecep_sample_detail;
			decimal? _weight;
			decimal? _reading;
			decimal? _volumen;
			decimal? _dilua;
			decimal? _dilub;
			decimal? _factor;
			decimal? _rank;
			decimal? _law;
			decimal? _verify_equip;
			decimal? _verify_curve;
			bool? _flag_dila;
			bool? _flag_dilb;
			long? _idbatch;
			char? _idtype_rep;
			char? _sample_mr_blk;
			short? _idmr_detail;
			short? _idmr_jar;
			string _usernew;
			DateTime? _datenew;
			string _useredit1;
			DateTime? _dateedit1;
			short? _idequipment1;
			bool? _status;

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

		public decimal?  Weight
		{
			 get { return _weight; }
			 set
			 {
				 if (_weight != value)
				 {
					_weight = value;
					 PropertyHasChanged("Weight");
				 }
			 }
		}

		public decimal?  Reading
		{
			 get { return _reading; }
			 set
			 {
				 if (_reading != value)
				 {
					_reading = value;
					 PropertyHasChanged("Reading");
				 }
			 }
		}

		public decimal?  Volumen
		{
			 get { return _volumen; }
			 set
			 {
				 if (_volumen != value)
				 {
					_volumen = value;
					 PropertyHasChanged("Volumen");
				 }
			 }
		}

		public decimal?  Dilua
		{
			 get { return _dilua; }
			 set
			 {
				 if (_dilua != value)
				 {
					_dilua = value;
					 PropertyHasChanged("Dilua");
				 }
			 }
		}

		public decimal?  Dilub
		{
			 get { return _dilub; }
			 set
			 {
				 if (_dilub != value)
				 {
					_dilub = value;
					 PropertyHasChanged("Dilub");
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

		public decimal?  Rank
		{
			 get { return _rank; }
			 set
			 {
				 if (_rank != value)
				 {
					_rank = value;
					 PropertyHasChanged("Rank");
				 }
			 }
		}

		public decimal?  Law
		{
			 get { return _law; }
			 set
			 {
				 if (_law != value)
				 {
					_law = value;
					 PropertyHasChanged("Law");
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

		public bool?  Flag_dila
		{
			 get { return _flag_dila; }
			 set
			 {
				 if (_flag_dila != value)
				 {
					_flag_dila = value;
					 PropertyHasChanged("Flag_dila");
				 }
			 }
		}

		public bool?  Flag_dilb
		{
			 get { return _flag_dilb; }
			 set
			 {
				 if (_flag_dilb != value)
				 {
					_flag_dilb = value;
					 PropertyHasChanged("Flag_dilb");
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

		public char?  Sample_mr_blk
		{
			 get { return _sample_mr_blk; }
			 set
			 {
				 if (_sample_mr_blk != value)
				 {
					_sample_mr_blk = value;
					 PropertyHasChanged("Sample_mr_blk");
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

		public string  Useredit1
		{
			 get { return _useredit1; }
			 set
			 {
				 if (_useredit1 != value)
				 {
					_useredit1 = value;
					 PropertyHasChanged("Useredit1");
				 }
			 }
		}

		public DateTime?  Dateedit1
		{
			 get { return _dateedit1; }
			 set
			 {
				 if (_dateedit1 != value)
				 {
					_dateedit1 = value;
					 PropertyHasChanged("Dateedit1");
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idbatch_detail_aa", "Idbatch_detail_aa"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit1", "Useredit1",20));
		}

		#endregion

	}
}
