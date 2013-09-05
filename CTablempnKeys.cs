using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTablempnKeys
	{

		#region Data Members

		short _idtablempn;

		#endregion

		#region Constructor

		public CTablempnKeys(short idtablempn)
		{
			 _idtablempn = idtablempn; 
		}

		#endregion

		#region Properties

		public short  Idtablempn
		{
			 get { return _idtablempn; }
		}

		#endregion

	}
}
