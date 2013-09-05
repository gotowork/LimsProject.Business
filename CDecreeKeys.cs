using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDecreeKeys
	{

		#region Data Members

		int _iddecree;

		#endregion

		#region Constructor

		public CDecreeKeys(int iddecree)
		{
			 _iddecree = iddecree; 
		}

		#endregion

		#region Properties

		public int  Iddecree
		{
			 get { return _iddecree; }
		}

		#endregion

	}
}
