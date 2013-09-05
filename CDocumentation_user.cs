using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDocumentation_user: BusinessObjectBase
	{

		#region InnerClass
		public enum CDocumentation_userFields
		{
			Iddocumentation_user,
			Iddocumentation,
			Iduser,
			Date_ini,
			Date_end,
			Name_file,
			Order_file,
			Extension_file,
			Prev_authorized,
			Rank_valid_inmonth,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			long _iddocumentation_user;
			short _iddocumentation;
			short _iduser;
			DateTime? _date_ini;
			DateTime? _date_end;
			string _name_file;
			long? _order_file;
			string _extension_file;
			bool? _prev_authorized;
			int? _rank_valid_inmonth;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public long  Iddocumentation_user
		{
			 get { return _iddocumentation_user; }
			 set
			 {
				 if (_iddocumentation_user != value)
				 {
					_iddocumentation_user = value;
					 PropertyHasChanged("Iddocumentation_user");
				 }
			 }
		}

		public short  Iddocumentation
		{
			 get { return _iddocumentation; }
			 set
			 {
				 if (_iddocumentation != value)
				 {
					_iddocumentation = value;
					 PropertyHasChanged("Iddocumentation");
				 }
			 }
		}

		public short  Iduser
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

		public string  Name_file
		{
			 get { return _name_file; }
			 set
			 {
				 if (_name_file != value)
				 {
					_name_file = value;
					 PropertyHasChanged("Name_file");
				 }
			 }
		}

		public long?  Order_file
		{
			 get { return _order_file; }
			 set
			 {
				 if (_order_file != value)
				 {
					_order_file = value;
					 PropertyHasChanged("Order_file");
				 }
			 }
		}

		public string  Extension_file
		{
			 get { return _extension_file; }
			 set
			 {
				 if (_extension_file != value)
				 {
					_extension_file = value;
					 PropertyHasChanged("Extension_file");
				 }
			 }
		}

		public bool?  Prev_authorized
		{
			 get { return _prev_authorized; }
			 set
			 {
				 if (_prev_authorized != value)
				 {
					_prev_authorized = value;
					 PropertyHasChanged("Prev_authorized");
				 }
			 }
		}

		public int?  Rank_valid_inmonth
		{
			 get { return _rank_valid_inmonth; }
			 set
			 {
				 if (_rank_valid_inmonth != value)
				 {
					_rank_valid_inmonth = value;
					 PropertyHasChanged("Rank_valid_inmonth");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Iddocumentation_user", "Iddocumentation_user"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Iddocumentation", "Iddocumentation"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Iduser", "Iduser"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_file", "Name_file",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Extension_file", "Extension_file",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
