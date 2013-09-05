using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LimsProject.BusinessLayer.Modules
{
    public class ModMaterialReference
    {
        public List<CMr_detail> SelectByMr(short idmr)
        {
            return new CMr_detailFactory().GetAll().Where(x => x.Idmr == idmr).ToList();
        }

        public List<CMr_jar> GetJarByMr(short idmr)
        {
            return new CMr_jarFactory().GetAll().Where(x => x.Idmr == idmr).ToList();
        }
    }
}
