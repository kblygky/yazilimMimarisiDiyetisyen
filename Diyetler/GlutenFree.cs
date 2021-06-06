using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazilimMimarisiDiyetisyen1.Abstract;

namespace yazilimMimarisiDiyetisyen1.Diyetler
{
    class GlutenFree : IDiyet
    {
        public string DiyetAdi { get; }
        public string DiyetAciklamasi { get; set; }

        public GlutenFree()
        {
            DiyetAdi = "Glutensiz Diyet";
            DiyetAciklamasi = "Buğday, arpa, çavdar veya yulaf unlarından hazırlanan ekmek, bisküvi, kek ve pasta gibi besinler yiyin";
        }
    }
}
