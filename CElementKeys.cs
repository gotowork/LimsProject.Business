using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CElementKeys
	{

		#region Data Members

		short _idelement;

		#endregion

		#region Constructor

		public CElementKeys(short idelement)
		{
			 _idelement = idelement; 
		}

		#endregion

		#region Properties

		public short  Idelement
		{
			 get { return _idelement; }
		}

		#endregion

	}
}
