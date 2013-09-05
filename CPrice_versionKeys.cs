using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CPrice_versionKeys
	{

		#region Data Members

		int _idprice_version;

		#endregion

		#region Constructor

		public CPrice_versionKeys(int idprice_version)
		{
			 _idprice_version = idprice_version; 
		}

		#endregion

		#region Properties

		public int  Idprice_version
		{
			 get { return _idprice_version; }
		}

		#endregion

	}
}
