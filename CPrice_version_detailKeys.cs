using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CPrice_version_detailKeys
	{

		#region Data Members

		int _idprice_version_detail;

		#endregion

		#region Constructor

		public CPrice_version_detailKeys(int idprice_version_detail)
		{
			 _idprice_version_detail = idprice_version_detail; 
		}

		#endregion

		#region Properties

		public int  Idprice_version_detail
		{
			 get { return _idprice_version_detail; }
		}

		#endregion

	}
}
