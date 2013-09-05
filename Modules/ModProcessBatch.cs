using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LimsProject.BusinessLayer.Modules
{
    public class ModProcessBatch
    {
        public CTrace_batch GetLastProcessBatch(string process, long idbatch)
        {
            /*
            SELECT *
	        FROM public.trace_batch
	        WHERE cod_process = p_cod_process 
		        AND idbatch = p_idbatch 
		        AND cod_process = p_cod_process
		        AND status_process in ('W', 'P')
	        ORDER BY idtrace_batch, date_in desc
	        LIMIT 1;
            */
            return new CTrace_batchFactory()
                .GetAll()
                .Where(c => c.Cod_process == process
                    && c.Idbatch == idbatch
                    && c.Status_process == 'W' || c.Status_process == 'P')
                    .OrderBy(c => c.Idtrace_batch)
                    .OrderByDescending(c => c.Date_in).FirstOrDefault();

        }

        public Dictionary<string, string> GetCurrentAndBelow(long idbatch, string process)
        { 
            /*
            CREATE TEMP TABLE tmp_batch_P013 ON COMMIT DROP AS 
	        SELECT idbatch, cod_module, cod_process,
		        useredit as user_approved, dateedit as date_approved, status_process
	        FROM trace_batch
	        WHERE idbatch = p_idbatch
		        AND cod_process = 'P013';

	        CREATE TEMP TABLE tmp_batch_P014 ON COMMIT DROP AS
	        SELECT idbatch, cod_module, cod_process,
		        useredit as user_revised, dateedit as date_revised, status_process
	        FROM trace_batch
	        WHERE idbatch = p_idbatch
		        AND cod_process = 'P014';
		
	        RETURN QUERY
	        SELECT DISTINCT t1.idbatch, t1.cod_module, t1.cod_process, t1.status_process
		        , t5.user_approved, t5.date_approved, t6.user_revised, t6.date_revised
		        , CAST(CASE
			        WHEN t1.idbatch = p_idbatch THEN 1
			        ELSE 0
		          END AS BOOLEAN) AS flag_current_batch
	        FROM batch t1
		        LEFT OUTER JOIN tmp_batch_P013 t5
			        ON t1.idbatch = t5.idbatch
		        LEFT OUTER JOIN tmp_batch_P014 t6
			        ON t1.idbatch = t6.idbatch
	        WHERE t1.idbatch = p_idbatch;
             */
            var tmp_batch_P013 = new CTrace_batchFactory().GetAll().Where(x => x.Idbatch == idbatch && x.Cod_process == "P013");
            var tmp_batch_P014 = new CTrace_batchFactory().GetAll().Where(x => x.Idbatch == idbatch && x.Cod_process == "P014");

            var query =
                (from m in new CBatchFactory().GetAll().Where(x=> x.Idbatch == idbatch)
                 join n in tmp_batch_P013 on m.Idbatch equals n.Idbatch into mn
                 from p in mn.DefaultIfEmpty()
                 join q in tmp_batch_P014 on p.Idbatch equals q.Idbatch into pq
                 from r in pq.DefaultIfEmpty()                 
                 select new
                 {
                     m.Idbatch,
                     m.Cod_module,
                     m.Cod_process,
                     m.Status_process,
                     User_approved = p.Useredit,
                     Date_approved = p.Dateedit,
                     User_revised = r.Useredit,
                     Date_revised = r.Dateedit,
                     Flag_current_batch = m.Idbatch == idbatch ? 1 : 0
                 }).ToList();

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("User_approved", query[0].User_approved);
            dic.Add("Date_approved", query[0].Date_approved.ToString());
            dic.Add("User_revised", query[0].User_revised);
            dic.Add("Date_revised", query[0].Date_revised.ToString());

            return dic;
        }
    }
}
