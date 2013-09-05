using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CProcess_user_systemKeys
	{

		#region Data Members

		short _idprocess_user_system;

		#endregion

		#region Constructor

		public CProcess_user_systemKeys(short idprocess_user_system)
		{
			 _idprocess_user_system = idprocess_user_system; 
		}

		#endregion

		#region Properties

		public short  Idprocess_user_system
		{
			 get { return _idprocess_user_system; }
		}

		#endregion

	}
}
