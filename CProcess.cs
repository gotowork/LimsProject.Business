using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CProcess: BusinessObjectBase
	{

		#region InnerClass
		public enum CProcessFields
		{
			Cod_process,
			Nom_process,
			Description,
			Cod_module,
			Cod_area
		}
		#endregion

		#region Data Members

			string _cod_process;
			string _nom_process;
			string _description;
			string _cod_module;
			string _cod_area;

		#endregion

		#region Properties

		public string  Cod_process
		{
			 get { return _cod_process; }
			 set
			 {
				 if (_cod_process != value)
				 {
					_cod_process = value;
					 PropertyHasChanged("Cod_process");
				 }
			 }
		}

		public string  Nom_process
		{
			 get { return _nom_process; }
			 set
			 {
				 if (_nom_process != value)
				 {
					_nom_process = value;
					 PropertyHasChanged("Nom_process");
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

		public string  Cod_module
		{
			 get { return _cod_module; }
			 set
			 {
				 if (_cod_module != value)
				 {
					_cod_module = value;
					 PropertyHasChanged("Cod_module");
				 }
			 }
		}

		public string  Cod_area
		{
			 get { return _cod_area; }
			 set
			 {
				 if (_cod_area != value)
				 {
					_cod_area = value;
					 PropertyHasChanged("Cod_area");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Cod_process", "Cod_process"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_process", "Cod_process",4));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Nom_process", "Nom_process",30));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_module", "Cod_module",4));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_area", "Cod_area",4));
		}

		#endregion

	}
}
