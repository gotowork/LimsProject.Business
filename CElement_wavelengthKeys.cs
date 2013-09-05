using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CElement_wavelengthKeys
	{

		#region Data Members

		int _idelement_wavelength;

		#endregion

		#region Constructor

		public CElement_wavelengthKeys(int idelement_wavelength)
		{
			 _idelement_wavelength = idelement_wavelength; 
		}

		#endregion

		#region Properties

		public int  Idelement_wavelength
		{
			 get { return _idelement_wavelength; }
		}

		#endregion

	}
}
