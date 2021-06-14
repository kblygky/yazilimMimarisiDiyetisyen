using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazilimMimarisiDiyetisyen1.veri;

namespace yazilimMimarisiDiyetisyen1.Report
{
    public abstract class ReportBuilderBase
    {
        protected Hasta Hasta;
        public ReportBuilderBase(Hasta hasta)
        {
            Hasta = hasta;
        }
        public string BuildOutput()
        {
            string output = BuildHastaInfo();
            output += BuildDiyetInfo();
            return output;
        }
        public abstract string BuildHastaInfo();
        public abstract string BuildDiyetInfo();
    }
}
