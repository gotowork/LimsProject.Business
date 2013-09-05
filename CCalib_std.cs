using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCalib_std: BusinessObjectBase
	{

		#region InnerClass
		public enum CCalib_stdFields
		{
			Idcalib_std,
			Idcalib,
			Absorbance,
			Absorbance_previus,
			Concentration,
			Idset_calibs,
			Idtemplate_method,
			Idgroup_solution
		}
		#endregion

		#region Data Members

			long _idcalib_std;
			long? _idcalib;
			decimal? _absorbance;
			decimal? _absorbance_previus;
			decimal? _concentration;
			int? _idset_calibs;
			int? _idtemplate_method;
			int? _idgroup_solution;

		#endregion

		#region Properties

		public long  Idcalib_std
		{
			 get { return _idcalib_std; }
			 set
			 {
				 if (_idcalib_std != value)
				 {
					_idcalib_std = value;
					 PropertyHasChanged("Idcalib_std");
				 }
			 }
		}

		public long?  Idcalib
		{
			 get { return _idcalib; }
			 set
			 {
				 if (_idcalib != value)
				 {
					_idcalib = value;
					 PropertyHasChanged("Idcalib");
				 }
			 }
		}

		public decimal?  Absorbance
		{
			 get { return _absorbance; }
			 set
			 {
				 if (_absorbance != value)
				 {
					_absorbance = value;
					 PropertyHasChanged("Absorbance");
				 }
			 }
		}

		public decimal?  Absorbance_previus
		{
			 get { return _absorbance_previus; }
			 set
			 {
				 if (_absorbance_previus != value)
				 {
					_absorbance_previus = value;
					 PropertyHasChanged("Absorbance_previus");
				 }
			 }
		}

		public decimal?  Concentration
		{
			 get { return _concentration; }
			 set
			 {
				 if (_concentration != value)
				 {
					_concentration = value;
					 PropertyHasChanged("Concentration");
				 }
			 }
		}

		public int?  Idset_calibs
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idcalib_std", "Idcalib_std"));
		}

		#endregion

	}
}
