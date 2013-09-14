using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CGroup_solution: BusinessObjectBase
	{

		#region InnerClass
		public enum CGroup_solutionFields
		{
			Idgroup_solution,
			Idelement,
			Idtemplate_method,
			Flag_selected_methods,
			Flag_close_calib,
			Flag_sign_calib,
			User_sign_calib,
			Date_sign_calib,
			Type_solution,
			Idreactive_medium,
			Idreactive_modif,
			Type_pattern,
			Idmr_detail,
			Cod_solution,
			Date_ini,
			Date_end
		}
		#endregion

		#region Data Members

			int _idgroup_solution;
			int? _idelement;
			int? _idtemplate_method;
			bool? _flag_selected_methods;
			bool? _flag_close_calib;
			bool? _flag_sign_calib;
			short? _user_sign_calib;
			DateTime? _date_sign_calib;
			int? _type_solution;
			int? _idreactive_medium;
			int? _idreactive_modif;
			int? _type_pattern;
			short? _idmr_detail;
			string _cod_solution;
			DateTime? _date_ini;
			DateTime? _date_end;

		#endregion

		#region Properties

		public int  Idgroup_solution
		{
			 get { return _idgroup_solution; }
			 set
			 {
				 if (_idgroup_solution != value)
				 {
					_idgroup_solution = value;
					 PropertyHasChanged("Idgroup_solution");
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

		public int?  Idtemplate_method
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

		public bool?  Flag_selected_methods
		{
			 get { return _flag_selected_methods; }
			 set
			 {
				 if (_flag_selected_methods != value)
				 {
					_flag_selected_methods = value;
					 PropertyHasChanged("Flag_selected_methods");
				 }
			 }
		}

		public bool?  Flag_close_calib
		{
			 get { return _flag_close_calib; }
			 set
			 {
				 if (_flag_close_calib != value)
				 {
					_flag_close_calib = value;
					 PropertyHasChanged("Flag_close_calib");
				 }
			 }
		}

		public bool?  Flag_sign_calib
		{
			 get { return _flag_sign_calib; }
			 set
			 {
				 if (_flag_sign_calib != value)
				 {
					_flag_sign_calib = value;
					 PropertyHasChanged("Flag_sign_calib");
				 }
			 }
		}

		public short?  User_sign_calib
		{
			 get { return _user_sign_calib; }
			 set
			 {
				 if (_user_sign_calib != value)
				 {
					_user_sign_calib = value;
					 PropertyHasChanged("User_sign_calib");
				 }
			 }
		}

		public DateTime?  Date_sign_calib
		{
			 get { return _date_sign_calib; }
			 set
			 {
				 if (_date_sign_calib != value)
				 {
					_date_sign_calib = value;
					 PropertyHasChanged("Date_sign_calib");
				 }
			 }
		}

		public int?  Type_solution
		{
			 get { return _type_solution; }
			 set
			 {
				 if (_type_solution != value)
				 {
					_type_solution = value;
					 PropertyHasChanged("Type_solution");
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

		public int?  Type_pattern
		{
			 get { return _type_pattern; }
			 set
			 {
				 if (_type_pattern != value)
				 {
					_type_pattern = value;
					 PropertyHasChanged("Type_pattern");
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

		public string  Cod_solution
		{
			 get { return _cod_solution; }
			 set
			 {
				 if (_cod_solution != value)
				 {
					_cod_solution = value;
					 PropertyHasChanged("Cod_solution");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idgroup_solution", "Idgroup_solution"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_solution", "Cod_solution",20));
		}

		#endregion

	}
}
