using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LimsProject.BusinessLayer;
using System.ComponentModel;
using System.Data;
using System.Collections;

namespace LimsProject.BusinessLayer.Modules
{
    public class Reception
    {

        public List<CDocAttach> GetLstDocAttach(long idrecep_sample)
        {
            List<CDocument_recep> lstDocument_recep = new CDocument_recepFactory().GetAll();
            List<CRecep_sample_attach> lstRecep_sample_attach = new CRecep_sample_attachFactory().GetAll().Where(c => c.Idrecep_sample == idrecep_sample).ToList();
            List<CDocAttach> lstDocAttach = new List<CDocAttach>((from t1 in lstDocument_recep
                                                                  join t2 in lstRecep_sample_attach on t1.Iddocument_recep equals t2.Iddocument_recep
                                                                  select new CDocAttach
                                                                  {
                                                                      Iddocument_recep = t1.Iddocument_recep,
                                                                      Idrecep_sample = t2.Idrecep_sample,
                                                                      Name_file = t1.Name_file,
                                                                      Order_file = t1.Order_file,
                                                                      Source_path = ""
                                                                  }).ToList<CDocAttach>());
            return lstDocAttach;
        }

        public List<CExistFiles> GetLstExistFiles(short idcompany, string cod_type_sample)
        {
            List<CRecep_sample> lstRecep_sample = new CRecep_sampleFactory().GetAll().Where(c=> c.Idcompany == idcompany && c.Cod_type_sample == cod_type_sample).ToList();
            List<CRecep_sample_attach> lstRecep_sample_attach = new CRecep_sample_attachFactory().GetAll();

            List<CExistFiles> lstExistFile = new List<CExistFiles>((from a in lstRecep_sample
                                                                    join b in lstRecep_sample_attach on a.Idrecep_sample equals b.Idrecep_sample
                                                                    select new CExistFiles
                                                                    {
                                                                        Idrecep_sample_attach = b.Idrecep_sample_attach//,
                                                                        //Name_file = b.Name_file
                                                                    }).ToList<CExistFiles>());
            return lstExistFile;
        }

        public List<CCells_attach_file> GetLstCellsAttach(short idrecep_sample)
        {
            List<CRecep_sample_detail_elem> lstRecepSample = new CRecep_sample_detail_elemFactory().GetAll().Where(c => c.Idrecep_sample == idrecep_sample).ToList();
            List<CCells_attach_file> lstCellsAttach = new CCells_attach_fileFactory().GetAll();

            List<CCells_attach_file> list = new List<CCells_attach_file>((from a in lstRecepSample
                                                                          join b in lstCellsAttach on a.Idrecep_sample_detail_elem equals b.Idrecep_sample_detail_elem
                                                                          select b).ToList());
            return list;
        }

        public void GetNextFileName(ref string next_filename, ref int next_file_order)
        {
            CDocument_recepFactory faDocument_recep = new CDocument_recepFactory();
            List<CDocument_recep> lstDocument_recep =
                faDocument_recep.GetAll();

            int max = 0;
            if (lstDocument_recep != null && lstDocument_recep.Count() > 0)
                max = lstDocument_recep.Max(c => Convert.ToInt32(c.Order_file));

            next_file_order = max + 1;
            next_filename = String.Format("{0}-{1}", "R", next_file_order.ToString().PadLeft(6, '0'));
        }

        public List<CAttach_status> GetAttachStatus()
        {
            List<CAttach_status> lst = new List<CAttach_status>();
            lst.Add(new CAttach_status { Id = 1, Name_status = "En creación" });
            lst.Add(new CAttach_status { Id = 2, Name_status = "Adjuntado" });
            return lst;
        }

        public List<CContact> GetLstContactsByCompany(short idcompany)
        {
            // --- get last idrecep_sample
            if (new CRecep_sampleFactory().GetAll().Exists(c => c.Idcompany == idcompany))
            {
                CRecep_sample oRecep_sample = new CRecep_sampleFactory().GetAll().Where(c => c.Idcompany == idcompany).Last();
                // --- retrieve contacts of last record company
                List<CRecep_company_person> lstRecep_company_person =
                    new CRecep_company_personFactory().GetAll().Where(c => c.Idrecep_sample == oRecep_sample.Idrecep_sample && c.Enabled_show == true).ToList();
                List<CPerson> lstPerson = new CPersonFactory().GetAll();
                List<CContact> lst = (
                    from r in lstRecep_company_person
                    join p in lstPerson on r.Idperson equals p.Idperson
                    select new CContact
                    {
                        Idrecep_company_person = 0,
                        Idcompany = r.Idcompany,
                        Idperson = r.Idperson,
                        Allname = p.Allname,
                        Mail = p.Mail,
                        Phone = p.Phone,
                        Cellphone = p.Cellphone,
                        Person_type = r.Person_type
                    }).ToList<CContact>();

                return lst;
            }
            return new List<CContact>();
        }

        public List<CContact> GetLstContactsByRecep(long idrecep_sample)
        {
            List<CRecep_company_person> lstRecep_company_person = new CRecep_company_personFactory().GetAll().Where(c => c.Idrecep_sample == idrecep_sample && c.Enabled_show == true).ToList();
            List<CPerson> lstPerson = new CPersonFactory().GetAll();
            List<CContact> lst = (
                from r in lstRecep_company_person
                join p in lstPerson on r.Idperson equals p.Idperson
                select new CContact
                {
                    Idrecep_company_person = r.Idrecep_company_person,
                    Idrecep_sample = idrecep_sample,
                    Idcompany = r.Idcompany,
                    Idperson = r.Idperson,
                    Allname = p.Allname,
                    Mail = p.Mail,
                    Phone = p.Phone,
                    Cellphone = p.Cellphone,
                    Person_type = r.Person_type
                }).ToList<CContact>();

            return lst;
        }    
    
        public List<CRecep_sample_dispatch> GetLstDispatch(long idrecep_sample)
        {
            List<CRecep_sample_dispatch> lstRecep_sample_dispatch = new CRecep_sample_dispatchFactory().GetAll().Where(c => c.Idrecep_sample == idrecep_sample).ToList();
            return lstRecep_sample_dispatch;
        }

        public List<CPerson_type> GetLstPersonType()
        {
            List<CPerson_type> lst = new List<CPerson_type>();
            lst.Add(new CPerson_type { Id = 1, Name = "Solicitante" });
            lst.Add(new CPerson_type { Id = 2, Name = "Contacto" });
            lst.Add(new CPerson_type { Id = 3, Name = "Atención" });

            return lst;
        }

        public void SetDisabledContact(long idrecep_sample)
        {
            List<CContact> lstContacts = GetLstContactsByRecep(idrecep_sample);

            CRecep_company_personFactory faRecep_company_person = new CRecep_company_personFactory();
            CRecep_company_person oRecep_company_person = new CRecep_company_person();
            for (int i = 0; i < lstContacts.Count; i++)
            {
                oRecep_company_person = faRecep_company_person.GetByPrimaryKey(new CRecep_company_personKeys(lstContacts[i].Idrecep_company_person));
                oRecep_company_person.Enabled_show = false;

                faRecep_company_person.Update(oRecep_company_person);
            }
        }

        public List<CCells_attach_file> GetLstCellsAttachFile(long idrecep_sample_attach)
        {
            List<CCells_attach_file> lst = new CCells_attach_fileFactory().GetAll().Where(c => c.Idrecep_sample_attach == idrecep_sample_attach).ToList();
            return lst;
        }

        public List<CCells_program> GetLstCellsProgram(long idrecep_sample_program)
        {
            List<CCells_program> lst = new CCells_programFactory().GetAll().Where(c => c.Idrecep_sample_program == idrecep_sample_program).ToList();
            return lst;
        }

        public List<CReception_template_method> GetMethodsDenominations(string cod_type_sample)
        {
            List<CTemplate_method> lstTemplate = new CTemplate_methodFactory().GetAll();

            // --- get last version all methods by cod_type_sample         
            var maxVersionTemplate =
                (from t1 in lstTemplate
                 group t1 by new { t1.Cod_template_method, t1.Cod_type_sample }
                     into grp
                     select new
                     {
                         grp.Key.Cod_template_method,
                         grp.Key.Cod_type_sample,
                         MaxIdtemplate_method = grp.Max(c => c.Idtemplate_method)
                     }).ToList().Where(q => q.Cod_type_sample == cod_type_sample).ToList();
                                    
            List<CMeasurement_unit> lstMeasurement_unit = new CMeasurement_unitFactory().GetAll();
            List<CElement> lstElement = new CElementFactory().GetAll();

            List<CReception_template_method> lstCustom =
                (from t1 in lstTemplate
                 from k in new CTemplate_method_aaFactory().GetAll().Where(x=> x.Idtemplate_method == t1.Idtemplate_method)
                 join t2 in lstMeasurement_unit on k.Idunit_result equals t2.Idunit
                 join t3 in maxVersionTemplate on t1.Idtemplate_method equals t3.MaxIdtemplate_method    
                 join t4 in lstElement on t1.Idelement equals t4.Idelement
                 select new CReception_template_method
                  {
                      Idelement = t1.Idelement,
                      Idtemplate_method = t1.Idtemplate_method,
                      Cod_template_method = t1.Cod_template_method,
                      Abbreviation = t1.Abbreviation,
                      Title = t1.Title,
                      Type_analisys = t1.Type_analisys,
                      Name_type_analisys = CaseNomTypeAnalysis(t1.Type_analisys),
                      Cod_type_sample = t1.Cod_type_sample,
                      Cost_method = t1.Cost_method,
                      Idunit_result = k.Idunit_result,
                      Name_unit = t2.Name_unit,
                      Analisys_time = Convert.ToDecimal(k.Num_days) / Convert.ToDecimal(k.Num_samples),
                      Cod_element = t4.Cod_element
                  }).OrderBy(c=> c.Cod_template_method).ToList<CReception_template_method>();

            return lstCustom;
        }

        public string CaseNomTypeAnalysis(char? type_analysis)
        {
            string result = "";
            switch (type_analysis)
            {
                case '1':
                    result = "AbsorcionAtomica";
                    break;
                case '2':
                    result = "Volumetria";
                    break;
                case '3':
                    result = "Gravimetria";
                    break;
                case '4':
                    result = "NewmontAA";
                    break;
                case '5':
                    result = "NewmontGr";
                    break;

            }
            return result;
        }

        public List<CSerie> GetCurrentSerie()
        {
            return new CSerieFactory().GetAll().Where(c => c.Status == true).ToList();
        }

        public DataTable GetReceptionDetail(long? idrecep_sample)
        {
            List<CRecep_sample_detail> lstRecep_sample_detail = new CRecep_sample_detailFactory()
                .GetAll()
                .Where(c => c.Idrecep_sample == idrecep_sample && c.Flag_control_sample == false).ToList();
            List<CType_sample> lstType_sample = new CType_sampleFactory().GetAll();
            List<CDescription_sample> lstDescription_sample = new CDescription_sampleFactory().GetAll();

            List<CReception_detail_description> lst =
                (from t1 in lstRecep_sample_detail
                 join t2 in lstType_sample on t1.Cod_type_sample equals t2.Cod_type_sample
                 join t3 in lstDescription_sample on t1.Cod_des_sample equals t3.Cod_des_sample
                 select new CReception_detail_description
                 {
                     Amount_weight = Convert.ToDecimal(t1.Amount_weight),
                     Analisys_time = Convert.ToDecimal(t1.Analisys_time),
                     Cod_des_sample = t1.Cod_des_sample,
                     Cod_sample = t1.Cod_sample,
                     Cod_type_sample = t1.Cod_type_sample,
                     Cost_sample = Convert.ToDecimal(t1.Cost_sample),
                     Description = t3.Description,
                     Flag_envelope_sealed = Convert.ToBoolean(t1.Flag_envelope_sealed),
                     Flag_counter_sample = Convert.ToInt16(t1.Flag_counter_sample),
                     Flag_reject = Convert.ToBoolean(t1.Flag_reject),
                     Idrecep_sample = Convert.ToInt64(t1.Idrecep_sample),
                     Idrecep_sample_detail = t1.Idrecep_sample_detail,
                     Name_sample = t1.Name_sample,
                     Name_type_sample = t2.Name_type_sample,
                     Order_sample = Convert.ToInt16(t1.Order_sample),
                     Procedence = t1.Procedence,  
                     Cod_interno = Convert.ToInt64(t1.Cod_interno)
                 }).OrderBy(c=> c.Order_sample).ToList<CReception_detail_description>();

            return ToDataTable<CReception_detail_description>(lst);
        }

        public DataTable ToDataTable<T>(IList<T> data)// T is any generic type
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        public DataTable GetReceptionDetailElem(long idrecep_sample)
        {
            List<CRecep_sample_detail_elem> lstRecep_sample_detail_elem = new CRecep_sample_detail_elemFactory().GetAll().Where(c => c.Idrecep_sample == idrecep_sample).ToList();
            List<CElement> lstElement = new CElementFactory().GetAll();
            List<CTemplate_method> lstTemplate_method = new CTemplate_methodFactory().GetAll();

            List<CReception_detail_elem> lst =
                (from t1 in lstRecep_sample_detail_elem
                 join t2 in lstElement on t1.Idelement equals t2.Idelement
                 join t3 in lstTemplate_method on t1.Idtemplate_method equals t3.Idtemplate_method
                 select new CReception_detail_elem
                 {
                     Idrecep_sample = Convert.ToInt64(t1.Idrecep_sample),
                     Idrecep_sample_detail = Convert.ToInt32(t1.Idrecep_sample_detail),
                     Idrecep_sample_detail_elem = t1.Idrecep_sample_detail_elem,
                     Idtemplate_method = Convert.ToInt32(t1.Idtemplate_method),
                     Idelement = Convert.ToInt16(t1.Idelement),
                     Cod_element = t2.Cod_element,
                     Abbreviation = t3.Abbreviation,
                     Result_analysis = Convert.ToDecimal(t1.Result_analysis),
                     Str_result_analysis = t1.Str_result_analysis,
                     Cod_template_method = t3.Cod_template_method
                 }).ToList<CReception_detail_elem>();

            return ToDataTable<CReception_detail_elem>(lst);
        }

        public long GetNewCodReport(short type_report)
        {
            CCorr_modulesFactory faCorr_module = new CCorr_modulesFactory();
            CCorr_modules oModule = new CCorr_modules();
            
            if (type_report == 1)
            {
                oModule = faCorr_module.GetByPrimaryKey(new CCorr_modulesKeys("RP"));
                oModule.Correlative = oModule.Correlative + 1;
                faCorr_module.Update(oModule);
            }
            else
            {
                oModule = faCorr_module.GetByPrimaryKey(new CCorr_modulesKeys("RF"));
                oModule.Correlative = oModule.Correlative + 1;
                faCorr_module.Update(oModule);
            }
            
            return Convert.ToInt16(oModule.Correlative);
        }

        public long GetNewCodProgram()
        {
            CCorr_modulesFactory faCorr_module = new CCorr_modulesFactory();
            CCorr_modules oModule = faCorr_module.GetByPrimaryKey(new CCorr_modulesKeys("PP"));
            oModule.Correlative = oModule.Correlative + 1;
            faCorr_module.Update(oModule);
            return Convert.ToInt16(oModule.Correlative);
        }

        public DataTable GetRecep_sample_report(long idrecep_sample)
        {            
            List<CCustom_Recep_sample_report> lst =
                (from t in new CRecep_sample_reportFactory().GetAll().Where(c => c.Idrecep_sample == idrecep_sample).ToList()
                 select new CCustom_Recep_sample_report
                 {
                     Sel = false,
                     Idrecep_sample_report = t.Idrecep_sample_report,
                     Order_report = Convert.ToInt16(t.Order_report),                     
                     Str_cod_recep_sample_report = GetFormatReportCode(t.Type_report, t.Cod_recep_sample_report),
                     Cod_recep_sample_report = Convert.ToInt16(t.Cod_recep_sample_report),
                     Report_status = Convert.ToInt16(t.Report_status),
                     Type_report = Convert.ToInt16(t.Type_report),
                     Idrecep_sample = Convert.ToInt64(t.Idrecep_sample),
                     Flag_rpt_email = Convert.ToBoolean(t.Flag_rpt_email),
                     Flag_rpt_print = Convert.ToBoolean(t.Flag_rpt_print),
                     Flag_rpt_pdf = Convert.ToBoolean(t.Flag_rpt_pdf),
                     Date_report = Convert.ToDateTime(t.Date_report),
                     Time_report = Convert.ToDateTime(t.Time_report)
                 }).ToList();
            return ToDataTable<CCustom_Recep_sample_report>(lst);
        }

        public DataTable GetRecep_sample_program(long idrecep_sample)
        {
            List<CCustom_recep_sample_program> lst =
                (from t in new CRecep_sample_programFactory().GetAll().Where(c => c.Idrecep_sample == idrecep_sample).ToList()
                 select new CCustom_recep_sample_program
                 {
                     Sel = false,
                     Idrecep_sample_program = t.Idrecep_sample_program,
                     Idrecep_sample = Convert.ToInt64(t.Idrecep_sample),
                     Order_report = Convert.ToInt16(t.Order_report),
                     Program_status = Convert.ToInt16(t.Program_status),
                     Cod_recep_sample_program = Convert.ToInt64(t.Cod_recep_sample_program),
                     Str_cod_recep_sample_program = GetFormatProgramCode(t.Cod_recep_sample_program),
                     Date_report = Convert.ToDateTime(t.Date_report),
                     Time_report = Convert.ToDateTime(t.Time_report)                     
                 }).ToList();

            return ToDataTable<CCustom_recep_sample_program>(lst);
        }

        public string GetFormatReportCode(short? type_report, long? Cod_recep_sample_report)
        {
            CCorr_modulesFactory faCorr_module = new CCorr_modulesFactory();
            CCorr_modules oModuleRP = new CCorr_modules();
            CCorr_modules oModuleRF = new CCorr_modules();
            oModuleRP = faCorr_module.GetByPrimaryKey(new CCorr_modulesKeys("RP"));
            oModuleRF = faCorr_module.GetByPrimaryKey(new CCorr_modulesKeys("RF"));

            if (type_report == 1)
                return oModuleRP.Prefix + oModuleRP.Cod_serie +"-"+ CompleteZeros(Convert.ToInt64(Cod_recep_sample_report), Convert.ToInt16(oModuleRP.Num_digits));
            else
                return oModuleRF.Prefix + oModuleRF.Cod_serie +"-"+ CompleteZeros(Convert.ToInt64(Cod_recep_sample_report), Convert.ToInt16(oModuleRF.Num_digits));
        }

        public string GetFormatProgramCode(long? Cod_recep_sample_report)
        {
            CCorr_modulesFactory faCorr_module = new CCorr_modulesFactory();
            CCorr_modules oModule = faCorr_module.GetByPrimaryKey(new CCorr_modulesKeys("PP"));

            return oModule.Prefix + oModule.Cod_serie + "-" + CompleteZeros(Convert.ToInt64(Cod_recep_sample_report), Convert.ToInt16(oModule.Num_digits));            
        }

        public long GetNewCodReception()
        {
            CCorr_modules oCorrelative = new CCorr_modulesFactory().GetAll().Single(c => c.Cod_module == "RR");
            oCorrelative.Correlative = oCorrelative.Correlative + 1;
            new CCorr_modulesFactory().Update(oCorrelative);
            return Convert.ToInt64(oCorrelative.Correlative);
        }

        public string GetFormatCodReception()
        {
            CCorr_modules oCorrelative = new CCorr_modulesFactory().GetAll().Single(c => c.Cod_module == "RR");
            return oCorrelative.Prefix + oCorrelative.Cod_serie + oCorrelative.Correlative.ToString().PadLeft(Convert.ToInt32(oCorrelative.Num_digits), '0');
        }

        public long GetNewCodInternoSample(string Cod_type_sample)
        {
            CCorrelative oCorrelative = new CCorrelativeFactory().GetAll().Single(c => c.Cod_type_sample == Cod_type_sample);
            int correlative = Convert.ToInt32(oCorrelative.Correlative) + 1;
            
            if (correlative % 15 == 6)
                correlative = correlative + 1;

            oCorrelative.Correlative = correlative;

            new CCorrelativeFactory().Update(oCorrelative);
            return new CCorrelativeFactory().GetAll().Max(c => Convert.ToInt64(c.Correlative));
        }

        public string GetFormatCodInternoSample(string Cod_type_sample)
        {
            CCorrelative oCorrelative = new CCorrelativeFactory().GetAll().Single(c => c.Cod_type_sample == Cod_type_sample);
            return oCorrelative.Prefix + oCorrelative.Cod_serie + Convert.ToInt32(oCorrelative.Correlative).ToString().PadLeft(Convert.ToInt32(oCorrelative.Num_digits), '0');
        }

        public string CompleteZeros(long number, short num_digits)
        {
            string num = number.ToString();
            return num.PadLeft(num_digits, '0');
        }

        public List<CTemplate_method> GetReceptionElem(long idrecep_sample)
        {
            Methods oMethods = new Methods();
            List<CTemplate_method> lstTemplate_method = oMethods.GetAllLastVersionMethods();
            List<CRecep_elem> lstRecep_elem = new CRecep_elemFactory().GetAll();

            return (from t1 in lstTemplate_method
                    join t2 in lstRecep_elem on t1.Idtemplate_method equals t2.Idtemplate_method
                    where t2.Idrecep_sample == idrecep_sample
                    select t1).ToList<CTemplate_method>();
        }

        #region modulo de matrices

        public IList GetAllMatrixGroup()
        {
            var query =
                (from m in new CMatrix_groupFactory().GetAll().Where(x=> x.Status == true)
                 where m.Status == true
                 select new
                 {
                     Code = m.Idmatrix_group,
                     Name = m.Sigla +" - "+ m.Name_group
                 }).ToList();
            return query;
        }

        #endregion

        #region modulo decreee

        public IList GetMethodsForDecree()
        {
            var query =
                (from m in new CTemplate_methodFactory().GetAll()
                 from n in new CElementFactory().GetAll().Where(x=> x.Idelement == m.Idelement)
                 select new
                 {
                     Code = m.Idtemplate_method,
                     Name = m.Cod_template_method + " - " + n.Cod_element + " - " + m.Title
                 }).ToList();

            return query;
        }

        public List<CDecree_detail> GetLstDecree_detail(int iddecree)
        {
            return new CDecree_detailFactory().GetAll().Where(x => x.Iddecree == iddecree).ToList();                
        }        

        #endregion 


    }

    public class CCustom_Recep_sample_report
    {
        public bool Sel { get; set; }
        public long Idrecep_sample_report { get; set; }
        public short Order_report { get; set; }
        public string Str_cod_recep_sample_report { get; set; }
        public long Cod_recep_sample_report { get; set; }
        public short Report_status { get; set; }
        public short Type_report { get; set; }
        public long Idrecep_sample { get; set; }
        public bool Flag_rpt_email { get; set; }
        public bool Flag_rpt_print { get; set; }
        public bool Flag_rpt_pdf { get; set; }
        public DateTime Date_report { get; set; }
        public DateTime Time_report { get; set; }
    }

    public class CCustom_recep_sample_program
    {
        public bool Sel { get; set; }
        public long Idrecep_sample_program { get; set; }
        public short Order_report { get; set; }
        public string Str_cod_recep_sample_program { get; set; }
        public long Cod_recep_sample_program { get; set; }
        public short Program_status { get; set; }        
        public long Idrecep_sample { get; set; }
        public DateTime Date_report { get; set; }
        public DateTime Time_report { get; set; }
    }

    public class TypeReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CExistFiles
    {
        public long Idrecep_sample_attach { get; set; }
        public string Name_file { get; set; }
    }

    public class CDocAttach
    {
        public int Iddocument_recep { get; set; }
        public string Name_file { get; set; }
        public int? Order_file { get; set; }
        public long? Idrecep_sample { get; set; }
        public string Source_path { get; set; }
        public long? Idrecep_sample_attach { get; set; }
        public int Attach_status { get; set; }
    }

    public class CAttach_status
    {
        public int Id { get; set; } 
        public string Name_status { get; set; }
    }

    public class CContact
    {
        public long Idrecep_company_person { get; set; }
        public short? Idperson { get; set; }
        public short? Idcompany { get; set; }
        public long? Idrecep_sample { get; set; }

        public string Allname { get; set; }
        public string Mail { get; set; }
        public short? Person_type { get; set; }
        public string Phone { get; set; }
        public string Cellphone { get; set; }
    }

    public class CPerson_type
    {
        public short Id { get; set; }
        public string Name { get; set; }
    }

    public class CReception_template_method
    {
        public int? Idelement { get; set; }
        public long? Idtemplate_method { get; set;}
        public string Cod_template_method { get; set; }
        public string Title { get; set; }
        public string Abbreviation { get; set; }
        public char? Type_analisys { get; set; }
        public string Name_type_analisys { get; set; }
        public string Cod_type_sample { get; set; }
        public decimal? Cost_method { get; set; }
        public int? Idunit_result { get; set; }
        public string Name_unit { get; set; }
        public decimal? Analisys_time { get; set; }
        public string Cod_element { get; set; }
    }

    public class CReception_detail_description
    {
        public long Idrecep_sample_detail { get; set; }
	    public short Order_sample { get; set; }
	    public string Cod_des_sample { get; set; }
	    public string Description { get; set; }
	    public string Cod_type_sample { get; set; }
	    public string Name_type_sample { get; set; }
	    public string Procedence { get; set; }
	    public string Cod_sample { get; set; }
	    public string Name_sample { get; set; }
	    public decimal Amount_weight { get; set; }
        public bool Flag_envelope_sealed { get; set; }
	    public bool Flag_reject { get; set; }
	    public decimal Analisys_time { get; set; }
	    public decimal Cost_sample { get; set; }
	    public long Idrecep_sample { get; set; }
        public short Flag_counter_sample { get; set; }
        public long Cod_interno { get; set; }
    }

    public class CReception_detail_elem
    {
        public long Idrecep_sample_detail_elem { get; set; }
        public long Idrecep_sample { get; set; }
        public long Idrecep_sample_detail { get; set; }
        public short Idelement { get; set; }
        public int Idtemplate_method { get; set; }
        public string Cod_element { get; set; }
        public string Abbreviation { get; set; }
        public decimal Result_analysis { get; set; }
        public string Str_result_analysis { get; set; }
        public string Cod_template_method { get; set; }
    }
}
