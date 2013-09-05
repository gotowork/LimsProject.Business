using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDigestion_method: BusinessObjectBase
	{

		#region InnerClass
		public enum CDigestion_methodFields
		{
			Cod_digestion_method,
			Name_digestion_method,
			Status
		}
		#endregion

		#region Data Members

			string _cod_digestion_method;
			string _name_digestion_method;
			bool? _status;

		#endregion

		#region Properties

		public string  Cod_digestion_method
		{
			 get { return _cod_digestion_method; }
			 set
			 {
				 if (_cod_digestion_method != value)
				 {
					_cod_digestion_method = value;
					 PropertyHasChanged("Cod_digestion_method");
				 }
			 }
		}

		public string  Name_digestion_method
		{
			 get { return _name_digestion_method; }
			 set
			 {
				 if (_name_digestion_method != value)
				 {
					_name_digestion_method = value;
					 PropertyHasChanged("Name_digestion_method");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Cod_digestion_method", "Cod_digestion_method"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_digestion_method", "Cod_digestion_method",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_digestion_method", "Name_digestion_method",20));
		}

		#endregion

	}
}
