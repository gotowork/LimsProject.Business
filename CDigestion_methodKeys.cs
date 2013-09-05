using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDigestion_methodKeys
	{

		#region Data Members

		string _cod_digestion_method;

		#endregion

		#region Constructor

		public CDigestion_methodKeys(string cod_digestion_method)
		{
			 _cod_digestion_method = cod_digestion_method; 
		}

		#endregion

		#region Properties

		public string  Cod_digestion_method
		{
			 get { return _cod_digestion_method; }
		}

		#endregion

	}
}
