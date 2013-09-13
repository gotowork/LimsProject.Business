using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CFactor_estequiometricoKeys
	{

		#region Data Members

		int _idfactor_estequiometrico;

		#endregion

		#region Constructor

		public CFactor_estequiometricoKeys(int idfactor_estequiometrico)
		{
			 _idfactor_estequiometrico = idfactor_estequiometrico; 
		}

		#endregion

		#region Properties

		public int  Idfactor_estequiometrico
		{
			 get { return _idfactor_estequiometrico; }
		}

		#endregion

	}
}
