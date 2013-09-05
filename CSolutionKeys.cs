using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CSolutionKeys
	{

		#region Data Members

		int _idsolution;

		#endregion

		#region Constructor

		public CSolutionKeys(int idsolution)
		{
			 _idsolution = idsolution; 
		}

		#endregion

		#region Properties

		public int  Idsolution
		{
			 get { return _idsolution; }
		}

		#endregion

	}
}
