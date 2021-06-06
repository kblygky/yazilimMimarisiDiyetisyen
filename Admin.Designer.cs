
namespace yazilimMimarisiDiyetisyen1
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDadi = new System.Windows.Forms.TextBox();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridViewDiyListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiyListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diyetisyen Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // txtBoxDadi
            // 
            this.txtBoxDadi.Location = new System.Drawing.Point(193, 92);
            this.txtBoxDadi.Name = "txtBoxDadi";
            this.txtBoxDadi.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDadi.TabIndex = 2;
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Location = new System.Drawing.Point(193, 131);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSifre.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(346, 128);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDiyListesi
            // 
            this.dataGridViewDiyListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiyListesi.Location = new System.Drawing.Point(117, 225);
            this.dataGridViewDiyListesi.Name = "dataGridViewDiyListesi";
            this.dataGridViewDiyListesi.Size = new System.Drawing.Size(568, 150);
            this.dataGridViewDiyListesi.TabIndex = 5;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDiyListesi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtBoxSifre);
            this.Controls.Add(this.txtBoxDadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiyListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDadi;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridViewDiyListesi;
    }
}