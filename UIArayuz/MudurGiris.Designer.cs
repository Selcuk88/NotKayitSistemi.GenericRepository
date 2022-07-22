
namespace UIArayuz
{
    partial class MudurGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MudurGiris));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkMudurSifreUnuttum = new System.Windows.Forms.LinkLabel();
            this.txtMudurSifre = new System.Windows.Forms.TextBox();
            this.mtxtMudurTc = new System.Windows.Forms.MaskedTextBox();
            this.btnMudurGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkMudurSifreUnuttum);
            this.groupBox1.Controls.Add(this.txtMudurSifre);
            this.groupBox1.Controls.Add(this.mtxtMudurTc);
            this.groupBox1.Controls.Add(this.btnMudurGiris);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müdür Giriş Paneli";
            // 
            // lnkMudurSifreUnuttum
            // 
            this.lnkMudurSifreUnuttum.AutoSize = true;
            this.lnkMudurSifreUnuttum.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lnkMudurSifreUnuttum.Location = new System.Drawing.Point(253, 155);
            this.lnkMudurSifreUnuttum.Name = "lnkMudurSifreUnuttum";
            this.lnkMudurSifreUnuttum.Size = new System.Drawing.Size(84, 12);
            this.lnkMudurSifreUnuttum.TabIndex = 1;
            this.lnkMudurSifreUnuttum.TabStop = true;
            this.lnkMudurSifreUnuttum.Text = "Şifremi Unuttum";
            // 
            // txtMudurSifre
            // 
            this.txtMudurSifre.Location = new System.Drawing.Point(188, 78);
            this.txtMudurSifre.Name = "txtMudurSifre";
            this.txtMudurSifre.PasswordChar = '*';
            this.txtMudurSifre.Size = new System.Drawing.Size(149, 23);
            this.txtMudurSifre.TabIndex = 4;
            // 
            // mtxtMudurTc
            // 
            this.mtxtMudurTc.BeepOnError = true;
            this.mtxtMudurTc.Location = new System.Drawing.Point(188, 38);
            this.mtxtMudurTc.Mask = "00000000000";
            this.mtxtMudurTc.Name = "mtxtMudurTc";
            this.mtxtMudurTc.Size = new System.Drawing.Size(149, 23);
            this.mtxtMudurTc.TabIndex = 3;
            this.mtxtMudurTc.ValidatingType = typeof(int);
            this.mtxtMudurTc.TextChanged += new System.EventHandler(this.mtxtMudurTc_TextChanged);
            // 
            // btnMudurGiris
            // 
            this.btnMudurGiris.BackColor = System.Drawing.Color.Black;
            this.btnMudurGiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMudurGiris.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMudurGiris.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMudurGiris.ForeColor = System.Drawing.Color.White;
            this.btnMudurGiris.Location = new System.Drawing.Point(225, 118);
            this.btnMudurGiris.Name = "btnMudurGiris";
            this.btnMudurGiris.Size = new System.Drawing.Size(112, 34);
            this.btnMudurGiris.TabIndex = 2;
            this.btnMudurGiris.Text = "Giriş Yap";
            this.btnMudurGiris.UseVisualStyleBackColor = false;
            this.btnMudurGiris.Click += new System.EventHandler(this.btnMudurGiris_Click);
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
            // MudurGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MudurGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOT KAYIT SİSTEMİ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MudurGiris_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkMudurSifreUnuttum;
        private System.Windows.Forms.TextBox txtMudurSifre;
        private System.Windows.Forms.MaskedTextBox mtxtMudurTc;
        private System.Windows.Forms.Button btnMudurGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}