using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_sample_detail_elemKeys
	{

		#region Data Members

		long _idrecep_sample_detail_elem;

		#endregion

		#region Constructor

		public CRecep_sample_detail_elemKeys(long idrecep_sample_detail_elem)
		{
			 _idrecep_sample_detail_elem = idrecep_sample_detail_elem; 
		}

		#endregion

		#region Properties

		public long  Idrecep_sample_detail_elem
		{
			 get { return _idrecep_sample_detail_elem; }
		}

		#endregion

	}
}
