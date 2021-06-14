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
            Diyetisyen diyetisyen = VeriList.veriListeDiyetisyen.diyetisyenler.FirstOrDefault(d => d.Ad == diyetisyenAdi);
            
            dataGridViewHastaList.DataSource = diyetisyen.Hastalar;

            //MessageBox.Show( dataGridViewHastaList.Columns.Count.ToString());
            if (diyetisyen.Hastalar!=null)
            {
                dataGridViewHastaList.Columns[3].Visible = false;
                dataGridViewHastaList.Columns[4].Visible = false;
            }
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            diyetisyenAdi = "";
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            HastaBilgileri hastaBilgileri = new HastaBilgileri();
            hastaBilgileri.diyetisyenAdi = diyetisyenAdi;
            hastaBilgileri.Show();
            this.Hide();
        }

        private void dataGridViewHastaList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HastaDuzenle hastaDuzenle = new HastaDuzenle();
            hastaDuzenle.diyetisyenAdi = diyetisyenAdi;
            hastaDuzenle.hastaTc = dataGridViewHastaList.CurrentRow.Cells[2].Value.ToString();
            hastaDuzenle.Show();
            this.Hide();
        }
    }
}
