using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDocumentation_userKeys
	{

		#region Data Members

		long _iddocumentation_user;

		#endregion

		#region Constructor

		public CDocumentation_userKeys(long iddocumentation_user)
		{
			 _iddocumentation_user = iddocumentation_user; 
		}

		#endregion

		#region Properties

		public long  Iddocumentation_user
		{
			 get { return _iddocumentation_user; }
		}

		#endregion

	}
}
