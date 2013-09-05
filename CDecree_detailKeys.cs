using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDecree_detailKeys
	{

		#region Data Members

		int _iddecree_detail;

		#endregion

		#region Constructor

		public CDecree_detailKeys(int iddecree_detail)
		{
			 _iddecree_detail = iddecree_detail; 
		}

		#endregion

		#region Properties

		public int  Iddecree_detail
		{
			 get { return _iddecree_detail; }
		}

		#endregion

	}
}
