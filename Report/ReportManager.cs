using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimMimarisiDiyetisyen1.Report
{
    public class ReportManager
    {
        private ReportBuilderBase Builder;
        public ReportManager(ReportBuilderBase builder)
        {
            Builder = builder;
        }
        public string Build()
        {
            string rapor = Builder.BuildOutput();
            return rapor;
        }
        public string BuildReverse()
        {
            string rapor = Builder.BuildDiyetInfo();
            rapor += Builder.BuildHastaInfo();
            return rapor;
        }
    }
}
