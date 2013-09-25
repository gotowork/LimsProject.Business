using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CSolution_interm_methodsKeys
	{

		#region Data Members

		int _idsolution_methods;

		#endregion

		#region Constructor

		public CSolution_interm_methodsKeys(int idsolution_methods)
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
