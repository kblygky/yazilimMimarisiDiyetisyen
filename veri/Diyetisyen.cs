using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimMimarisiDiyetisyen1.veri
{
    class Diyetisyen
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sifre { get; set; }
        public List<Hasta> Hastalar { get; set; }
    }
}
