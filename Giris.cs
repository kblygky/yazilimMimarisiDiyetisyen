using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazilimMimarisiDiyetisyen1.veri;

namespace yazilimMimarisiDiyetisyen1
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtBoxKullaniciAdi.Text == "admin" && txtBoxSifre.Text == "123")//admin kontrolü
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else//admin değil ise diyetisyen listesi kontrol ediliyor
            {
                Diyetisyen diyetisyen = VeriList.veriListeDiyetisyen.diyetisyenler.FirstOrDefault(d => d.Sifre == txtBoxSifre.Text && d.Ad == txtBoxKullaniciAdi.Text);
                if (diyetisyen == null)//şifre yanlış
                {
                    MessageBox.Show("şifren yanlış");
                }
                else//şifre doğru ise
                {
                    //MessageBox.Show(diyetisyen.Ad);
                    DiyetisyenSayfasi diyetisyenSayfasi = new DiyetisyenSayfasi();
                    diyetisyenSayfasi.diyetisyenAdi = diyetisyen.Ad;//diyetisyen adı ilgili forma gönderiliyor
                    diyetisyenSayfasi.Show();
                    this.Hide();
                }
            }



        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }

}
