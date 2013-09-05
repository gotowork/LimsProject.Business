using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_elem: BusinessObjectBase
	{

		#region InnerClass
		public enum CRecep_elemFields
		{
			Idrecep_elem,
			Idelement,
			Idtemplate_method,
			Idunit,
			Abbreviation,
			Name_unit,
			Percent_repetition,
			Idrecep_sample
		}
		#endregion

		#region Data Members

			long _idrecep_elem;
			short? _idelement;
			int? _idtemplate_method;
			short? _idunit;
			string _abbreviation;
			string _name_unit;
			short? _percent_repetition;
			long? _idrecep_sample;

		#endregion

		#region Properties

		public long  Idrecep_elem
		{
			 get { return _idrecep_elem; }
			 set
			 {
				 if (_idrecep_elem != value)
				 {
					_idrecep_elem = value;
					 PropertyHasChanged("Idrecep_elem");
				 }
			 }
		}

		public short?  Idelement
		{
			 get { return _idelement; }
			 set
			 {
				 if (_idelement != value)
				 {
					_idelement = value;
					 PropertyHasChanged("Idelement");
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

		public short?  Idunit
		{
			 get { return _idunit; }
			 set
			 {
				 if (_idunit != value)
				 {
					_idunit = value;
					 PropertyHasChanged("Idunit");
				 }
			 }
		}

		public string  Abbreviation
		{
			 get { return _abbreviation; }
			 set
			 {
				 if (_abbreviation != value)
				 {
					_abbreviation = value;
					 PropertyHasChanged("Abbreviation");
				 }
			 }
		}

		public string  Name_unit
		{
			 get { return _name_unit; }
			 set
			 {
				 if (_name_unit != value)
				 {
					_name_unit = value;
					 PropertyHasChanged("Name_unit");
				 }
			 }
		}

		public short?  Percent_repetition
		{
			 get { return _percent_repetition; }
			 set
			 {
				 if (_percent_repetition != value)
				 {
					_percent_repetition = value;
					 PropertyHasChanged("Percent_repetition");
				 }
			 }
		}

		public long?  Idrecep_sample
		{
			 get { return _idrecep_sample; }
			 set
			 {
				 if (_idrecep_sample != value)
				 {
					_idrecep_sample = value;
					 PropertyHasChanged("Idrecep_sample");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idrecep_elem", "Idrecep_elem"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Abbreviation", "Abbreviation",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_unit", "Name_unit",6));
		}

		#endregion

	}
}
