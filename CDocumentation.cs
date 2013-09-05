using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDocumentation: BusinessObjectBase
	{

		#region InnerClass
		public enum CDocumentationFields
		{
			Iddocumentation,
			Idconfiguration_folder,
			Idtemplate_method,
			Procedure_type,
			Code,
			Name_doc,
			Type_doc,
			Id,
			Parentid,
			Flag_enabled,
			Image_index,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			short _iddocumentation;
			short _idconfiguration_folder;
			int? _idtemplate_method;
			char? _procedure_type;
			int? _code;
			string _name_doc;
			char? _type_doc;
			int? _id;
			int? _parentid;
			bool? _flag_enabled;
			int? _image_index;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public short  Iddocumentation
		{
			 get { return _iddocumentation; }
			 set
			 {
				 if (_iddocumentation != value)
				 {
					_iddocumentation = value;
					 PropertyHasChanged("Iddocumentation");
				 }
			 }
		}

		public short  Idconfiguration_folder
		{
			 get { return _idconfiguration_folder; }
			 set
			 {
				 if (_idconfiguration_folder != value)
				 {
					_idconfiguration_folder = value;
					 PropertyHasChanged("Idconfiguration_folder");
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

		public char?  Procedure_type
		{
			 get { return _procedure_type; }
			 set
			 {
				 if (_procedure_type != value)
				 {
					_procedure_type = value;
					 PropertyHasChanged("Procedure_type");
				 }
			 }
		}

		public int?  Code
		{
			 get { return _code; }
			 set
			 {
				 if (_code != value)
				 {
					_code = value;
					 PropertyHasChanged("Code");
				 }
			 }
		}

		public string  Name_doc
		{
			 get { return _name_doc; }
			 set
			 {
				 if (_name_doc != value)
				 {
					_name_doc = value;
					 PropertyHasChanged("Name_doc");
				 }
			 }
		}

		public char?  Type_doc
		{
			 get { return _type_doc; }
			 set
			 {
				 if (_type_doc != value)
				 {
					_type_doc = value;
					 PropertyHasChanged("Type_doc");
				 }
			 }
		}

		public int?  Id
		{
			 get { return _id; }
			 set
			 {
				 if (_id != value)
				 {
					_id = value;
					 PropertyHasChanged("Id");
				 }
			 }
		}

		public int?  Parentid
		{
			 get { return _parentid; }
			 set
			 {
				 if (_parentid != value)
				 {
					_parentid = value;
					 PropertyHasChanged("Parentid");
				 }
			 }
		}

		public bool?  Flag_enabled
		{
			 get { return _flag_enabled; }
			 set
			 {
				 if (_flag_enabled != value)
				 {
					_flag_enabled = value;
					 PropertyHasChanged("Flag_enabled");
				 }
			 }
		}

		public int?  Image_index
		{
			 get { return _image_index; }
			 set
			 {
				 if (_image_index != value)
				 {
					_image_index = value;
					 PropertyHasChanged("Image_index");
				 }
			 }
		}

		public string  Usernew
		{
			 get { return _usernew; }
			 set
			 {
				 if (_usernew != value)
				 {
					_usernew = value;
					 PropertyHasChanged("Usernew");
				 }
			 }
		}

		public DateTime?  Datenew
		{
			 get { return _datenew; }
			 set
			 {
				 if (_datenew != value)
				 {
					_datenew = value;
					 PropertyHasChanged("Datenew");
				 }
			 }
		}

		public string  Useredit
		{
			 get { return _useredit; }
			 set
			 {
				 if (_useredit != value)
				 {
					_useredit = value;
					 PropertyHasChanged("Useredit");
				 }
			 }
		}

		public DateTime?  Dateedit
		{
			 get { return _dateedit; }
			 set
			 {
				 if (_dateedit != value)
				 {
					_dateedit = value;
					 PropertyHasChanged("Dateedit");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Iddocumentation", "Iddocumentation"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idconfiguration_folder", "Idconfiguration_folder"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_doc", "Name_doc",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
