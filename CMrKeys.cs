using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMrKeys
	{

		#region Data Members

		short _idmr;

		#endregion

		#region Constructor

		public CMrKeys(short idmr)
		{
			 _idmr = idmr; 
		}

		#endregion

		#region Properties

		public short  Idmr
		{
			 get { return _idmr; }
		}

		#endregion

	}
}
