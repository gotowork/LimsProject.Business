using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CBatch: BusinessObjectBase
	{

		#region InnerClass
		public enum CBatchFields
		{
			Idbatch,
			Name_batch,
			Num_tray,
			Idtemplate_method,
			Cod_module,
			Cod_process,
			Cod_area,
			Status_process,
			Status,
			Mri_value,
			Description,
			Date_creation_tray,
			User_creation_tray,
			Has_sample_control,
			Absorvance,
			Std_verification,
			Flag_abs_std,
			Mri_measured,
			Lrb_measured,
			Flag_correct_abs,
			Flag_correct_std,
			Flag_correct_mri,
			Flag_correct_lrb,
			User_close_tray,
			Date_close_tray,
			User_approve_tray,
			Date_approve_tray,
			User_review_tray,
			Date_review_tray
		}
		#endregion

		#region Data Members

			long _idbatch;
			string _name_batch;
			long? _num_tray;
			int? _idtemplate_method;
			string _cod_module;
			string _cod_process;
			string _cod_area;
			char? _status_process;
			bool? _status;
			decimal? _mri_value;
			string _description;
			DateTime? _date_creation_tray;
			string _user_creation_tray;
			bool? _has_sample_control;
			decimal? _absorvance;
			decimal? _std_verification;
			bool? _flag_abs_std;
			decimal? _mri_measured;
			decimal? _lrb_measured;
			bool? _flag_correct_abs;
			bool? _flag_correct_std;
			bool? _flag_correct_mri;
			bool? _flag_correct_lrb;
			string _user_close_tray;
			DateTime? _date_close_tray;
			string _user_approve_tray;
			DateTime? _date_approve_tray;
			string _user_review_tray;
			DateTime? _date_review_tray;

		#endregion

		#region Properties

		public long  Idbatch
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

		public string  Name_batch
		{
			 get { return _name_batch; }
			 set
			 {
				 if (_name_batch != value)
				 {
					_name_batch = value;
					 PropertyHasChanged("Name_batch");
				 }
			 }
		}

		public long?  Num_tray
		{
			 get { return _num_tray; }
			 set
			 {
				 if (_num_tray != value)
				 {
					_num_tray = value;
					 PropertyHasChanged("Num_tray");
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

		public string  Cod_module
		{
			 get { return _cod_module; }
			 set
			 {
				 if (_cod_module != value)
				 {
					_cod_module = value;
					 PropertyHasChanged("Cod_module");
				 }
			 }
		}

		public string  Cod_process
		{
			 get { return _cod_process; }
			 set
			 {
				 if (_cod_process != value)
				 {
					_cod_process = value;
					 PropertyHasChanged("Cod_process");
				 }
			 }
		}

		public string  Cod_area
		{
			 get { return _cod_area; }
			 set
			 {
				 if (_cod_area != value)
				 {
					_cod_area = value;
					 PropertyHasChanged("Cod_area");
				 }
			 }
		}

		public char?  Status_process
		{
			 get { return _status_process; }
			 set
			 {
				 if (_status_process != value)
				 {
					_status_process = value;
					 PropertyHasChanged("Status_process");
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

		public decimal?  Mri_value
		{
			 get { return _mri_value; }
			 set
			 {
				 if (_mri_value != value)
				 {
					_mri_value = value;
					 PropertyHasChanged("Mri_value");
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

		public DateTime?  Date_creation_tray
		{
			 get { return _date_creation_tray; }
			 set
			 {
				 if (_date_creation_tray != value)
				 {
					_date_creation_tray = value;
					 PropertyHasChanged("Date_creation_tray");
				 }
			 }
		}

		public string  User_creation_tray
		{
			 get { return _user_creation_tray; }
			 set
			 {
				 if (_user_creation_tray != value)
				 {
					_user_creation_tray = value;
					 PropertyHasChanged("User_creation_tray");
				 }
			 }
		}

		public bool?  Has_sample_control
		{
			 get { return _has_sample_control; }
			 set
			 {
				 if (_has_sample_control != value)
				 {
					_has_sample_control = value;
					 PropertyHasChanged("Has_sample_control");
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

		public decimal?  Std_verification
		{
			 get { return _std_verification; }
			 set
			 {
				 if (_std_verification != value)
				 {
					_std_verification = value;
					 PropertyHasChanged("Std_verification");
				 }
			 }
		}

		public bool?  Flag_abs_std
		{
			 get { return _flag_abs_std; }
			 set
			 {
				 if (_flag_abs_std != value)
				 {
					_flag_abs_std = value;
					 PropertyHasChanged("Flag_abs_std");
				 }
			 }
		}

		public decimal?  Mri_measured
		{
			 get { return _mri_measured; }
			 set
			 {
				 if (_mri_measured != value)
				 {
					_mri_measured = value;
					 PropertyHasChanged("Mri_measured");
				 }
			 }
		}

		public decimal?  Lrb_measured
		{
			 get { return _lrb_measured; }
			 set
			 {
				 if (_lrb_measured != value)
				 {
					_lrb_measured = value;
					 PropertyHasChanged("Lrb_measured");
				 }
			 }
		}

		public bool?  Flag_correct_abs
		{
			 get { return _flag_correct_abs; }
			 set
			 {
				 if (_flag_correct_abs != value)
				 {
					_flag_correct_abs = value;
					 PropertyHasChanged("Flag_correct_abs");
				 }
			 }
		}

		public bool?  Flag_correct_std
		{
			 get { return _flag_correct_std; }
			 set
			 {
				 if (_flag_correct_std != value)
				 {
					_flag_correct_std = value;
					 PropertyHasChanged("Flag_correct_std");
				 }
			 }
		}

		public bool?  Flag_correct_mri
		{
			 get { return _flag_correct_mri; }
			 set
			 {
				 if (_flag_correct_mri != value)
				 {
					_flag_correct_mri = value;
					 PropertyHasChanged("Flag_correct_mri");
				 }
			 }
		}

		public bool?  Flag_correct_lrb
		{
			 get { return _flag_correct_lrb; }
			 set
			 {
				 if (_flag_correct_lrb != value)
				 {
					_flag_correct_lrb = value;
					 PropertyHasChanged("Flag_correct_lrb");
				 }
			 }
		}

		public string  User_close_tray
		{
			 get { return _user_close_tray; }
			 set
			 {
				 if (_user_close_tray != value)
				 {
					_user_close_tray = value;
					 PropertyHasChanged("User_close_tray");
				 }
			 }
		}

		public DateTime?  Date_close_tray
		{
			 get { return _date_close_tray; }
			 set
			 {
				 if (_date_close_tray != value)
				 {
					_date_close_tray = value;
					 PropertyHasChanged("Date_close_tray");
				 }
			 }
		}

		public string  User_approve_tray
		{
			 get { return _user_approve_tray; }
			 set
			 {
				 if (_user_approve_tray != value)
				 {
					_user_approve_tray = value;
					 PropertyHasChanged("User_approve_tray");
				 }
			 }
		}

		public DateTime?  Date_approve_tray
		{
			 get { return _date_approve_tray; }
			 set
			 {
				 if (_date_approve_tray != value)
				 {
					_date_approve_tray = value;
					 PropertyHasChanged("Date_approve_tray");
				 }
			 }
		}

		public string  User_review_tray
		{
			 get { return _user_review_tray; }
			 set
			 {
				 if (_user_review_tray != value)
				 {
					_user_review_tray = value;
					 PropertyHasChanged("User_review_tray");
				 }
			 }
		}

		public DateTime?  Date_review_tray
		{
			 get { return _date_review_tray; }
			 set
			 {
				 if (_date_review_tray != value)
				 {
					_date_review_tray = value;
					 PropertyHasChanged("Date_review_tray");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idbatch", "Idbatch"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_batch", "Name_batch",30));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_module", "Cod_module",4));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_process", "Cod_process",4));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_area", "Cod_area",4));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("User_creation_tray", "User_creation_tray",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("User_close_tray", "User_close_tray",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("User_approve_tray", "User_approve_tray",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("User_review_tray", "User_review_tray",20));
		}

		#endregion

	}
}
