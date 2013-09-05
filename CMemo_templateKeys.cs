using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMemo_templateKeys
	{

		#region Data Members

		int _idmemo_template;

		#endregion

		#region Constructor

		public CMemo_templateKeys(int idmemo_template)
		{
			 _idmemo_template = idmemo_template; 
		}

		#endregion

		#region Properties

		public int  Idmemo_template
		{
			 get { return _idmemo_template; }
		}

		#endregion

	}
}
