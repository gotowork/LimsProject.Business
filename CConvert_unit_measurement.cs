using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CConvert_unit_measurement: BusinessObjectBase
	{

		#region InnerClass
		public enum CConvert_unit_measurementFields
		{
			Idconvert,
			Den_unit1,
			Den_unit2,
			Idunit1,
			Idunit2,
			Factor,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			short _idconvert;
			string _den_unit1;
			string _den_unit2;
			short? _idunit1;
			short? _idunit2;
			decimal? _factor;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public short  Idconvert
		{
			 get { return _idconvert; }
			 set
			 {
				 if (_idconvert != value)
				 {
					_idconvert = value;
					 PropertyHasChanged("Idconvert");
				 }
			 }
		}

		public string  Den_unit1
		{
			 get { return _den_unit1; }
			 set
			 {
				 if (_den_unit1 != value)
				 {
					_den_unit1 = value;
					 PropertyHasChanged("Den_unit1");
				 }
			 }
		}

		public string  Den_unit2
		{
			 get { return _den_unit2; }
			 set
			 {
				 if (_den_unit2 != value)
				 {
					_den_unit2 = value;
					 PropertyHasChanged("Den_unit2");
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

		public short?  Idunit2
		{
			 get { return _idunit2; }
			 set
			 {
				 if (_idunit2 != value)
				 {
					_idunit2 = value;
					 PropertyHasChanged("Idunit2");
				 }
			 }
		}

		public decimal?  Factor
		{
			 get { return _factor; }
			 set
			 {
				 if (_factor != value)
				 {
					_factor = value;
					 PropertyHasChanged("Factor");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idconvert", "Idconvert"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Den_unit1", "Den_unit1",6));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Den_unit2", "Den_unit2",6));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
