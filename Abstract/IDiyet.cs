using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimMimarisiDiyetisyen1.Abstract
{
    public interface IDiyet
    {
        string DiyetAdi { get;  }
        string DiyetAciklamasi { get; set; }
    }
}
