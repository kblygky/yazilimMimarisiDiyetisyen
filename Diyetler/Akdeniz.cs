using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazilimMimarisiDiyetisyen1.Abstract;

namespace yazilimMimarisiDiyetisyen1.Diyetler
{
    class Akdeniz:IDiyet
    {
        
        public string DiyetAdi { get ; }
        public string DiyetAciklamasi { get; set; }
       
        public Akdeniz()
        {
            DiyetAdi = "Akdeniz";
            DiyetAciklamasi = "Akdeniz diyeti kurallı bir diyet planı yerine yemek yemeyi temel alan bir beslenme planıdır. Akdeniz’e komşu ülkelerin geleneksel pişirme ve yemek yeme alışkanlıklarına dayanan bir beslenme şeklidir";
        }
    }
}
