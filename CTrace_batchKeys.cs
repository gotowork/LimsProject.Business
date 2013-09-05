using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTrace_batchKeys
	{

		#region Data Members

		long _idtrace_batch;

		#endregion

		#region Constructor

		public CTrace_batchKeys(long idtrace_batch)
		{
			 _idtrace_batch = idtrace_batch; 
		}

		#endregion

		#region Properties

		public long  Idtrace_batch
		{
			 get { return _idtrace_batch; }
		}

		#endregion

	}
}
