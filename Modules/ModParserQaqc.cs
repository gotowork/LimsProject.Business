using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathParserNet;

namespace LimsProject.BusinessLayer.Modules
{
    public class ModParserQaqc
    {   
        // ejemple de expresion pasado como parametro
        string str = "{ABS(LFB-LRB)>=VALUE1*M_LFB},{ABS(LFB-LRB)=VALUE2*M_LFB}";

        public bool EvalConditions(Parser parser, string expression)
        {
            //el parámetro debera ser carbado previamente con las variables
            //parser.AddVariable("LFB", 4.56);

            parser.RegisterCustomDoubleFunction("funMenor", funMenor);
            parser.RegisterCustomDoubleFunction("funMayor", funMayor);
            parser.RegisterCustomDoubleFunction("funIgual", funIgual);
            parser.RegisterCustomDoubleFunction("funMenorIgual", funMenorIgual);
            parser.RegisterCustomDoubleFunction("funMayorIgual", funMayorIgual);

            try
            {
                List<string> conditions = ExtractConditions(expression);

                foreach (string equation in conditions)
                {
                    if (parser.SimplifyDouble(equation) == 0)
                        return false;
                }
                return true;
            }
            catch {
                throw new Exception("Error en la expresión de condicionales.");
            }
        }

        public List<string> ExtractConditions(string strCondition)
        {
            List<string> lstCondition = new List<string>();

            //parsear expresiones, separar condicionales
            string[] arrayCondition = strCondition.Split(',');

            foreach (string str in arrayCondition)
            {
                string strExpresion = str
                    .Replace("{", "")
                    .Replace("}", "")
                    .Replace("<=", "[LTE]")
                    .Replace(">=", "[GTE]")
                    .Replace("<", "[LT]")
                    .Replace(">", "[GT]")
                    .Replace("=", "[ET]");
                string strNew = "";

                // quitar ambiguedades                

                // formatear a funcion de menor, mayor o igual
                string[] operandos = strExpresion.Split(new string[] { "[LTE]", "[GTE]", "[LT]", "[GT]", "[ET]" }, StringSplitOptions.RemoveEmptyEntries);

                if (strExpresion.Contains("[LT]"))
                    strNew = string.Format("funMenor({0},{1})", operandos[0], operandos[1]);
                if (strExpresion.Contains("[GT]"))
                    strNew = string.Format("funMayor({0},{1})", operandos[0], operandos[1]);
                if (strExpresion.Contains("[ET]"))
                    strNew = string.Format("funIgual({0},{1})", operandos[0], operandos[1]);
                if (strExpresion.Contains("[LTE]"))
                    strNew = string.Format("funMenorIgual({0},{1})", operandos[0], operandos[1]);
                if (strExpresion.Contains("[GTE]"))
                    strNew = string.Format("funMayorIgual({0},{1})", operandos[0], operandos[1]);

                lstCondition.Add(strNew);
            }

            return lstCondition;
        }         

        double funMenor(double v1, double v2)
        {
            if (v1 < v2)
                return 1;
            return 0;
        }

        double funMayor(double v1, double v2)
        {
            if (v1 > v2)
                return 1;
            return 0;
        }

        double funIgual(double v1, double v2)
        {
            if (v1 == v2)
                return 1;
            return 0;
        }

        static double funMenorIgual(double v1, double v2)
        {
            if (v1 <= v2)
                return 1;
            return 0;
        }

        static double funMayorIgual(double v1, double v2)
        {
            if (v1 >= v2)
                return 1;
            return 0;
        }

        //public Dictionary<string, bool> GetResultConditions(List<string> conditions)
        //{
        //    Dictionary<string, bool> dic = new Dictionary<string, bool>();

        //    foreach (string equation in conditions)
        //        dic.Add(equation, parser.SimplifyInt(equation) == 1 ? true : false);

        //    return dic;
        //}
                
    }

    public class Condition
    {
        public string Expresion { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
    }
}
