using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CBatchicp: BusinessObjectBase
	{

		#region InnerClass
		public enum CBatchicpFields
		{
			Idbatchicp,
			Datecreation
		}
		#endregion

		#region Data Members

			int _idbatchicp;
			DateTime? _datecreation;

		#endregion

		#region Properties

		public int  Idbatchicp
		{
			 get { return _idbatchicp; }
			 set
			 {
				 if (_idbatchicp != value)
				 {
					_idbatchicp = value;
					 PropertyHasChanged("Idbatchicp");
				 }
			 }
		}

		public DateTime?  Datecreation
		{
			 get { return _datecreation; }
			 set
			 {
				 if (_datecreation != value)
				 {
					_datecreation = value;
					 PropertyHasChanged("Datecreation");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idbatchicp", "Idbatchicp"));
		}

		#endregion

	}
}
