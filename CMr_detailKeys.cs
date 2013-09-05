using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMr_detailKeys
	{

		#region Data Members

		short _idmr_detail;

		#endregion

		#region Constructor

		public CMr_detailKeys(short idmr_detail)
		{
			 _idmr_detail = idmr_detail; 
		}

		#endregion

		#region Properties

		public short  Idmr_detail
		{
			 get { return _idmr_detail; }
		}

		#endregion

	}
}
