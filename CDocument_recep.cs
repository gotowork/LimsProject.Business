using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDocument_recep: BusinessObjectBase
	{

		#region InnerClass
		public enum CDocument_recepFields
		{
			Iddocument_recep,
			Name_file,
			Order_file,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _iddocument_recep;
			string _name_file;
			int? _order_file;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public int  Iddocument_recep
		{
			 get { return _iddocument_recep; }
			 set
			 {
				 if (_iddocument_recep != value)
				 {
					_iddocument_recep = value;
					 PropertyHasChanged("Iddocument_recep");
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

		public int?  Order_file
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Iddocument_recep", "Iddocument_recep"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_file", "Name_file",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
