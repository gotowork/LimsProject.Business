using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCalib: BusinessObjectBase
	{

		#region InnerClass
		public enum CCalibFields
		{
			Idcalib,
			Order_calib,
			Name_calib,
			Concentration,
			Idtemplate_method,
			Aliquot,
			Volumen
		}
		#endregion

		#region Data Members

			long _idcalib;
			short? _order_calib;
			string _name_calib;
			decimal? _concentration;
			int? _idtemplate_method;
			decimal? _aliquot;
			decimal? _volumen;

		#endregion

		#region Properties

		public long  Idcalib
		{
			 get { return _idcalib; }
			 set
			 {
				 if (_idcalib != value)
				 {
					_idcalib = value;
					 PropertyHasChanged("Idcalib");
				 }
			 }
		}

		public short?  Order_calib
		{
			 get { return _order_calib; }
			 set
			 {
				 if (_order_calib != value)
				 {
					_order_calib = value;
					 PropertyHasChanged("Order_calib");
				 }
			 }
		}

		public string  Name_calib
		{
			 get { return _name_calib; }
			 set
			 {
				 if (_name_calib != value)
				 {
					_name_calib = value;
					 PropertyHasChanged("Name_calib");
				 }
			 }
		}

		public decimal?  Concentration
		{
			 get { return _concentration; }
			 set
			 {
				 if (_concentration != value)
				 {
					_concentration = value;
					 PropertyHasChanged("Concentration");
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

		public decimal?  Aliquot
		{
			 get { return _aliquot; }
			 set
			 {
				 if (_aliquot != value)
				 {
					_aliquot = value;
					 PropertyHasChanged("Aliquot");
				 }
			 }
		}

		public decimal?  Volumen
		{
			 get { return _volumen; }
			 set
			 {
				 if (_volumen != value)
				 {
					_volumen = value;
					 PropertyHasChanged("Volumen");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idcalib", "Idcalib"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name_calib", "Name_calib",15));
		}

		#endregion

	}
}
