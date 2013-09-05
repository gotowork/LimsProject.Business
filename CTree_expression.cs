using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTree_expression: BusinessObjectBase
	{

		#region InnerClass
		public enum CTree_expressionFields
		{
			Idtree_expression,
			Name_variable,
			Id,
			Parentid,
			Expression,
			Status,
			Idtemplate_method,
			Idtemplate_method_detail
		}
		#endregion

		#region Data Members

			long _idtree_expression;
			string _name_variable;
			int? _id;
			int? _parentid;
			string _expression;
			bool? _status;
			int? _idtemplate_method;
			long? _idtemplate_method_detail;

		#endregion

		#region Properties

		public long  Idtree_expression
		{
			 get { return _idtree_expression; }
			 set
			 {
				 if (_idtree_expression != value)
				 {
					_idtree_expression = value;
					 PropertyHasChanged("Idtree_expression");
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

		public int?  Id
		{
			 get { return _id; }
			 set
			 {
				 if (_id != value)
				 {
					_id = value;
					 PropertyHasChanged("Id");
				 }
			 }
		}

		public int?  Parentid
		{
			 get { return _parentid; }
			 set
			 {
				 if (_parentid != value)
				 {
					_parentid = value;
					 PropertyHasChanged("Parentid");
				 }
			 }
		}

		public string  Expression
		{
			 get { return _expression; }
			 set
			 {
				 if (_expression != value)
				 {
					_expression = value;
					 PropertyHasChanged("Expression");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idtree_expression", "Idtree_expression"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_variable", "Name_variable",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Expression", "Expression",500));
		}

		#endregion

	}
}
