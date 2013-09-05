using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CPerson: BusinessObjectBase
	{

		#region InnerClass
		public enum CPersonFields
		{
			Idperson,
			Cod_person,
			Type_document,
			Last_name1,
			Last_name2,
			Names_person,
			Allname,
			Gender,
			Domicile,
			Mail,
			Phone,
			Cellphone,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status,
			Person_type
		}
		#endregion

		#region Data Members

			short _idperson;
			string _cod_person;
			short? _type_document;
			string _last_name1;
			string _last_name2;
			string _names_person;
			string _allname;
			char? _gender;
			string _domicile;
			string _mail;
			string _phone;
			string _cellphone;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;
			int? _person_type;

		#endregion

		#region Properties

		public short  Idperson
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

		public string  Cod_person
		{
			 get { return _cod_person; }
			 set
			 {
				 if (_cod_person != value)
				 {
					_cod_person = value;
					 PropertyHasChanged("Cod_person");
				 }
			 }
		}

		public short?  Type_document
		{
			 get { return _type_document; }
			 set
			 {
				 if (_type_document != value)
				 {
					_type_document = value;
					 PropertyHasChanged("Type_document");
				 }
			 }
		}

		public string  Last_name1
		{
			 get { return _last_name1; }
			 set
			 {
				 if (_last_name1 != value)
				 {
					_last_name1 = value;
					 PropertyHasChanged("Last_name1");
				 }
			 }
		}

		public string  Last_name2
		{
			 get { return _last_name2; }
			 set
			 {
				 if (_last_name2 != value)
				 {
					_last_name2 = value;
					 PropertyHasChanged("Last_name2");
				 }
			 }
		}

		public string  Names_person
		{
			 get { return _names_person; }
			 set
			 {
				 if (_names_person != value)
				 {
					_names_person = value;
					 PropertyHasChanged("Names_person");
				 }
			 }
		}

		public string  Allname
		{
			 get { return _allname; }
			 set
			 {
				 if (_allname != value)
				 {
					_allname = value;
					 PropertyHasChanged("Allname");
				 }
			 }
		}

		public char?  Gender
		{
			 get { return _gender; }
			 set
			 {
				 if (_gender != value)
				 {
					_gender = value;
					 PropertyHasChanged("Gender");
				 }
			 }
		}

		public string  Domicile
		{
			 get { return _domicile; }
			 set
			 {
				 if (_domicile != value)
				 {
					_domicile = value;
					 PropertyHasChanged("Domicile");
				 }
			 }
		}

		public string  Mail
		{
			 get { return _mail; }
			 set
			 {
				 if (_mail != value)
				 {
					_mail = value;
					 PropertyHasChanged("Mail");
				 }
			 }
		}

		public string  Phone
		{
			 get { return _phone; }
			 set
			 {
				 if (_phone != value)
				 {
					_phone = value;
					 PropertyHasChanged("Phone");
				 }
			 }
		}

		public string  Cellphone
		{
			 get { return _cellphone; }
			 set
			 {
				 if (_cellphone != value)
				 {
					_cellphone = value;
					 PropertyHasChanged("Cellphone");
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

		public int?  Person_type
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idperson", "Idperson"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_person", "Cod_person",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Last_name1", "Last_name1",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Last_name2", "Last_name2",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Names_person", "Names_person",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Allname", "Allname",200));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Domicile", "Domicile",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Mail", "Mail",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Phone", "Phone",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cellphone", "Cellphone",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
