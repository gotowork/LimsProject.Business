using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CRecep_sample_programKeys
	{

		#region Data Members

		long _idrecep_sample_program;

		#endregion

		#region Constructor

		public CRecep_sample_programKeys(long idrecep_sample_program)
		{
			 _idrecep_sample_program = idrecep_sample_program; 
		}

		#endregion

		#region Properties

		public long  Idrecep_sample_program
		{
			 get { return _idrecep_sample_program; }
		}

		#endregion

	}
}
