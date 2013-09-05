using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDecree_detail: BusinessObjectBase
	{

		#region InnerClass
		public enum CDecree_detailFields
		{
			Iddecree_detail,
			Iddecree,
			Idunit,
			Idtemplate_method,
			Parameter,
			Idcondition,
			Valor1,
			Valor2,
			Status
		}
		#endregion

		#region Data Members

			int _iddecree_detail;
			int? _iddecree;
			int? _idunit;
			int? _idtemplate_method;
			string _parameter;
			int? _idcondition;
			string _valor1;
			string _valor2;
			bool? _status;

		#endregion

		#region Properties

		public int  Iddecree_detail
		{
			 get { return _iddecree_detail; }
			 set
			 {
				 if (_iddecree_detail != value)
				 {
					_iddecree_detail = value;
					 PropertyHasChanged("Iddecree_detail");
				 }
			 }
		}

		public int?  Iddecree
		{
			 get { return _iddecree; }
			 set
			 {
				 if (_iddecree != value)
				 {
					_iddecree = value;
					 PropertyHasChanged("Iddecree");
				 }
			 }
		}

		public int?  Idunit
		{
			 get { return _idunit; }
			 set
			 {
				 if (_idunit != value)
				 {
					_idunit = value;
					 PropertyHasChanged("Idunit");
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

		public string  Parameter
		{
			 get { return _parameter; }
			 set
			 {
				 if (_parameter != value)
				 {
					_parameter = value;
					 PropertyHasChanged("Parameter");
				 }
			 }
		}

		public int?  Idcondition
		{
			 get { return _idcondition; }
			 set
			 {
				 if (_idcondition != value)
				 {
					_idcondition = value;
					 PropertyHasChanged("Idcondition");
				 }
			 }
		}

		public string  Valor1
		{
			 get { return _valor1; }
			 set
			 {
				 if (_valor1 != value)
				 {
					_valor1 = value;
					 PropertyHasChanged("Valor1");
				 }
			 }
		}

		public string  Valor2
		{
			 get { return _valor2; }
			 set
			 {
				 if (_valor2 != value)
				 {
					_valor2 = value;
					 PropertyHasChanged("Valor2");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Iddecree_detail", "Iddecree_detail"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Parameter", "Parameter",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Valor1", "Valor1",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Valor2", "Valor2",50));
		}

		#endregion

	}
}
