using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMr_jar: BusinessObjectBase
	{

		#region InnerClass
		public enum CMr_jarFields
		{
			Idmr_jar,
			Idmr,
			Idcorrelative,
			Description,
			Observation,
			Fbegin,
			Fend,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			short _idmr_jar;
			short? _idmr;
			short? _idcorrelative;
			string _description;
			string _observation;
			DateTime? _fbegin;
			DateTime? _fend;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public short  Idmr_jar
		{
			 get { return _idmr_jar; }
			 set
			 {
				 if (_idmr_jar != value)
				 {
					_idmr_jar = value;
					 PropertyHasChanged("Idmr_jar");
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

		public short?  Idcorrelative
		{
			 get { return _idcorrelative; }
			 set
			 {
				 if (_idcorrelative != value)
				 {
					_idcorrelative = value;
					 PropertyHasChanged("Idcorrelative");
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

		public DateTime?  Fbegin
		{
			 get { return _fbegin; }
			 set
			 {
				 if (_fbegin != value)
				 {
					_fbegin = value;
					 PropertyHasChanged("Fbegin");
				 }
			 }
		}

		public DateTime?  Fend
		{
			 get { return _fend; }
			 set
			 {
				 if (_fend != value)
				 {
					_fend = value;
					 PropertyHasChanged("Fend");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idmr_jar", "Idmr_jar"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Observation", "Observation",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
