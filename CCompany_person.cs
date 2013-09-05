using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCompany_person: BusinessObjectBase
	{

		#region InnerClass
		public enum CCompany_personFields
		{
			Idcompany_person,
			Idcompany,
			Idperson
		}
		#endregion

		#region Data Members

			int _idcompany_person;
			short? _idcompany;
			short? _idperson;

		#endregion

		#region Properties

		public int  Idcompany_person
		{
			 get { return _idcompany_person; }
			 set
			 {
				 if (_idcompany_person != value)
				 {
					_idcompany_person = value;
					 PropertyHasChanged("Idcompany_person");
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

		public short?  Idperson
		{
			 get { return _idperson; }
			 set
			 {
				 if (_idperson != value)
				 {
					_idperson = value;
					 PropertyHasChanged("Idperson");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idcompany_person", "Idcompany_person"));
		}

		#endregion

	}
}
