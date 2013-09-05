using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCalib_stdKeys
	{

		#region Data Members

		long _idcalib_std;

		#endregion

		#region Constructor

		public CCalib_stdKeys(long idcalib_std)
		{
			 _idcalib_std = idcalib_std; 
		}

		#endregion

		#region Properties

		public long  Idcalib_std
		{
			 get { return _idcalib_std; }
		}

		#endregion

	}
}
