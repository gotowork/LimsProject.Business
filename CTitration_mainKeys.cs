using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTitration_mainKeys
	{

		#region Data Members

		int _idtitration_main;

		#endregion

		#region Constructor

		public CTitration_mainKeys(int idtitration_main)
		{
			 _idtitration_main = idtitration_main; 
		}

		#endregion

		#region Properties

		public int  Idtitration_main
		{
			 get { return _idtitration_main; }
		}

		#endregion

	}
}
