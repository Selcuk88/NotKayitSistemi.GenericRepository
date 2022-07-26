
namespace UIArayuz
{
    partial class OgretmenGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenGiris));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkOgretmenSifreUnuttum = new System.Windows.Forms.LinkLabel();
            this.txtOgretmenSifre = new System.Windows.Forms.TextBox();
            this.mtxtOgretmenTc = new System.Windows.Forms.MaskedTextBox();
            this.btnOgretmenGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkOgretmenSifreUnuttum);
            this.groupBox1.Controls.Add(this.txtOgretmenSifre);
            this.groupBox1.Controls.Add(this.mtxtOgretmenTc);
            this.groupBox1.Controls.Add(this.btnOgretmenGiris);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(415, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Giriş Paneli";
            // 
            // lnkOgretmenSifreUnuttum
            // 
            this.lnkOgretmenSifreUnuttum.AutoSize = true;
            this.lnkOgretmenSifreUnuttum.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lnkOgretmenSifreUnuttum.Location = new System.Drawing.Point(289, 207);
            this.lnkOgretmenSifreUnuttum.Name = "lnkOgretmenSifreUnuttum";
            this.lnkOgretmenSifreUnuttum.Size = new System.Drawing.Size(102, 15);
            this.lnkOgretmenSifreUnuttum.TabIndex = 1;
            this.lnkOgretmenSifreUnuttum.TabStop = true;
            this.lnkOgretmenSifreUnuttum.Text = "Şifremi Unuttum";
            // 
            // txtOgretmenSifre
            // 
            this.txtOgretmenSifre.Location = new System.Drawing.Point(215, 104);
            this.txtOgretmenSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOgretmenSifre.Name = "txtOgretmenSifre";
            this.txtOgretmenSifre.PasswordChar = '*';
            this.txtOgretmenSifre.Size = new System.Drawing.Size(170, 27);
            this.txtOgretmenSifre.TabIndex = 4;
            // 
            // mtxtOgretmenTc
            // 
            this.mtxtOgretmenTc.Location = new System.Drawing.Point(215, 51);
            this.mtxtOgretmenTc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtOgretmenTc.Mask = "00000000000";
            this.mtxtOgretmenTc.Name = "mtxtOgretmenTc";
            this.mtxtOgretmenTc.Size = new System.Drawing.Size(170, 27);
            this.mtxtOgretmenTc.TabIndex = 3;
            this.mtxtOgretmenTc.ValidatingType = typeof(int);
            this.mtxtOgretmenTc.TextChanged += new System.EventHandler(this.mtxtOgretmenTc_TextChanged);
            // 
            // btnOgretmenGiris
            // 
            this.btnOgretmenGiris.BackColor = System.Drawing.Color.Black;
            this.btnOgretmenGiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOgretmenGiris.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOgretmenGiris.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgretmenGiris.ForeColor = System.Drawing.Color.White;
            this.btnOgretmenGiris.Location = new System.Drawing.Point(257, 157);
            this.btnOgretmenGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOgretmenGiris.Name = "btnOgretmenGiris";
            this.btnOgretmenGiris.Size = new System.Drawing.Size(128, 45);
            this.btnOgretmenGiris.TabIndex = 2;
            this.btnOgretmenGiris.Text = "Giriş Yap";
            this.btnOgretmenGiris.UseVisualStyleBackColor = false;
            this.btnOgretmenGiris.Click += new System.EventHandler(this.btnOgretmenGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC No:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OgretmenGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(440, 275);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "OgretmenGiris";
            this.Text = "NOT KAYIT SİSTEMİ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OgretmenGiris_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkOgretmenSifreUnuttum;
        private System.Windows.Forms.TextBox txtOgretmenSifre;
        private System.Windows.Forms.MaskedTextBox mtxtOgretmenTc;
        private System.Windows.Forms.Button btnOgretmenGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}