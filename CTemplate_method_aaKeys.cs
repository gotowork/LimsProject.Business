using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTemplate_method_aaKeys
	{

		#region Data Members

		int _idtemplate_method;

		#endregion

		#region Constructor

		public CTemplate_method_aaKeys(int idtemplate_method)
		{
			 _idtemplate_method = idtemplate_method; 
		}

		#endregion

		#region Properties

		public int  Idtemplate_method
		{
			 get { return _idtemplate_method; }
		}

		#endregion

	}
}
