using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDestiny_sample_recepKeys
	{

		#region Data Members

		int _iddestiny_sample_recep;

		#endregion

		#region Constructor

		public CDestiny_sample_recepKeys(int iddestiny_sample_recep)
		{
			 _iddestiny_sample_recep = iddestiny_sample_recep; 
		}

		#endregion

		#region Properties

		public int  Iddestiny_sample_recep
		{
			 get { return _iddestiny_sample_recep; }
		}

		#endregion

	}
}
