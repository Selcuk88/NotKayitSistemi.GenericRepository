
namespace UIArayuz
{
    partial class OgrenciPaneli
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDersCikar = new System.Windows.Forms.Button();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.lstDerslerim = new System.Windows.Forms.ListView();
            this.col1 = new System.Windows.Forms.ColumnHeader();
            this.col2 = new System.Windows.Forms.ColumnHeader();
            this.col3 = new System.Windows.Forms.ColumnHeader();
            this.col4 = new System.Windows.Forms.ColumnHeader();
            this.col5 = new System.Windows.Forms.ColumnHeader();
            this.col6 = new System.Windows.Forms.ColumnHeader();
            this.col7 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOgrenciBilgileri = new System.Windows.Forms.GroupBox();
            this.lblSinif = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.btnSifreDegistir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDersler = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.gbOgrenciBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDersler);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDersCikar);
            this.groupBox1.Controls.Add(this.btnDersEkle);
            this.groupBox1.Controls.Add(this.lstDerslerim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(222, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Seçme/Görüntüleme İşlemleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "DERSLERİM";
            // 
            // btnDersCikar
            // 
            this.btnDersCikar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDersCikar.ForeColor = System.Drawing.Color.Black;
            this.btnDersCikar.Location = new System.Drawing.Point(293, 131);
            this.btnDersCikar.Name = "btnDersCikar";
            this.btnDersCikar.Size = new System.Drawing.Size(75, 57);
            this.btnDersCikar.TabIndex = 3;
            this.btnDersCikar.Text = "ÇIKAR\r\n<<";
            this.btnDersCikar.UseVisualStyleBackColor = true;
            this.btnDersCikar.Click += new System.EventHandler(this.btnDersCikar_Click);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDersEkle.ForeColor = System.Drawing.Color.Black;
            this.btnDersEkle.Location = new System.Drawing.Point(293, 68);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(75, 57);
            this.btnDersEkle.TabIndex = 3;
            this.btnDersEkle.Text = "EKLE\r\n>>";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // lstDerslerim
            // 
            this.lstDerslerim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5,
            this.col6,
            this.col7});
            this.lstDerslerim.HideSelection = false;
            this.lstDerslerim.Location = new System.Drawing.Point(383, 49);
            this.lstDerslerim.Name = "lstDerslerim";
            this.lstDerslerim.Size = new System.Drawing.Size(519, 154);
            this.lstDerslerim.TabIndex = 2;
            this.lstDerslerim.UseCompatibleStateImageBehavior = false;
            this.lstDerslerim.View = System.Windows.Forms.View.Details;
            // 
            // col1
            // 
            this.col1.Text = "Ders Ad";
            this.col1.Width = 75;
            // 
            // col2
            // 
            this.col2.Text = "Dersi Veren";
            this.col2.Width = 100;
            // 
            // col3
            // 
            this.col3.Text = "1. Sınav";
            this.col3.Width = 55;
            // 
            // col4
            // 
            this.col4.Text = "2. Sınav";
            this.col4.Width = 55;
            // 
            // col5
            // 
            this.col5.Text = "3. Sınav";
            this.col5.Width = 55;
            // 
            // col6
            // 
            this.col6.Text = "Ortalama";
            this.col6.Width = 75;
            // 
            // col7
            // 
            this.col7.Text = "Başarı Durumu";
            this.col7.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DERSLER";
            // 
            // gbOgrenciBilgileri
            // 
            this.gbOgrenciBilgileri.Controls.Add(this.lblSinif);
            this.gbOgrenciBilgileri.Controls.Add(this.lblAdSoyad);
            this.gbOgrenciBilgileri.Controls.Add(this.lblTcNo);
            this.gbOgrenciBilgileri.Controls.Add(this.btnSifreDegistir);
            this.gbOgrenciBilgileri.Controls.Add(this.label4);
            this.gbOgrenciBilgileri.Controls.Add(this.label5);
            this.gbOgrenciBilgileri.Controls.Add(this.label3);
            this.gbOgrenciBilgileri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbOgrenciBilgileri.ForeColor = System.Drawing.Color.White;
            this.gbOgrenciBilgileri.Location = new System.Drawing.Point(12, 12);
            this.gbOgrenciBilgileri.Name = "gbOgrenciBilgileri";
            this.gbOgrenciBilgileri.Size = new System.Drawing.Size(204, 210);
            this.gbOgrenciBilgileri.TabIndex = 2;
            this.gbOgrenciBilgileri.TabStop = false;
            this.gbOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // lblSinif
            // 
            this.lblSinif.AutoSize = true;
            this.lblSinif.Location = new System.Drawing.Point(47, 91);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(0, 15);
            this.lblSinif.TabIndex = 4;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(73, 59);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 15);
            this.lblAdSoyad.TabIndex = 4;
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Location = new System.Drawing.Point(55, 32);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(0, 15);
            this.lblTcNo.TabIndex = 4;
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSifreDegistir.ForeColor = System.Drawing.Color.Blue;
            this.btnSifreDegistir.Location = new System.Drawing.Point(43, 181);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(155, 22);
            this.btnSifreDegistir.TabIndex = 3;
            this.btnSifreDegistir.Text = "Oturum Şifreni Değiştir";
            this.btnSifreDegistir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sınıf:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "TC No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad Soyad:";
            // 
            // lstDersler
            // 
            this.lstDersler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstDersler.FullRowSelect = true;
            this.lstDersler.HideSelection = false;
            this.lstDersler.Location = new System.Drawing.Point(6, 49);
            this.lstDersler.MultiSelect = false;
            this.lstDersler.Name = "lstDersler";
            this.lstDersler.Size = new System.Drawing.Size(269, 154);
            this.lstDersler.TabIndex = 4;
            this.lstDersler.UseCompatibleStateImageBehavior = false;
            this.lstDersler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ders Ad";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Öğretmen";
            this.columnHeader2.Width = 165;
            // 
            // OgrenciPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(1142, 231);
            this.Controls.Add(this.gbOgrenciBilgileri);
            this.Controls.Add(this.groupBox1);
            this.Name = "OgrenciPaneli";
            this.Text = "NOT KAYIT SİSTEMİ - Öğrenci Paneli";
            this.Load += new System.EventHandler(this.OgrenciPaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOgrenciBilgileri.ResumeLayout(false);
            this.gbOgrenciBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.ListView lstDerslerim;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.ColumnHeader col4;
        private System.Windows.Forms.ColumnHeader col5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader col6;
        private System.Windows.Forms.ColumnHeader col7;
        private System.Windows.Forms.GroupBox gbOgrenciBilgileri;
        private System.Windows.Forms.Button btnSifreDegistir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.Button btnDersCikar;
        private System.Windows.Forms.ListView lstDersler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}