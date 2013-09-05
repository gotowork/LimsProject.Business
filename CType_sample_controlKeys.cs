using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CType_sample_controlKeys
	{

		#region Data Members

		int _idtype_sample_control;

		#endregion

		#region Constructor

		public CType_sample_controlKeys(int idtype_sample_control)
		{
			 _idtype_sample_control = idtype_sample_control; 
		}

		#endregion

		#region Properties

		public int  Idtype_sample_control
		{
			 get { return _idtype_sample_control; }
		}

		#endregion

	}
}
