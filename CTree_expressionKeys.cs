using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CTree_expressionKeys
	{

		#region Data Members

		long _idtree_expression;

		#endregion

		#region Constructor

		public CTree_expressionKeys(long idtree_expression)
		{
			 _idtree_expression = idtree_expression; 
		}

		#endregion

		#region Properties

		public long  Idtree_expression
		{
			 get { return _idtree_expression; }
		}

		#endregion

	}
}
