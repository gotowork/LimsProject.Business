using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CPrice_company_personKeys
	{

		#region Data Members

		int _idprice_company_person;

		#endregion

		#region Constructor

		public CPrice_company_personKeys(int idprice_company_person)
		{
			 _idprice_company_person = idprice_company_person; 
		}

		#endregion

		#region Properties

		public int  Idprice_company_person
		{
			 get { return _idprice_company_person; }
		}

		#endregion

	}
}
