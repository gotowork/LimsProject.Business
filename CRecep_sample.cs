using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_sample: BusinessObjectBase
	{

		#region InnerClass
		public enum CRecep_sampleFields
		{
			Idrecep_sample,
			Cod_recep_sample,
			Date_reception,
			Type_post,
			Phone_client,
			Idcompany,
			Idcontact1,
			Idcontact2,
			Cod_serie,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status,
			Date_result,
			Cod_type_sample,
			Total_amount,
			Total_igv,
			Total_amount_igv,
			Amortization,
			Flag_isprice,
			Discount
		}
		#endregion

		#region Data Members

			long _idrecep_sample;
			string _cod_recep_sample;
			DateTime? _date_reception;
			char? _type_post;
			string _phone_client;
			short? _idcompany;
			short? _idcontact1;
			short? _idcontact2;
			string _cod_serie;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;
			DateTime? _date_result;
			string _cod_type_sample;
			decimal? _total_amount;
			decimal? _total_igv;
			decimal? _total_amount_igv;
			decimal? _amortization;
			bool? _flag_isprice;
			decimal? _discount;

		#endregion

		#region Properties

		public long  Idrecep_sample
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

		public string  Cod_recep_sample
		{
			 get { return _cod_recep_sample; }
			 set
			 {
				 if (_cod_recep_sample != value)
				 {
					_cod_recep_sample = value;
					 PropertyHasChanged("Cod_recep_sample");
				 }
			 }
		}

		public DateTime?  Date_reception
		{
			 get { return _date_reception; }
			 set
			 {
				 if (_date_reception != value)
				 {
					_date_reception = value;
					 PropertyHasChanged("Date_reception");
				 }
			 }
		}

		public char?  Type_post
		{
			 get { return _type_post; }
			 set
			 {
				 if (_type_post != value)
				 {
					_type_post = value;
					 PropertyHasChanged("Type_post");
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

		public string  Cod_serie
		{
			 get { return _cod_serie; }
			 set
			 {
				 if (_cod_serie != value)
				 {
					_cod_serie = value;
					 PropertyHasChanged("Cod_serie");
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

		public DateTime?  Date_result
		{
			 get { return _date_result; }
			 set
			 {
				 if (_date_result != value)
				 {
					_date_result = value;
					 PropertyHasChanged("Date_result");
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

		public decimal?  Total_amount
		{
			 get { return _total_amount; }
			 set
			 {
				 if (_total_amount != value)
				 {
					_total_amount = value;
					 PropertyHasChanged("Total_amount");
				 }
			 }
		}

		public decimal?  Total_igv
		{
			 get { return _total_igv; }
			 set
			 {
				 if (_total_igv != value)
				 {
					_total_igv = value;
					 PropertyHasChanged("Total_igv");
				 }
			 }
		}

		public decimal?  Total_amount_igv
		{
			 get { return _total_amount_igv; }
			 set
			 {
				 if (_total_amount_igv != value)
				 {
					_total_amount_igv = value;
					 PropertyHasChanged("Total_amount_igv");
				 }
			 }
		}

		public decimal?  Amortization
		{
			 get { return _amortization; }
			 set
			 {
				 if (_amortization != value)
				 {
					_amortization = value;
					 PropertyHasChanged("Amortization");
				 }
			 }
		}

		public bool?  Flag_isprice
		{
			 get { return _flag_isprice; }
			 set
			 {
				 if (_flag_isprice != value)
				 {
					_flag_isprice = value;
					 PropertyHasChanged("Flag_isprice");
				 }
			 }
		}

		public decimal?  Discount
		{
			 get { return _discount; }
			 set
			 {
				 if (_discount != value)
				 {
					_discount = value;
					 PropertyHasChanged("Discount");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idrecep_sample", "Idrecep_sample"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_recep_sample", "Cod_recep_sample",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Phone_client", "Phone_client",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_serie", "Cod_serie",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_type_sample", "Cod_type_sample",5));
		}

		#endregion

	}
}
