using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CControl_sample: BusinessObjectBase
	{

		#region InnerClass
		public enum CControl_sampleFields
		{
			Idcontrol_sample,
			Idtype_sample_control,
			Idtemplate_method,
			Type_analisys,
			Name_cs,
			Description,
			Name_value_prefijo,
			Value1,
			Name_value_sufijo,
			Name_frec_prefijo,
			Frecuency,
			Name_frec_sufijo,
			Flag_frec_by_batch,
			Flag_frec_by_sample,
			Priority,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _idcontrol_sample;
			int? _idtype_sample_control;
			int? _idtemplate_method;
			int? _type_analisys;
			string _name_cs;
			string _description;
			string _name_value_prefijo;
			decimal? _value1;
			string _name_value_sufijo;
			string _name_frec_prefijo;
			int? _frecuency;
			string _name_frec_sufijo;
			bool? _flag_frec_by_batch;
			bool? _flag_frec_by_sample;
			int? _priority;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public int  Idcontrol_sample
		{
			 get { return _idcontrol_sample; }
			 set
			 {
				 if (_idcontrol_sample != value)
				 {
					_idcontrol_sample = value;
					 PropertyHasChanged("Idcontrol_sample");
				 }
			 }
		}

		public int?  Idtype_sample_control
		{
			 get { return _idtype_sample_control; }
			 set
			 {
				 if (_idtype_sample_control != value)
				 {
					_idtype_sample_control = value;
					 PropertyHasChanged("Idtype_sample_control");
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

		public int?  Type_analisys
		{
			 get { return _type_analisys; }
			 set
			 {
				 if (_type_analisys != value)
				 {
					_type_analisys = value;
					 PropertyHasChanged("Type_analisys");
				 }
			 }
		}

		public string  Name_cs
		{
			 get { return _name_cs; }
			 set
			 {
				 if (_name_cs != value)
				 {
					_name_cs = value;
					 PropertyHasChanged("Name_cs");
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

		public string  Name_value_prefijo
		{
			 get { return _name_value_prefijo; }
			 set
			 {
				 if (_name_value_prefijo != value)
				 {
					_name_value_prefijo = value;
					 PropertyHasChanged("Name_value_prefijo");
				 }
			 }
		}

		public decimal?  Value1
		{
			 get { return _value1; }
			 set
			 {
				 if (_value1 != value)
				 {
					_value1 = value;
					 PropertyHasChanged("Value1");
				 }
			 }
		}

		public string  Name_value_sufijo
		{
			 get { return _name_value_sufijo; }
			 set
			 {
				 if (_name_value_sufijo != value)
				 {
					_name_value_sufijo = value;
					 PropertyHasChanged("Name_value_sufijo");
				 }
			 }
		}

		public string  Name_frec_prefijo
		{
			 get { return _name_frec_prefijo; }
			 set
			 {
				 if (_name_frec_prefijo != value)
				 {
					_name_frec_prefijo = value;
					 PropertyHasChanged("Name_frec_prefijo");
				 }
			 }
		}

		public int?  Frecuency
		{
			 get { return _frecuency; }
			 set
			 {
				 if (_frecuency != value)
				 {
					_frecuency = value;
					 PropertyHasChanged("Frecuency");
				 }
			 }
		}

		public string  Name_frec_sufijo
		{
			 get { return _name_frec_sufijo; }
			 set
			 {
				 if (_name_frec_sufijo != value)
				 {
					_name_frec_sufijo = value;
					 PropertyHasChanged("Name_frec_sufijo");
				 }
			 }
		}

		public bool?  Flag_frec_by_batch
		{
			 get { return _flag_frec_by_batch; }
			 set
			 {
				 if (_flag_frec_by_batch != value)
				 {
					_flag_frec_by_batch = value;
					 PropertyHasChanged("Flag_frec_by_batch");
				 }
			 }
		}

		public bool?  Flag_frec_by_sample
		{
			 get { return _flag_frec_by_sample; }
			 set
			 {
				 if (_flag_frec_by_sample != value)
				 {
					_flag_frec_by_sample = value;
					 PropertyHasChanged("Flag_frec_by_sample");
				 }
			 }
		}

		public int?  Priority
		{
			 get { return _priority; }
			 set
			 {
				 if (_priority != value)
				 {
					_priority = value;
					 PropertyHasChanged("Priority");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idcontrol_sample", "Idcontrol_sample"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_cs", "Name_cs",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",200));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_value_prefijo", "Name_value_prefijo",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_value_sufijo", "Name_value_sufijo",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_frec_prefijo", "Name_frec_prefijo",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_frec_sufijo", "Name_frec_sufijo",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",50));
		}

		#endregion

	}
}
