using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CProfile_systemKeys
	{

		#region Data Members

		short _idprofile;

		#endregion

		#region Constructor

		public CProfile_systemKeys(short idprofile)
		{
			 _idprofile = idprofile; 
		}

		#endregion

		#region Properties

		public short  Idprofile
		{
			 get { return _idprofile; }
		}

		#endregion

	}
}
