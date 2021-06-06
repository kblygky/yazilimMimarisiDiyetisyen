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
    public partial class DiyetisyenSayfasi : Form
    {
        public string diyetisyenAdi;
        public DiyetisyenSayfasi()
        {
            InitializeComponent();
        }
        
        
        private void DiyetisyenSayfasi_Load(object sender, EventArgs e)
        {
            lblDiyetisyenAdi.Text = diyetisyenAdi;
            Diyetisyen diyetisyen = VeriList.veriListeDiyetisyen.diyetisyenler.FirstOrDefault(d => d.Ad==diyetisyenAdi );
           //dataGridViewHastaList.AutoSize = true;
            dataGridViewHastaList.DataSource = diyetisyen.Hastalar;
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            diyetisyenAdi = "";
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
