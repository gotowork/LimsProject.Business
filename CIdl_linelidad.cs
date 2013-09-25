using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CIdl_linelidad: BusinessObjectBase
	{

		#region InnerClass
		public enum CIdl_linelidadFields
		{
			Elemento,
			Lectura,
			Mdl,
			Idl,
			Ldr
		}
		#endregion

		#region Data Members

			char? _elemento;
			char? _lectura;
			decimal? _mdl;
			decimal? _idl;
			decimal? _ldr;

		#endregion

		#region Properties

		public char?  Elemento
		{
			 get { return _elemento; }
			 set
			 {
				 if (_elemento != value)
				 {
					_elemento = value;
					 PropertyHasChanged("Elemento");
				 }
			 }
		}

		public char?  Lectura
		{
			 get { return _lectura; }
			 set
			 {
				 if (_lectura != value)
				 {
					_lectura = value;
					 PropertyHasChanged("Lectura");
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
		}

		#endregion

	}
}
