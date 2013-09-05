using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_sample_report: BusinessObjectBase
	{

		#region InnerClass
		public enum CRecep_sample_reportFields
		{
			Idrecep_sample_report,
			Order_report,
			Cod_recep_sample_report,
			Report_status,
			Type_report,
			Idrecep_sample,
			Flag_rpt_email,
			Flag_rpt_print,
			Flag_rpt_pdf,
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

			long _idrecep_sample_report;
			short? _order_report;
			long? _cod_recep_sample_report;
			short? _report_status;
			short? _type_report;
			long? _idrecep_sample;
			bool? _flag_rpt_email;
			bool? _flag_rpt_print;
			bool? _flag_rpt_pdf;
			DateTime? _date_report;
			DateTime? _time_report;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public long  Idrecep_sample_report
		{
			 get { return _idrecep_sample_report; }
			 set
			 {
				 if (_idrecep_sample_report != value)
				 {
					_idrecep_sample_report = value;
					 PropertyHasChanged("Idrecep_sample_report");
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

		public long?  Cod_recep_sample_report
		{
			 get { return _cod_recep_sample_report; }
			 set
			 {
				 if (_cod_recep_sample_report != value)
				 {
					_cod_recep_sample_report = value;
					 PropertyHasChanged("Cod_recep_sample_report");
				 }
			 }
		}

		public short?  Report_status
		{
			 get { return _report_status; }
			 set
			 {
				 if (_report_status != value)
				 {
					_report_status = value;
					 PropertyHasChanged("Report_status");
				 }
			 }
		}

		public short?  Type_report
		{
			 get { return _type_report; }
			 set
			 {
				 if (_type_report != value)
				 {
					_type_report = value;
					 PropertyHasChanged("Type_report");
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

		public bool?  Flag_rpt_email
		{
			 get { return _flag_rpt_email; }
			 set
			 {
				 if (_flag_rpt_email != value)
				 {
					_flag_rpt_email = value;
					 PropertyHasChanged("Flag_rpt_email");
				 }
			 }
		}

		public bool?  Flag_rpt_print
		{
			 get { return _flag_rpt_print; }
			 set
			 {
				 if (_flag_rpt_print != value)
				 {
					_flag_rpt_print = value;
					 PropertyHasChanged("Flag_rpt_print");
				 }
			 }
		}

		public bool?  Flag_rpt_pdf
		{
			 get { return _flag_rpt_pdf; }
			 set
			 {
				 if (_flag_rpt_pdf != value)
				 {
					_flag_rpt_pdf = value;
					 PropertyHasChanged("Flag_rpt_pdf");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idrecep_sample_report", "Idrecep_sample_report"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
