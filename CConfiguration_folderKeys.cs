using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CConfiguration_folderKeys
	{

		#region Data Members

		short _idconfiguration_folder;

		#endregion

		#region Constructor

		public CConfiguration_folderKeys(short idconfiguration_folder)
		{
			 _idconfiguration_folder = idconfiguration_folder; 
		}

		#endregion

		#region Properties

		public short  Idconfiguration_folder
		{
			 get { return _idconfiguration_folder; }
		}

		#endregion

	}
}
