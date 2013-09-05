using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMr_detail: BusinessObjectBase
	{

		#region InnerClass
		public enum CMr_detailFields
		{
			Idmr_detail,
			Idmr,
			Analyte,
			Cod_element,
			Nom_detail,
			Incertitude,
			Nominal_value,
			Idunit1,
			Document_ref,
			Dev,
			Dev_labs,
			Flag_provitional,
			Cod_digestion_method,
			Observation,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			short _idmr_detail;
			short? _idmr;
			short? _analyte;
			string _cod_element;
			string _nom_detail;
			decimal? _incertitude;
			decimal? _nominal_value;
			short? _idunit1;
			string _document_ref;
			decimal? _dev;
			decimal? _dev_labs;
			bool? _flag_provitional;
			string _cod_digestion_method;
			string _observation;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public short  Idmr_detail
		{
			 get { return _idmr_detail; }
			 set
			 {
				 if (_idmr_detail != value)
				 {
					_idmr_detail = value;
					 PropertyHasChanged("Idmr_detail");
				 }
			 }
		}

		public short?  Idmr
		{
			 get { return _idmr; }
			 set
			 {
				 if (_idmr != value)
				 {
					_idmr = value;
					 PropertyHasChanged("Idmr");
				 }
			 }
		}

		public short?  Analyte
		{
			 get { return _analyte; }
			 set
			 {
				 if (_analyte != value)
				 {
					_analyte = value;
					 PropertyHasChanged("Analyte");
				 }
			 }
		}

		public string  Cod_element
		{
			 get { return _cod_element; }
			 set
			 {
				 if (_cod_element != value)
				 {
					_cod_element = value;
					 PropertyHasChanged("Cod_element");
				 }
			 }
		}

		public string  Nom_detail
		{
			 get { return _nom_detail; }
			 set
			 {
				 if (_nom_detail != value)
				 {
					_nom_detail = value;
					 PropertyHasChanged("Nom_detail");
				 }
			 }
		}

		public decimal?  Incertitude
		{
			 get { return _incertitude; }
			 set
			 {
				 if (_incertitude != value)
				 {
					_incertitude = value;
					 PropertyHasChanged("Incertitude");
				 }
			 }
		}

		public decimal?  Nominal_value
		{
			 get { return _nominal_value; }
			 set
			 {
				 if (_nominal_value != value)
				 {
					_nominal_value = value;
					 PropertyHasChanged("Nominal_value");
				 }
			 }
		}

		public short?  Idunit1
		{
			 get { return _idunit1; }
			 set
			 {
				 if (_idunit1 != value)
				 {
					_idunit1 = value;
					 PropertyHasChanged("Idunit1");
				 }
			 }
		}

		public string  Document_ref
		{
			 get { return _document_ref; }
			 set
			 {
				 if (_document_ref != value)
				 {
					_document_ref = value;
					 PropertyHasChanged("Document_ref");
				 }
			 }
		}

		public decimal?  Dev
		{
			 get { return _dev; }
			 set
			 {
				 if (_dev != value)
				 {
					_dev = value;
					 PropertyHasChanged("Dev");
				 }
			 }
		}

		public decimal?  Dev_labs
		{
			 get { return _dev_labs; }
			 set
			 {
				 if (_dev_labs != value)
				 {
					_dev_labs = value;
					 PropertyHasChanged("Dev_labs");
				 }
			 }
		}

		public bool?  Flag_provitional
		{
			 get { return _flag_provitional; }
			 set
			 {
				 if (_flag_provitional != value)
				 {
					_flag_provitional = value;
					 PropertyHasChanged("Flag_provitional");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idmr_detail", "Idmr_detail"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_element", "Cod_element",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Nom_detail", "Nom_detail",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Document_ref", "Document_ref",1000));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_digestion_method", "Cod_digestion_method",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Observation", "Observation",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
