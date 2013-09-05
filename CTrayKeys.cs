using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTrayKeys
	{

		#region Data Members

		short _idtray;

		#endregion

		#region Constructor

		public CTrayKeys(short idtray)
		{
			 _idtray = idtray; 
		}

		#endregion

		#region Properties

		public short  Idtray
		{
			 get { return _idtray; }
		}

		#endregion

	}
}
