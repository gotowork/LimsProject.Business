using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CType_preparation_sampleKeys
	{

		#region Data Members

		int _idtype_preparation_sample;

		#endregion

		#region Constructor

		public CType_preparation_sampleKeys(int idtype_preparation_sample)
		{
			 _idtype_preparation_sample = idtype_preparation_sample; 
		}

		#endregion

		#region Properties

		public int  Idtype_preparation_sample
		{
			 get { return _idtype_preparation_sample; }
		}

		#endregion

	}
}
