using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CControl_sample_conditionKeys
	{

		#region Data Members

		int _idcontrol_sample_condition;

		#endregion

		#region Constructor

		public CControl_sample_conditionKeys(int idcontrol_sample_condition)
		{
			 _idcontrol_sample_condition = idcontrol_sample_condition; 
		}

		#endregion

		#region Properties

		public int  Idcontrol_sample_condition
		{
			 get { return _idcontrol_sample_condition; }
		}

		#endregion

	}
}
