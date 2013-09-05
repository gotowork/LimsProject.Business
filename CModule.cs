using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CModule: BusinessObjectBase
	{

		#region InnerClass
		public enum CModuleFields
		{
			Cod_module,
			Nom_module,
			Description
		}
		#endregion

		#region Data Members

			string _cod_module;
			string _nom_module;
			string _description;

		#endregion

		#region Properties

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

		public string  Nom_module
		{
			 get { return _nom_module; }
			 set
			 {
				 if (_nom_module != value)
				 {
					_nom_module = value;
					 PropertyHasChanged("Nom_module");
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Cod_module", "Cod_module"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_module", "Cod_module",4));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Nom_module", "Nom_module",30));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",100));
		}

		#endregion

	}
}
