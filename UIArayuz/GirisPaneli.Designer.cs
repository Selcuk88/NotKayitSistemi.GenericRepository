
namespace UIArayuz
{
    partial class GirisPaneli
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisPaneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbOgrenci = new System.Windows.Forms.PictureBox();
            this.pcbOgretmen = new System.Windows.Forms.PictureBox();
            this.pcbMudur = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOgrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOgretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMudur)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcbOgrenci);
            this.groupBox1.Controls.Add(this.pcbOgretmen);
            this.groupBox1.Controls.Add(this.pcbMudur);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Paneli";
            // 
            // pcbOgrenci
            // 
            this.pcbOgrenci.Image = ((System.Drawing.Image)(resources.GetObject("pcbOgrenci.Image")));
            this.pcbOgrenci.Location = new System.Drawing.Point(242, 64);
            this.pcbOgrenci.Name = "pcbOgrenci";
            this.pcbOgrenci.Size = new System.Drawing.Size(103, 91);
            this.pcbOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbOgrenci.TabIndex = 1;
            this.pcbOgrenci.TabStop = false;
            this.pcbOgrenci.Click += new System.EventHandler(this.pcbOgrenci_Click);
            // 
            // pcbOgretmen
            // 
            this.pcbOgretmen.Image = ((System.Drawing.Image)(resources.GetObject("pcbOgretmen.Image")));
            this.pcbOgretmen.Location = new System.Drawing.Point(130, 64);
            this.pcbOgretmen.Name = "pcbOgretmen";
            this.pcbOgretmen.Size = new System.Drawing.Size(103, 91);
            this.pcbOgretmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbOgretmen.TabIndex = 1;
            this.pcbOgretmen.TabStop = false;
            this.pcbOgretmen.Click += new System.EventHandler(this.pcbOgretmen_Click);
            // 
            // pcbMudur
            // 
            this.pcbMudur.Image = ((System.Drawing.Image)(resources.GetObject("pcbMudur.Image")));
            this.pcbMudur.Location = new System.Drawing.Point(18, 64);
            this.pcbMudur.Name = "pcbMudur";
            this.pcbMudur.Size = new System.Drawing.Size(103, 91);
            this.pcbMudur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMudur.TabIndex = 1;
            this.pcbMudur.TabStop = false;
            this.pcbMudur.Click += new System.EventHandler(this.pcbMudur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(264, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "ÖĞRENCİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(145, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ÖĞRETMEN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÜDÜR";
            // 
            // GirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(388, 258);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOT KAYIT SİSTEMİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GirisPaneli_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOgrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOgretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMudur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcbOgrenci;
        private System.Windows.Forms.PictureBox pcbOgretmen;
        private System.Windows.Forms.PictureBox pcbMudur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

