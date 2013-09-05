using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CConfigurationKeys
	{

		#region Data Members

		short _idconfiguration;

		#endregion

		#region Constructor

		public CConfigurationKeys(short idconfiguration)
		{
			 _idconfiguration = idconfiguration; 
		}

		#endregion

		#region Properties

		public short  Idconfiguration
		{
			 get { return _idconfiguration; }
		}

		#endregion

	}
}
