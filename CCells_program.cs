using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCells_program: BusinessObjectBase
	{

		#region InnerClass
		public enum CCells_programFields
		{
			Idcell_reported,
			Idrecep_sample_detail_elem,
			Idrecep_sample_program,
			Idtemplate_method,
			Idrecep_sample_detail,
			Flag_confirm_report,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			long _idcell_reported;
			long? _idrecep_sample_detail_elem;
			long? _idrecep_sample_program;
			int? _idtemplate_method;
			long? _idrecep_sample_detail;
			bool? _flag_confirm_report;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public long  Idcell_reported
		{
			 get { return _idcell_reported; }
			 set
			 {
				 if (_idcell_reported != value)
				 {
					_idcell_reported = value;
					 PropertyHasChanged("Idcell_reported");
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

		public long?  Idrecep_sample_program
		{
			 get { return _idrecep_sample_program; }
			 set
			 {
				 if (_idrecep_sample_program != value)
				 {
					_idrecep_sample_program = value;
					 PropertyHasChanged("Idrecep_sample_program");
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

		public bool?  Flag_confirm_report
		{
			 get { return _flag_confirm_report; }
			 set
			 {
				 if (_flag_confirm_report != value)
				 {
					_flag_confirm_report = value;
					 PropertyHasChanged("Flag_confirm_report");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idcell_reported", "Idcell_reported"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
