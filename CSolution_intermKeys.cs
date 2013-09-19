using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CSolution_intermKeys
	{

		#region Data Members

		int _idsolution_interm;

		#endregion

		#region Constructor

		public CSolution_intermKeys(int idsolution_interm)
		{
			 _idsolution_interm = idsolution_interm; 
		}

		#endregion

		#region Properties

		public int  Idsolution_interm
		{
			 get { return _idsolution_interm; }
		}

		#endregion

	}
}
