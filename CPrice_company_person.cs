using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CPrice_company_person: BusinessObjectBase
	{

		#region InnerClass
		public enum CPrice_company_personFields
		{
			Idprice_company_person,
			Idcompany,
			Idperson,
			Idprice,
			Idprice_version,
			Person_type
		}
		#endregion

		#region Data Members

			int _idprice_company_person;
			short? _idcompany;
			short? _idperson;
			int? _idprice;
			int? _idprice_version;
			short? _person_type;

		#endregion

		#region Properties

		public int  Idprice_company_person
		{
			 get { return _idprice_company_person; }
			 set
			 {
				 if (_idprice_company_person != value)
				 {
					_idprice_company_person = value;
					 PropertyHasChanged("Idprice_company_person");
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

		public int?  Idprice
		{
			 get { return _idprice; }
			 set
			 {
				 if (_idprice != value)
				 {
					_idprice = value;
					 PropertyHasChanged("Idprice");
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

		public short?  Person_type
		{
			 get { return _person_type; }
			 set
			 {
				 if (_person_type != value)
				 {
					_person_type = value;
					 PropertyHasChanged("Person_type");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idprice_company_person", "Idprice_company_person"));
		}

		#endregion

	}
}
