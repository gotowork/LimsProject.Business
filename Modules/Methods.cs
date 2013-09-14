using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LimsProject.BusinessLayer;

namespace LimsProject.BusinessLayer.Modules
{
    public class Methods
    {
        public List<CCustomMr_detail> GetByElement(short idelement)
        {    
            List<CMr> lstMr = new CMrFactory().GetAll().Where(c => c.Status_mr == true).ToList();
            List<CMr_detail> lstMr_detail = new CMr_detailFactory().GetAll().Where(c=> c.Analyte == idelement).ToList();

            List<CCustomMr_detail> lst = (from t1 in lstMr
                                          join t2 in lstMr_detail on t1.Idmr equals t2.Idmr
                                          select new CCustomMr_detail
                                          {
                                              Cod_mr = t1.Cod_mr,
                                              Idmr = t1.Idmr,
                                              Idmr_detail = t2.Idmr_detail
                                          }).ToList<CCustomMr_detail>();
            return lst;
        }

        public List<CCustom_template_method> GetAll(int? idelement, string cod_type_sample, char? type_analysis)
        {
            // --- get last version           
            List<CTemplate_method> lstTemplate_method = new CTemplate_methodFactory().GetAll();            

            // --- get last version            
            var maxVersionTemplate =
                (from t1 in lstTemplate_method
                 where (t1.Idelement == idelement || idelement == null) && 
                       (t1.Cod_type_sample == cod_type_sample || cod_type_sample == null) && 
                       (t1.Type_analisys == type_analysis || type_analysis == null)
                 group t1 by new { t1.Idelement, t1.Cod_type_sample, t1.Type_analisys }
                     into grp
                     select new
                     {
                         grp.Key.Idelement,
                         grp.Key.Cod_type_sample,
                         grp.Key.Type_analisys,
                         MaxIdtemplate_method = grp.Max(c => c.Idtemplate_method)
                     }).ToList();

            // --- get final query
            List<CCustom_template_method> lstCustom =
                (from t1 in lstTemplate_method
                 join t2 in maxVersionTemplate on t1.Idtemplate_method equals t2.MaxIdtemplate_method
                 select new CCustom_template_method
                 {
                     Idtemplate_method = t1.Idtemplate_method,
                     Cod_template_method = t1.Cod_template_method,
                     Repetition = CaseRepetition(t1.Cod_repetition),
                     Title = t1.Title,
                     Abbreviation = t1.Abbreviation
                 }).ToList<CCustom_template_method>();

            return lstCustom;
        }

        public List<CTemplate_method> GetAllLastVersionMethods()
        {
            List<CTemplate_method> lstTemplate = new CTemplate_methodFactory().GetAll();
            List<CTemplate_method> lstTemplateVersion =
               (from t1 in lstTemplate
                group t1 by new { t1.Cod_template_method, t1.Abbreviation, t1.Cod_repetition, t1.Cod_digestion_method, t1.Title }
                    into grp
                    select new CTemplate_method
                    {                        
                        Cod_template_method = grp.Key.Cod_template_method,
                        Abbreviation = grp.Key.Abbreviation,
                        Cod_repetition =  grp.Key.Cod_repetition,
                        Cod_digestion_method = grp.Key.Cod_digestion_method,
                        Idtemplate_method = grp.Max(c => c.Idtemplate_method),
                        Title = grp.Key.Cod_template_method + " - " + grp.Key.Title
                    }).ToList<CTemplate_method>();
            

            return (from t1 in lstTemplateVersion
                    join t2 in lstTemplate on t1.Idtemplate_method equals t2.Idtemplate_method                    
                    orderby t2.Cod_template_method
                    select t2).ToList<CTemplate_method>();
        }

        public List<CTemplate_method> GetAllLastVersionMethods(int? idelement, string cod_type_sample, char? type_analysis)
        {
            return (from t1 in GetAllLastVersionMethods()
                    where (t1.Idelement == idelement || idelement == null) &&
                       (t1.Cod_type_sample == cod_type_sample || cod_type_sample == null) &&
                       (t1.Type_analisys == type_analysis || type_analysis == null)
                    select t1).ToList<CTemplate_method>();
        }

        public List<CTemplate_method> GetAllLastVersionMethods(int? idelement, string cod_type_sample)
        {
            return (from t1 in GetAllLastVersionMethods()
                    where (t1.Idelement == idelement || idelement == null) &&
                       (t1.Cod_type_sample == cod_type_sample || cod_type_sample == null)                       
                    select t1).ToList<CTemplate_method>();
        }

        public string CaseRepetition(short? cod_repetition)
        {
            string result = "";
            switch (cod_repetition)
            {
                case 1:
                    result = "Simple";
                    break;
                case 2:
                    result = "Duplicado";
                    break;
                case 3:
                    result = "Triplicado";
                    break;
                case 4:
                    result = "Lote";
                    break;
                case 8:
                    result = "Dirimencia";
                    break;
            }
            return result;
        }

        public string CaseTypeAnalysis(char? type_analysis)
        {
            string result = "";
            switch (type_analysis)
            {
                case '1':
                    result = "Absorción atómica";
                    break;
                case '2':
                    result = "Volumetría";
                    break;
                case '3':
                    result = "Gravimetría";
                    break;
                case '4':
                    result = "newmont-AA";
                    break;
                case '5':
                    result = "newmont-grav";
                    break;
            }
            return result;
        }

        public string CaseTypeSample(string cod_type_sample)
        {
            return new CType_sampleFactory().GetByPrimaryKey(new CType_sampleKeys(cod_type_sample)).Name_type_sample;            
        }

        public string CaseDigestion(string cod_digestion)
        {
            return new CDigestion_methodFactory().GetByPrimaryKey(new CDigestion_methodKeys(cod_digestion)).Name_digestion_method;
        }

        public string CaseUnitMeasure(short? idunit_measure)
        {
            return new CMeasurement_unitFactory().GetByPrimaryKey(new CMeasurement_unitKeys(Convert.ToInt16(idunit_measure))).Name_unit;
        }        

        public short GetNumNewVersion(int idtemplate_method)
        {
            // --- get last version
            short num_version = new CTemplate_methodFactory().GetAll().Where(c => c.Idtemplate_method == idtemplate_method).Max(d => Convert.ToInt16(d.Num_version));
            num_version++;
            return num_version;
        }

        public List<CAbsorcionAtomica> GetMethodsAbsorcionAtomica(int idtemplate_method)
        {
            List<CTemplate_method> lstTemplate_method = new CTemplate_methodFactory().GetAll().Where(c=> c.Idtemplate_method == idtemplate_method).ToList();
            List<CTemplate_method_aa> lstTemplate_method_aa = new CTemplate_method_aaFactory().GetAll().Where(c=> c.Idtemplate_method == idtemplate_method).ToList();

            return (from t1 in lstTemplate_method
                    join t2 in lstTemplate_method_aa on t1.Idtemplate_method equals t2.Idtemplate_method
                    where t1.Idtemplate_method == t2.Idtemplate_method
                    select new CAbsorcionAtomica { 
                        Idtemplate_method = t1.Idtemplate_method,
                        Num_version = t1.Num_version,
                        Cod_template_method = t1.Cod_template_method,
                        Name_repetition = CaseRepetition(t1.Cod_repetition),
                        Title = t1.Title,
                        Abbreviation = t1.Abbreviation,                        
                        Name_type_analysis = CaseTypeAnalysis(t1.Type_analisys),
                        Name_type_sample = CaseTypeSample(t1.Cod_type_sample),
                        Name_digestion = CaseDigestion(t1.Cod_digestion_method),
                        Name_unit_result = CaseUnitMeasure(t2.Idunit_result),

                        Weight = t2.Weight,
                        Volumen = t2.Volumen,
                        Reading_min = t2.Reading_min,
                        Reading_max = t2.Reading_max,
                        Dilution2 = t2.Dilution2,
                        Dilution3 = t2.Dilution3,
                        Reason_rep = t2.Reason_rep,
                        Law_limit_bottom = t2.Law_limit_bottom,
                        Law_limit_top = t2.Law_limit_top,
                        Name_unit_calib = CaseUnitMeasure(t2.Idunit_calib)
                    }
                        ).ToList<CAbsorcionAtomica>();
        }

        public decimal GetFactorConvertionUM(int idtemplate_method)
        {
            /*
             SELECT INTO v_factor t3.factor
	FROM template_method t1
		INNER JOIN template_method_aa t2
			ON t1.idtemplate_method = t2.idtemplate_method 
		INNER JOIN convert_unit_measurement t3
			ON t1.idunit_result = t3.idunit2 AND
			t2.idunit_calib = t3.idunit1
	WHERE t1.idtemplate_method = p_idtemplate_method;
			
	RETURN v_factor;	              
             */

            var query = (from t1 in GetAllLastVersionMethods()
                         join t2 in new CTemplate_method_aaFactory().GetAll() on t1.Idtemplate_method equals t2.Idtemplate_method
                         where t1.Idtemplate_method == idtemplate_method
                         select new
                         {
                             idtemplate_method = t1.Idtemplate_method,
                             idunit_result = t2.Idunit_result,
                             idunit_calib = t2.Idunit_calib
                         }).Distinct();

            short idunit_result = 0, idunit_calib = 0;
            decimal factor = 1;

            foreach (var item in query)
            {
                idunit_result = Convert.ToInt16(item.idunit_result);
                idunit_calib = Convert.ToInt16(item.idunit_calib);
                break;
            }

            List<CConvert_unit_measurement> lst = new CConvert_unit_measurementFactory().GetAll();
            foreach (CConvert_unit_measurement item in lst)
            {
                if (item.Idunit1 == idunit_calib && item.Idunit2 == idunit_result)
                    factor = Convert.ToDecimal(item.Factor);
            }

            return factor;
        }


    }

    public class CCustomMr_detail
    {
        public int Idmr { get; set; }
        public string Cod_mr { get; set; }
        public short Idmr_detail { get; set; }
    }

    public class CCustom_template_method
    {
        public long Idtemplate_method { get; set; }
        public string Cod_template_method { get; set; }
        public string Repetition { get; set; }
        public string Title { get; set; }
        public string Abbreviation { get; set; }
    }

    public class CAbsorcionAtomica
    {
        public long Idtemplate_method { get; set; }
        public short? Num_version { get; set; }
        public string Cod_template_method { get; set; }
        public string Name_repetition { get; set; }
        public string Title { get; set; }
        public string Abbreviation { get; set; }        
        public string Name_type_analysis { get; set; }
        public string Name_type_sample { get; set; }
        public string Name_digestion { get; set; }
        public string Name_unit_result { get; set; }

        public decimal? Weight { get; set; }
        public decimal? Volumen { get; set; }
        public decimal? Reading_min { get; set; }
        public decimal? Reading_max { get; set; }
        public decimal? Dilution2 { get; set; }
        public decimal? Dilution3 { get; set; }
        public decimal? Reason_rep { get; set; }
        public decimal? Law_limit_bottom { get; set; }
        public decimal? Law_limit_top { get; set; }
        public string Name_unit_calib { get; set; }
    }
}
