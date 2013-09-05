using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_sample_detailKeys
	{

		#region Data Members

		long _idrecep_sample_detail;

		#endregion

		#region Constructor

		public CRecep_sample_detailKeys(long idrecep_sample_detail)
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
