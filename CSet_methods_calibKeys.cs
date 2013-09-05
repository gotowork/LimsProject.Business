using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CSet_methods_calibKeys
	{

		#region Data Members

		int _idset_methods_calib;

		#endregion

		#region Constructor

		public CSet_methods_calibKeys(int idset_methods_calib)
		{
			 _idset_methods_calib = idset_methods_calib; 
		}

		#endregion

		#region Properties

		public int  Idset_methods_calib
		{
			 get { return _idset_methods_calib; }
		}

		#endregion

	}
}
