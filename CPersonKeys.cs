using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CPersonKeys
	{

		#region Data Members

		short _idperson;

		#endregion

		#region Constructor

		public CPersonKeys(short idperson)
		{
			 _idperson = idperson; 
		}

		#endregion

		#region Properties

		public short  Idperson
		{
			 get { return _idperson; }
		}

		#endregion

	}
}
