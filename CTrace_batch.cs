using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTrace_batch: BusinessObjectBase
	{

		#region InnerClass
		public enum CTrace_batchFields
		{
			Idtrace_batch,
			Cod_module,
			Cod_process,
			Cod_area,
			Idbatch,
			Date_in,
			Date_out,
			Status_process,
			Idtrace_prev,
			Idtrace_next,
			Observation,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			long _idtrace_batch;
			string _cod_module;
			string _cod_process;
			string _cod_area;
			long? _idbatch;
			DateTime? _date_in;
			DateTime? _date_out;
			char? _status_process;
			long? _idtrace_prev;
			long? _idtrace_next;
			string _observation;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public long  Idtrace_batch
		{
			 get { return _idtrace_batch; }
			 set
			 {
				 if (_idtrace_batch != value)
				 {
					_idtrace_batch = value;
					 PropertyHasChanged("Idtrace_batch");
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

		public DateTime?  Date_in
		{
			 get { return _date_in; }
			 set
			 {
				 if (_date_in != value)
				 {
					_date_in = value;
					 PropertyHasChanged("Date_in");
				 }
			 }
		}

		public DateTime?  Date_out
		{
			 get { return _date_out; }
			 set
			 {
				 if (_date_out != value)
				 {
					_date_out = value;
					 PropertyHasChanged("Date_out");
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

		public long?  Idtrace_prev
		{
			 get { return _idtrace_prev; }
			 set
			 {
				 if (_idtrace_prev != value)
				 {
					_idtrace_prev = value;
					 PropertyHasChanged("Idtrace_prev");
				 }
			 }
		}

		public long?  Idtrace_next
		{
			 get { return _idtrace_next; }
			 set
			 {
				 if (_idtrace_next != value)
				 {
					_idtrace_next = value;
					 PropertyHasChanged("Idtrace_next");
				 }
			 }
		}

		public string  Observation
		{
			 get { return _observation; }
			 set
			 {
				 if (_observation != value)
				 {
					_observation = value;
					 PropertyHasChanged("Observation");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idtrace_batch", "Idtrace_batch"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_module", "Cod_module",4));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_process", "Cod_process",4));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_area", "Cod_area",4));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Observation", "Observation",60));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
