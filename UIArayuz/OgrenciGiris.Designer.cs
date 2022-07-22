
namespace UIArayuz
{
    partial class OgrenciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciGiris));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkOgrenciSifreUnuttum = new System.Windows.Forms.LinkLabel();
            this.txtOgrenciSifre = new System.Windows.Forms.TextBox();
            this.mtxtOgrenciTc = new System.Windows.Forms.MaskedTextBox();
            this.btnOgrenciGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkOgrenciSifreUnuttum);
            this.groupBox1.Controls.Add(this.txtOgrenciSifre);
            this.groupBox1.Controls.Add(this.mtxtOgrenciTc);
            this.groupBox1.Controls.Add(this.btnOgrenciGiris);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Giriş Paneli";
            // 
            // lnkOgrenciSifreUnuttum
            // 
            this.lnkOgrenciSifreUnuttum.AutoSize = true;
            this.lnkOgrenciSifreUnuttum.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lnkOgrenciSifreUnuttum.Location = new System.Drawing.Point(253, 155);
            this.lnkOgrenciSifreUnuttum.Name = "lnkOgrenciSifreUnuttum";
            this.lnkOgrenciSifreUnuttum.Size = new System.Drawing.Size(84, 12);
            this.lnkOgrenciSifreUnuttum.TabIndex = 1;
            this.lnkOgrenciSifreUnuttum.TabStop = true;
            this.lnkOgrenciSifreUnuttum.Text = "Şifremi Unuttum";
            // 
            // txtOgrenciSifre
            // 
            this.txtOgrenciSifre.Location = new System.Drawing.Point(188, 78);
            this.txtOgrenciSifre.Name = "txtOgrenciSifre";
            this.txtOgrenciSifre.PasswordChar = '*';
            this.txtOgrenciSifre.Size = new System.Drawing.Size(149, 23);
            this.txtOgrenciSifre.TabIndex = 4;
            // 
            // mtxtOgrenciTc
            // 
            this.mtxtOgrenciTc.Location = new System.Drawing.Point(188, 38);
            this.mtxtOgrenciTc.Mask = "00000000000";
            this.mtxtOgrenciTc.Name = "mtxtOgrenciTc";
            this.mtxtOgrenciTc.Size = new System.Drawing.Size(149, 23);
            this.mtxtOgrenciTc.TabIndex = 3;
            this.mtxtOgrenciTc.ValidatingType = typeof(int);
            this.mtxtOgrenciTc.TextChanged += new System.EventHandler(this.mtxtOgrenciTc_TextChanged);
            // 
            // btnOgrenciGiris
            // 
            this.btnOgrenciGiris.BackColor = System.Drawing.Color.Black;
            this.btnOgrenciGiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOgrenciGiris.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOgrenciGiris.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgrenciGiris.ForeColor = System.Drawing.Color.White;
            this.btnOgrenciGiris.Location = new System.Drawing.Point(225, 118);
            this.btnOgrenciGiris.Name = "btnOgrenciGiris";
            this.btnOgrenciGiris.Size = new System.Drawing.Size(112, 34);
            this.btnOgrenciGiris.TabIndex = 2;
            this.btnOgrenciGiris.Text = "Giriş Yap";
            this.btnOgrenciGiris.UseVisualStyleBackColor = false;
            this.btnOgrenciGiris.Click += new System.EventHandler(this.btnOgrenciGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC No:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(386, 205);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OgrenciGiris";
            this.Text = "NOT KAYIT SİSTEMİ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OgrenciGiris_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkOgrenciSifreUnuttum;
        private System.Windows.Forms.TextBox txtOgrenciSifre;
        private System.Windows.Forms.MaskedTextBox mtxtOgrenciTc;
        private System.Windows.Forms.Button btnOgrenciGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}