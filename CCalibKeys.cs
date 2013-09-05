using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCalibKeys
	{

		#region Data Members

		long _idcalib;

		#endregion

		#region Constructor

		public CCalibKeys(long idcalib)
		{
			 _idcalib = idcalib; 
		}

		#endregion

		#region Properties

		public long  Idcalib
		{
			 get { return _idcalib; }
		}

		#endregion

	}
}
