
namespace UIArayuz
{
    partial class DersIslemleri
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
            this.btnDersAc = new System.Windows.Forms.Button();
            this.ltbMevcutDersler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEklenecekDers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeciliDersiKapat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDersAc);
            this.groupBox1.Controls.Add(this.ltbMevcutDersler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEklenecekDers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSeciliDersiKapat);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Açma-Kapatma İşlemleri";
            // 
            // btnDersAc
            // 
            this.btnDersAc.ForeColor = System.Drawing.Color.Black;
            this.btnDersAc.Location = new System.Drawing.Point(225, 95);
            this.btnDersAc.Name = "btnDersAc";
            this.btnDersAc.Size = new System.Drawing.Size(143, 29);
            this.btnDersAc.TabIndex = 7;
            this.btnDersAc.Text = "Ders Aç";
            this.btnDersAc.UseVisualStyleBackColor = true;
            this.btnDersAc.Click += new System.EventHandler(this.btnDersAc_Click);
            // 
            // ltbMevcutDersler
            // 
            this.ltbMevcutDersler.FormattingEnabled = true;
            this.ltbMevcutDersler.ItemHeight = 15;
            this.ltbMevcutDersler.Location = new System.Drawing.Point(16, 47);
            this.ltbMevcutDersler.Name = "ltbMevcutDersler";
            this.ltbMevcutDersler.Size = new System.Drawing.Size(120, 94);
            this.ltbMevcutDersler.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mevcut Dersler:";
            // 
            // txtEklenecekDers
            // 
            this.txtEklenecekDers.Location = new System.Drawing.Point(225, 66);
            this.txtEklenecekDers.Name = "txtEklenecekDers";
            this.txtEklenecekDers.Size = new System.Drawing.Size(143, 23);
            this.txtEklenecekDers.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ders Ekle:";
            // 
            // btnSeciliDersiKapat
            // 
            this.btnSeciliDersiKapat.ForeColor = System.Drawing.Color.Black;
            this.btnSeciliDersiKapat.Location = new System.Drawing.Point(16, 147);
            this.btnSeciliDersiKapat.Name = "btnSeciliDersiKapat";
            this.btnSeciliDersiKapat.Size = new System.Drawing.Size(120, 29);
            this.btnSeciliDersiKapat.TabIndex = 1;
            this.btnSeciliDersiKapat.Text = "Seçili Dersi Kapat";
            this.btnSeciliDersiKapat.UseVisualStyleBackColor = true;
            this.btnSeciliDersiKapat.Click += new System.EventHandler(this.btnSeciliDersiKapat_Click);
            // 
            // DersIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(417, 213);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DersIslemleri";
            this.Text = "NOT KAYIT SİSTEMİ - Müdür Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DersIslemleri_FormClosing);
            this.Load += new System.EventHandler(this.DersIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEklenecekDers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeciliDersiKapat;
        private System.Windows.Forms.Button btnDersAc;
        private System.Windows.Forms.ListBox ltbMevcutDersler;
        private System.Windows.Forms.Label label1;
    }
}