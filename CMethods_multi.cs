using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMethods_multi: BusinessObjectBase
	{

		#region InnerClass
		public enum CMethods_multiFields
		{
			Id,
			Elemento_longitud,
			Elemento,
			Prioridad,
			Longitud,
			Idl,
			Mdl,
			Linealidad,
			Num_decimal,
			Std1,
			Std2,
			Ipc,
			Lfb,
			Lfm,
			Limite_inferior_md,
			Limite_inferior_mt,
			Limite_superior
		}
		#endregion

		#region Data Members

			int _id;
			string _elemento_longitud;
			string _elemento;
			int? _prioridad;
			decimal? _longitud;
			decimal? _idl;
			decimal? _mdl;
			decimal? _linealidad;
			decimal? _num_decimal;
			decimal? _std1;
			decimal? _std2;
			decimal? _ipc;
			decimal? _lfb;
			decimal? _lfm;
			decimal? _limite_inferior_md;
			decimal? _limite_inferior_mt;
			decimal? _limite_superior;

		#endregion

		#region Properties

		public int  Id
		{
			 get { return _id; }
			 set
			 {
				 if (_id != value)
				 {
					_id = value;
					 PropertyHasChanged("Id");
				 }
			 }
		}

		public string  Elemento_longitud
		{
			 get { return _elemento_longitud; }
			 set
			 {
				 if (_elemento_longitud != value)
				 {
					_elemento_longitud = value;
					 PropertyHasChanged("Elemento_longitud");
				 }
			 }
		}

		public string  Elemento
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

		public int?  Prioridad
		{
			 get { return _prioridad; }
			 set
			 {
				 if (_prioridad != value)
				 {
					_prioridad = value;
					 PropertyHasChanged("Prioridad");
				 }
			 }
		}

		public decimal?  Longitud
		{
			 get { return _longitud; }
			 set
			 {
				 if (_longitud != value)
				 {
					_longitud = value;
					 PropertyHasChanged("Longitud");
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

		public decimal?  Limite_inferior_md
		{
			 get { return _limite_inferior_md; }
			 set
			 {
				 if (_limite_inferior_md != value)
				 {
					_limite_inferior_md = value;
					 PropertyHasChanged("Limite_inferior_md");
				 }
			 }
		}

		public decimal?  Limite_inferior_mt
		{
			 get { return _limite_inferior_mt; }
			 set
			 {
				 if (_limite_inferior_mt != value)
				 {
					_limite_inferior_mt = value;
					 PropertyHasChanged("Limite_inferior_mt");
				 }
			 }
		}

		public decimal?  Limite_superior
		{
			 get { return _limite_superior; }
			 set
			 {
				 if (_limite_superior != value)
				 {
					_limite_superior = value;
					 PropertyHasChanged("Limite_superior");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Elemento_longitud", "Elemento_longitud",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Elemento", "Elemento",10));
		}

		#endregion

	}
}
