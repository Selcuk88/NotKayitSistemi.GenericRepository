
namespace UIArayuz
{
    partial class OgretmenKayitSilme
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
            this.btnOgretmenSil = new System.Windows.Forms.Button();
            this.lstOgretmenKadrosu = new System.Windows.Forms.ListView();
            this.col1 = new System.Windows.Forms.ColumnHeader();
            this.col2 = new System.Windows.Forms.ColumnHeader();
            this.col3 = new System.Windows.Forms.ColumnHeader();
            this.col4 = new System.Windows.Forms.ColumnHeader();
            this.col5 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOgretmenSil);
            this.groupBox1.Controls.Add(this.lstOgretmenKadrosu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Kayıt Silme İşlemleri";
            // 
            // btnOgretmenSil
            // 
            this.btnOgretmenSil.ForeColor = System.Drawing.Color.Black;
            this.btnOgretmenSil.Location = new System.Drawing.Point(336, 269);
            this.btnOgretmenSil.Name = "btnOgretmenSil";
            this.btnOgretmenSil.Size = new System.Drawing.Size(104, 32);
            this.btnOgretmenSil.TabIndex = 2;
            this.btnOgretmenSil.Text = "Sil";
            this.btnOgretmenSil.UseVisualStyleBackColor = true;
            this.btnOgretmenSil.Click += new System.EventHandler(this.btnOgretmenSil_Click);
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
            this.lstOgretmenKadrosu.Location = new System.Drawing.Point(6, 52);
            this.lstOgretmenKadrosu.MultiSelect = false;
            this.lstOgretmenKadrosu.Name = "lstOgretmenKadrosu";
            this.lstOgretmenKadrosu.Size = new System.Drawing.Size(434, 211);
            this.lstOgretmenKadrosu.TabIndex = 1;
            this.lstOgretmenKadrosu.UseCompatibleStateImageBehavior = false;
            this.lstOgretmenKadrosu.View = System.Windows.Forms.View.Details;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğretmen Kadrosu:";
            // 
            // OgretmenKayitSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(471, 331);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OgretmenKayitSilme";
            this.Text = "NOT KAYIT SİSTEMİ - Müdür Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OgretmenKayitSilme_FormClosing);
            this.Load += new System.EventHandler(this.OgretmenKayitSilme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgretmenSil;
        private System.Windows.Forms.ListView lstOgretmenKadrosu;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.ColumnHeader col4;
        private System.Windows.Forms.ColumnHeader col5;
    }
}