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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //diyetisyen listesine ekleniyor
            VeriList.veriListeDiyetisyen.diyetisyenler.Add(new Diyetisyen
            {
                Ad = txtBoxDadi.Text,
                Soyad = txtBoxDSoyadi.Text,
                Sifre = txtBoxSifre.Text
            });

            //diyetisyenler listesi yenileniyor
            dataGridViewDiyListesi.DataSource = null;
            dataGridViewDiyListesi.DataSource = VeriList.veriListeDiyetisyen.diyetisyenler;
            txtBoxDadi.Text = "";
            txtBoxDSoyadi.Text = "";
            txtBoxSifre.Text = "";
            MessageBox.Show("diyetisyen eklendi");
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // Initialize the DataGridView.
            dataGridViewDiyListesi.AutoSize = true;
            dataGridViewDiyListesi.DataSource = VeriList.veriListeDiyetisyen.diyetisyenler;
            
        }
    }
}
