using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CBatch_detail_aaKeys
	{

		#region Data Members

		long _idbatch_detail_aa;

		#endregion

		#region Constructor

		public CBatch_detail_aaKeys(long idbatch_detail_aa)
		{
			 _idbatch_detail_aa = idbatch_detail_aa; 
		}

		#endregion

		#region Properties

		public long  Idbatch_detail_aa
		{
			 get { return _idbatch_detail_aa; }
		}

		#endregion

	}
}
