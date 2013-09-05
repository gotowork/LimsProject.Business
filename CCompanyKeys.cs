using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCompanyKeys
	{

		#region Data Members

		short _idcompany;

		#endregion

		#region Constructor

		public CCompanyKeys(short idcompany)
		{
			 _idcompany = idcompany; 
		}

		#endregion

		#region Properties

		public short  Idcompany
		{
			 get { return _idcompany; }
		}

		#endregion

	}
}
