using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CPriceKeys
	{

		#region Data Members

		int _idprice;

		#endregion

		#region Constructor

		public CPriceKeys(int idprice)
		{
			 _idprice = idprice; 
		}

		#endregion

		#region Properties

		public int  Idprice
		{
			 get { return _idprice; }
		}

		#endregion

	}
}
