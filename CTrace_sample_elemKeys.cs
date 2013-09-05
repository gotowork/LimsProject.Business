using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTrace_sample_elemKeys
	{

		#region Data Members

		long _idtrace_sample_elem;

		#endregion

		#region Constructor

		public CTrace_sample_elemKeys(long idtrace_sample_elem)
		{
			 _idtrace_sample_elem = idtrace_sample_elem; 
		}

		#endregion

		#region Properties

		public long  Idtrace_sample_elem
		{
			 get { return _idtrace_sample_elem; }
		}

		#endregion

	}
}
