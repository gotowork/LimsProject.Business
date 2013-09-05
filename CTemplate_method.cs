using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTemplate_method: BusinessObjectBase
	{

		#region InnerClass
		public enum CTemplate_methodFields
		{
			Idtemplate_method,
			Num_version,
			Cod_template_method,
			Cod_repetition,
			Title,
			Abbreviation,
			Name_method,
			Type_analisys,
			Recognized,
			Idelement,
			Cod_type_sample,
			Cod_digestion_method,
			Cost_method,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _idtemplate_method;
			short? _num_version;
			string _cod_template_method;
			short? _cod_repetition;
			string _title;
			string _abbreviation;
			string _name_method;
			char? _type_analisys;
			bool? _recognized;
			int? _idelement;
			string _cod_type_sample;
			string _cod_digestion_method;
			decimal? _cost_method;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public int  Idtemplate_method
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

		public short?  Num_version
		{
			 get { return _num_version; }
			 set
			 {
				 if (_num_version != value)
				 {
					_num_version = value;
					 PropertyHasChanged("Num_version");
				 }
			 }
		}

		public string  Cod_template_method
		{
			 get { return _cod_template_method; }
			 set
			 {
				 if (_cod_template_method != value)
				 {
					_cod_template_method = value;
					 PropertyHasChanged("Cod_template_method");
				 }
			 }
		}

		public short?  Cod_repetition
		{
			 get { return _cod_repetition; }
			 set
			 {
				 if (_cod_repetition != value)
				 {
					_cod_repetition = value;
					 PropertyHasChanged("Cod_repetition");
				 }
			 }
		}

		public string  Title
		{
			 get { return _title; }
			 set
			 {
				 if (_title != value)
				 {
					_title = value;
					 PropertyHasChanged("Title");
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

		public string  Name_method
		{
			 get { return _name_method; }
			 set
			 {
				 if (_name_method != value)
				 {
					_name_method = value;
					 PropertyHasChanged("Name_method");
				 }
			 }
		}

		public char?  Type_analisys
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

		public bool?  Recognized
		{
			 get { return _recognized; }
			 set
			 {
				 if (_recognized != value)
				 {
					_recognized = value;
					 PropertyHasChanged("Recognized");
				 }
			 }
		}

		public int?  Idelement
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

		public string  Cod_type_sample
		{
			 get { return _cod_type_sample; }
			 set
			 {
				 if (_cod_type_sample != value)
				 {
					_cod_type_sample = value;
					 PropertyHasChanged("Cod_type_sample");
				 }
			 }
		}

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

		public decimal?  Cost_method
		{
			 get { return _cost_method; }
			 set
			 {
				 if (_cost_method != value)
				 {
					_cost_method = value;
					 PropertyHasChanged("Cost_method");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idtemplate_method", "Idtemplate_method"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_template_method", "Cod_template_method",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Title", "Title",200));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Abbreviation", "Abbreviation",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_method", "Name_method",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_type_sample", "Cod_type_sample",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_digestion_method", "Cod_digestion_method",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
