using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRetestKeys
	{

		#region Data Members

		long _idretest;

		#endregion

		#region Constructor

		public CRetestKeys(long idretest)
		{
			 _idretest = idretest; 
		}

		#endregion

		#region Properties

		public long  Idretest
		{
			 get { return _idretest; }
		}

		#endregion

	}
}
