using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTemplate_method_aa: BusinessObjectBase
	{

		#region InnerClass
		public enum CTemplate_method_aaFields
		{
			Idtemplate_method,
			Weight,
			Weight_incertitude,
			Volumen,
			Reading_min,
			Reading_max,
			Dilution2,
			Dilution3,
			Reason_rep,
			Error_allowed,
			Symbol,
			Law_limit_bottom,
			Law_limit_top,
			Idunit_calib,
			Absorvance,
			Abs_incertitude,
			Std_verif,
			Std_verif_incertitude,
			Wave_long,
			Num_decimal,
			Idmr_detail,
			Mr_incertitude,
			Blk_max,
			Reproducibility,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status,
			Date_allowed_error,
			Mrorpattern,
			Rexp2,
			Medium,
			Medium_conc,
			Modif,
			Modif_conc,
			Validity_calib,
			Type_pattern,
			Flag_sol_intermedia,
			Sol_concentration,
			Sol_status,
			Sol_date_preparation,
			Sol_date_expiration,
			Std_mrorpattern,
			Std_type_pattern,
			Std_flag_sol_intermedia1,
			Std_flag_sol_intermedia2,
			Std_concentration,
			Std_concentration_sol1,
			Std_concentration_sol2,
			Std_validity,
			Std_status,
			Std_date_preparation,
			Std_date_expiration,
			Std_sol1_medium,
			Std_sol2_medium,
			Std_stdverif_medium,
			Idunit_result,
			Num_samples,
			Num_days,
			Limit_samples
		}
		#endregion

		#region Data Members

			int _idtemplate_method;
			decimal? _weight;
			decimal? _weight_incertitude;
			decimal? _volumen;
			decimal? _reading_min;
			decimal? _reading_max;
			decimal? _dilution2;
			decimal? _dilution3;
			decimal? _reason_rep;
			decimal? _error_allowed;
			string _symbol;
			decimal? _law_limit_bottom;
			decimal? _law_limit_top;
			short? _idunit_calib;
			decimal? _absorvance;
			decimal? _abs_incertitude;
			decimal? _std_verif;
			decimal? _std_verif_incertitude;
			decimal? _wave_long;
			short? _num_decimal;
			short? _idmr_detail;
			decimal? _mr_incertitude;
			decimal? _blk_max;
			decimal? _reproducibility;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;
			DateTime? _date_allowed_error;
			short? _mrorpattern;
			decimal? _rexp2;
			int? _medium;
			decimal? _medium_conc;
			int? _modif;
			decimal? _modif_conc;
			short? _validity_calib;
			int? _type_pattern;
			bool? _flag_sol_intermedia;
			decimal? _sol_concentration;
			bool? _sol_status;
			DateTime? _sol_date_preparation;
			DateTime? _sol_date_expiration;
			int? _std_mrorpattern;
			int? _std_type_pattern;
			bool? _std_flag_sol_intermedia1;
			bool? _std_flag_sol_intermedia2;
			decimal? _std_concentration;
			decimal? _std_concentration_sol1;
			decimal? _std_concentration_sol2;
			short? _std_validity;
			bool? _std_status;
			DateTime? _std_date_preparation;
			DateTime? _std_date_expiration;
			decimal? _std_sol1_medium;
			decimal? _std_sol2_medium;
			decimal? _std_stdverif_medium;
			short? _idunit_result;
			short? _num_samples;
			short? _num_days;
			short? _limit_samples;

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

		public decimal?  Dilution2
		{
			 get { return _dilution2; }
			 set
			 {
				 if (_dilution2 != value)
				 {
					_dilution2 = value;
					 PropertyHasChanged("Dilution2");
				 }
			 }
		}

		public decimal?  Dilution3
		{
			 get { return _dilution3; }
			 set
			 {
				 if (_dilution3 != value)
				 {
					_dilution3 = value;
					 PropertyHasChanged("Dilution3");
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

		public short?  Idunit_calib
		{
			 get { return _idunit_calib; }
			 set
			 {
				 if (_idunit_calib != value)
				 {
					_idunit_calib = value;
					 PropertyHasChanged("Idunit_calib");
				 }
			 }
		}

		public decimal?  Absorvance
		{
			 get { return _absorvance; }
			 set
			 {
				 if (_absorvance != value)
				 {
					_absorvance = value;
					 PropertyHasChanged("Absorvance");
				 }
			 }
		}

		public decimal?  Abs_incertitude
		{
			 get { return _abs_incertitude; }
			 set
			 {
				 if (_abs_incertitude != value)
				 {
					_abs_incertitude = value;
					 PropertyHasChanged("Abs_incertitude");
				 }
			 }
		}

		public decimal?  Std_verif
		{
			 get { return _std_verif; }
			 set
			 {
				 if (_std_verif != value)
				 {
					_std_verif = value;
					 PropertyHasChanged("Std_verif");
				 }
			 }
		}

		public decimal?  Std_verif_incertitude
		{
			 get { return _std_verif_incertitude; }
			 set
			 {
				 if (_std_verif_incertitude != value)
				 {
					_std_verif_incertitude = value;
					 PropertyHasChanged("Std_verif_incertitude");
				 }
			 }
		}

		public decimal?  Wave_long
		{
			 get { return _wave_long; }
			 set
			 {
				 if (_wave_long != value)
				 {
					_wave_long = value;
					 PropertyHasChanged("Wave_long");
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

		public short?  Mrorpattern
		{
			 get { return _mrorpattern; }
			 set
			 {
				 if (_mrorpattern != value)
				 {
					_mrorpattern = value;
					 PropertyHasChanged("Mrorpattern");
				 }
			 }
		}

		public decimal?  Rexp2
		{
			 get { return _rexp2; }
			 set
			 {
				 if (_rexp2 != value)
				 {
					_rexp2 = value;
					 PropertyHasChanged("Rexp2");
				 }
			 }
		}

		public int?  Medium
		{
			 get { return _medium; }
			 set
			 {
				 if (_medium != value)
				 {
					_medium = value;
					 PropertyHasChanged("Medium");
				 }
			 }
		}

		public decimal?  Medium_conc
		{
			 get { return _medium_conc; }
			 set
			 {
				 if (_medium_conc != value)
				 {
					_medium_conc = value;
					 PropertyHasChanged("Medium_conc");
				 }
			 }
		}

		public int?  Modif
		{
			 get { return _modif; }
			 set
			 {
				 if (_modif != value)
				 {
					_modif = value;
					 PropertyHasChanged("Modif");
				 }
			 }
		}

		public decimal?  Modif_conc
		{
			 get { return _modif_conc; }
			 set
			 {
				 if (_modif_conc != value)
				 {
					_modif_conc = value;
					 PropertyHasChanged("Modif_conc");
				 }
			 }
		}

		public short?  Validity_calib
		{
			 get { return _validity_calib; }
			 set
			 {
				 if (_validity_calib != value)
				 {
					_validity_calib = value;
					 PropertyHasChanged("Validity_calib");
				 }
			 }
		}

		public int?  Type_pattern
		{
			 get { return _type_pattern; }
			 set
			 {
				 if (_type_pattern != value)
				 {
					_type_pattern = value;
					 PropertyHasChanged("Type_pattern");
				 }
			 }
		}

		public bool?  Flag_sol_intermedia
		{
			 get { return _flag_sol_intermedia; }
			 set
			 {
				 if (_flag_sol_intermedia != value)
				 {
					_flag_sol_intermedia = value;
					 PropertyHasChanged("Flag_sol_intermedia");
				 }
			 }
		}

		public decimal?  Sol_concentration
		{
			 get { return _sol_concentration; }
			 set
			 {
				 if (_sol_concentration != value)
				 {
					_sol_concentration = value;
					 PropertyHasChanged("Sol_concentration");
				 }
			 }
		}

		public bool?  Sol_status
		{
			 get { return _sol_status; }
			 set
			 {
				 if (_sol_status != value)
				 {
					_sol_status = value;
					 PropertyHasChanged("Sol_status");
				 }
			 }
		}

		public DateTime?  Sol_date_preparation
		{
			 get { return _sol_date_preparation; }
			 set
			 {
				 if (_sol_date_preparation != value)
				 {
					_sol_date_preparation = value;
					 PropertyHasChanged("Sol_date_preparation");
				 }
			 }
		}

		public DateTime?  Sol_date_expiration
		{
			 get { return _sol_date_expiration; }
			 set
			 {
				 if (_sol_date_expiration != value)
				 {
					_sol_date_expiration = value;
					 PropertyHasChanged("Sol_date_expiration");
				 }
			 }
		}

		public int?  Std_mrorpattern
		{
			 get { return _std_mrorpattern; }
			 set
			 {
				 if (_std_mrorpattern != value)
				 {
					_std_mrorpattern = value;
					 PropertyHasChanged("Std_mrorpattern");
				 }
			 }
		}

		public int?  Std_type_pattern
		{
			 get { return _std_type_pattern; }
			 set
			 {
				 if (_std_type_pattern != value)
				 {
					_std_type_pattern = value;
					 PropertyHasChanged("Std_type_pattern");
				 }
			 }
		}

		public bool?  Std_flag_sol_intermedia1
		{
			 get { return _std_flag_sol_intermedia1; }
			 set
			 {
				 if (_std_flag_sol_intermedia1 != value)
				 {
					_std_flag_sol_intermedia1 = value;
					 PropertyHasChanged("Std_flag_sol_intermedia1");
				 }
			 }
		}

		public bool?  Std_flag_sol_intermedia2
		{
			 get { return _std_flag_sol_intermedia2; }
			 set
			 {
				 if (_std_flag_sol_intermedia2 != value)
				 {
					_std_flag_sol_intermedia2 = value;
					 PropertyHasChanged("Std_flag_sol_intermedia2");
				 }
			 }
		}

		public decimal?  Std_concentration
		{
			 get { return _std_concentration; }
			 set
			 {
				 if (_std_concentration != value)
				 {
					_std_concentration = value;
					 PropertyHasChanged("Std_concentration");
				 }
			 }
		}

		public decimal?  Std_concentration_sol1
		{
			 get { return _std_concentration_sol1; }
			 set
			 {
				 if (_std_concentration_sol1 != value)
				 {
					_std_concentration_sol1 = value;
					 PropertyHasChanged("Std_concentration_sol1");
				 }
			 }
		}

		public decimal?  Std_concentration_sol2
		{
			 get { return _std_concentration_sol2; }
			 set
			 {
				 if (_std_concentration_sol2 != value)
				 {
					_std_concentration_sol2 = value;
					 PropertyHasChanged("Std_concentration_sol2");
				 }
			 }
		}

		public short?  Std_validity
		{
			 get { return _std_validity; }
			 set
			 {
				 if (_std_validity != value)
				 {
					_std_validity = value;
					 PropertyHasChanged("Std_validity");
				 }
			 }
		}

		public bool?  Std_status
		{
			 get { return _std_status; }
			 set
			 {
				 if (_std_status != value)
				 {
					_std_status = value;
					 PropertyHasChanged("Std_status");
				 }
			 }
		}

		public DateTime?  Std_date_preparation
		{
			 get { return _std_date_preparation; }
			 set
			 {
				 if (_std_date_preparation != value)
				 {
					_std_date_preparation = value;
					 PropertyHasChanged("Std_date_preparation");
				 }
			 }
		}

		public DateTime?  Std_date_expiration
		{
			 get { return _std_date_expiration; }
			 set
			 {
				 if (_std_date_expiration != value)
				 {
					_std_date_expiration = value;
					 PropertyHasChanged("Std_date_expiration");
				 }
			 }
		}

		public decimal?  Std_sol1_medium
		{
			 get { return _std_sol1_medium; }
			 set
			 {
				 if (_std_sol1_medium != value)
				 {
					_std_sol1_medium = value;
					 PropertyHasChanged("Std_sol1_medium");
				 }
			 }
		}

		public decimal?  Std_sol2_medium
		{
			 get { return _std_sol2_medium; }
			 set
			 {
				 if (_std_sol2_medium != value)
				 {
					_std_sol2_medium = value;
					 PropertyHasChanged("Std_sol2_medium");
				 }
			 }
		}

		public decimal?  Std_stdverif_medium
		{
			 get { return _std_stdverif_medium; }
			 set
			 {
				 if (_std_stdverif_medium != value)
				 {
					_std_stdverif_medium = value;
					 PropertyHasChanged("Std_stdverif_medium");
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
