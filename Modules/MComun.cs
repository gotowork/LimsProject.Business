using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LimsProject.BusinessLayer.Modules
{
    public static class MComun
    {
        public static string FormatCorrelativeCode(string prefix, long num, int num_digits)
        {
            return prefix + num.ToString().PadLeft(num_digits, '0');
        }

        public enum SampleCameFrom
        {
            NewSample,
            QaqcSampleRetest,
            QaqcFullBatchRetest
        }
    }
}
