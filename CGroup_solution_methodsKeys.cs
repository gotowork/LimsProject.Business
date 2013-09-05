using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CGroup_solution_methodsKeys
	{

		#region Data Members

		int _idgroup_solution_methods;

		#endregion

		#region Constructor

		public CGroup_solution_methodsKeys(int idgroup_solution_methods)
		{
			 _idgroup_solution_methods = idgroup_solution_methods; 
		}

		#endregion

		#region Properties

		public int  Idgroup_solution_methods
		{
			 get { return _idgroup_solution_methods; }
		}

		#endregion

	}
}
