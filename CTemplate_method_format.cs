using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTemplate_method_format: BusinessObjectBase
	{

		#region InnerClass
		public enum CTemplate_method_formatFields
		{
			Idtemplate_method_format,
			Idtemplate_method,
			Nom_field,
			Num_decimal
		}
		#endregion

		#region Data Members

			long _idtemplate_method_format;
			int? _idtemplate_method;
			string _nom_field;
			short? _num_decimal;

		#endregion

		#region Properties

		public long  Idtemplate_method_format
		{
			 get { return _idtemplate_method_format; }
			 set
			 {
				 if (_idtemplate_method_format != value)
				 {
					_idtemplate_method_format = value;
					 PropertyHasChanged("Idtemplate_method_format");
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

		public string  Nom_field
		{
			 get { return _nom_field; }
			 set
			 {
				 if (_nom_field != value)
				 {
					_nom_field = value;
					 PropertyHasChanged("Nom_field");
				 }
			 }
		}

		public short?  Num_decimal
		{
			 get { return _num_decimal; }
			 set
			 {
				 if (_num_decimal != value)
				 {
					_num_decimal = value;
					 PropertyHasChanged("Num_decimal");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idtemplate_method_format", "Idtemplate_method_format"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Nom_field", "Nom_field",40));
		}

		#endregion

	}
}
