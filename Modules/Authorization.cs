using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using LimsProject.BusinessLayer;
using System.ComponentModel;

namespace LimsProject.BusinessLayer.Modules
{
    public class Authorization
    {
        /// <summary>
        ///1;"Qaqc - Aprobación de lecturas"
        ///2;"Qaqc - Revisión de lecturas"
        ///3;"Preparación de Soluciones - Firmar datos de titulaciones"
        ///4;"Preparación de Soluciones - Firmar factor de titulaciones"
        ///5;"Preparación de Soluciones - Firmar calibración de estandares"
        /// </summary>

        public enum ListAuthorization
        {
            CanApproveReadings = 1,
            CanReviewReadings = 2,
            CanSignDataTitration = 3,
            CanSignFactorTitration = 4,
            CanSignCalibStandard = 5
        }

        List<CProcedure> lstProcedure = new List<CProcedure>();        

        public List<CConfiguration_folder> GetDocument()
        {
            return new CConfiguration_folderFactory().GetAll().Where(c => c.Folder_type == 'C').ToList();
        }

        public List<CProcedure> GetProcedure()
        {
            if (lstProcedure.Count == 0)
            {
                lstProcedure.Add(new CProcedure { Id = 'T', Name = "Tareas" });
                lstProcedure.Add(new CProcedure { Id = 'M', Name = "Metodos" });
                lstProcedure.Add(new CProcedure { Id = 'G', Name = "Gestión" });
            }
            return lstProcedure;
        }

        public List<CDocumentation> GetDocumentation(short idconfiguration_folder, char procedure_type)
        {
            CDocumentationFactory faDocumentation = new CDocumentationFactory();
            return faDocumentation.GetAll().Where(c => c.Idconfiguration_folder == idconfiguration_folder && c.Procedure_type == procedure_type).ToList();
        }

        public List<CConfiguration_folder> GetListConfiguration_folder()
        {
            return new CConfiguration_folderFactory().GetAll().Where(c=> c.Folder_type == 'C').ToList();
        }

        public CConfiguration_folder GetRootDirectory()
        {
            return new CConfiguration_folderFactory().GetAll().Single(c => c.Folder_type == 'R');
        }

        public List<CDocumentation_User_File> GetListDocumentation_User_File(short idconfiguration_folder, char procedure_type, short iduser, int expire)
        {
            List<CDocumentation> lstDocumentation = GetDocumentation(idconfiguration_folder, procedure_type);
            List<CDocumentation_user> lstDocumentation_user = new CDocumentation_userFactory().GetAll().Where(c=> c.Iduser == iduser).ToList();
            long? longNull = null;

            List<CDocumentation_User_File> lst =
                    new List<CDocumentation_User_File>(
                        (from l in lstDocumentation
                         join r in lstDocumentation_user on l.Iddocumentation equals r.Iddocumentation into ps
                         from t in ps.DefaultIfEmpty()
                         select new CDocumentation_User_File
                         {
                             Iddocumentation = l.Iddocumentation,
                             Iddocumentation_user = t == null ? longNull : Convert.ToInt64(t.Iddocumentation_user),
                             Idconfiguration_folder = l.Idconfiguration_folder,
                             Idtemplate_method = l.Idtemplate_method,
                             Id = Convert.ToInt32(l.Id),
                             Parentid = Convert.ToInt32(l.Parentid),
                             Flag_enabled = Convert.ToBoolean(l.Flag_enabled),
                             Image_index = Convert.ToInt32(l.Image_index),
                             Procedure_type = Convert.ToChar(l.Procedure_type),
                             Type_doc = Convert.ToChar(l.Type_doc),
                             Name_doc = l.Name_doc,
                             Name_file = t == null ? "" : t.Name_file,
                             Allowed = t == null ? false : true,
                             Extension_file = t == null ? "" : t.Extension_file,
                             Date_ini = t == null ? null : t.Date_ini,
                             Date_end = t == null ? null : t.Date_end,
                             Prev_authorized = t == null ? false : Convert.ToBoolean(t.Prev_authorized),
                             Rank_valid_inmonth = t == null ? 0 : Convert.ToInt32(t.Rank_valid_inmonth),
                             Error_valid = GetErrorValid(t, expire)
                         }).ToList());
            return lst;
        }

        int GetErrorValid(CDocumentation_user document_user, int expire)
        {
            // 1:expired, 2:into to rank
            if (document_user == null)
                return 0;
            else
            {
                if ((DateTime.Now.AddMonths(expire) > document_user.Date_end))
                    return 1;
            }
            return 2;
        }

        public string Get_next_file_name(short iduser, char type_doc)
        {
            CDocumentation_userFactory faDocumentation_user = new CDocumentation_userFactory();
            List<CDocumentation_user> lstDocumentation_user =
                faDocumentation_user.GetAll().Where(c => c.Iduser == iduser && c.Name_file[0] == type_doc).ToList();

            long max = 0;
            if (lstDocumentation_user != null && lstDocumentation_user.Count() > 0)            
                max = lstDocumentation_user.Max(c => Convert.ToInt64(c.Order_file));
            
            long next = max+1;
            return String.Format("{0}-{1}", type_doc,  next.ToString().PadLeft(6, '0'));
        }

        public bool IsAuthorized(ListAuthorization code, short iduser)
        {
            CDocumentation_userFactory faDocumentation_user = new CDocumentation_userFactory();
            CDocumentationFactory faDocumentation = new CDocumentationFactory();
            
            List<CDocumentation_user> lstDocUser = faDocumentation_user.GetAll();
            List<CDocumentation> lstDocumentation = faDocumentation.GetAll();

            var query = 
                (from t1 in lstDocUser
                 join t2 in lstDocumentation on t1.Iddocumentation equals t2.Iddocumentation
                 where t2.Code == Convert.ToInt16(code) && t1.Iduser == iduser
                 select new
                 {
                     Prev_authorized = t1.Prev_authorized
                 }).ToList();
                
            foreach(var item in query)            
                return Convert.ToBoolean(item.Prev_authorized);
            
            return false;
        }
    }

    public class CProcedure
    {
        public char Id { get; set; }
        public string Name { get; set; }
    }

    public class CDocumentation_User_File
    {
        public short Iddocumentation { get; set; }
        public long? Iddocumentation_user { get; set; }
        public short Idconfiguration_folder { get; set; }
        public int? Idtemplate_method { get; set; }
        public char Procedure_type { get; set; }
        public string Name_doc { get; set; }
        public char Type_doc { get; set; }
        public bool Flag_enabled { get; set; }
        public int Image_index { get; set; }
        public int Id { get; set; }
        public int Parentid { get; set; }
        public string Name_file { get; set; }
        public long Order_file { get; set; }
        public bool Allowed { get; set; }
        public bool Prev_authorized { get; set; }
        public string Extension_file { get; set; }
        public int Rank_valid_inmonth { get; set; }
        public DateTime? Date_ini { get; set; }
        public DateTime? Date_end { get; set; }
        public int Error_valid { get; set; }
    }
}
