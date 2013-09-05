using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LimsProject.BusinessLayer.Modules
{
    public class CUser_Authorization
    {
        public string Cod_process { get; set; }
        public string Name_process { get; set; }
        public string Aias_process { get; set; }
        public string Description { get; set; }
        public DateTime? Date_ini { get; set; }
        public DateTime? Date_end { get; set; }
        public string Link_document { get; set; }
        public bool Authorized { get; set; }
    }
}
