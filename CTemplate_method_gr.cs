using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTemplate_method_gr: BusinessObjectBase
	{

		#region InnerClass
		public enum CTemplate_method_grFields
		{
			Idtemplate_method,
			Weight,
			Weight_incertitude,
			Reading_min,
			Reading_max,
			Reason_rep,
			Error_allowed,
			Symbol,
			Law_limit_bottom,
			Law_limit_top,
			Num_decimal,
			Flag_mr,
			Idmr_detail,
			Mr_incertitude,
			Blk_max,
			Reproducibility,
			Flagsamfortify,
			Samfortisol,
			Samfortialiquot,
			Samfortireproducibility,
			Flagblkfortify,
			Blkfortisol,
			Blkfortialiquot,
			Blkfortireproducibility,
			Date_allowed_error,
			Idunit_result,
			Num_samples,
			Num_days,
			Limit_samples,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _idtemplate_method;
			decimal? _weight;
			decimal? _weight_incertitude;
			decimal? _reading_min;
			decimal? _reading_max;
			decimal? _reason_rep;
			decimal? _error_allowed;
			string _symbol;
			decimal? _law_limit_bottom;
			decimal? _law_limit_top;
			short? _num_decimal;
			bool? _flag_mr;
			short? _idmr_detail;
			decimal? _mr_incertitude;
			decimal? _blk_max;
			decimal? _reproducibility;
			bool? _flagsamfortify;
			decimal? _samfortisol;
			decimal? _samfortialiquot;
			decimal? _samfortireproducibility;
			bool? _flagblkfortify;
			decimal? _blkfortisol;
			decimal? _blkfortialiquot;
			decimal? _blkfortireproducibility;
			DateTime? _date_allowed_error;
			short? _idunit_result;
			short? _num_samples;
			short? _num_days;
			short? _limit_samples;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public int  Idtemplate_method
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

		public decimal?  Weight_incertitude
		{
			 get { return _weight_incertitude; }
			 set
			 {
				 if (_weight_incertitude != value)
				 {
					_weight_incertitude = value;
					 PropertyHasChanged("Weight_incertitude");
				 }
			 }
		}

		public decimal?  Reading_min
		{
			 get { return _reading_min; }
			 set
			 {
				 if (_reading_min != value)
				 {
					_reading_min = value;
					 PropertyHasChanged("Reading_min");
				 }
			 }
		}

		public decimal?  Reading_max
		{
			 get { return _reading_max; }
			 set
			 {
				 if (_reading_max != value)
				 {
					_reading_max = value;
					 PropertyHasChanged("Reading_max");
				 }
			 }
		}

		public decimal?  Reason_rep
		{
			 get { return _reason_rep; }
			 set
			 {
				 if (_reason_rep != value)
				 {
					_reason_rep = value;
					 PropertyHasChanged("Reason_rep");
				 }
			 }
		}

		public decimal?  Error_allowed
		{
			 get { return _error_allowed; }
			 set
			 {
				 if (_error_allowed != value)
				 {
					_error_allowed = value;
					 PropertyHasChanged("Error_allowed");
				 }
			 }
		}

		public string  Symbol
		{
			 get { return _symbol; }
			 set
			 {
				 if (_symbol != value)
				 {
					_symbol = value;
					 PropertyHasChanged("Symbol");
				 }
			 }
		}

		public decimal?  Law_limit_bottom
		{
			 get { return _law_limit_bottom; }
			 set
			 {
				 if (_law_limit_bottom != value)
				 {
					_law_limit_bottom = value;
					 PropertyHasChanged("Law_limit_bottom");
				 }
			 }
		}

		public decimal?  Law_limit_top
		{
			 get { return _law_limit_top; }
			 set
			 {
				 if (_law_limit_top != value)
				 {
					_law_limit_top = value;
					 PropertyHasChanged("Law_limit_top");
				 }
			 }
		}

		public short?  Num_decimal
		{
			 get { return _num_decimal; }
			 set
			 {
				 if (_num_decimal != value)
				 {
					_num_decimal = value;
					 PropertyHasChanged("Num_decimal");
				 }
			 }
		}

		public bool?  Flag_mr
		{
			 get { return _flag_mr; }
			 set
			 {
				 if (_flag_mr != value)
				 {
					_flag_mr = value;
					 PropertyHasChanged("Flag_mr");
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

		public decimal?  Mr_incertitude
		{
			 get { return _mr_incertitude; }
			 set
			 {
				 if (_mr_incertitude != value)
				 {
					_mr_incertitude = value;
					 PropertyHasChanged("Mr_incertitude");
				 }
			 }
		}

		public decimal?  Blk_max
		{
			 get { return _blk_max; }
			 set
			 {
				 if (_blk_max != value)
				 {
					_blk_max = value;
					 PropertyHasChanged("Blk_max");
				 }
			 }
		}

		public decimal?  Reproducibility
		{
			 get { return _reproducibility; }
			 set
			 {
				 if (_reproducibility != value)
				 {
					_reproducibility = value;
					 PropertyHasChanged("Reproducibility");
				 }
			 }
		}

		public bool?  Flagsamfortify
		{
			 get { return _flagsamfortify; }
			 set
			 {
				 if (_flagsamfortify != value)
				 {
					_flagsamfortify = value;
					 PropertyHasChanged("Flagsamfortify");
				 }
			 }
		}

		public decimal?  Samfortisol
		{
			 get { return _samfortisol; }
			 set
			 {
				 if (_samfortisol != value)
				 {
					_samfortisol = value;
					 PropertyHasChanged("Samfortisol");
				 }
			 }
		}

		public decimal?  Samfortialiquot
		{
			 get { return _samfortialiquot; }
			 set
			 {
				 if (_samfortialiquot != value)
				 {
					_samfortialiquot = value;
					 PropertyHasChanged("Samfortialiquot");
				 }
			 }
		}

		public decimal?  Samfortireproducibility
		{
			 get { return _samfortireproducibility; }
			 set
			 {
				 if (_samfortireproducibility != value)
				 {
					_samfortireproducibility = value;
					 PropertyHasChanged("Samfortireproducibility");
				 }
			 }
		}

		public bool?  Flagblkfortify
		{
			 get { return _flagblkfortify; }
			 set
			 {
				 if (_flagblkfortify != value)
				 {
					_flagblkfortify = value;
					 PropertyHasChanged("Flagblkfortify");
				 }
			 }
		}

		public decimal?  Blkfortisol
		{
			 get { return _blkfortisol; }
			 set
			 {
				 if (_blkfortisol != value)
				 {
					_blkfortisol = value;
					 PropertyHasChanged("Blkfortisol");
				 }
			 }
		}

		public decimal?  Blkfortialiquot
		{
			 get { return _blkfortialiquot; }
			 set
			 {
				 if (_blkfortialiquot != value)
				 {
					_blkfortialiquot = value;
					 PropertyHasChanged("Blkfortialiquot");
				 }
			 }
		}

		public decimal?  Blkfortireproducibility
		{
			 get { return _blkfortireproducibility; }
			 set
			 {
				 if (_blkfortireproducibility != value)
				 {
					_blkfortireproducibility = value;
					 PropertyHasChanged("Blkfortireproducibility");
				 }
			 }
		}

		public DateTime?  Date_allowed_error
		{
			 get { return _date_allowed_error; }
			 set
			 {
				 if (_date_allowed_error != value)
				 {
					_date_allowed_error = value;
					 PropertyHasChanged("Date_allowed_error");
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

		public short?  Num_samples
		{
			 get { return _num_samples; }
			 set
			 {
				 if (_num_samples != value)
				 {
					_num_samples = value;
					 PropertyHasChanged("Num_samples");
				 }
			 }
		}

		public short?  Num_days
		{
			 get { return _num_days; }
			 set
			 {
				 if (_num_days != value)
				 {
					_num_days = value;
					 PropertyHasChanged("Num_days");
				 }
			 }
		}

		public short?  Limit_samples
		{
			 get { return _limit_samples; }
			 set
			 {
				 if (_limit_samples != value)
				 {
					_limit_samples = value;
					 PropertyHasChanged("Limit_samples");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idtemplate_method", "Idtemplate_method"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Symbol", "Symbol",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
