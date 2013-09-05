using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CPrice_version_detail: BusinessObjectBase
	{

		#region InnerClass
		public enum CPrice_version_detailFields
		{
			Idprice_version_detail,
			Idprice_version,
			Num_item,
			Idtemplate_method,
			Amount_item,
			Rank,
			Unit_price,
			Sale_price
		}
		#endregion

		#region Data Members

			int _idprice_version_detail;
			int? _idprice_version;
			int? _num_item;
			int? _idtemplate_method;
			int? _amount_item;
			string _rank;
			decimal? _unit_price;
			decimal? _sale_price;

		#endregion

		#region Properties

		public int  Idprice_version_detail
		{
			 get { return _idprice_version_detail; }
			 set
			 {
				 if (_idprice_version_detail != value)
				 {
					_idprice_version_detail = value;
					 PropertyHasChanged("Idprice_version_detail");
				 }
			 }
		}

		public int?  Idprice_version
		{
			 get { return _idprice_version; }
			 set
			 {
				 if (_idprice_version != value)
				 {
					_idprice_version = value;
					 PropertyHasChanged("Idprice_version");
				 }
			 }
		}

		public int?  Num_item
		{
			 get { return _num_item; }
			 set
			 {
				 if (_num_item != value)
				 {
					_num_item = value;
					 PropertyHasChanged("Num_item");
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

		public int?  Amount_item
		{
			 get { return _amount_item; }
			 set
			 {
				 if (_amount_item != value)
				 {
					_amount_item = value;
					 PropertyHasChanged("Amount_item");
				 }
			 }
		}

		public string  Rank
		{
			 get { return _rank; }
			 set
			 {
				 if (_rank != value)
				 {
					_rank = value;
					 PropertyHasChanged("Rank");
				 }
			 }
		}

		public decimal?  Unit_price
		{
			 get { return _unit_price; }
			 set
			 {
				 if (_unit_price != value)
				 {
					_unit_price = value;
					 PropertyHasChanged("Unit_price");
				 }
			 }
		}

		public decimal?  Sale_price
		{
			 get { return _sale_price; }
			 set
			 {
				 if (_sale_price != value)
				 {
					_sale_price = value;
					 PropertyHasChanged("Sale_price");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idprice_version_detail", "Idprice_version_detail"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Rank", "Rank",20));
		}

		#endregion

	}
}
