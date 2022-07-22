
namespace UIArayuz
{
    partial class SinifIslemleri
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
            this.col1 = new System.Windows.Forms.ColumnHeader();
            this.col2 = new System.Windows.Forms.ColumnHeader();
            this.col3 = new System.Windows.Forms.ColumnHeader();
            this.col4 = new System.Windows.Forms.ColumnHeader();
            this.col5 = new System.Windows.Forms.ColumnHeader();
            this.btnSinifKapat = new System.Windows.Forms.Button();
            this.btnSinifAc = new System.Windows.Forms.Button();
            this.cmbSinifSubeler = new System.Windows.Forms.ComboBox();
            this.lblSube = new System.Windows.Forms.Label();
            this.nmrSinifKapasite = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrSinifNo = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSinifKapasite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSinifNo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstMevcutSiniflar);
            this.groupBox1.Controls.Add(this.btnSinifKapat);
            this.groupBox1.Controls.Add(this.btnSinifAc);
            this.groupBox1.Controls.Add(this.cmbSinifSubeler);
            this.groupBox1.Controls.Add(this.lblSube);
            this.groupBox1.Controls.Add(this.nmrSinifKapasite);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nmrSinifNo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(379, 489);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınıf Açma-Kapatma İşlemleri";
            // 
            // lstMevcutSiniflar
            // 
            this.lstMevcutSiniflar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5});
            this.lstMevcutSiniflar.FullRowSelect = true;
            this.lstMevcutSiniflar.HideSelection = false;
            this.lstMevcutSiniflar.Location = new System.Drawing.Point(16, 229);
            this.lstMevcutSiniflar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstMevcutSiniflar.MultiSelect = false;
            this.lstMevcutSiniflar.Name = "lstMevcutSiniflar";
            this.lstMevcutSiniflar.Size = new System.Drawing.Size(342, 179);
            this.lstMevcutSiniflar.TabIndex = 7;
            this.lstMevcutSiniflar.UseCompatibleStateImageBehavior = false;
            this.lstMevcutSiniflar.View = System.Windows.Forms.View.Details;
            // 
            // col1
            // 
            this.col1.Text = "ID";
            this.col1.Width = 50;
            // 
            // col2
            // 
            this.col2.Text = "Sınıf No";
            // 
            // col3
            // 
            this.col3.Text = "Şube";
            // 
            // col4
            // 
            this.col4.Text = "Kapasite";
            // 
            // col5
            // 
            this.col5.Text = "Mevcut";
            // 
            // btnSinifKapat
            // 
            this.btnSinifKapat.ForeColor = System.Drawing.Color.Black;
            this.btnSinifKapat.Location = new System.Drawing.Point(16, 417);
            this.btnSinifKapat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSinifKapat.Name = "btnSinifKapat";
            this.btnSinifKapat.Size = new System.Drawing.Size(343, 53);
            this.btnSinifKapat.TabIndex = 6;
            this.btnSinifKapat.Text = "SEÇİLİ SINIFI KAPAT";
            this.btnSinifKapat.UseVisualStyleBackColor = true;
            this.btnSinifKapat.Click += new System.EventHandler(this.btnSinifKapat_Click);
            // 
            // btnSinifAc
            // 
            this.btnSinifAc.ForeColor = System.Drawing.Color.Black;
            this.btnSinifAc.Location = new System.Drawing.Point(234, 52);
            this.btnSinifAc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSinifAc.Name = "btnSinifAc";
            this.btnSinifAc.Size = new System.Drawing.Size(125, 127);
            this.btnSinifAc.TabIndex = 6;
            this.btnSinifAc.Text = "SINIF AÇ";
            this.btnSinifAc.UseVisualStyleBackColor = true;
            this.btnSinifAc.Click += new System.EventHandler(this.btnSinifAc_Click);
            // 
            // cmbSinifSubeler
            // 
            this.cmbSinifSubeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSinifSubeler.FormattingEnabled = true;
            this.cmbSinifSubeler.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbSinifSubeler.Location = new System.Drawing.Point(137, 99);
            this.cmbSinifSubeler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSinifSubeler.Name = "cmbSinifSubeler";
            this.cmbSinifSubeler.Size = new System.Drawing.Size(65, 28);
            this.cmbSinifSubeler.TabIndex = 5;
            // 
            // lblSube
            // 
            this.lblSube.AutoSize = true;
            this.lblSube.Location = new System.Drawing.Point(70, 104);
            this.lblSube.Name = "lblSube";
            this.lblSube.Size = new System.Drawing.Size(47, 20);
            this.lblSube.TabIndex = 4;
            this.lblSube.Text = "Şube:";
            // 
            // nmrSinifKapasite
            // 
            this.nmrSinifKapasite.Location = new System.Drawing.Point(137, 148);
            this.nmrSinifKapasite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmrSinifKapasite.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nmrSinifKapasite.Name = "nmrSinifKapasite";
            this.nmrSinifKapasite.Size = new System.Drawing.Size(65, 27);
            this.nmrSinifKapasite.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mevcut Sınıflar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sınıf Kapasite:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sınıf No:";
            // 
            // nmrSinifNo
            // 
            this.nmrSinifNo.Location = new System.Drawing.Point(137, 52);
            this.nmrSinifNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmrSinifNo.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmrSinifNo.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nmrSinifNo.Name = "nmrSinifNo";
            this.nmrSinifNo.Size = new System.Drawing.Size(65, 27);
            this.nmrSinifNo.TabIndex = 1;
            this.nmrSinifNo.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // SinifIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(407, 521);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SinifIslemleri";
            this.Text = "NOT KAYIT SİSTEMİ - Müdür Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SinifIslemleri_FormClosing);
            this.Load += new System.EventHandler(this.SinifIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSinifKapasite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSinifNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmrSinifKapasite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrSinifNo;
        private System.Windows.Forms.ComboBox cmbSinifSubeler;
        private System.Windows.Forms.Label lblSube;
        private System.Windows.Forms.Button btnSinifKapat;
        private System.Windows.Forms.Button btnSinifAc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstMevcutSiniflar;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.ColumnHeader col4;
        private System.Windows.Forms.ColumnHeader col5;
    }
}