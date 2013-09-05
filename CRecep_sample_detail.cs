using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_sample_detail: BusinessObjectBase
	{

		#region InnerClass
		public enum CRecep_sample_detailFields
		{
			Idrecep_sample_detail,
			Order_sample,
			Cod_sample,
			Procedence,
			Name_sample,
			Amount_weight,
			Cod_interno,
			Flag_reject,
			Cost_sample,
			Analisys_time,
			Flag_control_sample,
			Cod_type_sample,
			Cod_des_sample,
			Idrecep_sample,
			Flag_counter_sample,
			Flag_envelope_sealed
		}
		#endregion

		#region Data Members

			long _idrecep_sample_detail;
			short? _order_sample;
			string _cod_sample;
			string _procedence;
			string _name_sample;
			decimal? _amount_weight;
			long? _cod_interno;
			bool? _flag_reject;
			decimal? _cost_sample;
			decimal? _analisys_time;
			bool? _flag_control_sample;
			string _cod_type_sample;
			string _cod_des_sample;
			long? _idrecep_sample;
			short? _flag_counter_sample;
			bool? _flag_envelope_sealed;

		#endregion

		#region Properties

		public long  Idrecep_sample_detail
		{
			 get { return _idrecep_sample_detail; }
			 set
			 {
				 if (_idrecep_sample_detail != value)
				 {
					_idrecep_sample_detail = value;
					 PropertyHasChanged("Idrecep_sample_detail");
				 }
			 }
		}

		public short?  Order_sample
		{
			 get { return _order_sample; }
			 set
			 {
				 if (_order_sample != value)
				 {
					_order_sample = value;
					 PropertyHasChanged("Order_sample");
				 }
			 }
		}

		public string  Cod_sample
		{
			 get { return _cod_sample; }
			 set
			 {
				 if (_cod_sample != value)
				 {
					_cod_sample = value;
					 PropertyHasChanged("Cod_sample");
				 }
			 }
		}

		public string  Procedence
		{
			 get { return _procedence; }
			 set
			 {
				 if (_procedence != value)
				 {
					_procedence = value;
					 PropertyHasChanged("Procedence");
				 }
			 }
		}

		public string  Name_sample
		{
			 get { return _name_sample; }
			 set
			 {
				 if (_name_sample != value)
				 {
					_name_sample = value;
					 PropertyHasChanged("Name_sample");
				 }
			 }
		}

		public decimal?  Amount_weight
		{
			 get { return _amount_weight; }
			 set
			 {
				 if (_amount_weight != value)
				 {
					_amount_weight = value;
					 PropertyHasChanged("Amount_weight");
				 }
			 }
		}

		public long?  Cod_interno
		{
			 get { return _cod_interno; }
			 set
			 {
				 if (_cod_interno != value)
				 {
					_cod_interno = value;
					 PropertyHasChanged("Cod_interno");
				 }
			 }
		}

		public bool?  Flag_reject
		{
			 get { return _flag_reject; }
			 set
			 {
				 if (_flag_reject != value)
				 {
					_flag_reject = value;
					 PropertyHasChanged("Flag_reject");
				 }
			 }
		}

		public decimal?  Cost_sample
		{
			 get { return _cost_sample; }
			 set
			 {
				 if (_cost_sample != value)
				 {
					_cost_sample = value;
					 PropertyHasChanged("Cost_sample");
				 }
			 }
		}

		public decimal?  Analisys_time
		{
			 get { return _analisys_time; }
			 set
			 {
				 if (_analisys_time != value)
				 {
					_analisys_time = value;
					 PropertyHasChanged("Analisys_time");
				 }
			 }
		}

		public bool?  Flag_control_sample
		{
			 get { return _flag_control_sample; }
			 set
			 {
				 if (_flag_control_sample != value)
				 {
					_flag_control_sample = value;
					 PropertyHasChanged("Flag_control_sample");
				 }
			 }
		}

		public string  Cod_type_sample
		{
			 get { return _cod_type_sample; }
			 set
			 {
				 if (_cod_type_sample != value)
				 {
					_cod_type_sample = value;
					 PropertyHasChanged("Cod_type_sample");
				 }
			 }
		}

		public string  Cod_des_sample
		{
			 get { return _cod_des_sample; }
			 set
			 {
				 if (_cod_des_sample != value)
				 {
					_cod_des_sample = value;
					 PropertyHasChanged("Cod_des_sample");
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

		public short?  Flag_counter_sample
		{
			 get { return _flag_counter_sample; }
			 set
			 {
				 if (_flag_counter_sample != value)
				 {
					_flag_counter_sample = value;
					 PropertyHasChanged("Flag_counter_sample");
				 }
			 }
		}

		public bool?  Flag_envelope_sealed
		{
			 get { return _flag_envelope_sealed; }
			 set
			 {
				 if (_flag_envelope_sealed != value)
				 {
					_flag_envelope_sealed = value;
					 PropertyHasChanged("Flag_envelope_sealed");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idrecep_sample_detail", "Idrecep_sample_detail"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_sample", "Cod_sample",12));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Procedence", "Procedence",300));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_sample", "Name_sample",300));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_type_sample", "Cod_type_sample",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_des_sample", "Cod_des_sample",5));
		}

		#endregion

	}
}
