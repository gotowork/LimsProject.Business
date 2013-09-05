using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCells_reportedKeys
	{

		#region Data Members

		long _idcell_reported;

		#endregion

		#region Constructor

		public CCells_reportedKeys(long idcell_reported)
		{
			 _idcell_reported = idcell_reported; 
		}

		#endregion

		#region Properties

		public long  Idcell_reported
		{
			 get { return _idcell_reported; }
		}

		#endregion

	}
}
