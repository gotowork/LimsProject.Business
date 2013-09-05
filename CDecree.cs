using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDecree: BusinessObjectBase
	{

		#region InnerClass
		public enum CDecreeFields
		{
			Iddecree,
			Cod_decree,
			Name_decree,
			Description,
			Cumple,
			Nocumple,
			Cumple_onlytest,
			Status,
			Conclusion
		}
		#endregion

		#region Data Members

			int _iddecree;
			string _cod_decree;
			string _name_decree;
			string _description;
			string _cumple;
			string _nocumple;
			string _cumple_onlytest;
			bool? _status;
			string _conclusion;

		#endregion

		#region Properties

		public int  Iddecree
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

		public string  Cod_decree
		{
			 get { return _cod_decree; }
			 set
			 {
				 if (_cod_decree != value)
				 {
					_cod_decree = value;
					 PropertyHasChanged("Cod_decree");
				 }
			 }
		}

		public string  Name_decree
		{
			 get { return _name_decree; }
			 set
			 {
				 if (_name_decree != value)
				 {
					_name_decree = value;
					 PropertyHasChanged("Name_decree");
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

		public string  Cumple
		{
			 get { return _cumple; }
			 set
			 {
				 if (_cumple != value)
				 {
					_cumple = value;
					 PropertyHasChanged("Cumple");
				 }
			 }
		}

		public string  Nocumple
		{
			 get { return _nocumple; }
			 set
			 {
				 if (_nocumple != value)
				 {
					_nocumple = value;
					 PropertyHasChanged("Nocumple");
				 }
			 }
		}

		public string  Cumple_onlytest
		{
			 get { return _cumple_onlytest; }
			 set
			 {
				 if (_cumple_onlytest != value)
				 {
					_cumple_onlytest = value;
					 PropertyHasChanged("Cumple_onlytest");
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

		public string  Conclusion
		{
			 get { return _conclusion; }
			 set
			 {
				 if (_conclusion != value)
				 {
					_conclusion = value;
					 PropertyHasChanged("Conclusion");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Iddecree", "Iddecree"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_decree", "Cod_decree",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_decree", "Name_decree",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",500));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cumple", "Cumple",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Nocumple", "Nocumple",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cumple_onlytest", "Cumple_onlytest",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Conclusion", "Conclusion",500));
		}

		#endregion

	}
}
