using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTemplate_method_formatKeys
	{

		#region Data Members

		long _idtemplate_method_format;

		#endregion

		#region Constructor

		public CTemplate_method_formatKeys(long idtemplate_method_format)
		{
			 _idtemplate_method_format = idtemplate_method_format; 
		}

		#endregion

		#region Properties

		public long  Idtemplate_method_format
		{
			 get { return _idtemplate_method_format; }
		}

		#endregion

	}
}
