using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazilimMimarisiDiyetisyen1.Abstract;

namespace yazilimMimarisiDiyetisyen1.veri
{
    public class Hasta
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public IHastalik Hastaligi { get; set; }
        public IDiyet Diyeti { get; set; }
    }
}
