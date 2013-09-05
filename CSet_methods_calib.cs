using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CSet_methods_calib: BusinessObjectBase
	{

		#region InnerClass
		public enum CSet_methods_calibFields
		{
			Idset_methods_calib,
			Idsolution_pattern,
			Idelement,
			Idmr_detail,
			Idreactive_medium,
			Idreactive_modif,
			Order_set,
			Name_methods_calib,
			User_calib,
			Date_calib,
			Status_set,
			Date_ini,
			Date_end
		}
		#endregion

		#region Data Members

			int _idset_methods_calib;
			int? _idsolution_pattern;
			int? _idelement;
			short? _idmr_detail;
			int? _idreactive_medium;
			int? _idreactive_modif;
			int? _order_set;
			string _name_methods_calib;
			short? _user_calib;
			DateTime? _date_calib;
			int? _status_set;
			DateTime? _date_ini;
			DateTime? _date_end;

		#endregion

		#region Properties

		public int  Idset_methods_calib
		{
			 get { return _idset_methods_calib; }
			 set
			 {
				 if (_idset_methods_calib != value)
				 {
					_idset_methods_calib = value;
					 PropertyHasChanged("Idset_methods_calib");
				 }
			 }
		}

		public int?  Idsolution_pattern
		{
			 get { return _idsolution_pattern; }
			 set
			 {
				 if (_idsolution_pattern != value)
				 {
					_idsolution_pattern = value;
					 PropertyHasChanged("Idsolution_pattern");
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

		public short?  Idmr_detail
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

		public int?  Idreactive_medium
		{
			 get { return _idreactive_medium; }
			 set
			 {
				 if (_idreactive_medium != value)
				 {
					_idreactive_medium = value;
					 PropertyHasChanged("Idreactive_medium");
				 }
			 }
		}

		public int?  Idreactive_modif
		{
			 get { return _idreactive_modif; }
			 set
			 {
				 if (_idreactive_modif != value)
				 {
					_idreactive_modif = value;
					 PropertyHasChanged("Idreactive_modif");
				 }
			 }
		}

		public int?  Order_set
		{
			 get { return _order_set; }
			 set
			 {
				 if (_order_set != value)
				 {
					_order_set = value;
					 PropertyHasChanged("Order_set");
				 }
			 }
		}

		public string  Name_methods_calib
		{
			 get { return _name_methods_calib; }
			 set
			 {
				 if (_name_methods_calib != value)
				 {
					_name_methods_calib = value;
					 PropertyHasChanged("Name_methods_calib");
				 }
			 }
		}

		public short?  User_calib
		{
			 get { return _user_calib; }
			 set
			 {
				 if (_user_calib != value)
				 {
					_user_calib = value;
					 PropertyHasChanged("User_calib");
				 }
			 }
		}

		public DateTime?  Date_calib
		{
			 get { return _date_calib; }
			 set
			 {
				 if (_date_calib != value)
				 {
					_date_calib = value;
					 PropertyHasChanged("Date_calib");
				 }
			 }
		}

		public int?  Status_set
		{
			 get { return _status_set; }
			 set
			 {
				 if (_status_set != value)
				 {
					_status_set = value;
					 PropertyHasChanged("Status_set");
				 }
			 }
		}

		public DateTime?  Date_ini
		{
			 get { return _date_ini; }
			 set
			 {
				 if (_date_ini != value)
				 {
					_date_ini = value;
					 PropertyHasChanged("Date_ini");
				 }
			 }
		}

		public DateTime?  Date_end
		{
			 get { return _date_end; }
			 set
			 {
				 if (_date_end != value)
				 {
					_date_end = value;
					 PropertyHasChanged("Date_end");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idset_methods_calib", "Idset_methods_calib"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_methods_calib", "Name_methods_calib",100));
		}

		#endregion

	}
}
