using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazilimMimarisiDiyetisyen1.Abstract;

namespace yazilimMimarisiDiyetisyen1.Diyetler
{
    class DenizUrunleri : IDiyet
    {
        public string DiyetAdi { get; }
        public string DiyetAciklamasi { get; set; }

        public DenizUrunleri()
        {
            DiyetAdi = "Deniz Ürünleri";
            DiyetAciklamasi = "Akdeniz diyeti kurallı bir diyet planı yerine yemek yemeyi temel alan bir beslenme planıdır.";
        }
    }
}
