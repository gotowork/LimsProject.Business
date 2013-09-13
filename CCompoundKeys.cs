using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCompoundKeys
	{

		#region Data Members

		int _idcompound;

		#endregion

		#region Constructor

		public CCompoundKeys(int idcompound)
		{
			 _idcompound = idcompound; 
		}

		#endregion

		#region Properties

		public int  Idcompound
		{
			 get { return _idcompound; }
		}

		#endregion

	}
}
