using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazilimMimarisiDiyetisyen1.Diyetler;
using yazilimMimarisiDiyetisyen1.Hastaliklar;

namespace yazilimMimarisiDiyetisyen1.veri
{
    class VeriList
    {
        //singleton tasarımı
        private static VeriList liste;
        private static object kilitNesnesi=new object();
        public List<Diyetisyen> diyetisyenler;
        public static VeriList veriListeDiyetisyen {
            
            get {
                lock (kilitNesnesi)
                {
                    if ( liste==null)
                    {
                        liste = new VeriList();
                    }
                }
                return liste;
            }
        }

        public VeriList()
        {
            diyetisyenler = new List<Diyetisyen>();

            //--------------------------------------------------------
            //diyetisyen 1 
            Diyetisyen diyetisyen1 = new Diyetisyen();
            diyetisyen1.Ad = "kubi";
            diyetisyen1.Soyad = "Gökay";
            diyetisyen1.Sifre = "123";

            Hasta hasta1 = new Hasta();//hasta 1
            hasta1.Ad = "Mahmut";
            hasta1.Soyad = "Tuncer";
            hasta1.Tc = "11023423450";
            hasta1.Hastaligi = new Obez();
            hasta1.Diyeti = new Akdeniz();

            Hasta hasta2 = new Hasta();//hasta 2
            hasta2.Ad = "Merve";
            hasta2.Soyad = "Karagöz";
            hasta2.Tc = "11034345353";
            hasta2.Hastaligi = new Seker();
            hasta2.Diyeti = new GlutenFree();
            diyetisyen1.Hastalar = new List<Hasta>();
            diyetisyen1.Hastalar.Add(hasta1);
            diyetisyen1.Hastalar.Add(hasta2);
            diyetisyenler.Add(diyetisyen1);

            //diyetisyen 2 
            Diyetisyen diyetisyen2 = new Diyetisyen();
            diyetisyen2.Ad = "zehra";
            diyetisyen2.Soyad = "Kurucu";
            diyetisyen2.Sifre = "Crazy_zehra";

            Hasta hasta3 = new Hasta();//hasta 3
            hasta3.Ad = "Samet";
            hasta3.Soyad = "Güllaç";
            hasta3.Tc = "11111111111";
            hasta3.Hastaligi = new Colyak();
            hasta3.Diyeti = new DenizUrunleri();

            Hasta hasta4 = new Hasta();//hasta 4
            hasta4.Ad = "Süheyl";
            hasta4.Soyad = "Mamur";
            hasta4.Tc = "22222222222";
            hasta4.Hastaligi = new Seker();
            hasta4.Diyeti = new YesilliklerDunyasi();
            diyetisyen2.Hastalar = new List<Hasta>();
            diyetisyen2.Hastalar.Add(hasta3);
            diyetisyen2.Hastalar.Add(hasta4);
            diyetisyenler.Add(diyetisyen2);
            //------------------------------------------------------------
        }
    }
}
