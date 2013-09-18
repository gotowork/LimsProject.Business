using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace LimsProject.BusinessLayer.Modules
{
    public class ModSolInterm
    {

        public List<CSolution> GetLstSolution(CGroup_solution p_group_solution)
        {            
            List<CSolution> lst = 
                (from m in new CSolutionFactory().GetAll()
                 where m.Idgroup_solution == p_group_solution.Idgroup_solution
                 select m).ToList();

            return lst;
        }

        public List<CSolution> GetLstSolution(short? idelement, int type_pattern)
        {
            List<CSolution> lst =
                (from m in new CSolutionFactory().GetAll()
                 from n in new CGroup_solutionFactory().GetAll().Where(x=> x.Idgroup_solution == m.Idgroup_solution)
                 where n.Idelement == idelement && n.Type_pattern == type_pattern
                 select m).ToList();

            return lst;
        }
    }
}
