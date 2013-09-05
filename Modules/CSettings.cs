using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LimsProject.BusinessLayer.Modules
{
    public class CSettings
    {        
        const string FOLDER_ACCIONES_CORRECTIVAS = "acciones correctivas";
        const string FOLDER_AUTORIZACIONES = "autorizaciones";
        const string FOLDER_PROCEDIMIENTO_ENSAYO_EXTERNO = "procedimiento ensayo externo";
        const string FOLDER_ANEXOS_COTIZACION = "anexos cotizacion";

        public short GetUnitMeasureSolution()
        {
            return 1;
        }

        public short GetNumYearValidDocument()
        {
            return 3;
        }

        public short GetNumMonthStdCalib()
        {
            return 12;
        }

        public short GetNumMonthStdVerification()
        {
            return 12;
        }

        public short GetNumMonthSolInterm()
        {
            return 12;
        }

        public short GetNumMonthSolTitration()
        {
            return 12;
        }

        public string GetPathRoot()
        {
            return @"\\LAS0020-PC\Compartido-LAS\2013";
        }

        public short GetNumDaysPriceDefault()
        {
            return 10;
        }

        public string GetPathAttachPrice()
        {
            return @GetPathRoot() + "\\" + FOLDER_ANEXOS_COTIZACION;
        }
    }
}
