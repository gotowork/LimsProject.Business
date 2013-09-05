using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CGroup_solutionKeys
	{

		#region Data Members

		int _idgroup_solution;

		#endregion

		#region Constructor

		public CGroup_solutionKeys(int idgroup_solution)
		{
			 _idgroup_solution = idgroup_solution; 
		}

		#endregion

		#region Properties

		public int  Idgroup_solution
		{
			 get { return _idgroup_solution; }
		}

		#endregion

	}
}
