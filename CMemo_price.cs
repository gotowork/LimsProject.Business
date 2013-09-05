using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMemo_price: BusinessObjectBase
	{

		#region InnerClass
		public enum CMemo_priceFields
		{
			Idmemo_price,
			Idprice_version,
			Paragraph,
			Memo_type
		}
		#endregion

		#region Data Members

			int _idmemo_price;
			int? _idprice_version;
			string _paragraph;
			int? _memo_type;

		#endregion

		#region Properties

		public int  Idmemo_price
		{
			 get { return _idmemo_price; }
			 set
			 {
				 if (_idmemo_price != value)
				 {
					_idmemo_price = value;
					 PropertyHasChanged("Idmemo_price");
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

		public string  Paragraph
		{
			 get { return _paragraph; }
			 set
			 {
				 if (_paragraph != value)
				 {
					_paragraph = value;
					 PropertyHasChanged("Paragraph");
				 }
			 }
		}

		public int?  Memo_type
		{
			 get { return _memo_type; }
			 set
			 {
				 if (_memo_type != value)
				 {
					_memo_type = value;
					 PropertyHasChanged("Memo_type");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idmemo_price", "Idmemo_price"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Paragraph", "Paragraph",3000));
		}

		#endregion

	}
}
