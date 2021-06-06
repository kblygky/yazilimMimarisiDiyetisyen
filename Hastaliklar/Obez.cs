using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazilimMimarisiDiyetisyen1.Abstract;

namespace yazilimMimarisiDiyetisyen1.Hastaliklar
{
    class Obez : IHastalik
    {
        public string HastalikAdi { get ;  }
        public Obez()
        {
            HastalikAdi = "Obez";
        }
    }
}
