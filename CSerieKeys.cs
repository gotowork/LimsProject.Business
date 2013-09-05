using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CSerieKeys
	{

		#region Data Members

		string _cod_serie;

		#endregion

		#region Constructor

		public CSerieKeys(string cod_serie)
		{
			 _cod_serie = cod_serie; 
		}

		#endregion

		#region Properties

		public string  Cod_serie
		{
			 get { return _cod_serie; }
		}

		#endregion

	}
}
