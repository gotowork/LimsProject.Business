using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCompany: BusinessObjectBase
	{

		#region InnerClass
		public enum CCompanyFields
		{
			Idcompany,
			Cod_company,
			Ruc,
			Business_name,
			Type_company,
			Domicile,
			Mail,
			Phone_client,
			Idcontact1,
			Idcontact2,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			short _idcompany;
			string _cod_company;
			string _ruc;
			string _business_name;
			char? _type_company;
			string _domicile;
			string _mail;
			string _phone_client;
			short? _idcontact1;
			short? _idcontact2;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public short  Idcompany
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

		public string  Cod_company
		{
			 get { return _cod_company; }
			 set
			 {
				 if (_cod_company != value)
				 {
					_cod_company = value;
					 PropertyHasChanged("Cod_company");
				 }
			 }
		}

		public string  Ruc
		{
			 get { return _ruc; }
			 set
			 {
				 if (_ruc != value)
				 {
					_ruc = value;
					 PropertyHasChanged("Ruc");
				 }
			 }
		}

		public string  Business_name
		{
			 get { return _business_name; }
			 set
			 {
				 if (_business_name != value)
				 {
					_business_name = value;
					 PropertyHasChanged("Business_name");
				 }
			 }
		}

		public char?  Type_company
		{
			 get { return _type_company; }
			 set
			 {
				 if (_type_company != value)
				 {
					_type_company = value;
					 PropertyHasChanged("Type_company");
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

		public string  Phone_client
		{
			 get { return _phone_client; }
			 set
			 {
				 if (_phone_client != value)
				 {
					_phone_client = value;
					 PropertyHasChanged("Phone_client");
				 }
			 }
		}

		public short?  Idcontact1
		{
			 get { return _idcontact1; }
			 set
			 {
				 if (_idcontact1 != value)
				 {
					_idcontact1 = value;
					 PropertyHasChanged("Idcontact1");
				 }
			 }
		}

		public short?  Idcontact2
		{
			 get { return _idcontact2; }
			 set
			 {
				 if (_idcontact2 != value)
				 {
					_idcontact2 = value;
					 PropertyHasChanged("Idcontact2");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idcompany", "Idcompany"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_company", "Cod_company",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Ruc", "Ruc",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Business_name", "Business_name",30));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Domicile", "Domicile",200));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Mail", "Mail",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Phone_client", "Phone_client",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
