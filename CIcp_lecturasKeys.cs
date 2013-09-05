using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CIcp_lecturasKeys
	{

		#region Data Members

		int _id;

		#endregion

		#region Constructor

		public CIcp_lecturasKeys(int id)
		{
			 _id = id; 
		}

		#endregion

		#region Properties

		public int  Id
		{
			 get { return _id; }
		}

		#endregion

	}
}
