using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CType_sampleKeys
	{

		#region Data Members

		string _cod_type_sample;

		#endregion

		#region Constructor

		public CType_sampleKeys(string cod_type_sample)
		{
			 _cod_type_sample = cod_type_sample; 
		}

		#endregion

		#region Properties

		public string  Cod_type_sample
		{
			 get { return _cod_type_sample; }
		}

		#endregion

	}
}
