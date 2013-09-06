using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTemplate_method_ah: BusinessObjectBase
	{

		#region InnerClass
		public enum CTemplate_method_ahFields
		{
			Idtemplate_method,
			Symbol,
			Idunit_result,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _idtemplate_method;
			string _symbol;
			short? _idunit_result;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idtemplate_method", "Idtemplate_method"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Symbol", "Symbol",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
