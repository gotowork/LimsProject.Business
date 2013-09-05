using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CType_solution: BusinessObjectBase
	{

		#region InnerClass
		public enum CType_solutionFields
		{
			Idtype_solution,
			Name_type_solution,
			Num_days_expiration,
			Observation,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _idtype_solution;
			string _name_type_solution;
			short? _num_days_expiration;
			string _observation;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public int  Idtype_solution
		{
			 get { return _idtype_solution; }
			 set
			 {
				 if (_idtype_solution != value)
				 {
					_idtype_solution = value;
					 PropertyHasChanged("Idtype_solution");
				 }
			 }
		}

		public string  Name_type_solution
		{
			 get { return _name_type_solution; }
			 set
			 {
				 if (_name_type_solution != value)
				 {
					_name_type_solution = value;
					 PropertyHasChanged("Name_type_solution");
				 }
			 }
		}

		public short?  Num_days_expiration
		{
			 get { return _num_days_expiration; }
			 set
			 {
				 if (_num_days_expiration != value)
				 {
					_num_days_expiration = value;
					 PropertyHasChanged("Num_days_expiration");
				 }
			 }
		}

		public string  Observation
		{
			 get { return _observation; }
			 set
			 {
				 if (_observation != value)
				 {
					_observation = value;
					 PropertyHasChanged("Observation");
				 }
			 }
		}

		public string  Usernew
		{
			 get { return _usernew; }
			 set
			 {
				 if (_usernew != value)
				 {
					_usernew = value;
					 PropertyHasChanged("Usernew");
				 }
			 }
		}

		public DateTime?  Datenew
		{
			 get { return _datenew; }
			 set
			 {
				 if (_datenew != value)
				 {
					_datenew = value;
					 PropertyHasChanged("Datenew");
				 }
			 }
		}

		public string  Useredit
		{
			 get { return _useredit; }
			 set
			 {
				 if (_useredit != value)
				 {
					_useredit = value;
					 PropertyHasChanged("Useredit");
				 }
			 }
		}

		public DateTime?  Dateedit
		{
			 get { return _dateedit; }
			 set
			 {
				 if (_dateedit != value)
				 {
					_dateedit = value;
					 PropertyHasChanged("Dateedit");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idtype_solution", "Idtype_solution"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_type_solution", "Name_type_solution",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Observation", "Observation",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
