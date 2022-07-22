
namespace UIArayuz
{
    partial class OgrenciKayitAlmaGuncellemeSilme
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
            this.lstMevcutSiniflar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.lstOgrencilerListe = new System.Windows.Forms.ListView();
            this.col1 = new System.Windows.Forms.ColumnHeader();
            this.col2 = new System.Windows.Forms.ColumnHeader();
            this.col3 = new System.Windows.Forms.ColumnHeader();
            this.col4 = new System.Windows.Forms.ColumnHeader();
            this.col5 = new System.Windows.Forms.ColumnHeader();
            this.btnSeciliOgrenciSil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKiz = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOgrenciGuncelle = new System.Windows.Forms.Button();
            this.btnOgrenciKaydet = new System.Windows.Forms.Button();
            this.mtxtOgrenciTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.txtOgrenciSifre = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstMevcutSiniflar);
            this.groupBox1.Controls.Add(this.lstOgrencilerListe);
            this.groupBox1.Controls.Add(this.btnSeciliOgrenciSil);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbErkek);
            this.groupBox1.Controls.Add(this.rbKiz);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnOgrenciGuncelle);
            this.groupBox1.Controls.Add(this.btnOgrenciKaydet);
            this.groupBox1.Controls.Add(this.mtxtOgrenciTcNo);
            this.groupBox1.Controls.Add(this.txtOgrenciAd);
            this.groupBox1.Controls.Add(this.txtOgrenciSifre);
            this.groupBox1.Controls.Add(this.txtOgrenciSoyad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 530);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Kayıt - Güncelleme İşlemleri";
            // 
            // lstMevcutSiniflar
            // 
            this.lstMevcutSiniflar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstMevcutSiniflar.FullRowSelect = true;
            this.lstMevcutSiniflar.HideSelection = false;
            this.lstMevcutSiniflar.Location = new System.Drawing.Point(239, 55);
            this.lstMevcutSiniflar.MultiSelect = false;
            this.lstMevcutSiniflar.Name = "lstMevcutSiniflar";
            this.lstMevcutSiniflar.Size = new System.Drawing.Size(305, 204);
            this.lstMevcutSiniflar.TabIndex = 15;
            this.lstMevcutSiniflar.UseCompatibleStateImageBehavior = false;
            this.lstMevcutSiniflar.View = System.Windows.Forms.View.Details;
            this.lstMevcutSiniflar.SelectedIndexChanged += new System.EventHandler(this.lstMevcutSiniflar_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sınıf No";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Şube";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kapasite";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mevcut";
            // 
            // lstOgrencilerListe
            // 
            this.lstOgrencilerListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5});
            this.lstOgrencilerListe.FullRowSelect = true;
            this.lstOgrencilerListe.HideSelection = false;
            this.lstOgrencilerListe.Location = new System.Drawing.Point(12, 306);
            this.lstOgrencilerListe.MultiSelect = false;
            this.lstOgrencilerListe.Name = "lstOgrencilerListe";
            this.lstOgrencilerListe.Size = new System.Drawing.Size(532, 171);
            this.lstOgrencilerListe.TabIndex = 13;
            this.lstOgrencilerListe.UseCompatibleStateImageBehavior = false;
            this.lstOgrencilerListe.View = System.Windows.Forms.View.Details;
            this.lstOgrencilerListe.DoubleClick += new System.EventHandler(this.lstOgrencilerListe_DoubleClick);
            // 
            // col1
            // 
            this.col1.Text = "ID";
            this.col1.Width = 50;
            // 
            // col2
            // 
            this.col2.Text = "Ad";
            this.col2.Width = 110;
            // 
            // col3
            // 
            this.col3.Text = "Soyad";
            this.col3.Width = 150;
            // 
            // col4
            // 
            this.col4.Text = "TC No";
            this.col4.Width = 110;
            // 
            // col5
            // 
            this.col5.Text = "Cinsiyet";
            this.col5.Width = 100;
            // 
            // btnSeciliOgrenciSil
            // 
            this.btnSeciliOgrenciSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeciliOgrenciSil.ForeColor = System.Drawing.Color.Black;
            this.btnSeciliOgrenciSil.Location = new System.Drawing.Point(12, 483);
            this.btnSeciliOgrenciSil.Name = "btnSeciliOgrenciSil";
            this.btnSeciliOgrenciSil.Size = new System.Drawing.Size(532, 36);
            this.btnSeciliOgrenciSil.TabIndex = 1;
            this.btnSeciliOgrenciSil.Text = "SEÇİLİ ÖĞRENCİ SİL";
            this.btnSeciliOgrenciSil.UseVisualStyleBackColor = true;
            this.btnSeciliOgrenciSil.Click += new System.EventHandler(this.btnSeciliOgrenciSil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sınıflar-Şubeler:";
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(135, 150);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(61, 19);
            this.rbErkek.TabIndex = 10;
            this.rbErkek.Text = "ERKEK";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKiz
            // 
            this.rbKiz.AutoSize = true;
            this.rbKiz.Checked = true;
            this.rbKiz.Location = new System.Drawing.Point(72, 150);
            this.rbKiz.Name = "rbKiz";
            this.rbKiz.Size = new System.Drawing.Size(44, 19);
            this.rbKiz.TabIndex = 9;
            this.rbKiz.TabStop = true;
            this.rbKiz.Text = "KIZ";
            this.rbKiz.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cinsiyet:";
            // 
            // btnOgrenciGuncelle
            // 
            this.btnOgrenciGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgrenciGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnOgrenciGuncelle.Location = new System.Drawing.Point(12, 223);
            this.btnOgrenciGuncelle.Name = "btnOgrenciGuncelle";
            this.btnOgrenciGuncelle.Size = new System.Drawing.Size(100, 36);
            this.btnOgrenciGuncelle.TabIndex = 1;
            this.btnOgrenciGuncelle.Text = "GÜNCELLE";
            this.btnOgrenciGuncelle.UseVisualStyleBackColor = true;
            this.btnOgrenciGuncelle.Click += new System.EventHandler(this.btnOgrenciGuncelle_Click);
            // 
            // btnOgrenciKaydet
            // 
            this.btnOgrenciKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgrenciKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnOgrenciKaydet.Location = new System.Drawing.Point(123, 223);
            this.btnOgrenciKaydet.Name = "btnOgrenciKaydet";
            this.btnOgrenciKaydet.Size = new System.Drawing.Size(100, 36);
            this.btnOgrenciKaydet.TabIndex = 1;
            this.btnOgrenciKaydet.Text = "KAYDET";
            this.btnOgrenciKaydet.UseVisualStyleBackColor = true;
            this.btnOgrenciKaydet.Click += new System.EventHandler(this.btnOgrenciKaydet_Click);
            // 
            // mtxtOgrenciTcNo
            // 
            this.mtxtOgrenciTcNo.Location = new System.Drawing.Point(72, 111);
            this.mtxtOgrenciTcNo.Mask = "00000000000";
            this.mtxtOgrenciTcNo.Name = "mtxtOgrenciTcNo";
            this.mtxtOgrenciTcNo.Size = new System.Drawing.Size(151, 23);
            this.mtxtOgrenciTcNo.TabIndex = 7;
            this.mtxtOgrenciTcNo.ValidatingType = typeof(int);
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(72, 33);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(151, 23);
            this.txtOgrenciAd.TabIndex = 6;
            // 
            // txtOgrenciSifre
            // 
            this.txtOgrenciSifre.Location = new System.Drawing.Point(72, 185);
            this.txtOgrenciSifre.Name = "txtOgrenciSifre";
            this.txtOgrenciSifre.PasswordChar = '*';
            this.txtOgrenciSifre.Size = new System.Drawing.Size(151, 23);
            this.txtOgrenciSifre.TabIndex = 5;
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(72, 72);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(151, 23);
            this.txtOgrenciSoyad.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(72, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sınıftaki Öğrenciler:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // OgrenciKayitAlmaGuncellemeSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(577, 550);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "OgrenciKayitAlmaGuncellemeSilme";
            this.Text = "NOT KAYIT SİSTEMİ - Müdür Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OgrenciKayitAlmaGuncellemeSilme_FormClosing);
            this.Load += new System.EventHandler(this.OgrenciKayitAlmaGuncellemeSilme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOgrenciKaydet;
        private System.Windows.Forms.MaskedTextBox mtxtOgrenciTcNo;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.TextBox txtOgrenciSifre;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKiz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOgrenciGuncelle;
        private System.Windows.Forms.ListView lstOgrencilerListe;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.ColumnHeader col4;
        private System.Windows.Forms.ColumnHeader col5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSeciliOgrenciSil;
        private System.Windows.Forms.ListView lstMevcutSiniflar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}