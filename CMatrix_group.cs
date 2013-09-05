using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMatrix_group: BusinessObjectBase
	{

		#region InnerClass
		public enum CMatrix_groupFields
		{
			Idmatrix_group,
			Sigla,
			Name_group,
			Status
		}
		#endregion

		#region Data Members

			int _idmatrix_group;
			string _sigla;
			string _name_group;
			bool? _status;

		#endregion

		#region Properties

		public int  Idmatrix_group
		{
			 get { return _idmatrix_group; }
			 set
			 {
				 if (_idmatrix_group != value)
				 {
					_idmatrix_group = value;
					 PropertyHasChanged("Idmatrix_group");
				 }
			 }
		}

		public string  Sigla
		{
			 get { return _sigla; }
			 set
			 {
				 if (_sigla != value)
				 {
					_sigla = value;
					 PropertyHasChanged("Sigla");
				 }
			 }
		}

		public string  Name_group
		{
			 get { return _name_group; }
			 set
			 {
				 if (_name_group != value)
				 {
					_name_group = value;
					 PropertyHasChanged("Name_group");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idmatrix_group", "Idmatrix_group"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Sigla", "Sigla",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_group", "Name_group",100));
		}

		#endregion

	}
}
