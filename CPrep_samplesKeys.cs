using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CPrep_samplesKeys
	{

		#region Data Members

		long _idrecep_sample_detail;

		#endregion

		#region Constructor

		public CPrep_samplesKeys(long idrecep_sample_detail)
		{
			 _idrecep_sample_detail = idrecep_sample_detail; 
		}

		#endregion

		#region Properties

		public long  Idrecep_sample_detail
		{
			 get { return _idrecep_sample_detail; }
		}

		#endregion

	}
}
