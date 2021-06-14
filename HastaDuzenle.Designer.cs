
namespace yazilimMimarisiDiyetisyen1
{
    partial class HastaDuzenle
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
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxDiyetAciklama = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDiyetAdi = new System.Windows.Forms.ComboBox();
            this.comboBoxHastalik = new System.Windows.Forms.ComboBox();
            this.txtBoxKimlikNo = new System.Windows.Forms.TextBox();
            this.txtBoxSoyad = new System.Windows.Forms.TextBox();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRapor = new System.Windows.Forms.Button();
            this.comboBoxRapor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Diyet Açıklaması";
            // 
            // richTextBoxDiyetAciklama
            // 
            this.richTextBoxDiyetAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxDiyetAciklama.Location = new System.Drawing.Point(30, 307);
            this.richTextBoxDiyetAciklama.Name = "richTextBoxDiyetAciklama";
            this.richTextBoxDiyetAciklama.Size = new System.Drawing.Size(403, 96);
            this.richTextBoxDiyetAciklama.TabIndex = 30;
            this.richTextBoxDiyetAciklama.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(189, 425);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(92, 30);
            this.btnKaydet.TabIndex = 29;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(350, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(83, 26);
            this.btnGeri.TabIndex = 28;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Diyet Adı ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Hastalık";
            // 
            // comboBoxDiyetAdi
            // 
            this.comboBoxDiyetAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDiyetAdi.FormattingEnabled = true;
            this.comboBoxDiyetAdi.Items.AddRange(new object[] {
            "Akdeniz",
            "Gluten Free",
            "Deniz Ürünleri",
            "Yeşillikler Dünyası"});
            this.comboBoxDiyetAdi.Location = new System.Drawing.Point(100, 219);
            this.comboBoxDiyetAdi.Name = "comboBoxDiyetAdi";
            this.comboBoxDiyetAdi.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDiyetAdi.TabIndex = 25;
            this.comboBoxDiyetAdi.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiyetAdi_SelectedIndexChanged);
            // 
            // comboBoxHastalik
            // 
            this.comboBoxHastalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxHastalik.FormattingEnabled = true;
            this.comboBoxHastalik.Items.AddRange(new object[] {
            "Obez",
            "Çölyak",
            "Şeker Hastalığı"});
            this.comboBoxHastalik.Location = new System.Drawing.Point(100, 182);
            this.comboBoxHastalik.Name = "comboBoxHastalik";
            this.comboBoxHastalik.Size = new System.Drawing.Size(121, 23);
            this.comboBoxHastalik.TabIndex = 24;
            // 
            // txtBoxKimlikNo
            // 
            this.txtBoxKimlikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxKimlikNo.Location = new System.Drawing.Point(100, 144);
            this.txtBoxKimlikNo.Name = "txtBoxKimlikNo";
            this.txtBoxKimlikNo.Size = new System.Drawing.Size(121, 21);
            this.txtBoxKimlikNo.TabIndex = 23;
            // 
            // txtBoxSoyad
            // 
            this.txtBoxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxSoyad.Location = new System.Drawing.Point(100, 103);
            this.txtBoxSoyad.Name = "txtBoxSoyad";
            this.txtBoxSoyad.Size = new System.Drawing.Size(121, 21);
            this.txtBoxSoyad.TabIndex = 22;
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAd.Location = new System.Drawing.Point(100, 59);
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(121, 21);
            this.txtBoxAd.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ad";
            // 
            // btnRapor
            // 
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.Location = new System.Drawing.Point(350, 222);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(83, 26);
            this.btnRapor.TabIndex = 32;
            this.btnRapor.Text = "Rapor Yaz";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // comboBoxRapor
            // 
            this.comboBoxRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxRapor.FormattingEnabled = true;
            this.comboBoxRapor.Items.AddRange(new object[] {
            "JSON",
            "JSON(ters)",
            "HTML",
            "HTML(ters)"});
            this.comboBoxRapor.Location = new System.Drawing.Point(350, 182);
            this.comboBoxRapor.Name = "comboBoxRapor";
            this.comboBoxRapor.Size = new System.Drawing.Size(83, 23);
            this.comboBoxRapor.TabIndex = 33;
            // 
            // HastaDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 474);
            this.Controls.Add(this.comboBoxRapor);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxDiyetAciklama);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxDiyetAdi);
            this.Controls.Add(this.comboBoxHastalik);
            this.Controls.Add(this.txtBoxKimlikNo);
            this.Controls.Add(this.txtBoxSoyad);
            this.Controls.Add(this.txtBoxAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HastaDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaDuzenle";
            this.Load += new System.EventHandler(this.HastaDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxDiyetAciklama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDiyetAdi;
        private System.Windows.Forms.ComboBox comboBoxHastalik;
        private System.Windows.Forms.TextBox txtBoxKimlikNo;
        private System.Windows.Forms.TextBox txtBoxSoyad;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.ComboBox comboBoxRapor;
    }
}