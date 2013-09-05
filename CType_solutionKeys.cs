using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CType_solutionKeys
	{

		#region Data Members

		int _idtype_solution;

		#endregion

		#region Constructor

		public CType_solutionKeys(int idtype_solution)
		{
			 _idtype_solution = idtype_solution; 
		}

		#endregion

		#region Properties

		public int  Idtype_solution
		{
			 get { return _idtype_solution; }
		}

		#endregion

	}
}
