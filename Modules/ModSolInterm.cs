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
    }
}
