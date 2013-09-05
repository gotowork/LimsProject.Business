using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CConfiguration: BusinessObjectBase
	{

		#region InnerClass
		public enum CConfigurationFields
		{
			Idconfiguration,
			Nom_configuration,
			Value_configuration
		}
		#endregion

		#region Data Members

			short _idconfiguration;
			string _nom_configuration;
			string _value_configuration;

		#endregion

		#region Properties

		public short  Idconfiguration
		{
			 get { return _idconfiguration; }
			 set
			 {
				 if (_idconfiguration != value)
				 {
					_idconfiguration = value;
					 PropertyHasChanged("Idconfiguration");
				 }
			 }
		}

		public string  Nom_configuration
		{
			 get { return _nom_configuration; }
			 set
			 {
				 if (_nom_configuration != value)
				 {
					_nom_configuration = value;
					 PropertyHasChanged("Nom_configuration");
				 }
			 }
		}

		public string  Value_configuration
		{
			 get { return _value_configuration; }
			 set
			 {
				 if (_value_configuration != value)
				 {
					_value_configuration = value;
					 PropertyHasChanged("Value_configuration");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idconfiguration", "Idconfiguration"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Nom_configuration", "Nom_configuration",30));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Value_configuration", "Value_configuration",300));
		}

		#endregion

	}
}
