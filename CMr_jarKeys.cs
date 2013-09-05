using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMr_jarKeys
	{

		#region Data Members

		short _idmr_jar;

		#endregion

		#region Constructor

		public CMr_jarKeys(short idmr_jar)
		{
			 _idmr_jar = idmr_jar; 
		}

		#endregion

		#region Properties

		public short  Idmr_jar
		{
			 get { return _idmr_jar; }
		}

		#endregion

	}
}
