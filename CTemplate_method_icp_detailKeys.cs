using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTemplate_method_icp_detailKeys
	{

		#region Data Members

		int _idtemplate_method_icp_detail;

		#endregion

		#region Constructor

		public CTemplate_method_icp_detailKeys(int idtemplate_method_icp_detail)
		{
			 _idtemplate_method_icp_detail = idtemplate_method_icp_detail; 
		}

		#endregion

		#region Properties

		public int  Idtemplate_method_icp_detail
		{
			 get { return _idtemplate_method_icp_detail; }
		}

		#endregion

	}
}
