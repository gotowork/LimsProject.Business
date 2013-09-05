using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CControl_sampleKeys
	{

		#region Data Members

		int _idcontrol_sample;

		#endregion

		#region Constructor

		public CControl_sampleKeys(int idcontrol_sample)
		{
			 _idcontrol_sample = idcontrol_sample; 
		}

		#endregion

		#region Properties

		public int  Idcontrol_sample
		{
			 get { return _idcontrol_sample; }
		}

		#endregion

	}
}
