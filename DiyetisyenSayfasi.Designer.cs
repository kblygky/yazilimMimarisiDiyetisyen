
namespace yazilimMimarisiDiyetisyen1
{
    partial class DiyetisyenSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.dataGridViewHastaList = new System.Windows.Forms.DataGridView();
            this.lblDiyetisyenAdi = new System.Windows.Forms.Label();
            this.btnCik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHastaList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.Location = new System.Drawing.Point(242, 89);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(91, 23);
            this.btnHastaEkle.TabIndex = 10;
            this.btnHastaEkle.Text = "Hasta Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = true;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // dataGridViewHastaList
            // 
            this.dataGridViewHastaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHastaList.Location = new System.Drawing.Point(12, 169);
            this.dataGridViewHastaList.Name = "dataGridViewHastaList";
            this.dataGridViewHastaList.Size = new System.Drawing.Size(561, 256);
            this.dataGridViewHastaList.TabIndex = 9;
            this.dataGridViewHastaList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHastaList_CellContentClick);
            // 
            // lblDiyetisyenAdi
            // 
            this.lblDiyetisyenAdi.AutoSize = true;
            this.lblDiyetisyenAdi.Location = new System.Drawing.Point(272, 42);
            this.lblDiyetisyenAdi.Name = "lblDiyetisyenAdi";
            this.lblDiyetisyenAdi.Size = new System.Drawing.Size(35, 13);
            this.lblDiyetisyenAdi.TabIndex = 11;
            this.lblDiyetisyenAdi.Text = "label1";
            // 
            // btnCik
            // 
            this.btnCik.Location = new System.Drawing.Point(498, 32);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(75, 23);
            this.btnCik.TabIndex = 12;
            this.btnCik.Text = "Çık";
            this.btnCik.UseVisualStyleBackColor = true;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // DiyetisyenSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.lblDiyetisyenAdi);
            this.Controls.Add(this.btnHastaEkle);
            this.Controls.Add(this.dataGridViewHastaList);
            this.Name = "DiyetisyenSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiyetisyenSayfasi";
            this.Load += new System.EventHandler(this.DiyetisyenSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHastaList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.DataGridView dataGridViewHastaList;
        private System.Windows.Forms.Label lblDiyetisyenAdi;
        private System.Windows.Forms.Button btnCik;
    }
}