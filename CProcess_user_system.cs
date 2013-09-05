using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CProcess_user_system: BusinessObjectBase
	{

		#region InnerClass
		public enum CProcess_user_systemFields
		{
			Idprocess_user_system,
			Cod_process,
			Cod_module,
			Cod_area,
			Iduser,
			Date_ini,
			Date_end,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			short _idprocess_user_system;
			string _cod_process;
			string _cod_module;
			string _cod_area;
			short? _iduser;
			DateTime? _date_ini;
			DateTime? _date_end;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public short  Idprocess_user_system
		{
			 get { return _idprocess_user_system; }
			 set
			 {
				 if (_idprocess_user_system != value)
				 {
					_idprocess_user_system = value;
					 PropertyHasChanged("Idprocess_user_system");
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

		public short?  Iduser
		{
			 get { return _iduser; }
			 set
			 {
				 if (_iduser != value)
				 {
					_iduser = value;
					 PropertyHasChanged("Iduser");
				 }
			 }
		}

		public DateTime?  Date_ini
		{
			 get { return _date_ini; }
			 set
			 {
				 if (_date_ini != value)
				 {
					_date_ini = value;
					 PropertyHasChanged("Date_ini");
				 }
			 }
		}

		public DateTime?  Date_end
		{
			 get { return _date_end; }
			 set
			 {
				 if (_date_end != value)
				 {
					_date_end = value;
					 PropertyHasChanged("Date_end");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idprocess_user_system", "Idprocess_user_system"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_process", "Cod_process",4));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_module", "Cod_module",4));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_area", "Cod_area",4));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",50));
		}

		#endregion

	}
}
