using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CSolution_titration: BusinessObjectBase
	{

		#region InnerClass
		public enum CSolution_titrationFields
		{
			Idsolution_titration,
			Idtitration_main,
			Idsolution,
			Aliquot,
			Theorical_reading,
			Practice_reading,
			Factor,
			Prepared_by,
			Date_prepared,
			Status_titration,
			Average
		}
		#endregion

		#region Data Members

			int _idsolution_titration;
			int? _idtitration_main;
			int? _idsolution;
			decimal? _aliquot;
			decimal? _theorical_reading;
			decimal? _practice_reading;
			decimal? _factor;
			short? _prepared_by;
			DateTime? _date_prepared;
			bool? _status_titration;
			decimal? _average;

		#endregion

		#region Properties

		public int  Idsolution_titration
		{
			 get { return _idsolution_titration; }
			 set
			 {
				 if (_idsolution_titration != value)
				 {
					_idsolution_titration = value;
					 PropertyHasChanged("Idsolution_titration");
				 }
			 }
		}

		public int?  Idtitration_main
		{
			 get { return _idtitration_main; }
			 set
			 {
				 if (_idtitration_main != value)
				 {
					_idtitration_main = value;
					 PropertyHasChanged("Idtitration_main");
				 }
			 }
		}

		public int?  Idsolution
		{
			 get { return _idsolution; }
			 set
			 {
				 if (_idsolution != value)
				 {
					_idsolution = value;
					 PropertyHasChanged("Idsolution");
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

		public decimal?  Theorical_reading
		{
			 get { return _theorical_reading; }
			 set
			 {
				 if (_theorical_reading != value)
				 {
					_theorical_reading = value;
					 PropertyHasChanged("Theorical_reading");
				 }
			 }
		}

		public decimal?  Practice_reading
		{
			 get { return _practice_reading; }
			 set
			 {
				 if (_practice_reading != value)
				 {
					_practice_reading = value;
					 PropertyHasChanged("Practice_reading");
				 }
			 }
		}

		public decimal?  Factor
		{
			 get { return _factor; }
			 set
			 {
				 if (_factor != value)
				 {
					_factor = value;
					 PropertyHasChanged("Factor");
				 }
			 }
		}

		public short?  Prepared_by
		{
			 get { return _prepared_by; }
			 set
			 {
				 if (_prepared_by != value)
				 {
					_prepared_by = value;
					 PropertyHasChanged("Prepared_by");
				 }
			 }
		}

		public DateTime?  Date_prepared
		{
			 get { return _date_prepared; }
			 set
			 {
				 if (_date_prepared != value)
				 {
					_date_prepared = value;
					 PropertyHasChanged("Date_prepared");
				 }
			 }
		}

		public bool?  Status_titration
		{
			 get { return _status_titration; }
			 set
			 {
				 if (_status_titration != value)
				 {
					_status_titration = value;
					 PropertyHasChanged("Status_titration");
				 }
			 }
		}

		public decimal?  Average
		{
			 get { return _average; }
			 set
			 {
				 if (_average != value)
				 {
					_average = value;
					 PropertyHasChanged("Average");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idsolution_titration", "Idsolution_titration"));
		}

		#endregion

	}
}
