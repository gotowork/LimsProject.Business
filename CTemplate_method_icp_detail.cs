using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTemplate_method_icp_detail: BusinessObjectBase
	{

		#region InnerClass
		public enum CTemplate_method_icp_detailFields
		{
			Idtemplate_method_icp_detail,
			Idtemplate_method,
			Idelement_wavelength,
			Idelement,
			Idl,
			Mdl_axial,
			Mdl_radial,
			Ldr,
			Ldr_aux,
			Num_decimal,
			Std1,
			Std2,
			Ipc,
			Lfb,
			Qc,
			Priority,
			Lfm,
			Limit_top,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _idtemplate_method_icp_detail;
			int? _idtemplate_method;
			int? _idelement_wavelength;
			short? _idelement;
			decimal? _idl;
			decimal? _mdl_axial;
			decimal? _mdl_radial;
			decimal? _ldr;
			decimal? _ldr_aux;
			decimal? _num_decimal;
			decimal? _std1;
			decimal? _std2;
			decimal? _ipc;
			decimal? _lfb;
			decimal? _qc;
			decimal? _priority;
			decimal? _lfm;
			decimal? _limit_top;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public int  Idtemplate_method_icp_detail
		{
			 get { return _idtemplate_method_icp_detail; }
			 set
			 {
				 if (_idtemplate_method_icp_detail != value)
				 {
					_idtemplate_method_icp_detail = value;
					 PropertyHasChanged("Idtemplate_method_icp_detail");
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

		public int?  Idelement_wavelength
		{
			 get { return _idelement_wavelength; }
			 set
			 {
				 if (_idelement_wavelength != value)
				 {
					_idelement_wavelength = value;
					 PropertyHasChanged("Idelement_wavelength");
				 }
			 }
		}

		public short?  Idelement
		{
			 get { return _idelement; }
			 set
			 {
				 if (_idelement != value)
				 {
					_idelement = value;
					 PropertyHasChanged("Idelement");
				 }
			 }
		}

		public decimal?  Idl
		{
			 get { return _idl; }
			 set
			 {
				 if (_idl != value)
				 {
					_idl = value;
					 PropertyHasChanged("Idl");
				 }
			 }
		}

		public decimal?  Mdl_axial
		{
			 get { return _mdl_axial; }
			 set
			 {
				 if (_mdl_axial != value)
				 {
					_mdl_axial = value;
					 PropertyHasChanged("Mdl_axial");
				 }
			 }
		}

		public decimal?  Mdl_radial
		{
			 get { return _mdl_radial; }
			 set
			 {
				 if (_mdl_radial != value)
				 {
					_mdl_radial = value;
					 PropertyHasChanged("Mdl_radial");
				 }
			 }
		}

		public decimal?  Ldr
		{
			 get { return _ldr; }
			 set
			 {
				 if (_ldr != value)
				 {
					_ldr = value;
					 PropertyHasChanged("Ldr");
				 }
			 }
		}

		public decimal?  Ldr_aux
		{
			 get { return _ldr_aux; }
			 set
			 {
				 if (_ldr_aux != value)
				 {
					_ldr_aux = value;
					 PropertyHasChanged("Ldr_aux");
				 }
			 }
		}

		public decimal?  Num_decimal
		{
			 get { return _num_decimal; }
			 set
			 {
				 if (_num_decimal != value)
				 {
					_num_decimal = value;
					 PropertyHasChanged("Num_decimal");
				 }
			 }
		}

		public decimal?  Std1
		{
			 get { return _std1; }
			 set
			 {
				 if (_std1 != value)
				 {
					_std1 = value;
					 PropertyHasChanged("Std1");
				 }
			 }
		}

		public decimal?  Std2
		{
			 get { return _std2; }
			 set
			 {
				 if (_std2 != value)
				 {
					_std2 = value;
					 PropertyHasChanged("Std2");
				 }
			 }
		}

		public decimal?  Ipc
		{
			 get { return _ipc; }
			 set
			 {
				 if (_ipc != value)
				 {
					_ipc = value;
					 PropertyHasChanged("Ipc");
				 }
			 }
		}

		public decimal?  Lfb
		{
			 get { return _lfb; }
			 set
			 {
				 if (_lfb != value)
				 {
					_lfb = value;
					 PropertyHasChanged("Lfb");
				 }
			 }
		}

		public decimal?  Qc
		{
			 get { return _qc; }
			 set
			 {
				 if (_qc != value)
				 {
					_qc = value;
					 PropertyHasChanged("Qc");
				 }
			 }
		}

		public decimal?  Priority
		{
			 get { return _priority; }
			 set
			 {
				 if (_priority != value)
				 {
					_priority = value;
					 PropertyHasChanged("Priority");
				 }
			 }
		}

		public decimal?  Lfm
		{
			 get { return _lfm; }
			 set
			 {
				 if (_lfm != value)
				 {
					_lfm = value;
					 PropertyHasChanged("Lfm");
				 }
			 }
		}

		public decimal?  Limit_top
		{
			 get { return _limit_top; }
			 set
			 {
				 if (_limit_top != value)
				 {
					_limit_top = value;
					 PropertyHasChanged("Limit_top");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idtemplate_method_icp_detail", "Idtemplate_method_icp_detail"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
