using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LimsProject.BusinessLayer.Modules
{
    public class ModPreparationSamples
    {
        
    }

    public class CPrepSamplesGrid
    {
        public bool Sel { get; set; }
        public string Cod_sample { get; set; }
        public bool Flag_humidity_analysis { get; set; }    // informativo
        public bool Flag_reject { get; set; }               // informativo
        public short? Flag_counter_sample { get; set; }     // informativo           

        public int Idprep_samples { get; set; }
        public long Idrecep_sample_detail { get; set; }
        public bool Flag_60celsius { get; set; }           // informativo

        // entrada y salida de la muestra
        public DateTime Input_sample_date { get; set; }
        public string Input_sample_user { get; set; }

        public decimal Weight_gross { get; set; }
        public decimal Weight_gross_date { get; set; }
        public string Weight_gross_user { get; set; }

        // determinación de humedad
        public decimal Weight_moisture { get; set; }
        public decimal Weight_moisture_date { get; set; }
        public string Weight_moisture_user { get; set; }

        public decimal Weight_dry { get; set; }
        public DateTime Weight_dry_date { get; set; }
        public string Weight_dry_user { get; set; }

        public decimal Percent_moisture { get; set; }

        public bool Moisture_reject { get; set; }
        public DateTime Moisture_reject_date { get; set; }
        public string Moisture_reject_user { get; set; }

        // peso de rechazo para almacenamiento
        public decimal Weight_gross_reject { get; set; }
        public DateTime Weight_gross_reject_date { get; set; }
        public string Weight_gross_reject_user { get; set; }

        // marcar salida de muestra, contramuestra y rechazo
        public DateTime Output_date_sample { get; set; } // a ataque
        public string Output_user_sample { get; set; }   // a ataque
        public DateTime Output_date_cs { get; set; }    // contramuestra
        public string Output_user_cs { get; set; }       // contramuestra
        public DateTime Output_date_re { get; set; }    // rechazo
        public string Output_user_re { get; set; }       // rechazo

        public string Observation1 { get; set; }

        // entrada y salida almacen
        public DateTime Store_input_date_cs { get; set; }
        public string Store_input_user_cs { get; set; }

        public DateTime Store_input_date_re { get; set; }
        public string Store_input_user_re { get; set; }

        public DateTime Store_output_date_cs { get; set; }
        public string Store_output_user_cs { get; set; }

        public DateTime Store_output_date_re { get; set; }
        public string Store_output_user_re { get; set; }

        public string Observation2 { get; set; }
    }
}
