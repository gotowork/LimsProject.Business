using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CBatchicpKeys
	{

		#region Data Members

		int _idbatchicp;

		#endregion

		#region Constructor

		public CBatchicpKeys(int idbatchicp)
		{
			 _idbatchicp = idbatchicp; 
		}

		#endregion

		#region Properties

		public int  Idbatchicp
		{
			 get { return _idbatchicp; }
		}

		#endregion

	}
}
