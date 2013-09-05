using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTemplate_method_detail: BusinessObjectBase
	{

		#region InnerClass
		public enum CTemplate_method_detailFields
		{
			Idtemplate_method_detail,
			Name_variable,
			Alias_variable,
			Value_variable,
			Type_variable,
			Group_variable,
			Visible,
			Idtemplate_method,
			Status
		}
		#endregion

		#region Data Members

			int _idtemplate_method_detail;
			string _name_variable;
			string _alias_variable;
			decimal? _value_variable;
			char? _type_variable;
			char? _group_variable;
			bool? _visible;
			int? _idtemplate_method;
			bool? _status;

		#endregion

		#region Properties

		public int  Idtemplate_method_detail
		{
			 get { return _idtemplate_method_detail; }
			 set
			 {
				 if (_idtemplate_method_detail != value)
				 {
					_idtemplate_method_detail = value;
					 PropertyHasChanged("Idtemplate_method_detail");
				 }
			 }
		}

		public string  Name_variable
		{
			 get { return _name_variable; }
			 set
			 {
				 if (_name_variable != value)
				 {
					_name_variable = value;
					 PropertyHasChanged("Name_variable");
				 }
			 }
		}

		public string  Alias_variable
		{
			 get { return _alias_variable; }
			 set
			 {
				 if (_alias_variable != value)
				 {
					_alias_variable = value;
					 PropertyHasChanged("Alias_variable");
				 }
			 }
		}

		public decimal?  Value_variable
		{
			 get { return _value_variable; }
			 set
			 {
				 if (_value_variable != value)
				 {
					_value_variable = value;
					 PropertyHasChanged("Value_variable");
				 }
			 }
		}

		public char?  Type_variable
		{
			 get { return _type_variable; }
			 set
			 {
				 if (_type_variable != value)
				 {
					_type_variable = value;
					 PropertyHasChanged("Type_variable");
				 }
			 }
		}

		public char?  Group_variable
		{
			 get { return _group_variable; }
			 set
			 {
				 if (_group_variable != value)
				 {
					_group_variable = value;
					 PropertyHasChanged("Group_variable");
				 }
			 }
		}

		public bool?  Visible
		{
			 get { return _visible; }
			 set
			 {
				 if (_visible != value)
				 {
					_visible = value;
					 PropertyHasChanged("Visible");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idtemplate_method_detail", "Idtemplate_method_detail"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_variable", "Name_variable",30));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Alias_variable", "Alias_variable",30));
		}

		#endregion

	}
}
