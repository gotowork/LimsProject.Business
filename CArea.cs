using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CArea: BusinessObjectBase
	{

		#region InnerClass
		public enum CAreaFields
		{
			Cod_area,
			Nom_area,
			Description
		}
		#endregion

		#region Data Members

			string _cod_area;
			string _nom_area;
			string _description;

		#endregion

		#region Properties

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

		public string  Nom_area
		{
			 get { return _nom_area; }
			 set
			 {
				 if (_nom_area != value)
				 {
					_nom_area = value;
					 PropertyHasChanged("Nom_area");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Cod_area", "Cod_area"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_area", "Cod_area",4));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Nom_area", "Nom_area",30));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",100));
		}

		#endregion

	}
}
