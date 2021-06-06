using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazilimMimarisiDiyetisyen1.Abstract;

namespace yazilimMimarisiDiyetisyen1.Diyetler
{
    class YesilliklerDunyasi : IDiyet
    {
        public string DiyetAdi { get; }
        public string DiyetAciklamasi { get; set; }

        public YesilliklerDunyasi()
        {
            DiyetAdi = "Yeşillikler dünyas";
            DiyetAciklamasi = "Roka yiyin her gün.";
        }
    }
}
