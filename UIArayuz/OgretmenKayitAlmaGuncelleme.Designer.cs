
namespace UIArayuz
{
    partial class OgretmenKayitAlmaGuncelleme
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
            this.label6 = new System.Windows.Forms.Label();
            this.lstOgretmenKadrosu = new System.Windows.Forms.ListView();
            this.col1 = new System.Windows.Forms.ColumnHeader();
            this.col2 = new System.Windows.Forms.ColumnHeader();
            this.col3 = new System.Windows.Forms.ColumnHeader();
            this.col4 = new System.Windows.Forms.ColumnHeader();
            this.col5 = new System.Windows.Forms.ColumnHeader();
            this.btnOgretmenKaydet = new System.Windows.Forms.Button();
            this.btnOgretmenGuncelle = new System.Windows.Forms.Button();
            this.cmbDersler = new System.Windows.Forms.ComboBox();
            this.mtxtOgretmenTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtOgretmenAd = new System.Windows.Forms.TextBox();
            this.txtOgretmenSifre = new System.Windows.Forms.TextBox();
            this.txtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lstOgretmenKadrosu);
            this.groupBox1.Controls.Add(this.btnOgretmenKaydet);
            this.groupBox1.Controls.Add(this.btnOgretmenGuncelle);
            this.groupBox1.Controls.Add(this.cmbDersler);
            this.groupBox1.Controls.Add(this.mtxtOgretmenTcNo);
            this.groupBox1.Controls.Add(this.txtOgretmenAd);
            this.groupBox1.Controls.Add(this.txtOgretmenSifre);
            this.groupBox1.Controls.Add(this.txtOgretmenSoyad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Kayıt - Güncelleme İşlemleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(288, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Öğretmen Kadrosu:";
            // 
            // lstOgretmenKadrosu
            // 
            this.lstOgretmenKadrosu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5});
            this.lstOgretmenKadrosu.FullRowSelect = true;
            this.lstOgretmenKadrosu.HideSelection = false;
            this.lstOgretmenKadrosu.Location = new System.Drawing.Point(252, 52);
            this.lstOgretmenKadrosu.MultiSelect = false;
            this.lstOgretmenKadrosu.Name = "lstOgretmenKadrosu";
            this.lstOgretmenKadrosu.Size = new System.Drawing.Size(434, 140);
            this.lstOgretmenKadrosu.TabIndex = 8;
            this.lstOgretmenKadrosu.UseCompatibleStateImageBehavior = false;
            this.lstOgretmenKadrosu.View = System.Windows.Forms.View.Details;
            this.lstOgretmenKadrosu.DoubleClick += new System.EventHandler(this.lstOgretmenKadrosu_DoubleClick);
            // 
            // col1
            // 
            this.col1.Text = "ID";
            this.col1.Width = 30;
            // 
            // col2
            // 
            this.col2.Text = "Ad";
            this.col2.Width = 100;
            // 
            // col3
            // 
            this.col3.Text = "Soyad";
            this.col3.Width = 100;
            // 
            // col4
            // 
            this.col4.Text = "TC No";
            this.col4.Width = 100;
            // 
            // col5
            // 
            this.col5.Text = "Ders";
            this.col5.Width = 100;
            // 
            // btnOgretmenKaydet
            // 
            this.btnOgretmenKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgretmenKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnOgretmenKaydet.Location = new System.Drawing.Point(100, 227);
            this.btnOgretmenKaydet.Name = "btnOgretmenKaydet";
            this.btnOgretmenKaydet.Size = new System.Drawing.Size(199, 36);
            this.btnOgretmenKaydet.TabIndex = 1;
            this.btnOgretmenKaydet.Text = "KAYDET";
            this.btnOgretmenKaydet.UseVisualStyleBackColor = true;
            this.btnOgretmenKaydet.Click += new System.EventHandler(this.btnOgretmenKaydet_Click);
            // 
            // btnOgretmenGuncelle
            // 
            this.btnOgretmenGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgretmenGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnOgretmenGuncelle.Location = new System.Drawing.Point(393, 227);
            this.btnOgretmenGuncelle.Name = "btnOgretmenGuncelle";
            this.btnOgretmenGuncelle.Size = new System.Drawing.Size(188, 36);
            this.btnOgretmenGuncelle.TabIndex = 1;
            this.btnOgretmenGuncelle.Text = "GÜNCELLE";
            this.btnOgretmenGuncelle.UseVisualStyleBackColor = true;
            this.btnOgretmenGuncelle.Click += new System.EventHandler(this.btnOgretmenGuncelle_Click);
            // 
            // cmbDersler
            // 
            this.cmbDersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDersler.FormattingEnabled = true;
            this.cmbDersler.Location = new System.Drawing.Point(72, 169);
            this.cmbDersler.Name = "cmbDersler";
            this.cmbDersler.Size = new System.Drawing.Size(151, 23);
            this.cmbDersler.TabIndex = 1;
            // 
            // mtxtOgretmenTcNo
            // 
            this.mtxtOgretmenTcNo.Location = new System.Drawing.Point(72, 101);
            this.mtxtOgretmenTcNo.Mask = "00000000000";
            this.mtxtOgretmenTcNo.Name = "mtxtOgretmenTcNo";
            this.mtxtOgretmenTcNo.Size = new System.Drawing.Size(151, 23);
            this.mtxtOgretmenTcNo.TabIndex = 7;
            this.mtxtOgretmenTcNo.ValidatingType = typeof(int);
            // 
            // txtOgretmenAd
            // 
            this.txtOgretmenAd.Location = new System.Drawing.Point(72, 33);
            this.txtOgretmenAd.Name = "txtOgretmenAd";
            this.txtOgretmenAd.Size = new System.Drawing.Size(151, 23);
            this.txtOgretmenAd.TabIndex = 6;
            // 
            // txtOgretmenSifre
            // 
            this.txtOgretmenSifre.Location = new System.Drawing.Point(72, 135);
            this.txtOgretmenSifre.Name = "txtOgretmenSifre";
            this.txtOgretmenSifre.PasswordChar = '*';
            this.txtOgretmenSifre.Size = new System.Drawing.Size(151, 23);
            this.txtOgretmenSifre.TabIndex = 5;
            // 
            // txtOgretmenSoyad
            // 
            this.txtOgretmenSoyad.Location = new System.Drawing.Point(72, 67);
            this.txtOgretmenSoyad.Name = "txtOgretmenSoyad";
            this.txtOgretmenSoyad.Size = new System.Drawing.Size(151, 23);
            this.txtOgretmenSoyad.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
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
            // OgretmenKayitAlmaGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(712, 308);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OgretmenKayitAlmaGuncelleme";
            this.Text = "NOT KAYIT SİSTEMİ - Müdür Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OgretmenKayitAlmaGuncelleme_FormClosing);
            this.Load += new System.EventHandler(this.OgretmenKayitAlmaGuncelleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtOgretmenTcNo;
        private System.Windows.Forms.TextBox txtOgretmenAd;
        private System.Windows.Forms.TextBox txtOgretmenSoyad;
        private System.Windows.Forms.TextBox txtOgretmenSifre;
        private System.Windows.Forms.Button btnOgretmenGuncelle;
        private System.Windows.Forms.Button btnOgretmenKaydet;
        private System.Windows.Forms.ListView lstOgretmenKadrosu;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.ColumnHeader col4;
        private System.Windows.Forms.ColumnHeader col5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDersler;
    }
}