using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CUser_system: BusinessObjectBase
	{

		#region InnerClass
		public enum CUser_systemFields
		{
			Iduser,
			Cod_user,
			Pwd,
			Idperson,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			short _iduser;
			string _cod_user;
			string _pwd;
			short? _idperson;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public short  Iduser
		{
			 get { return _iduser; }
			 set
			 {
				 if (_iduser != value)
				 {
					_iduser = value;
					 PropertyHasChanged("Iduser");
				 }
			 }
		}

		public string  Cod_user
		{
			 get { return _cod_user; }
			 set
			 {
				 if (_cod_user != value)
				 {
					_cod_user = value;
					 PropertyHasChanged("Cod_user");
				 }
			 }
		}

		public string  Pwd
		{
			 get { return _pwd; }
			 set
			 {
				 if (_pwd != value)
				 {
					_pwd = value;
					 PropertyHasChanged("Pwd");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Iduser", "Iduser"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Cod_user", "Cod_user"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_user", "Cod_user",30));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Pwd", "Pwd"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Pwd", "Pwd",32));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",50));
		}

		#endregion

	}
}
