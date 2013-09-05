using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CAreaKeys
	{

		#region Data Members

		string _cod_area;

		#endregion

		#region Constructor

		public CAreaKeys(string cod_area)
		{
			 _cod_area = cod_area; 
		}

		#endregion

		#region Properties

		public string  Cod_area
		{
			 get { return _cod_area; }
		}

		#endregion

	}
}
