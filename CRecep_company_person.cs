using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_company_person: BusinessObjectBase
	{

		#region InnerClass
		public enum CRecep_company_personFields
		{
			Idrecep_company_person,
			Idcompany,
			Idperson,
			Idrecep_sample,
			Person_type,
			Enabled_show,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			long _idrecep_company_person;
			short? _idcompany;
			short? _idperson;
			long? _idrecep_sample;
			short? _person_type;
			bool? _enabled_show;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public long  Idrecep_company_person
		{
			 get { return _idrecep_company_person; }
			 set
			 {
				 if (_idrecep_company_person != value)
				 {
					_idrecep_company_person = value;
					 PropertyHasChanged("Idrecep_company_person");
				 }
			 }
		}

		public short?  Idcompany
		{
			 get { return _idcompany; }
			 set
			 {
				 if (_idcompany != value)
				 {
					_idcompany = value;
					 PropertyHasChanged("Idcompany");
				 }
			 }
		}

		public short?  Idperson
		{
			 get { return _idperson; }
			 set
			 {
				 if (_idperson != value)
				 {
					_idperson = value;
					 PropertyHasChanged("Idperson");
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

		public short?  Person_type
		{
			 get { return _person_type; }
			 set
			 {
				 if (_person_type != value)
				 {
					_person_type = value;
					 PropertyHasChanged("Person_type");
				 }
			 }
		}

		public bool?  Enabled_show
		{
			 get { return _enabled_show; }
			 set
			 {
				 if (_enabled_show != value)
				 {
					_enabled_show = value;
					 PropertyHasChanged("Enabled_show");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idrecep_company_person", "Idrecep_company_person"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
