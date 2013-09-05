using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CDocumentationKeys
	{

		#region Data Members

		short _iddocumentation;

		#endregion

		#region Constructor

		public CDocumentationKeys(short iddocumentation)
		{
			 _iddocumentation = iddocumentation; 
		}

		#endregion

		#region Properties

		public short  Iddocumentation
		{
			 get { return _iddocumentation; }
		}

		#endregion

	}
}
