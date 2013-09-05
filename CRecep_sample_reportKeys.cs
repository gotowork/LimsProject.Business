using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_sample_reportKeys
	{

		#region Data Members

		long _idrecep_sample_report;

		#endregion

		#region Constructor

		public CRecep_sample_reportKeys(long idrecep_sample_report)
		{
			 _idrecep_sample_report = idrecep_sample_report; 
		}

		#endregion

		#region Properties

		public long  Idrecep_sample_report
		{
			 get { return _idrecep_sample_report; }
		}

		#endregion

	}
}
