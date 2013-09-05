using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCompany_personKeys
	{

		#region Data Members

		int _idcompany_person;

		#endregion

		#region Constructor

		public CCompany_personKeys(int idcompany_person)
		{
			 _idcompany_person = idcompany_person; 
		}

		#endregion

		#region Properties

		public int  Idcompany_person
		{
			 get { return _idcompany_person; }
		}

		#endregion

	}
}
