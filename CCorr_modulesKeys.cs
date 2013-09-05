using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCorr_modulesKeys
	{

		#region Data Members

		string _cod_module;

		#endregion

		#region Constructor

		public CCorr_modulesKeys(string cod_module)
		{
			 _cod_module = cod_module; 
		}

		#endregion

		#region Properties

		public string  Cod_module
		{
			 get { return _cod_module; }
		}

		#endregion

	}
}
