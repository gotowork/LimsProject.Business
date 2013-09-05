using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTray: BusinessObjectBase
	{

		#region InnerClass
		public enum CTrayFields
		{
			Idtray,
			Name_tray,
			Num_cols,
			Num_rows,
			Repetition,
			Cost_method,
			Type_tray,
			Size_tray,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			short _idtray;
			string _name_tray;
			short? _num_cols;
			short? _num_rows;
			short? _repetition;
			decimal? _cost_method;
			char? _type_tray;
			short? _size_tray;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public short  Idtray
		{
			 get { return _idtray; }
			 set
			 {
				 if (_idtray != value)
				 {
					_idtray = value;
					 PropertyHasChanged("Idtray");
				 }
			 }
		}

		public string  Name_tray
		{
			 get { return _name_tray; }
			 set
			 {
				 if (_name_tray != value)
				 {
					_name_tray = value;
					 PropertyHasChanged("Name_tray");
				 }
			 }
		}

		public short?  Num_cols
		{
			 get { return _num_cols; }
			 set
			 {
				 if (_num_cols != value)
				 {
					_num_cols = value;
					 PropertyHasChanged("Num_cols");
				 }
			 }
		}

		public short?  Num_rows
		{
			 get { return _num_rows; }
			 set
			 {
				 if (_num_rows != value)
				 {
					_num_rows = value;
					 PropertyHasChanged("Num_rows");
				 }
			 }
		}

		public short?  Repetition
		{
			 get { return _repetition; }
			 set
			 {
				 if (_repetition != value)
				 {
					_repetition = value;
					 PropertyHasChanged("Repetition");
				 }
			 }
		}

		public decimal?  Cost_method
		{
			 get { return _cost_method; }
			 set
			 {
				 if (_cost_method != value)
				 {
					_cost_method = value;
					 PropertyHasChanged("Cost_method");
				 }
			 }
		}

		public char?  Type_tray
		{
			 get { return _type_tray; }
			 set
			 {
				 if (_type_tray != value)
				 {
					_type_tray = value;
					 PropertyHasChanged("Type_tray");
				 }
			 }
		}

		public short?  Size_tray
		{
			 get { return _size_tray; }
			 set
			 {
				 if (_size_tray != value)
				 {
					_size_tray = value;
					 PropertyHasChanged("Size_tray");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idtray", "Idtray"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_tray", "Name_tray",7));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
