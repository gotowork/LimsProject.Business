using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CSet_calibs: BusinessObjectBase
	{

		#region InnerClass
		public enum CSet_calibsFields
		{
			Idset_calibs,
			Calib_group_name,
			R,
			A,
			B,
			Idtemplate_method,
			Idgroup_solution
		}
		#endregion

		#region Data Members

			int _idset_calibs;
			string _calib_group_name;
			decimal? _r;
			decimal? _a;
			decimal? _b;
			int? _idtemplate_method;
			int? _idgroup_solution;

		#endregion

		#region Properties

		public int  Idset_calibs
		{
			 get { return _idset_calibs; }
			 set
			 {
				 if (_idset_calibs != value)
				 {
					_idset_calibs = value;
					 PropertyHasChanged("Idset_calibs");
				 }
			 }
		}

		public string  Calib_group_name
		{
			 get { return _calib_group_name; }
			 set
			 {
				 if (_calib_group_name != value)
				 {
					_calib_group_name = value;
					 PropertyHasChanged("Calib_group_name");
				 }
			 }
		}

		public decimal?  R
		{
			 get { return _r; }
			 set
			 {
				 if (_r != value)
				 {
					_r = value;
					 PropertyHasChanged("R");
				 }
			 }
		}

		public decimal?  A
		{
			 get { return _a; }
			 set
			 {
				 if (_a != value)
				 {
					_a = value;
					 PropertyHasChanged("A");
				 }
			 }
		}

		public decimal?  B
		{
			 get { return _b; }
			 set
			 {
				 if (_b != value)
				 {
					_b = value;
					 PropertyHasChanged("B");
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

		public int?  Idgroup_solution
		{
			 get { return _idgroup_solution; }
			 set
			 {
				 if (_idgroup_solution != value)
				 {
					_idgroup_solution = value;
					 PropertyHasChanged("Idgroup_solution");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idset_calibs", "Idset_calibs"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Calib_group_name", "Calib_group_name",20));
		}

		#endregion

	}
}
