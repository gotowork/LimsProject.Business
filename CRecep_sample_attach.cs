using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_sample_attach: BusinessObjectBase
	{

		#region InnerClass
		public enum CRecep_sample_attachFields
		{
			Idrecep_sample_attach,
			Iddocument_recep,
			Idrecep_sample,
			Order_file,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			long _idrecep_sample_attach;
			int? _iddocument_recep;
			long? _idrecep_sample;
			short? _order_file;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public long  Idrecep_sample_attach
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

		public int?  Iddocument_recep
		{
			 get { return _iddocument_recep; }
			 set
			 {
				 if (_iddocument_recep != value)
				 {
					_iddocument_recep = value;
					 PropertyHasChanged("Iddocument_recep");
				 }
			 }
		}

		public long?  Idrecep_sample
		{
			 get { return _idrecep_sample; }
			 set
			 {
				 if (_idrecep_sample != value)
				 {
					_idrecep_sample = value;
					 PropertyHasChanged("Idrecep_sample");
				 }
			 }
		}

		public short?  Order_file
		{
			 get { return _order_file; }
			 set
			 {
				 if (_order_file != value)
				 {
					_order_file = value;
					 PropertyHasChanged("Order_file");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idrecep_sample_attach", "Idrecep_sample_attach"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
