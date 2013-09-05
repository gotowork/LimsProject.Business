using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTitration_main: BusinessObjectBase
	{

		#region InnerClass
		public enum CTitration_mainFields
		{
			Idtitration_main,
			Num_analyst,
			Type_average,
			Num_test,
			Concentration_unit,
			Concentration_value,
			Factor,
			Idunit_measure_factor,
			Status_process,
			Analyst1,
			Date_analyst1,
			Analyst2,
			Date_analyst2,
			Analyst3,
			Date_analyst3,
			Analyst4,
			Date_analyst4
		}
		#endregion

		#region Data Members

			int _idtitration_main;
			int? _num_analyst;
			int? _type_average;
			int? _num_test;
			int? _concentration_unit;
			decimal? _concentration_value;
			decimal? _factor;
			short? _idunit_measure_factor;
			int? _status_process;
			short? _analyst1;
			DateTime? _date_analyst1;
			short? _analyst2;
			DateTime? _date_analyst2;
			short? _analyst3;
			DateTime? _date_analyst3;
			short? _analyst4;
			DateTime? _date_analyst4;

		#endregion

		#region Properties

		public int  Idtitration_main
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

		public int?  Num_analyst
		{
			 get { return _num_analyst; }
			 set
			 {
				 if (_num_analyst != value)
				 {
					_num_analyst = value;
					 PropertyHasChanged("Num_analyst");
				 }
			 }
		}

		public int?  Type_average
		{
			 get { return _type_average; }
			 set
			 {
				 if (_type_average != value)
				 {
					_type_average = value;
					 PropertyHasChanged("Type_average");
				 }
			 }
		}

		public int?  Num_test
		{
			 get { return _num_test; }
			 set
			 {
				 if (_num_test != value)
				 {
					_num_test = value;
					 PropertyHasChanged("Num_test");
				 }
			 }
		}

		public int?  Concentration_unit
		{
			 get { return _concentration_unit; }
			 set
			 {
				 if (_concentration_unit != value)
				 {
					_concentration_unit = value;
					 PropertyHasChanged("Concentration_unit");
				 }
			 }
		}

		public decimal?  Concentration_value
		{
			 get { return _concentration_value; }
			 set
			 {
				 if (_concentration_value != value)
				 {
					_concentration_value = value;
					 PropertyHasChanged("Concentration_value");
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

		public short?  Idunit_measure_factor
		{
			 get { return _idunit_measure_factor; }
			 set
			 {
				 if (_idunit_measure_factor != value)
				 {
					_idunit_measure_factor = value;
					 PropertyHasChanged("Idunit_measure_factor");
				 }
			 }
		}

		public int?  Status_process
		{
			 get { return _status_process; }
			 set
			 {
				 if (_status_process != value)
				 {
					_status_process = value;
					 PropertyHasChanged("Status_process");
				 }
			 }
		}

		public short?  Analyst1
		{
			 get { return _analyst1; }
			 set
			 {
				 if (_analyst1 != value)
				 {
					_analyst1 = value;
					 PropertyHasChanged("Analyst1");
				 }
			 }
		}

		public DateTime?  Date_analyst1
		{
			 get { return _date_analyst1; }
			 set
			 {
				 if (_date_analyst1 != value)
				 {
					_date_analyst1 = value;
					 PropertyHasChanged("Date_analyst1");
				 }
			 }
		}

		public short?  Analyst2
		{
			 get { return _analyst2; }
			 set
			 {
				 if (_analyst2 != value)
				 {
					_analyst2 = value;
					 PropertyHasChanged("Analyst2");
				 }
			 }
		}

		public DateTime?  Date_analyst2
		{
			 get { return _date_analyst2; }
			 set
			 {
				 if (_date_analyst2 != value)
				 {
					_date_analyst2 = value;
					 PropertyHasChanged("Date_analyst2");
				 }
			 }
		}

		public short?  Analyst3
		{
			 get { return _analyst3; }
			 set
			 {
				 if (_analyst3 != value)
				 {
					_analyst3 = value;
					 PropertyHasChanged("Analyst3");
				 }
			 }
		}

		public DateTime?  Date_analyst3
		{
			 get { return _date_analyst3; }
			 set
			 {
				 if (_date_analyst3 != value)
				 {
					_date_analyst3 = value;
					 PropertyHasChanged("Date_analyst3");
				 }
			 }
		}

		public short?  Analyst4
		{
			 get { return _analyst4; }
			 set
			 {
				 if (_analyst4 != value)
				 {
					_analyst4 = value;
					 PropertyHasChanged("Analyst4");
				 }
			 }
		}

		public DateTime?  Date_analyst4
		{
			 get { return _date_analyst4; }
			 set
			 {
				 if (_date_analyst4 != value)
				 {
					_date_analyst4 = value;
					 PropertyHasChanged("Date_analyst4");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idtitration_main", "Idtitration_main"));
		}

		#endregion

	}
}
