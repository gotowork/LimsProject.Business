using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_sample_attachKeys
	{

		#region Data Members

		long _idrecep_sample_attach;

		#endregion

		#region Constructor

		public CRecep_sample_attachKeys(long idrecep_sample_attach)
		{
			 _idrecep_sample_attach = idrecep_sample_attach; 
		}

		#endregion

		#region Properties

		public long  Idrecep_sample_attach
		{
			 get { return _idrecep_sample_attach; }
		}

		#endregion

	}
}
