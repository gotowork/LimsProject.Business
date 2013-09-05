using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CControl_sample_frequencyKeys
	{

		#region Data Members

		int _idcontrol_sample_frequency;

		#endregion

		#region Constructor

		public CControl_sample_frequencyKeys(int idcontrol_sample_frequency)
		{
			 _idcontrol_sample_frequency = idcontrol_sample_frequency; 
		}

		#endregion

		#region Properties

		public int  Idcontrol_sample_frequency
		{
			 get { return _idcontrol_sample_frequency; }
		}

		#endregion

	}
}
