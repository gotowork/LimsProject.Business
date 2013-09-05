using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CPrice_attachKeys
	{

		#region Data Members

		int _idattach;

		#endregion

		#region Constructor

		public CPrice_attachKeys(int idattach)
		{
			 _idattach = idattach; 
		}

		#endregion

		#region Properties

		public int  Idattach
		{
			 get { return _idattach; }
		}

		#endregion

	}
}
