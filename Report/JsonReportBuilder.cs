using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using yazilimMimarisiDiyetisyen1.veri;


namespace yazilimMimarisiDiyetisyen1.Report
{
    public class JsonReportBuilder: ReportBuilderBase
    {
        
        public JsonReportBuilder(Hasta hasta) : base(hasta) { }
        public override string BuildDiyetInfo()
        {
            return JsonConvert.SerializeObject(Hasta.Diyeti);
        }

        public override string BuildHastaInfo()
        {
            HastaInfo h = new HastaInfo();
            h.Adi = Hasta.Ad;
            h.Soyadi = Hasta.Soyad;
            h.Tc = Hasta.Tc;
            return JsonConvert.SerializeObject(h);
        }
    }
}
