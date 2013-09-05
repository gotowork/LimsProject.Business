using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer.DataLayer.Modules;

namespace LimsProject.BusinessLayer.Modules
{
    public class ModQaQc
    {
        public DataTable GetAllTree(string p_cod_area, string p_cod_module, bool p_enabled_history, DateTime p_date_ini, DateTime p_date_end, long? p_cod_interno, long? p_idcompany)
        {
            return new ModQaQcSql().SelectAllTree(p_cod_area, p_cod_module, p_enabled_history, p_date_ini, p_date_end, p_cod_interno, p_idcompany);
        }
    }
}
