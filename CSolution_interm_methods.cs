using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CSolution_interm_methods: BusinessObjectBase
	{

		#region InnerClass
		public enum CSolution_interm_methodsFields
		{
			Idsolution_methods,
			Idsolution_interm,
			Idtemplate_method,
			Status
		}
		#endregion

		#region Data Members

			int _idsolution_methods;
			int? _idsolution_interm;
			int? _idtemplate_method;
			bool? _status;

		#endregion

		#region Properties

		public int  Idsolution_methods
		{
			 get { return _idsolution_methods; }
			 set
			 {
				 if (_idsolution_methods != value)
				 {
					_idsolution_methods = value;
					 PropertyHasChanged("Idsolution_methods");
				 }
			 }
		}

		public int?  Idsolution_interm
		{
			 get { return _idsolution_interm; }
			 set
			 {
				 if (_idsolution_interm != value)
				 {
					_idsolution_interm = value;
					 PropertyHasChanged("Idsolution_interm");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idsolution_methods", "Idsolution_methods"));
		}

		#endregion

	}
}
