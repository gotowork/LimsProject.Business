using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CProcessKeys
	{

		#region Data Members

		string _cod_process;

		#endregion

		#region Constructor

		public CProcessKeys(string cod_process)
		{
			 _cod_process = cod_process; 
		}

		#endregion

		#region Properties

		public string  Cod_process
		{
			 get { return _cod_process; }
		}

		#endregion

	}
}
