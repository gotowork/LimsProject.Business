using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CConfiguration_folder: BusinessObjectBase
	{

		#region InnerClass
		public enum CConfiguration_folderFields
		{
			Idconfiguration_folder,
			Folder_name,
			Description,
			Path,
			Folder_type,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			short _idconfiguration_folder;
			string _folder_name;
			string _description;
			string _path;
			char _folder_type;
			string _usernew;
			DateTime _datenew;
			string _useredit;
			DateTime _dateedit;
			bool _status;

		#endregion

		#region Properties

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

		public string  Folder_name
		{
			 get { return _folder_name; }
			 set
			 {
				 if (_folder_name != value)
				 {
					_folder_name = value;
					 PropertyHasChanged("Folder_name");
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

		public string  Path
		{
			 get { return _path; }
			 set
			 {
				 if (_path != value)
				 {
					_path = value;
					 PropertyHasChanged("Path");
				 }
			 }
		}

		public char  Folder_type
		{
			 get { return _folder_type; }
			 set
			 {
				 if (_folder_type != value)
				 {
					_folder_type = value;
					 PropertyHasChanged("Folder_type");
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

		public DateTime  Datenew
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

		public DateTime  Dateedit
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

		public bool  Status
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idconfiguration_folder", "Idconfiguration_folder"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Folder_name", "Folder_name"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Folder_name", "Folder_name",100));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Description", "Description"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",500));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Path", "Path"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Path", "Path",500));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Folder_type", "Folder_type"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Usernew", "Usernew"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Datenew", "Datenew"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Useredit", "Useredit"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Dateedit", "Dateedit"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Status", "Status"));
		}

		#endregion

	}
}
