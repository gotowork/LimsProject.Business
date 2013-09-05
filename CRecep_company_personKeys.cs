using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_company_personKeys
	{

		#region Data Members

		long _idrecep_company_person;

		#endregion

		#region Constructor

		public CRecep_company_personKeys(long idrecep_company_person)
		{
			 _idrecep_company_person = idrecep_company_person; 
		}

		#endregion

		#region Properties

		public long  Idrecep_company_person
		{
			 get { return _idrecep_company_person; }
		}

		#endregion

	}
}
