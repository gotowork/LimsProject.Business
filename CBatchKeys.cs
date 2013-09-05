using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CBatchKeys
	{

		#region Data Members

		long _idbatch;

		#endregion

		#region Constructor

		public CBatchKeys(long idbatch)
		{
			 _idbatch = idbatch; 
		}

		#endregion

		#region Properties

		public long  Idbatch
		{
			 get { return _idbatch; }
		}

		#endregion

	}
}
