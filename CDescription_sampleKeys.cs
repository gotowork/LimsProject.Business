using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDescription_sampleKeys
	{

		#region Data Members

		string _cod_des_sample;

		#endregion

		#region Constructor

		public CDescription_sampleKeys(string cod_des_sample)
		{
			 _cod_des_sample = cod_des_sample; 
		}

		#endregion

		#region Properties

		public string  Cod_des_sample
		{
			 get { return _cod_des_sample; }
		}

		#endregion

	}
}
