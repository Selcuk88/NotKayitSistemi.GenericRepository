namespace UIArayuz
{
    partial class SinifAtama
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGorevlendirmeyiSil = new System.Windows.Forms.Button();
            this.btnGorevlendirmeyiOnayla = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lstOgretmeninSiniflari = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.lstMevcutSiniflar = new System.Windows.Forms.ListView();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.label8 = new System.Windows.Forms.Label();
            this.lstOgretmenKadrosu = new System.Windows.Forms.ListView();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnGorevlendirmeyiSil);
            this.groupBox2.Controls.Add(this.btnGorevlendirmeyiOnayla);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lstOgretmeninSiniflari);
            this.groupBox2.Controls.Add(this.lstMevcutSiniflar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lstOgretmenKadrosu);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 852);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınıf Atama İşlemleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 60);
            this.label6.TabIndex = 15;
            this.label6.Text = "Öğretmen kadorsunda seçili öğretmenin görevli olduğu sınıflar \r\naşağıdadır. Silme" +
    "k istediğiniz bir görevlendirmeyi seçerek \r\ngörevlendirmeyi sil butonuna basınız" +
    ".";
            // 
            // btnGorevlendirmeyiSil
            // 
            this.btnGorevlendirmeyiSil.ForeColor = System.Drawing.Color.Black;
            this.btnGorevlendirmeyiSil.Location = new System.Drawing.Point(288, 804);
            this.btnGorevlendirmeyiSil.Name = "btnGorevlendirmeyiSil";
            this.btnGorevlendirmeyiSil.Size = new System.Drawing.Size(221, 38);
            this.btnGorevlendirmeyiSil.TabIndex = 14;
            this.btnGorevlendirmeyiSil.Text = "Görevlendirmeyi Sil";
            this.btnGorevlendirmeyiSil.UseVisualStyleBackColor = true;
            // 
            // btnGorevlendirmeyiOnayla
            // 
            this.btnGorevlendirmeyiOnayla.ForeColor = System.Drawing.Color.Black;
            this.btnGorevlendirmeyiOnayla.Location = new System.Drawing.Point(288, 484);
            this.btnGorevlendirmeyiOnayla.Name = "btnGorevlendirmeyiOnayla";
            this.btnGorevlendirmeyiOnayla.Size = new System.Drawing.Size(221, 38);
            this.btnGorevlendirmeyiOnayla.TabIndex = 14;
            this.btnGorevlendirmeyiOnayla.Text = "Görevlendirmeyi Onayla";
            this.btnGorevlendirmeyiOnayla.UseVisualStyleBackColor = true;
            this.btnGorevlendirmeyiOnayla.Click += new System.EventHandler(this.btnGorevlendirmeyiOnayla_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 620);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Öğretmenin Sınıfları:";
            // 
            // lstOgretmeninSiniflari
            // 
            this.lstOgretmeninSiniflari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lstOgretmeninSiniflari.FullRowSelect = true;
            this.lstOgretmeninSiniflari.HideSelection = false;
            this.lstOgretmeninSiniflari.Location = new System.Drawing.Point(12, 659);
            this.lstOgretmeninSiniflari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstOgretmeninSiniflari.MultiSelect = false;
            this.lstOgretmeninSiniflari.Name = "lstOgretmeninSiniflari";
            this.lstOgretmeninSiniflari.Size = new System.Drawing.Size(497, 126);
            this.lstOgretmeninSiniflari.TabIndex = 12;
            this.lstOgretmeninSiniflari.UseCompatibleStateImageBehavior = false;
            this.lstOgretmeninSiniflari.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Sınıf No";
            this.columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Şube";
            this.columnHeader9.Width = 200;
            // 
            // lstMevcutSiniflar
            // 
            this.lstMevcutSiniflar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lstMevcutSiniflar.FullRowSelect = true;
            this.lstMevcutSiniflar.HideSelection = false;
            this.lstMevcutSiniflar.Location = new System.Drawing.Point(12, 339);
            this.lstMevcutSiniflar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstMevcutSiniflar.MultiSelect = false;
            this.lstMevcutSiniflar.Name = "lstMevcutSiniflar";
            this.lstMevcutSiniflar.Size = new System.Drawing.Size(497, 126);
            this.lstMevcutSiniflar.TabIndex = 11;
            this.lstMevcutSiniflar.UseCompatibleStateImageBehavior = false;
            this.lstMevcutSiniflar.View = System.Windows.Forms.View.Details;
            this.lstMevcutSiniflar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstMevcutSiniflar_MouseClick);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            this.columnHeader10.Width = 50;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Sınıf No";
            this.columnHeader11.Width = 200;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Şube";
            this.columnHeader12.Width = 200;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mevcut Sınıflar:";
            // 
            // lstOgretmenKadrosu
            // 
            this.lstOgretmenKadrosu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.lstOgretmenKadrosu.FullRowSelect = true;
            this.lstOgretmenKadrosu.HideSelection = false;
            this.lstOgretmenKadrosu.Location = new System.Drawing.Point(12, 155);
            this.lstOgretmenKadrosu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstOgretmenKadrosu.MultiSelect = false;
            this.lstOgretmenKadrosu.Name = "lstOgretmenKadrosu";
            this.lstOgretmenKadrosu.Size = new System.Drawing.Size(497, 126);
            this.lstOgretmenKadrosu.TabIndex = 9;
            this.lstOgretmenKadrosu.UseCompatibleStateImageBehavior = false;
            this.lstOgretmenKadrosu.View = System.Windows.Forms.View.Details;
            this.lstOgretmenKadrosu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstOgretmenKadrosu_MouseClick);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "ID";
            this.columnHeader13.Width = 50;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Ad";
            this.columnHeader14.Width = 110;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Soyad";
            this.columnHeader15.Width = 110;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "TC No";
            this.columnHeader16.Width = 110;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Ders";
            this.columnHeader17.Width = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Öğretmen Kadrosu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(477, 60);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mevcut öğretmen kadrosu ve mevcut sınıflar aşağıda listelenmiştir.\r\nHangi öğretme" +
    "ni hangi sınıfa atamak isiyorsanız listeler üzerinden \r\nseçim yapın ve seçimi on" +
    "ayla butonuna basın.";
            // 
            // SinifAtama
            // 
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(549, 870);
            this.Controls.Add(this.groupBox2);
            this.Name = "SinifAtama";
            this.Load += new System.EventHandler(this.SinifAtama_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGorevlendirmeyiSil;
        private System.Windows.Forms.Button btnGorevlendirmeyiOnayla;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lstOgretmeninSiniflari;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lstMevcutSiniflar;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lstOgretmenKadrosu;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}