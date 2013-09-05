using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCondition_variableKeys
	{

		#region Data Members

		int _idcondition_variable;

		#endregion

		#region Constructor

		public CCondition_variableKeys(int idcondition_variable)
		{
			 _idcondition_variable = idcondition_variable; 
		}

		#endregion

		#region Properties

		public int  Idcondition_variable
		{
			 get { return _idcondition_variable; }
		}

		#endregion

	}
}
