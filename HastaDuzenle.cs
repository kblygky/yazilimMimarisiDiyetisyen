using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazilimMimarisiDiyetisyen1.Abstract;
using yazilimMimarisiDiyetisyen1.Diyetler;
using yazilimMimarisiDiyetisyen1.Hastaliklar;
using yazilimMimarisiDiyetisyen1.Report;
using yazilimMimarisiDiyetisyen1.veri;

namespace yazilimMimarisiDiyetisyen1
{
    public partial class HastaDuzenle : Form
    {
        public string diyetisyenAdi;
        public string hastaTc;
        public HastaDuzenle()
        {
            InitializeComponent();
        }

        private void HastaDuzenle_Load(object sender, EventArgs e)
        {

            Diyetisyen diyetisyen = VeriList.veriListeDiyetisyen.diyetisyenler.FirstOrDefault(d => d.Ad == diyetisyenAdi);
            Hasta hasta = diyetisyen.Hastalar.FirstOrDefault(tc => tc.Tc == hastaTc);

            txtBoxAd.Text = hasta.Ad;
            txtBoxSoyad.Text = hasta.Soyad;
            txtBoxKimlikNo.Text = hasta.Tc;
            comboBoxHastalik.Text = hasta.Hastaligi.HastalikAdi;
            comboBoxDiyetAdi.Text = hasta.Diyeti.DiyetAdi;
            richTextBoxDiyetAciklama.Text = hasta.Diyeti.DiyetAciklamasi;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GeriGit();
        }
        void GeriGit()
        {
            DiyetisyenSayfasi diyetisyenSayfasi = new DiyetisyenSayfasi();
            diyetisyenSayfasi.diyetisyenAdi = diyetisyenAdi;
            diyetisyenSayfasi.Show();
            this.Hide();
        }

        private void comboBoxDiyetAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDiyetAdi.Text == "Akdeniz")
            {
                IDiyet diyet = new Akdeniz();
                richTextBoxDiyetAciklama.Text = diyet.DiyetAciklamasi;
            }
            else if (comboBoxDiyetAdi.Text == "Gluten Free")
            {
                IDiyet diyet = new DenizUrunleri();
                richTextBoxDiyetAciklama.Text = diyet.DiyetAciklamasi;
            }
            else if (comboBoxDiyetAdi.Text == "Deniz Ürünleri")
            {
                IDiyet diyet = new GlutenFree();
                richTextBoxDiyetAciklama.Text = diyet.DiyetAciklamasi;
            }
            else if (comboBoxDiyetAdi.Text == "Yeşillikler Dünyası")
            {
                IDiyet diyet = new YesilliklerDunyasi();
                richTextBoxDiyetAciklama.Text = diyet.DiyetAciklamasi;
            }
            else
            {
                MessageBox.Show("boş");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Diyetisyen diyetisyen = VeriList.veriListeDiyetisyen.diyetisyenler.FirstOrDefault(d => d.Ad == diyetisyenAdi);
            Hasta hasta = diyetisyen.Hastalar.FirstOrDefault(tc => tc.Tc == hastaTc);

            hasta.Ad = txtBoxAd.Text;
            hasta.Soyad = txtBoxSoyad.Text;
            hasta.Tc = txtBoxKimlikNo.Text;


            if (comboBoxDiyetAdi.Text == "Akdeniz")
            {
                IDiyet diyet = new Akdeniz();
                diyet.DiyetAciklamasi = richTextBoxDiyetAciklama.Text;
                hasta.Diyeti = diyet;
            }
            else if (comboBoxDiyetAdi.Text == "Gluten Free")
            {
                IDiyet diyet = new DenizUrunleri();
                diyet.DiyetAciklamasi = richTextBoxDiyetAciklama.Text;
                hasta.Diyeti = diyet;
            }
            else if (comboBoxDiyetAdi.Text == "Deniz Ürünleri")
            {
                IDiyet diyet = new GlutenFree();
                diyet.DiyetAciklamasi = richTextBoxDiyetAciklama.Text;
                hasta.Diyeti = diyet;
            }
            else if (comboBoxDiyetAdi.Text == "Yeşillikler Dünyası")
            {
                IDiyet diyet = new YesilliklerDunyasi();
                diyet.DiyetAciklamasi = richTextBoxDiyetAciklama.Text;
                hasta.Diyeti = diyet;
            }
            else
            {
                MessageBox.Show("boş");
            }


            if (comboBoxHastalik.Text == "Obez")
            {
                IHastalik hastalik = new Obez();
                hasta.Hastaligi = hastalik;
            }
            else if (comboBoxHastalik.Text == "Çölyak")
            {
                IHastalik hastalik = new Colyak();
                hasta.Hastaligi = hastalik;
            }
            else if (comboBoxHastalik.Text == "Şeker Hastalığı")
            {
                IHastalik hastalik = new Seker();
                hasta.Hastaligi = hastalik;
            }
            else
            {
                MessageBox.Show("boş");
            }

            MessageBox.Show("Değişiklikler Kaydedildi");
            GeriGit();

        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Diyetisyen diyetisyen = VeriList.veriListeDiyetisyen.diyetisyenler.FirstOrDefault(d => d.Ad == diyetisyenAdi);
            Hasta hasta = diyetisyen.Hastalar.FirstOrDefault(tc => tc.Tc == hastaTc);

            if (comboBoxRapor.Text== "JSON")
            {
                ReportBuilderBase builder = new JsonReportBuilder(hasta);
                ReportManager reportManager = new ReportManager(builder);
                string rapor = reportManager.Build();
                MessageBox.Show(rapor);
            }
            else if (comboBoxRapor.Text == "HTML")
            {
                ReportBuilderBase builder = new HtmlReportBuilder(hasta);
                ReportManager reportManager = new ReportManager(builder);
                string rapor = reportManager.Build();
                MessageBox.Show(rapor);
            }
            else if (comboBoxRapor.Text == "JSON(ters)")
            {
                ReportBuilderBase builder = new JsonReportBuilder(hasta);
                ReportManager reportManager = new ReportManager(builder);
                string rapor = reportManager.BuildReverse();
                MessageBox.Show(rapor);
            }
            else if (comboBoxRapor.Text == "HTML(ters)")
            {
                ReportBuilderBase builder = new HtmlReportBuilder(hasta);
                ReportManager reportManager = new ReportManager(builder);
                string rapor = reportManager.BuildReverse();
                MessageBox.Show(rapor);
            }
            else
            {
                MessageBox.Show("Rapor Formatı seçin");
            }
            
        }
    }
}
//(ters)