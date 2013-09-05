using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CIcp_lecturas: BusinessObjectBase
	{

		#region InnerClass
		public enum CIcp_lecturasFields
		{
			Id,
			Calibracion,
			Elemento,
			Idmuestra,
			Muestra,
			Lectura,
			Dilucion2
		}
		#endregion

		#region Data Members

			int _id;
			int? _calibracion;
			string _elemento;
			int? _idmuestra;
			string _muestra;
			string _lectura;
			string _dilucion2;

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

		public int?  Calibracion
		{
			 get { return _calibracion; }
			 set
			 {
				 if (_calibracion != value)
				 {
					_calibracion = value;
					 PropertyHasChanged("Calibracion");
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

		public int?  Idmuestra
		{
			 get { return _idmuestra; }
			 set
			 {
				 if (_idmuestra != value)
				 {
					_idmuestra = value;
					 PropertyHasChanged("Idmuestra");
				 }
			 }
		}

		public string  Muestra
		{
			 get { return _muestra; }
			 set
			 {
				 if (_muestra != value)
				 {
					_muestra = value;
					 PropertyHasChanged("Muestra");
				 }
			 }
		}

		public string  Lectura
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

		public string  Dilucion2
		{
			 get { return _dilucion2; }
			 set
			 {
				 if (_dilucion2 != value)
				 {
					_dilucion2 = value;
					 PropertyHasChanged("Dilucion2");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Elemento", "Elemento",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Muestra", "Muestra",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Lectura", "Lectura",15));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Dilucion2", "Dilucion2",15));
		}

		#endregion

	}
}
