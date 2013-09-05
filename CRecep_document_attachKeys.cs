using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_document_attachKeys
	{

		#region Data Members

		int _idrecep_document_attach;

		#endregion

		#region Constructor

		public CRecep_document_attachKeys(int idrecep_document_attach)
		{
			 _idrecep_document_attach = idrecep_document_attach; 
		}

		#endregion

		#region Properties

		public int  Idrecep_document_attach
		{
			 get { return _idrecep_document_attach; }
		}

		#endregion

	}
}
