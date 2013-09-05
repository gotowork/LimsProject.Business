using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMr: BusinessObjectBase
	{

		#region InnerClass
		public enum CMrFields
		{
			Idmr,
			Cod_mr,
			Lot,
			Type_mr,
			Type_material,
			Status_mr,
			Manufaturer,
			Certifier,
			Fbegin_validity,
			Fend_validity,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status,
			Solid
		}
		#endregion

		#region Data Members

			short _idmr;
			string _cod_mr;
			string _lot;
			char? _type_mr;
			char? _type_material;
			bool? _status_mr;
			short? _manufaturer;
			short? _certifier;
			DateTime? _fbegin_validity;
			DateTime? _fend_validity;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;
			bool? _solid;

		#endregion

		#region Properties

		public short  Idmr
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

		public string  Cod_mr
		{
			 get { return _cod_mr; }
			 set
			 {
				 if (_cod_mr != value)
				 {
					_cod_mr = value;
					 PropertyHasChanged("Cod_mr");
				 }
			 }
		}

		public string  Lot
		{
			 get { return _lot; }
			 set
			 {
				 if (_lot != value)
				 {
					_lot = value;
					 PropertyHasChanged("Lot");
				 }
			 }
		}

		public char?  Type_mr
		{
			 get { return _type_mr; }
			 set
			 {
				 if (_type_mr != value)
				 {
					_type_mr = value;
					 PropertyHasChanged("Type_mr");
				 }
			 }
		}

		public char?  Type_material
		{
			 get { return _type_material; }
			 set
			 {
				 if (_type_material != value)
				 {
					_type_material = value;
					 PropertyHasChanged("Type_material");
				 }
			 }
		}

		public bool?  Status_mr
		{
			 get { return _status_mr; }
			 set
			 {
				 if (_status_mr != value)
				 {
					_status_mr = value;
					 PropertyHasChanged("Status_mr");
				 }
			 }
		}

		public short?  Manufaturer
		{
			 get { return _manufaturer; }
			 set
			 {
				 if (_manufaturer != value)
				 {
					_manufaturer = value;
					 PropertyHasChanged("Manufaturer");
				 }
			 }
		}

		public short?  Certifier
		{
			 get { return _certifier; }
			 set
			 {
				 if (_certifier != value)
				 {
					_certifier = value;
					 PropertyHasChanged("Certifier");
				 }
			 }
		}

		public DateTime?  Fbegin_validity
		{
			 get { return _fbegin_validity; }
			 set
			 {
				 if (_fbegin_validity != value)
				 {
					_fbegin_validity = value;
					 PropertyHasChanged("Fbegin_validity");
				 }
			 }
		}

		public DateTime?  Fend_validity
		{
			 get { return _fend_validity; }
			 set
			 {
				 if (_fend_validity != value)
				 {
					_fend_validity = value;
					 PropertyHasChanged("Fend_validity");
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

		public bool?  Solid
		{
			 get { return _solid; }
			 set
			 {
				 if (_solid != value)
				 {
					_solid = value;
					 PropertyHasChanged("Solid");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idmr", "Idmr"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_mr", "Cod_mr",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Lot", "Lot",12));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
