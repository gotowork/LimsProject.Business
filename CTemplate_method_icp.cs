using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTemplate_method_icp: BusinessObjectBase
	{

		#region InnerClass
		public enum CTemplate_method_icpFields
		{
			Idtemplate_method,
			Volumen,
			Aliquot,
			Dilution_flag,
			Dilution_value,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _idtemplate_method;
			decimal? _volumen;
			decimal? _aliquot;
			bool? _dilution_flag;
			decimal? _dilution_value;
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

		public decimal?  Volumen
		{
			 get { return _volumen; }
			 set
			 {
				 if (_volumen != value)
				 {
					_volumen = value;
					 PropertyHasChanged("Volumen");
				 }
			 }
		}

		public decimal?  Aliquot
		{
			 get { return _aliquot; }
			 set
			 {
				 if (_aliquot != value)
				 {
					_aliquot = value;
					 PropertyHasChanged("Aliquot");
				 }
			 }
		}

		public bool?  Dilution_flag
		{
			 get { return _dilution_flag; }
			 set
			 {
				 if (_dilution_flag != value)
				 {
					_dilution_flag = value;
					 PropertyHasChanged("Dilution_flag");
				 }
			 }
		}

		public decimal?  Dilution_value
		{
			 get { return _dilution_value; }
			 set
			 {
				 if (_dilution_value != value)
				 {
					_dilution_value = value;
					 PropertyHasChanged("Dilution_value");
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
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
