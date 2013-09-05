using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CCells_attach_fileKeys
	{

		#region Data Members

		long _idcells_attach_file;

		#endregion

		#region Constructor

		public CCells_attach_fileKeys(long idcells_attach_file)
		{
			 _idcells_attach_file = idcells_attach_file; 
		}

		#endregion

		#region Properties

		public long  Idcells_attach_file
		{
			 get { return _idcells_attach_file; }
		}

		#endregion

	}
}
