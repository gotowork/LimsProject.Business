using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CSolution_interm: BusinessObjectBase
	{

		#region InnerClass
		public enum CSolution_intermFields
		{
			Idsolution_interm,
			Id,
			Parentid,
			Idelement,
			Cod_solution,
			Type_sol,
			Solution_name,
			Purity,
			Concentration,
			Aliquot,
			Volumen,
			Date_begin,
			Date_end,
			Num_months,
			Prepared_by,
			Observation,
			Lote,
			Solution_status,
			Root_type_pattern,
			Root_idmr_detail,
			Idreactive_medium,
			Reactive_medium_value,
			Idreactive_modif,
			Reactive_modif_value,
			Concat_cod_methods,
			Image_index,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _idsolution_interm;
			int? _id;
			int? _parentid;
			int? _idelement;
			string _cod_solution;
			int? _type_sol;
			string _solution_name;
			decimal? _purity;
			decimal? _concentration;
			decimal? _aliquot;
			decimal? _volumen;
			DateTime? _date_begin;
			DateTime? _date_end;
			int? _num_months;
			short? _prepared_by;
			string _observation;
			string _lote;
			bool? _solution_status;
			int? _root_type_pattern;
			short? _root_idmr_detail;
			int? _idreactive_medium;
			decimal? _reactive_medium_value;
			int? _idreactive_modif;
			decimal? _reactive_modif_value;
			string _concat_cod_methods;
			int? _image_index;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public int  Idsolution_interm
		{
			 get { return _idsolution_interm; }
			 set
			 {
				 if (_idsolution_interm != value)
				 {
					_idsolution_interm = value;
					 PropertyHasChanged("Idsolution_interm");
				 }
			 }
		}

		public int?  Id
		{
			 get { return _id; }
			 set
			 {
				 if (_id != value)
				 {
					_id = value;
					 PropertyHasChanged("Id");
				 }
			 }
		}

		public int?  Parentid
		{
			 get { return _parentid; }
			 set
			 {
				 if (_parentid != value)
				 {
					_parentid = value;
					 PropertyHasChanged("Parentid");
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

		public int?  Type_sol
		{
			 get { return _type_sol; }
			 set
			 {
				 if (_type_sol != value)
				 {
					_type_sol = value;
					 PropertyHasChanged("Type_sol");
				 }
			 }
		}

		public string  Solution_name
		{
			 get { return _solution_name; }
			 set
			 {
				 if (_solution_name != value)
				 {
					_solution_name = value;
					 PropertyHasChanged("Solution_name");
				 }
			 }
		}

		public decimal?  Purity
		{
			 get { return _purity; }
			 set
			 {
				 if (_purity != value)
				 {
					_purity = value;
					 PropertyHasChanged("Purity");
				 }
			 }
		}

		public decimal?  Concentration
		{
			 get { return _concentration; }
			 set
			 {
				 if (_concentration != value)
				 {
					_concentration = value;
					 PropertyHasChanged("Concentration");
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

		public DateTime?  Date_begin
		{
			 get { return _date_begin; }
			 set
			 {
				 if (_date_begin != value)
				 {
					_date_begin = value;
					 PropertyHasChanged("Date_begin");
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

		public int?  Num_months
		{
			 get { return _num_months; }
			 set
			 {
				 if (_num_months != value)
				 {
					_num_months = value;
					 PropertyHasChanged("Num_months");
				 }
			 }
		}

		public short?  Prepared_by
		{
			 get { return _prepared_by; }
			 set
			 {
				 if (_prepared_by != value)
				 {
					_prepared_by = value;
					 PropertyHasChanged("Prepared_by");
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

		public string  Lote
		{
			 get { return _lote; }
			 set
			 {
				 if (_lote != value)
				 {
					_lote = value;
					 PropertyHasChanged("Lote");
				 }
			 }
		}

		public bool?  Solution_status
		{
			 get { return _solution_status; }
			 set
			 {
				 if (_solution_status != value)
				 {
					_solution_status = value;
					 PropertyHasChanged("Solution_status");
				 }
			 }
		}

		public int?  Root_type_pattern
		{
			 get { return _root_type_pattern; }
			 set
			 {
				 if (_root_type_pattern != value)
				 {
					_root_type_pattern = value;
					 PropertyHasChanged("Root_type_pattern");
				 }
			 }
		}

		public short?  Root_idmr_detail
		{
			 get { return _root_idmr_detail; }
			 set
			 {
				 if (_root_idmr_detail != value)
				 {
					_root_idmr_detail = value;
					 PropertyHasChanged("Root_idmr_detail");
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

		public decimal?  Reactive_medium_value
		{
			 get { return _reactive_medium_value; }
			 set
			 {
				 if (_reactive_medium_value != value)
				 {
					_reactive_medium_value = value;
					 PropertyHasChanged("Reactive_medium_value");
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

		public decimal?  Reactive_modif_value
		{
			 get { return _reactive_modif_value; }
			 set
			 {
				 if (_reactive_modif_value != value)
				 {
					_reactive_modif_value = value;
					 PropertyHasChanged("Reactive_modif_value");
				 }
			 }
		}

		public string  Concat_cod_methods
		{
			 get { return _concat_cod_methods; }
			 set
			 {
				 if (_concat_cod_methods != value)
				 {
					_concat_cod_methods = value;
					 PropertyHasChanged("Concat_cod_methods");
				 }
			 }
		}

		public int?  Image_index
		{
			 get { return _image_index; }
			 set
			 {
				 if (_image_index != value)
				 {
					_image_index = value;
					 PropertyHasChanged("Image_index");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idsolution_interm", "Idsolution_interm"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_solution", "Cod_solution",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Solution_name", "Solution_name",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Observation", "Observation",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Lote", "Lote",12));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Concat_cod_methods", "Concat_cod_methods",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
