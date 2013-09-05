using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CSet_calibsKeys
	{

		#region Data Members

		int _idset_calibs;

		#endregion

		#region Constructor

		public CSet_calibsKeys(int idset_calibs)
		{
			 _idset_calibs = idset_calibs; 
		}

		#endregion

		#region Properties

		public int  Idset_calibs
		{
			 get { return _idset_calibs; }
		}

		#endregion

	}
}
