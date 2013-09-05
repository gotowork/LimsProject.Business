using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_sample_program: BusinessObjectBase
	{

		#region InnerClass
		public enum CRecep_sample_programFields
		{
			Idrecep_sample_program,
			Cod_recep_sample_program,
			Order_report,
			Idrecep_sample,
			Program_status,
			Date_report,
			Time_report,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			long _idrecep_sample_program;
			long? _cod_recep_sample_program;
			short? _order_report;
			long? _idrecep_sample;
			short? _program_status;
			DateTime? _date_report;
			DateTime? _time_report;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public long  Idrecep_sample_program
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

		public long?  Cod_recep_sample_program
		{
			 get { return _cod_recep_sample_program; }
			 set
			 {
				 if (_cod_recep_sample_program != value)
				 {
					_cod_recep_sample_program = value;
					 PropertyHasChanged("Cod_recep_sample_program");
				 }
			 }
		}

		public short?  Order_report
		{
			 get { return _order_report; }
			 set
			 {
				 if (_order_report != value)
				 {
					_order_report = value;
					 PropertyHasChanged("Order_report");
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

		public short?  Program_status
		{
			 get { return _program_status; }
			 set
			 {
				 if (_program_status != value)
				 {
					_program_status = value;
					 PropertyHasChanged("Program_status");
				 }
			 }
		}

		public DateTime?  Date_report
		{
			 get { return _date_report; }
			 set
			 {
				 if (_date_report != value)
				 {
					_date_report = value;
					 PropertyHasChanged("Date_report");
				 }
			 }
		}

		public DateTime?  Time_report
		{
			 get { return _time_report; }
			 set
			 {
				 if (_time_report != value)
				 {
					_time_report = value;
					 PropertyHasChanged("Time_report");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idrecep_sample_program", "Idrecep_sample_program"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
