using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CSolution_titrationKeys
	{

		#region Data Members

		int _idsolution_titration;

		#endregion

		#region Constructor

		public CSolution_titrationKeys(int idsolution_titration)
		{
			 _idsolution_titration = idsolution_titration; 
		}

		#endregion

		#region Properties

		public int  Idsolution_titration
		{
			 get { return _idsolution_titration; }
		}

		#endregion

	}
}
