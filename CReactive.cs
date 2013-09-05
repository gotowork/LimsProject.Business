using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CReactive: BusinessObjectBase
	{

		#region InnerClass
		public enum CReactiveFields
		{
			Idreactive,
			Reactive_name,
			Chemical_formula,
			Weight_molecular
		}
		#endregion

		#region Data Members

			int _idreactive;
			string _reactive_name;
			string _chemical_formula;
			decimal? _weight_molecular;

		#endregion

		#region Properties

		public int  Idreactive
		{
			 get { return _idreactive; }
			 set
			 {
				 if (_idreactive != value)
				 {
					_idreactive = value;
					 PropertyHasChanged("Idreactive");
				 }
			 }
		}

		public string  Reactive_name
		{
			 get { return _reactive_name; }
			 set
			 {
				 if (_reactive_name != value)
				 {
					_reactive_name = value;
					 PropertyHasChanged("Reactive_name");
				 }
			 }
		}

		public string  Chemical_formula
		{
			 get { return _chemical_formula; }
			 set
			 {
				 if (_chemical_formula != value)
				 {
					_chemical_formula = value;
					 PropertyHasChanged("Chemical_formula");
				 }
			 }
		}

		public decimal?  Weight_molecular
		{
			 get { return _weight_molecular; }
			 set
			 {
				 if (_weight_molecular != value)
				 {
					_weight_molecular = value;
					 PropertyHasChanged("Weight_molecular");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idreactive", "Idreactive"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Reactive_name", "Reactive_name",40));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Chemical_formula", "Chemical_formula",15));
		}

		#endregion

	}
}
