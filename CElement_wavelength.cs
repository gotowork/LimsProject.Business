using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CElement_wavelength: BusinessObjectBase
	{

		#region InnerClass
		public enum CElement_wavelengthFields
		{
			Idelement_wavelength,
			Elementsymbol,
			Wavelength,
			Lineorder,
			Plasmaview,
			Idl,
			Linealidad,
			Mdl,
			Ipc,
			Lfb,
			Qc,
			Priority,
			Usernew,
			Datenew,
			Useredit,
			Dateedit,
			Status
		}
		#endregion

		#region Data Members

			int _idelement_wavelength;
			string _elementsymbol;
			string _wavelength;
			short? _lineorder;
			short? _plasmaview;
			decimal? _idl;
			decimal? _linealidad;
			decimal? _mdl;
			decimal? _ipc;
			decimal? _lfb;
			decimal? _qc;
			decimal? _priority;
			string _usernew;
			DateTime? _datenew;
			string _useredit;
			DateTime? _dateedit;
			bool? _status;

		#endregion

		#region Properties

		public int  Idelement_wavelength
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

		public string  Elementsymbol
		{
			 get { return _elementsymbol; }
			 set
			 {
				 if (_elementsymbol != value)
				 {
					_elementsymbol = value;
					 PropertyHasChanged("Elementsymbol");
				 }
			 }
		}

		public string  Wavelength
		{
			 get { return _wavelength; }
			 set
			 {
				 if (_wavelength != value)
				 {
					_wavelength = value;
					 PropertyHasChanged("Wavelength");
				 }
			 }
		}

		public short?  Lineorder
		{
			 get { return _lineorder; }
			 set
			 {
				 if (_lineorder != value)
				 {
					_lineorder = value;
					 PropertyHasChanged("Lineorder");
				 }
			 }
		}

		public short?  Plasmaview
		{
			 get { return _plasmaview; }
			 set
			 {
				 if (_plasmaview != value)
				 {
					_plasmaview = value;
					 PropertyHasChanged("Plasmaview");
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

		public decimal?  Linealidad
		{
			 get { return _linealidad; }
			 set
			 {
				 if (_linealidad != value)
				 {
					_linealidad = value;
					 PropertyHasChanged("Linealidad");
				 }
			 }
		}

		public decimal?  Mdl
		{
			 get { return _mdl; }
			 set
			 {
				 if (_mdl != value)
				 {
					_mdl = value;
					 PropertyHasChanged("Mdl");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idelement_wavelength", "Idelement_wavelength"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Elementsymbol", "Elementsymbol",4));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Wavelength", "Wavelength",8));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Usernew", "Usernew",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Useredit", "Useredit",20));
		}

		#endregion

	}
}
