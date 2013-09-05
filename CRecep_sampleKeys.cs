using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_sampleKeys
	{

		#region Data Members

		long _idrecep_sample;

		#endregion

		#region Constructor

		public CRecep_sampleKeys(long idrecep_sample)
		{
			 _idrecep_sample = idrecep_sample; 
		}

		#endregion

		#region Properties

		public long  Idrecep_sample
		{
			 get { return _idrecep_sample; }
		}

		#endregion

	}
}
