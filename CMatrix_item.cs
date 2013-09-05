using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMatrix_item: BusinessObjectBase
	{

		#region InnerClass
		public enum CMatrix_itemFields
		{
			Idmatrix_item,
			Idmatrix_group,
			Sigla,
			Name_item,
			Description,
			Flag_acreditado,
			Status
		}
		#endregion

		#region Data Members

			int _idmatrix_item;
			int? _idmatrix_group;
			string _sigla;
			string _name_item;
			string _description;
			bool? _flag_acreditado;
			bool? _status;

		#endregion

		#region Properties

		public int  Idmatrix_item
		{
			 get { return _idmatrix_item; }
			 set
			 {
				 if (_idmatrix_item != value)
				 {
					_idmatrix_item = value;
					 PropertyHasChanged("Idmatrix_item");
				 }
			 }
		}

		public int?  Idmatrix_group
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

		public string  Name_item
		{
			 get { return _name_item; }
			 set
			 {
				 if (_name_item != value)
				 {
					_name_item = value;
					 PropertyHasChanged("Name_item");
				 }
			 }
		}

		public string  Description
		{
			 get { return _description; }
			 set
			 {
				 if (_description != value)
				 {
					_description = value;
					 PropertyHasChanged("Description");
				 }
			 }
		}

		public bool?  Flag_acreditado
		{
			 get { return _flag_acreditado; }
			 set
			 {
				 if (_flag_acreditado != value)
				 {
					_flag_acreditado = value;
					 PropertyHasChanged("Flag_acreditado");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idmatrix_item", "Idmatrix_item"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Sigla", "Sigla",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_item", "Name_item",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",500));
		}

		#endregion

	}
}
