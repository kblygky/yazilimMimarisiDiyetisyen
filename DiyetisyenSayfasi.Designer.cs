
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewHastaList = new System.Windows.Forms.DataGridView();
            this.lblDiyetisyenAdi = new System.Windows.Forms.Label();
            this.btnCik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHastaList)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hasta Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHastaList
            // 
            this.dataGridViewHastaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHastaList.Location = new System.Drawing.Point(12, 169);
            this.dataGridViewHastaList.Name = "dataGridViewHastaList";
            this.dataGridViewHastaList.Size = new System.Drawing.Size(776, 256);
            this.dataGridViewHastaList.TabIndex = 9;
            // 
            // lblDiyetisyenAdi
            // 
            this.lblDiyetisyenAdi.AutoSize = true;
            this.lblDiyetisyenAdi.Location = new System.Drawing.Point(381, 42);
            this.lblDiyetisyenAdi.Name = "lblDiyetisyenAdi";
            this.lblDiyetisyenAdi.Size = new System.Drawing.Size(35, 13);
            this.lblDiyetisyenAdi.TabIndex = 11;
            this.lblDiyetisyenAdi.Text = "label1";
            // 
            // btnCik
            // 
            this.btnCik.Location = new System.Drawing.Point(693, 32);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.lblDiyetisyenAdi);
            this.Controls.Add(this.button1);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewHastaList;
        private System.Windows.Forms.Label lblDiyetisyenAdi;
        private System.Windows.Forms.Button btnCik;
    }
}