using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CSolution_methodsKeys
	{

		#region Data Members

		int _idsolution_methods;

		#endregion

		#region Constructor

		public CSolution_methodsKeys(int idsolution_methods)
		{
			 _idsolution_methods = idsolution_methods; 
		}

		#endregion

		#region Properties

		public int  Idsolution_methods
		{
			 get { return _idsolution_methods; }
		}

		#endregion

	}
}
