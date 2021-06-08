
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Diyet Açıklaması";
            // 
            // richTextBoxDiyetAciklama
            // 
            this.richTextBoxDiyetAciklama.Location = new System.Drawing.Point(30, 297);
            this.richTextBoxDiyetAciklama.Name = "richTextBoxDiyetAciklama";
            this.richTextBoxDiyetAciklama.Size = new System.Drawing.Size(362, 96);
            this.richTextBoxDiyetAciklama.TabIndex = 30;
            this.richTextBoxDiyetAciklama.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(172, 399);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(92, 23);
            this.btnKaydet.TabIndex = 29;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(317, 33);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 26);
            this.btnGeri.TabIndex = 28;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Diyet Adı ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Hastalık";
            // 
            // comboBoxDiyetAdi
            // 
            this.comboBoxDiyetAdi.FormattingEnabled = true;
            this.comboBoxDiyetAdi.Items.AddRange(new object[] {
            "Akdeniz",
            "Gluten Free",
            "Deniz Ürünleri",
            "Yeşillikler Dünyası"});
            this.comboBoxDiyetAdi.Location = new System.Drawing.Point(86, 219);
            this.comboBoxDiyetAdi.Name = "comboBoxDiyetAdi";
            this.comboBoxDiyetAdi.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDiyetAdi.TabIndex = 25;
            this.comboBoxDiyetAdi.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiyetAdi_SelectedIndexChanged);
            // 
            // comboBoxHastalik
            // 
            this.comboBoxHastalik.FormattingEnabled = true;
            this.comboBoxHastalik.Items.AddRange(new object[] {
            "Obez",
            "Çölyak",
            "Şeker Hastalığı"});
            this.comboBoxHastalik.Location = new System.Drawing.Point(86, 182);
            this.comboBoxHastalik.Name = "comboBoxHastalik";
            this.comboBoxHastalik.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHastalik.TabIndex = 24;
            // 
            // txtBoxKimlikNo
            // 
            this.txtBoxKimlikNo.Location = new System.Drawing.Point(86, 144);
            this.txtBoxKimlikNo.Name = "txtBoxKimlikNo";
            this.txtBoxKimlikNo.Size = new System.Drawing.Size(121, 20);
            this.txtBoxKimlikNo.TabIndex = 23;
            // 
            // txtBoxSoyad
            // 
            this.txtBoxSoyad.Location = new System.Drawing.Point(86, 103);
            this.txtBoxSoyad.Name = "txtBoxSoyad";
            this.txtBoxSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtBoxSoyad.TabIndex = 22;
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Location = new System.Drawing.Point(86, 59);
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(121, 20);
            this.txtBoxAd.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 32;
            this.button1.Text = "Rapor Yaz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "JSON",
            "HTML"});
            this.comboBox1.Location = new System.Drawing.Point(317, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // HastaDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 457);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}