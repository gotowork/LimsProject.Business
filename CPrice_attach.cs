using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CPrice_attach: BusinessObjectBase
	{

		#region InnerClass
		public enum CPrice_attachFields
		{
			Idattach,
			Idprice,
			Idprice_version,
			Name_document,
			Type_document
		}
		#endregion

		#region Data Members

			int _idattach;
			int? _idprice;
			int? _idprice_version;
			string _name_document;
			string _type_document;

		#endregion

		#region Properties

		public int  Idattach
		{
			 get { return _idattach; }
			 set
			 {
				 if (_idattach != value)
				 {
					_idattach = value;
					 PropertyHasChanged("Idattach");
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

		public string  Name_document
		{
			 get { return _name_document; }
			 set
			 {
				 if (_name_document != value)
				 {
					_name_document = value;
					 PropertyHasChanged("Name_document");
				 }
			 }
		}

		public string  Type_document
		{
			 get { return _type_document; }
			 set
			 {
				 if (_type_document != value)
				 {
					_type_document = value;
					 PropertyHasChanged("Type_document");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idattach", "Idattach"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_document", "Name_document",500));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Type_document", "Type_document",10));
		}

		#endregion

	}
}
