using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_elemKeys
	{

		#region Data Members

		long _idrecep_elem;

		#endregion

		#region Constructor

		public CRecep_elemKeys(long idrecep_elem)
		{
			 _idrecep_elem = idrecep_elem; 
		}

		#endregion

		#region Properties

		public long  Idrecep_elem
		{
			 get { return _idrecep_elem; }
		}

		#endregion

	}
}
