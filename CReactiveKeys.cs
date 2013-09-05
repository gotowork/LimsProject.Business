using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CReactiveKeys
	{

		#region Data Members

		int _idreactive;

		#endregion

		#region Constructor

		public CReactiveKeys(int idreactive)
		{
			 _idreactive = idreactive; 
		}

		#endregion

		#region Properties

		public int  Idreactive
		{
			 get { return _idreactive; }
		}

		#endregion

	}
}
