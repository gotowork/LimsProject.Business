using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCondition_variable: BusinessObjectBase
	{

		#region InnerClass
		public enum CCondition_variableFields
		{
			Idcondition_variable,
			Name_variable,
			Operation,
			Name_value1,
			Name_value2,
			Idvalue1,
			Idvalue2,
			Message,
			Status,
			Idtemplate_method,
			Idtemplate_method_detail
		}
		#endregion

		#region Data Members

			int _idcondition_variable;
			string _name_variable;
			string _operation;
			string _name_value1;
			string _name_value2;
			int? _idvalue1;
			int? _idvalue2;
			string _message;
			bool? _status;
			int? _idtemplate_method;
			long? _idtemplate_method_detail;

		#endregion

		#region Properties

		public int  Idcondition_variable
		{
			 get { return _idcondition_variable; }
			 set
			 {
				 if (_idcondition_variable != value)
				 {
					_idcondition_variable = value;
					 PropertyHasChanged("Idcondition_variable");
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

		public string  Operation
		{
			 get { return _operation; }
			 set
			 {
				 if (_operation != value)
				 {
					_operation = value;
					 PropertyHasChanged("Operation");
				 }
			 }
		}

		public string  Name_value1
		{
			 get { return _name_value1; }
			 set
			 {
				 if (_name_value1 != value)
				 {
					_name_value1 = value;
					 PropertyHasChanged("Name_value1");
				 }
			 }
		}

		public string  Name_value2
		{
			 get { return _name_value2; }
			 set
			 {
				 if (_name_value2 != value)
				 {
					_name_value2 = value;
					 PropertyHasChanged("Name_value2");
				 }
			 }
		}

		public int?  Idvalue1
		{
			 get { return _idvalue1; }
			 set
			 {
				 if (_idvalue1 != value)
				 {
					_idvalue1 = value;
					 PropertyHasChanged("Idvalue1");
				 }
			 }
		}

		public int?  Idvalue2
		{
			 get { return _idvalue2; }
			 set
			 {
				 if (_idvalue2 != value)
				 {
					_idvalue2 = value;
					 PropertyHasChanged("Idvalue2");
				 }
			 }
		}

		public string  Message
		{
			 get { return _message; }
			 set
			 {
				 if (_message != value)
				 {
					_message = value;
					 PropertyHasChanged("Message");
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

		public long?  Idtemplate_method_detail
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idcondition_variable", "Idcondition_variable"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_variable", "Name_variable",30));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Operation", "Operation",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_value1", "Name_value1",40));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_value2", "Name_value2",40));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Message", "Message",100));
		}

		#endregion

	}
}
