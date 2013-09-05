using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMemo_priceKeys
	{

		#region Data Members

		int _idmemo_price;

		#endregion

		#region Constructor

		public CMemo_priceKeys(int idmemo_price)
		{
			 _idmemo_price = idmemo_price; 
		}

		#endregion

		#region Properties

		public int  Idmemo_price
		{
			 get { return _idmemo_price; }
		}

		#endregion

	}
}
