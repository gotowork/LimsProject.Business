using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CGroup_solution_methods: BusinessObjectBase
	{

		#region InnerClass
		public enum CGroup_solution_methodsFields
		{
			Idgroup_solution_methods,
			Idgroup_solution,
			Idtemplate_method,
			Status
		}
		#endregion

		#region Data Members

			int _idgroup_solution_methods;
			int? _idgroup_solution;
			int? _idtemplate_method;
			bool? _status;

		#endregion

		#region Properties

		public int  Idgroup_solution_methods
		{
			 get { return _idgroup_solution_methods; }
			 set
			 {
				 if (_idgroup_solution_methods != value)
				 {
					_idgroup_solution_methods = value;
					 PropertyHasChanged("Idgroup_solution_methods");
				 }
			 }
		}

		public int?  Idgroup_solution
		{
			 get { return _idgroup_solution; }
			 set
			 {
				 if (_idgroup_solution != value)
				 {
					_idgroup_solution = value;
					 PropertyHasChanged("Idgroup_solution");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idgroup_solution_methods", "Idgroup_solution_methods"));
		}

		#endregion

	}
}
