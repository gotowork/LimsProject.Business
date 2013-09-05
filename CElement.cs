using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CElement: BusinessObjectBase
	{

		#region InnerClass
		public enum CElementFields
		{
			Idelement,
			Cod_element,
			Name_element,
			Description,
			Native_element,
			Type_element,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			short _idelement;
			string _cod_element;
			string _name_element;
			string _description;
			string _native_element;
			char? _type_element;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public short  Idelement
		{
			 get { return _idelement; }
			 set
			 {
				 if (_idelement != value)
				 {
					_idelement = value;
					 PropertyHasChanged("Idelement");
				 }
			 }
		}

		public string  Cod_element
		{
			 get { return _cod_element; }
			 set
			 {
				 if (_cod_element != value)
				 {
					_cod_element = value;
					 PropertyHasChanged("Cod_element");
				 }
			 }
		}

		public string  Name_element
		{
			 get { return _name_element; }
			 set
			 {
				 if (_name_element != value)
				 {
					_name_element = value;
					 PropertyHasChanged("Name_element");
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

		public string  Native_element
		{
			 get { return _native_element; }
			 set
			 {
				 if (_native_element != value)
				 {
					_native_element = value;
					 PropertyHasChanged("Native_element");
				 }
			 }
		}

		public char?  Type_element
		{
			 get { return _type_element; }
			 set
			 {
				 if (_type_element != value)
				 {
					_type_element = value;
					 PropertyHasChanged("Type_element");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idelement", "Idelement"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_element", "Cod_element",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_element", "Name_element",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",200));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Native_element", "Native_element",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",50));
		}

		#endregion

	}
}
