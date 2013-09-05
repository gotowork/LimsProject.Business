using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CUser_systemKeys
	{

		#region Data Members

		short _iduser;

		#endregion

		#region Constructor

		public CUser_systemKeys(short iduser)
		{
			 _iduser = iduser; 
		}

		#endregion

		#region Properties

		public short  Iduser
		{
			 get { return _iduser; }
		}

		#endregion

	}
}
