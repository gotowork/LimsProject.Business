using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryBasicForm.Util;

namespace LimsProject.BusinessLayer.Modules
{
    public class ModMasterSearch
    {

        #region register reception

        public CParameterIList GetRegReception(short? p_year, short? p_idcompany, DateTime? p_date_begin, DateTime? p_date_end)
        {
            CParameterIList parameter = new CParameterIList();

            parameter.Keys.Add("Idrecep_sample");
            
            parameter.Fields.Add("Idrecep_sample", "");
            parameter.Fields.Add("Cod_recep_sample", "Código");
            parameter.Fields.Add("Date_reception", "Fecha de recepción");                      
            parameter.Fields.Add("Date_result", "Fecha de resultado");
            parameter.Fields.Add("Business_name", "Cliente");

            /*
            SELECT cast('' as varchar), t1.*
	        FROM public.recep_sample t1
	        WHERE 	(p_year IS NULL OR CAST(p_year AS VARCHAR) = cod_serie)
		        AND (p_idcompany IS NULL OR p_idcompany = t1.idcompany)		
		        AND (
		           (p_date_begin IS NOT NULL AND p_date_end IS NOT NULL AND (t1.date_reception BETWEEN p_date_begin AND p_date_end)) OR
		           (p_date_begin IS NOT NULL AND p_date_end IS NULL AND (t1.date_reception >= p_date_begin)) OR
		           (p_date_begin IS NULL AND p_date_end IS NOT NULL AND (t1.date_reception <= p_date_end)) OR
		           (p_date_begin IS NULL AND p_date_end IS NULL)
		        )
		        AND flag_isprice = false;	
            */

            var queryFilter =
                (from m in new CRecep_sampleFactory().GetAll()
                 where (p_year == null || p_year.ToString() == m.Cod_serie)
                     && (p_idcompany == null || p_idcompany == m.Idcompany)
                     && (
                         (p_date_begin != null && p_date_end != null && (m.Date_reception >= p_date_begin && m.Date_reception < p_date_end)) ||
                         (p_date_begin != null && p_date_end == null && (m.Date_reception >= p_date_begin)) ||
                         (p_date_begin == null && p_date_end != null && (m.Date_reception <= p_date_end)) ||
                         (p_date_begin == null && p_date_end == null)
                     )
                     && m.Flag_isprice == false
                 select m).ToList();

            var lstReception =
                (from m in queryFilter
                 select new 
                 {
                     Select = "",
                     Idrecep_sample = m.Idrecep_sample,
                     Cod_recep_sample = m.Cod_recep_sample,
                     Date_reception = m.Date_reception,
                     Idcompany = m.Idcompany,
                     Cod_serie = m.Cod_serie,
                     Usernew = m.Usernew,
                     Datenew = m.Datenew,
                     Useredit = m.Useredit,
                     Dateedit = m.Dateedit,                     
                     Date_result = m.Date_result,
                     Cod_type_sample = m.Cod_type_sample,
                     Total_amount = m.Total_amount,
                     Total_igv = m.Total_igv,
                     Total_amount_igv = m.Total_amount_igv,
                     Amortization = m.Amortization,
                     Flag_isprice = m.Flag_isprice
                 }).ToList();

            var query =
                (from m in lstReception
                 join n in new CCompanyFactory().GetAll() on m.Idcompany equals n.Idcompany
                 select new 
                 {
                     m.Select,
                     m.Idrecep_sample,
                     m.Cod_recep_sample,
                     n.Business_name,
                     m.Date_reception,
                     m.Date_result                     
                 }).ToList();

            parameter.ResultSearch = query;

            return parameter;
        }

        #endregion

        #region prices

        public struct KeyFilterPrice
        {
            public string Company;
            public string Nombre;
            public DateTime? DateIni;
            public DateTime? DateEnd;
            public int? Status;
        }

        public CParameterIList GetPrices(KeyFilterPrice keyFilter)
        {
            CParameterIList parameter = new CParameterIList();

            parameter.Keys.Add("Idprice_version");
            parameter.Keys.Add("Idprice");
            parameter.Keys.Add("Idrecep_sample");

            parameter.Fields.Add("Cod_price", "Código");
            parameter.Fields.Add("Date_creation", "Fecha de creación");
            parameter.Fields.Add("Date_expiration", "Fecha de expiración");
            parameter.Fields.Add("User_creation", "Usuario de creación");
            parameter.Fields.Add("Idprice_version", "");
            parameter.Fields.Add("Idprice", "");
            parameter.Fields.Add("Idrecep_sample", "");
            parameter.Fields.Add("Num_version", "Versión");
            parameter.Fields.Add("Status_price", "");
            parameter.Fields.Add("Allname", "Atención");
            parameter.Fields.Add("Business_name", "Empresa");

            // --- concatenar nombres de personas
            //var query = 
            //    (from m in new CPersonFactory().GetAll()
            //     from n in new CPrice_company_personFactory().GetAll().Where(c=> c.Idperson == m.Idperson).ToList()
            //     group by 

            // --- filtrar solo contactos del tipo atención
            var lstCompanyContact =
                (from m in new CPersonFactory().GetAll()
                 join n in new CPrice_company_personFactory().GetAll().Where(c => c.Person_type == 3)
                    on m.Idperson equals n.Idperson into tmp
                 from t in tmp
                 join p in new CCompanyFactory().GetAll() on t.Idcompany equals p.Idcompany
                 where p.Business_name.Contains(keyFilter.Company)
                 && m.Allname.Contains(keyFilter.Nombre)
                 select new
                 {
                     t.Idprice,
                     t.Idprice_version,
                     m.Idperson,
                     m.Allname,
                     p.Idcompany,
                     p.Business_name
                 }).ToList();


            var lstPrices =
                (from m in new CPriceFactory().GetAll()
                 join n in new CPrice_versionFactory().GetAll() on m.Idprice equals n.Idprice into tmp
                 from q in tmp
                 join t in lstCompanyContact on q.Idprice_version equals t.Idprice_version
                 where (q.Date_creation > keyFilter.DateIni || keyFilter.DateIni == null)
                 && (q.Date_creation < keyFilter.DateEnd || keyFilter.DateEnd == null)
                 && (q.Status_price == keyFilter.Status || keyFilter.Status == 0 || keyFilter.Status == null)
                 select new
                 {
                     Select = "",
                     m.Cod_price,
                     q.Num_version,
                     q.Date_creation,
                     q.User_creation,
                     q.Idprice_version,
                     q.Idprice,
                     q.Idrecep_sample,
                     q.Status_price,
                     t.Allname,
                     t.Business_name
                 }).Distinct().ToList();

            parameter.ResultSearch = lstPrices;

            return parameter;
        }

        #endregion

        #region decree

        public CParameterIList GetDecrees()
        {
            CParameterIList parameter = new CParameterIList();

            parameter.Keys.Add("Iddecree");
            
            parameter.Fields.Add("Cod_decree", "Código");
            parameter.Fields.Add("Name_decree", "Nombre");
            parameter.Fields.Add("Description", "Descripción");
            
            // --- filtrar solo contactos del tipo atención
            var lstDecree =
                (from m in new CDecreeFactory().GetAll()
                 select new {
                     Select = "",
                     m.Iddecree,
                     m.Cod_decree,
                     m.Name_decree,
                     m.Description
                 }).ToList();

            parameter.ResultSearch = lstDecree;

            return parameter;
        }

        #endregion
    }    
}
