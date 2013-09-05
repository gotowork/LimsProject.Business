using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace LimsProject.BusinessLayer.Modules
{    

    public class ModPrice
    {
        public int GetNextNumVersion(int idprice)
        {
            List<CPrice_version> lstPrice =
                new CPrice_versionFactory()
                .GetAll()
                .Where(c => c.Idprice == idprice).ToList();

            if (lstPrice.Count > 0)
                return Convert.ToInt32(lstPrice.Max(c => c.Num_version));
            return 1;
        }

        public CPrice_version GetPrice_version(int idprice)
        {
            List<CPrice_version> lstPriceVersion =
                new CPrice_versionFactory()
                .GetAll()
                .Where(c => c.Idprice == idprice && c.Status_price == 1).ToList();

            if (lstPriceVersion.Count > 0)
                return lstPriceVersion.First();
            return null;
        }

        public List<CPrice_version_detail> GetLstPrice_version_detail(int idprice_version)
        {
            List<CPrice_version_detail> lst = 
                (from m in new CPrice_version_detailFactory().GetAll()
                 where m.Idprice_version == idprice_version
                 select m).ToList();

            return lst;
        }

        public DataTable GetDTPrice_version_detail(CPrice_version price_version)
        {
            return ToDataTable<PriceMethod>(GetPriceMethod(price_version));
        }

        public List<CHistoryDetailPrice> GetPrice_history(int idcompany)
        {
            List<CHistoryDetailPrice> lst =
                (from m in new CPrice_version_detailFactory().GetAll()
                 join n in new CPrice_versionFactory().GetAll() on m.Idprice_version equals n.Idprice_version
                 where n.Idcompany == idcompany
                 select new CHistoryDetailPrice { 
                     Idtemplate_method = Convert.ToInt32(m.Idtemplate_method),
                     Unit_price = Convert.ToDecimal(m.Unit_price)
                 }).ToList();

            return lst;
        }

        public DataTable GetDTPrice_history(int idcompany)
        {
            return ToDataTable<CHistoryDetailPrice>(GetPrice_history(idcompany));
        }

        public class CHistoryDetailPrice
        {
            public int Idtemplate_method { get; set; }
            public decimal Unit_price { get; set; }
        }

        public CRecep_sample getRecep_sample(CPrice_version p_price_version)
        {
            return new CRecep_sampleFactory()
                .GetByPrimaryKey(new CRecep_sampleKeys(Convert.ToInt64(p_price_version.Idrecep_sample)));            
        }

        public List<CMemo_price> GetMemo(int idprice_version)
        {
            List<CMemo_price> lst =
                (from m in new CMemo_priceFactory().GetAll()
                 where m.Idmemo_price == idprice_version
                 select m).ToList();
            return lst;
        }

        public List<CMemo_price> GetMemoHistory(int idcompany)
        {
            List<CMemo_price> lst =
                (from m in new CMemo_priceFactory().GetAll()
                 select m).ToList();
            return lst;
        }

        public DataTable ToDataTable<T>(IList<T> data)// T is any generic type
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, typeof(string));
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

        public List<CContact_price> GetLstContactsByPrice(long idprice, int idprice_version)
        {
            List<CPrice_company_person> lstPrice_company_person 
                = new CPrice_company_personFactory()
                .GetAll()
                .Where(c => c.Idprice == idprice && c.Idprice_version == idprice_version).ToList();

            List<CPerson> lstPerson = new CPersonFactory().GetAll();
            List<CContact_price> lst = (
                from r in lstPrice_company_person
                join p in lstPerson on r.Idperson equals p.Idperson
                select new CContact_price
                {
                    Idprice_company_person = r.Idprice_company_person,
                    Idprice = idprice,
                    Idcompany = r.Idcompany,
                    Idperson = r.Idperson,
                    Allname = p.Allname,
                    Mail = p.Mail,
                    Phone = p.Phone,
                    Cellphone = p.Cellphone,
                    Person_type = r.Person_type
                }).ToList<CContact_price>();

            return lst;
        }

        public List<CContact_price> GetLstContactsByCompany(short idcompany)
        {
            List<CContact_price> lst =
                (from m in new CCompany_personFactory().GetAll().Where(c => c.Idcompany == idcompany).ToList()
                 from n in new CPersonFactory().GetAll()
                    .Where(c=> c.Idperson == m.Idperson).DefaultIfEmpty()
                 from r in new CCompanyFactory().GetAll()
                    .Where(c => c.Idcompany == idcompany && m.Idcompany == c.Idcompany).DefaultIfEmpty()
                 select new CContact_price
                 {
                     Idprice_company_person = 0,
                     Idprice = 0,
                     Idcompany = r.Idcompany,
                     Idperson = n.Idperson,
                     Allname = n.Allname,
                     Mail = n.Mail,
                     Phone = n.Phone,
                     Cellphone = n.Cellphone,
                     Person_type = 3
                 }).ToList();

            return lst;
        }

        public List<Anexos> GetLstAnexos(CPrice_version price_version)
        {
            if (price_version == null)
            {
                List<Anexos> lst = new List<Anexos>();
                return lst;
            }
            else
            {
                var query = 
                    new CPrice_attachFactory()
                    .GetAll()
                    .Where(c => 
                        c.Idprice == price_version.Idprice 
                        ).ToList();

                List<Anexos> query2 =
                    (from m in query
                     from n in new CPrice_versionFactory().GetAll().Where(c => c.Idprice == m.Idprice && c.Idprice_version == m.Idprice_version).DefaultIfEmpty()
                     where n.Num_version <= price_version.Num_version
                     select new Anexos
                     {
                         Filename = m.Name_document,
                         Idprice = m.Idprice,
                         Idprice_version = m.Idprice_version,
                         Num_version = n.Num_version,
                         Source_filename = ""
                     }).ToList();

                return query2;
            }
        }

        #region master - detail
        
        public List<PriceMethod> GetPriceMethod(CPrice_version price_version)
        {
            if (price_version == null)
            {
                List<PriceMethod> lstPriceMethod = new List<PriceMethod>();                                
                return lstPriceMethod;
            }
            else
            {
                List<CPrice_version_detail> lst =
                    (from m in new CPrice_version_detailFactory().GetAll()
                     where m.Idprice_version == price_version.Idprice_version
                     select m).ToList();

                List<PriceMethod> lstPriceMethod = new List<PriceMethod>();                
                foreach (CPrice_version_detail item in lst)
                {
                    lstPriceMethod.Add(new PriceMethod(item, GetPriceMethodHistory(price_version, item.Idtemplate_method)));
                }
                return lstPriceMethod;
            }
        }

        // --- obtener la ultima version de la cotización
        public BindingList<PriceMethodHistory> GetPriceMethodHistory(CPrice_version price_version, int? idtemplate_method)
        {
            var query =
                (from m in new CPrice_version_detailFactory().GetAll()
                 join n in new CPrice_versionFactory().GetAll() on m.Idprice_version equals n.Idprice_version
                 select m).ToList();

            List<PriceMethodHistory> lst =
                    (from m in new CPrice_version_detailFactory().GetAll()
                     join n in new CPrice_versionFactory().GetAll() on m.Idprice_version equals n.Idprice_version into tmp1
                     from o in tmp1
                     join p in new CPriceFactory().GetAll() on o.Idprice equals p.Idprice
                     where o.Idcompany == price_version.Idcompany && m.Idtemplate_method == idtemplate_method
                        && o.Idprice_version != price_version.Idprice_version
                        && o.Date_creation < price_version.Date_creation
                     select new PriceMethodHistory
                     {
                         Name = "History",
                         Idprice_version = m.Idprice_version,
                         Cod_price = p.Cod_price,
                         Num_version = o.Num_version,
                         Date_creation = o.Date_creation,
                         Amount_item = m.Amount_item,
                         Unit_price = m.Unit_price
                     }).OrderByDescending(c => c.Cod_price).ToList();
            return new BindingList<PriceMethodHistory>(lst);
        }

        public DataTable getDTPriceMethod(List<PriceMethod> lstPriceMethod)
        {            
            DataTable dt = new DataTable();
            dt.Columns.Add("Idprice_version");
            dt.Columns.Add("Idprice_version_detail");
            dt.Columns.Add("Num_item");
            dt.Columns.Add("Idtemplate_method");
            dt.Columns.Add("Den_method");
            dt.Columns.Add("Amount_item");
            dt.Columns.Add("Rank");
            dt.Columns.Add("Unit_price");
            dt.Columns.Add("Sale_price");

            if (lstPriceMethod == null)
                return dt;

            foreach (PriceMethod item in lstPriceMethod)
            {
                DataRow dr = dt.NewRow();
                dr["Idprice_version"] = item.Idprice_version;
                dr["Idprice_version_detail"] = item.Idprice_version_detail;
                dr["Num_item"] = item.Num_item;
                dr["Idtemplate_method"] = item.Idtemplate_method;
                dr["Den_method"] = item.Den_method;
                dr["Amount_item"] = item.Amount_item;
                dr["Rank"] = item.Rank;
                dr["Unit_price"] = item.Unit_price;
                dr["Sale_price"] = item.Sale_price;

                dt.Rows.Add(dr);
            }

            return dt;
        }

        #endregion
    }

    public class Anexos
    {
        public int? Idprice { get; set; }
        public int? Idprice_version { get; set; }
        public string Filename { get; set; }
        public int? Num_version { get; set; }
        public string Source_filename { get; set; }
    }

    public class ListPriceMethod : BindingList<PriceMethod>
    {
        new public void Add(PriceMethod item)
        {
            base.Add(item);
        }
    }

    #region class master-detail   

    public class PriceMethod
    {
        public PriceMethod(CPrice_version_detail version, BindingList<PriceMethodHistory> history)
        {
            Idprice_version = version.Idprice_version;
            Idprice_version_detail = version.Idprice_version_detail;
            Num_item = version.Num_item;
            Idtemplate_method = version.Idtemplate_method;
            CTemplate_method oTemplate_method = new CTemplate_methodFactory().GetByPrimaryKey(new CTemplate_methodKeys(Convert.ToInt32(version.Idtemplate_method)));
            CTemplate_method_aa oTemplate_method_aa = new CTemplate_method_aaFactory().GetByPrimaryKey(new CTemplate_method_aaKeys(Convert.ToInt32(version.Idtemplate_method)));
            Den_method = oTemplate_method.Cod_template_method + " - " + oTemplate_method.Title;
            Amount_item = version.Amount_item;
            Rank = oTemplate_method_aa.Reading_min.ToString() + " - " + oTemplate_method_aa.Reading_max.ToString();
            Unit_price = version.Unit_price;
            Sale_price = version.Sale_price;

            History = history;
        }
        

        public int Idprice_version_detail { get; set; }
        public int? Idprice_version { get; set; }
        public int? Num_item { get; set; }
        public int? Idtemplate_method { get; set; }
        public string Den_method { get; set; }
        public int? Amount_item { get; set; }
        public string Rank { get; set; }
        public decimal? Unit_price { get; set; }
        public decimal? Sale_price { get; set; }        

        public BindingList<PriceMethodHistory> History { get; set;}
    }

    public class PriceMethodHistory
    {
        public string Name { get; set; }
        public int? Idprice_version { get; set; }
        public string Cod_price { get; set; }
        public int? Num_version { get; set; }
        public int? Amount_item { get; set; }
        public decimal? Unit_price { get; set; }
        public DateTime? Date_creation { get; set; }
    }

    #endregion

    public class CContact_price
    {
        public long Idprice_company_person { get; set; }
        public short? Idperson { get; set; }
        public short? Idcompany { get; set; }
        public long? Idprice { get; set; }

        public string Allname { get; set; }
        public string Mail { get; set; }
        public short? Person_type { get; set; }
        public string Phone { get; set; }
        public string Cellphone { get; set; }
    }
}
