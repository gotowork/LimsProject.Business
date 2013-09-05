using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CBatch_result_aa_qaqcKeys
	{

		#region Data Members

		long _idbatch_result_aa_qaqc;

		#endregion

		#region Constructor

		public CBatch_result_aa_qaqcKeys(long idbatch_result_aa_qaqc)
		{
			 _idbatch_result_aa_qaqc = idbatch_result_aa_qaqc; 
		}

		#endregion

		#region Properties

		public long  Idbatch_result_aa_qaqc
		{
			 get { return _idbatch_result_aa_qaqc; }
		}

		#endregion

	}
}
