using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCells_attach_file: BusinessObjectBase
	{

		#region InnerClass
		public enum CCells_attach_fileFields
		{
			Idcells_attach_file,
			Idrecep_sample_attach,
			Idrecep_sample_detail_elem,
			Idtemplate_method,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			long _idcells_attach_file;
			long? _idrecep_sample_attach;
			long? _idrecep_sample_detail_elem;
			int? _idtemplate_method;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public long  Idcells_attach_file
		{
			 get { return _idcells_attach_file; }
			 set
			 {
				 if (_idcells_attach_file != value)
				 {
					_idcells_attach_file = value;
					 PropertyHasChanged("Idcells_attach_file");
				 }
			 }
		}

		public long?  Idrecep_sample_attach
		{
			 get { return _idrecep_sample_attach; }
			 set
			 {
				 if (_idrecep_sample_attach != value)
				 {
					_idrecep_sample_attach = value;
					 PropertyHasChanged("Idrecep_sample_attach");
				 }
			 }
		}

		public long?  Idrecep_sample_detail_elem
		{
			 get { return _idrecep_sample_detail_elem; }
			 set
			 {
				 if (_idrecep_sample_detail_elem != value)
				 {
					_idrecep_sample_detail_elem = value;
					 PropertyHasChanged("Idrecep_sample_detail_elem");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idcells_attach_file", "Idcells_attach_file"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
