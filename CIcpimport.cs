using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CIcpimport: BusinessObjectBase
	{

		#region InnerClass
		public enum CIcpimportFields
		{
			Idicpimport,
			Idbatchicp,
			Methodid,
			Version,
			Storagedate,
			Calibid,
			Elementname,
			Sampleid,
			Name,
			Averageresult,
			Str_result,
			Dilution2
		}
		#endregion

		#region Data Members

			int _idicpimport;
			int? _idbatchicp;
			int? _methodid;
			int? _version;
			DateTime? _storagedate;
			int? _calibid;
			string _elementname;
			int? _sampleid;
			string _name;
			decimal? _averageresult;
			string _str_result;
			int? _dilution2;

		#endregion

		#region Properties

		public int  Idicpimport
		{
			 get { return _idicpimport; }
			 set
			 {
				 if (_idicpimport != value)
				 {
					_idicpimport = value;
					 PropertyHasChanged("Idicpimport");
				 }
			 }
		}

		public int?  Idbatchicp
		{
			 get { return _idbatchicp; }
			 set
			 {
				 if (_idbatchicp != value)
				 {
					_idbatchicp = value;
					 PropertyHasChanged("Idbatchicp");
				 }
			 }
		}

		public int?  Methodid
		{
			 get { return _methodid; }
			 set
			 {
				 if (_methodid != value)
				 {
					_methodid = value;
					 PropertyHasChanged("Methodid");
				 }
			 }
		}

		public int?  Version
		{
			 get { return _version; }
			 set
			 {
				 if (_version != value)
				 {
					_version = value;
					 PropertyHasChanged("Version");
				 }
			 }
		}

		public DateTime?  Storagedate
		{
			 get { return _storagedate; }
			 set
			 {
				 if (_storagedate != value)
				 {
					_storagedate = value;
					 PropertyHasChanged("Storagedate");
				 }
			 }
		}

		public int?  Calibid
		{
			 get { return _calibid; }
			 set
			 {
				 if (_calibid != value)
				 {
					_calibid = value;
					 PropertyHasChanged("Calibid");
				 }
			 }
		}

		public string  Elementname
		{
			 get { return _elementname; }
			 set
			 {
				 if (_elementname != value)
				 {
					_elementname = value;
					 PropertyHasChanged("Elementname");
				 }
			 }
		}

		public int?  Sampleid
		{
			 get { return _sampleid; }
			 set
			 {
				 if (_sampleid != value)
				 {
					_sampleid = value;
					 PropertyHasChanged("Sampleid");
				 }
			 }
		}

		public string  Name
		{
			 get { return _name; }
			 set
			 {
				 if (_name != value)
				 {
					_name = value;
					 PropertyHasChanged("Name");
				 }
			 }
		}

		public decimal?  Averageresult
		{
			 get { return _averageresult; }
			 set
			 {
				 if (_averageresult != value)
				 {
					_averageresult = value;
					 PropertyHasChanged("Averageresult");
				 }
			 }
		}

		public string  Str_result
		{
			 get { return _str_result; }
			 set
			 {
				 if (_str_result != value)
				 {
					_str_result = value;
					 PropertyHasChanged("Str_result");
				 }
			 }
		}

		public int?  Dilution2
		{
			 get { return _dilution2; }
			 set
			 {
				 if (_dilution2 != value)
				 {
					_dilution2 = value;
					 PropertyHasChanged("Dilution2");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idicpimport", "Idicpimport"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Elementname", "Elementname",6));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name", "Name",30));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Str_result", "Str_result",10));
		}

		#endregion

	}
}
