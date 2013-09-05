using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMeasurement_unitKeys
	{

		#region Data Members

		short _idunit;

		#endregion

		#region Constructor

		public CMeasurement_unitKeys(short idunit)
		{
			 _idunit = idunit; 
		}

		#endregion

		#region Properties

		public short  Idunit
		{
			 get { return _idunit; }
		}

		#endregion

	}
}
