using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDescription_sample: BusinessObjectBase
	{

		#region InnerClass
		public enum CDescription_sampleFields
		{
			Cod_des_sample,
			Description,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status,
			Priority_order
		}
		#endregion

		#region Data Members

			string _cod_des_sample;
			string _description;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;
			short? _priority_order;

		#endregion

		#region Properties

		public string  Cod_des_sample
		{
			 get { return _cod_des_sample; }
			 set
			 {
				 if (_cod_des_sample != value)
				 {
					_cod_des_sample = value;
					 PropertyHasChanged("Cod_des_sample");
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

		public short?  Priority_order
		{
			 get { return _priority_order; }
			 set
			 {
				 if (_priority_order != value)
				 {
					_priority_order = value;
					 PropertyHasChanged("Priority_order");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Cod_des_sample", "Cod_des_sample"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Cod_des_sample", "Cod_des_sample",5));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
