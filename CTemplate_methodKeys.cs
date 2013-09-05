using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTemplate_methodKeys
	{

		#region Data Members

		int _idtemplate_method;

		#endregion

		#region Constructor

		public CTemplate_methodKeys(int idtemplate_method)
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
