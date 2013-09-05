using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRetest: BusinessObjectBase
	{

		#region InnerClass
		public enum CRetestFields
		{
			Idretest,
			Idrecep_sample_detail_elem,
			Idrecep_sample_detail,
			Origin_batch,
			Destiny_batch,
			Type_retest,
			Date_retest,
			Usernew,
			Datenew,
			Useredit1,
			Dateedit1,
			Status,
			Status_retest
		}
		#endregion

		#region Data Members

			long _idretest;
			long? _idrecep_sample_detail_elem;
			long? _idrecep_sample_detail;
			long? _origin_batch;
			long? _destiny_batch;
			char? _type_retest;
			DateTime? _date_retest;
			string _usernew;
			DateTime? _datenew;
			string _useredit1;
			DateTime? _dateedit1;
			bool? _status;
			short? _status_retest;

		#endregion

		#region Properties

		public long  Idretest
		{
			 get { return _idretest; }
			 set
			 {
				 if (_idretest != value)
				 {
					_idretest = value;
					 PropertyHasChanged("Idretest");
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

		public long?  Idrecep_sample_detail
		{
			 get { return _idrecep_sample_detail; }
			 set
			 {
				 if (_idrecep_sample_detail != value)
				 {
					_idrecep_sample_detail = value;
					 PropertyHasChanged("Idrecep_sample_detail");
				 }
			 }
		}

		public long?  Origin_batch
		{
			 get { return _origin_batch; }
			 set
			 {
				 if (_origin_batch != value)
				 {
					_origin_batch = value;
					 PropertyHasChanged("Origin_batch");
				 }
			 }
		}

		public long?  Destiny_batch
		{
			 get { return _destiny_batch; }
			 set
			 {
				 if (_destiny_batch != value)
				 {
					_destiny_batch = value;
					 PropertyHasChanged("Destiny_batch");
				 }
			 }
		}

		public char?  Type_retest
		{
			 get { return _type_retest; }
			 set
			 {
				 if (_type_retest != value)
				 {
					_type_retest = value;
					 PropertyHasChanged("Type_retest");
				 }
			 }
		}

		public DateTime?  Date_retest
		{
			 get { return _date_retest; }
			 set
			 {
				 if (_date_retest != value)
				 {
					_date_retest = value;
					 PropertyHasChanged("Date_retest");
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

		public string  Useredit1
		{
			 get { return _useredit1; }
			 set
			 {
				 if (_useredit1 != value)
				 {
					_useredit1 = value;
					 PropertyHasChanged("Useredit1");
				 }
			 }
		}

		public DateTime?  Dateedit1
		{
			 get { return _dateedit1; }
			 set
			 {
				 if (_dateedit1 != value)
				 {
					_dateedit1 = value;
					 PropertyHasChanged("Dateedit1");
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

		public short?  Status_retest
		{
			 get { return _status_retest; }
			 set
			 {
				 if (_status_retest != value)
				 {
					_status_retest = value;
					 PropertyHasChanged("Status_retest");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idretest", "Idretest"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit1", "Useredit1",20));
		}

		#endregion

	}
}
