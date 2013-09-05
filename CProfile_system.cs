using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CProfile_system: BusinessObjectBase
	{

		#region InnerClass
		public enum CProfile_systemFields
		{
			Idprofile,
			Profile_name
		}
		#endregion

		#region Data Members

			short _idprofile;
			string _profile_name;

		#endregion

		#region Properties

		public short  Idprofile
		{
			 get { return _idprofile; }
			 set
			 {
				 if (_idprofile != value)
				 {
					_idprofile = value;
					 PropertyHasChanged("Idprofile");
				 }
			 }
		}

		public string  Profile_name
		{
			 get { return _profile_name; }
			 set
			 {
				 if (_profile_name != value)
				 {
					_profile_name = value;
					 PropertyHasChanged("Profile_name");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idprofile", "Idprofile"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Profile_name", "Profile_name",30));
		}

		#endregion

	}
}
