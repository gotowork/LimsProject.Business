using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDocument_recepKeys
	{

		#region Data Members

		int _iddocument_recep;

		#endregion

		#region Constructor

		public CDocument_recepKeys(int iddocument_recep)
		{
			 _iddocument_recep = iddocument_recep; 
		}

		#endregion

		#region Properties

		public int  Iddocument_recep
		{
			 get { return _iddocument_recep; }
		}

		#endregion

	}
}
