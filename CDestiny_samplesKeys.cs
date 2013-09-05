using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDestiny_samplesKeys
	{

		#region Data Members

		int _iddestiny_samples;

		#endregion

		#region Constructor

		public CDestiny_samplesKeys(int iddestiny_samples)
		{
			 _iddestiny_samples = iddestiny_samples; 
		}

		#endregion

		#region Properties

		public int  Iddestiny_samples
		{
			 get { return _iddestiny_samples; }
		}

		#endregion

	}
}
