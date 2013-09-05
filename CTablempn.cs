using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTablempn: BusinessObjectBase
	{

		#region InnerClass
		public enum CTablempnFields
		{
			Idtablempn,
			Combination_pos,
			Mpn_index,
			Limit_lower,
			Limit_high
		}
		#endregion

		#region Data Members

			short _idtablempn;
			string _combination_pos;
			string _mpn_index;
			decimal? _limit_lower;
			decimal? _limit_high;

		#endregion

		#region Properties

		public short  Idtablempn
		{
			 get { return _idtablempn; }
			 set
			 {
				 if (_idtablempn != value)
				 {
					_idtablempn = value;
					 PropertyHasChanged("Idtablempn");
				 }
			 }
		}

		public string  Combination_pos
		{
			 get { return _combination_pos; }
			 set
			 {
				 if (_combination_pos != value)
				 {
					_combination_pos = value;
					 PropertyHasChanged("Combination_pos");
				 }
			 }
		}

		public string  Mpn_index
		{
			 get { return _mpn_index; }
			 set
			 {
				 if (_mpn_index != value)
				 {
					_mpn_index = value;
					 PropertyHasChanged("Mpn_index");
				 }
			 }
		}

		public decimal?  Limit_lower
		{
			 get { return _limit_lower; }
			 set
			 {
				 if (_limit_lower != value)
				 {
					_limit_lower = value;
					 PropertyHasChanged("Limit_lower");
				 }
			 }
		}

		public decimal?  Limit_high
		{
			 get { return _limit_high; }
			 set
			 {
				 if (_limit_high != value)
				 {
					_limit_high = value;
					 PropertyHasChanged("Limit_high");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idtablempn", "Idtablempn"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Combination_pos", "Combination_pos",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Mpn_index", "Mpn_index",5));
		}

		#endregion

	}
}
