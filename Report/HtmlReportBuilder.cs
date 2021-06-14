using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazilimMimarisiDiyetisyen1.veri;

namespace yazilimMimarisiDiyetisyen1.Report
{
    public class HtmlReportBuilder : ReportBuilderBase
    {
        public HtmlReportBuilder(Hasta hasta): base(hasta) { }
        public override string BuildHastaInfo()
        {
            return string.Format("<h1>Diyet Bilgileri</h1><h2>Diyet adı: " + this.Hasta.Diyeti.DiyetAdi + "</h2>" + "<h2>" + this.Hasta.Diyeti.DiyetAciklamasi + "</h2>");
        }
        public override string BuildDiyetInfo()
        {
            return string.Format("<h1>Hasta Bilgileri</h1><h2>adı: " +this.Hasta.Ad + "</h2>"+"<h2>soyadı: "+ this.Hasta.Soyad+"</h2>" + "<h2>tc: " + this.Hasta.Tc + "</h2>" + "<h2>Hastalık: " + this.Hasta.Hastaligi.HastalikAdi + "</h2>");
        }
    }
}
