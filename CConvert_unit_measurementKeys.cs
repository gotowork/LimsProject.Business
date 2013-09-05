using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CConvert_unit_measurementKeys
	{

		#region Data Members

		short _idconvert;

		#endregion

		#region Constructor

		public CConvert_unit_measurementKeys(short idconvert)
		{
			 _idconvert = idconvert; 
		}

		#endregion

		#region Properties

		public short  Idconvert
		{
			 get { return _idconvert; }
		}

		#endregion

	}
}
