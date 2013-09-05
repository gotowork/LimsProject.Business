using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMatrix_groupKeys
	{

		#region Data Members

		int _idmatrix_group;

		#endregion

		#region Constructor

		public CMatrix_groupKeys(int idmatrix_group)
		{
			 _idmatrix_group = idmatrix_group; 
		}

		#endregion

		#region Properties

		public int  Idmatrix_group
		{
			 get { return _idmatrix_group; }
		}

		#endregion

	}
}
