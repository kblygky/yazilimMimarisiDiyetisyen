
namespace yazilimMimarisiDiyetisyen1
{
    partial class HastaBilgileri
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.txtBoxSoyad = new System.Windows.Forms.TextBox();
            this.txtBoxKimlikNo = new System.Windows.Forms.TextBox();
            this.comboBoxHastalik = new System.Windows.Forms.ComboBox();
            this.comboBoxDiyetAdi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.richTextBoxDiyetAciklama = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kimlik No";
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAd.Location = new System.Drawing.Point(125, 76);
            this.txtBoxAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(126, 21);
            this.txtBoxAd.TabIndex = 3;
            // 
            // txtBoxSoyad
            // 
            this.txtBoxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxSoyad.Location = new System.Drawing.Point(125, 116);
            this.txtBoxSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxSoyad.Name = "txtBoxSoyad";
            this.txtBoxSoyad.Size = new System.Drawing.Size(126, 21);
            this.txtBoxSoyad.TabIndex = 4;
            // 
            // txtBoxKimlikNo
            // 
            this.txtBoxKimlikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxKimlikNo.Location = new System.Drawing.Point(125, 157);
            this.txtBoxKimlikNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxKimlikNo.Name = "txtBoxKimlikNo";
            this.txtBoxKimlikNo.Size = new System.Drawing.Size(126, 21);
            this.txtBoxKimlikNo.TabIndex = 5;
            // 
            // comboBoxHastalik
            // 
            this.comboBoxHastalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxHastalik.FormattingEnabled = true;
            this.comboBoxHastalik.Items.AddRange(new object[] {
            "Obez",
            "Çölyak",
            "Şeker Hastalığı"});
            this.comboBoxHastalik.Location = new System.Drawing.Point(125, 195);
            this.comboBoxHastalik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxHastalik.Name = "comboBoxHastalik";
            this.comboBoxHastalik.Size = new System.Drawing.Size(126, 23);
            this.comboBoxHastalik.TabIndex = 6;
            this.comboBoxHastalik.SelectedIndexChanged += new System.EventHandler(this.comboBoxHastalik_SelectedIndexChanged);
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
            this.comboBoxDiyetAdi.Location = new System.Drawing.Point(125, 237);
            this.comboBoxDiyetAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDiyetAdi.Name = "comboBoxDiyetAdi";
            this.comboBoxDiyetAdi.Size = new System.Drawing.Size(126, 23);
            this.comboBoxDiyetAdi.TabIndex = 7;
            this.comboBoxDiyetAdi.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiyetAdi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hastalık";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(49, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Diyet Adı ";
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(376, 13);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 32);
            this.btnGeri.TabIndex = 13;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(182, 481);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(123, 32);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // richTextBoxDiyetAciklama
            // 
            this.richTextBoxDiyetAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxDiyetAciklama.Location = new System.Drawing.Point(39, 344);
            this.richTextBoxDiyetAciklama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxDiyetAciklama.Name = "richTextBoxDiyetAciklama";
            this.richTextBoxDiyetAciklama.Size = new System.Drawing.Size(437, 117);
            this.richTextBoxDiyetAciklama.TabIndex = 16;
            this.richTextBoxDiyetAciklama.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(49, 311);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Diyet Açıklaması";
            // 
            // HastaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(505, 541);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxDiyetAciklama);
            this.Controls.Add(this.btnEkle);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HastaBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaBilgileri";
            this.Load += new System.EventHandler(this.HastaBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.TextBox txtBoxSoyad;
        private System.Windows.Forms.TextBox txtBoxKimlikNo;
        private System.Windows.Forms.ComboBox comboBoxHastalik;
        private System.Windows.Forms.ComboBox comboBoxDiyetAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RichTextBox richTextBoxDiyetAciklama;
        private System.Windows.Forms.Label label6;
    }
}