using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CBatch_detail_aa_twofoldKeys
	{

		#region Data Members

		long _idbatch_detail_aa;

		#endregion

		#region Constructor

		public CBatch_detail_aa_twofoldKeys(long idbatch_detail_aa)
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
