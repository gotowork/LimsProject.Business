using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CIcpimportKeys
	{

		#region Data Members

		int _idicpimport;

		#endregion

		#region Constructor

		public CIcpimportKeys(int idicpimport)
		{
			 _idicpimport = idicpimport; 
		}

		#endregion

		#region Properties

		public int  Idicpimport
		{
			 get { return _idicpimport; }
		}

		#endregion

	}
}
