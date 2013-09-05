using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMatrix_itemKeys
	{

		#region Data Members

		int _idmatrix_item;

		#endregion

		#region Constructor

		public CMatrix_itemKeys(int idmatrix_item)
		{
			 _idmatrix_item = idmatrix_item; 
		}

		#endregion

		#region Properties

		public int  Idmatrix_item
		{
			 get { return _idmatrix_item; }
		}

		#endregion

	}
}
