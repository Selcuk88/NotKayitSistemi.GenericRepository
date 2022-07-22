using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIArayuz
{
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        OgrenciManager ogrenciManager = new OgrenciManager(new EfOgrenciDal());
        SinifManager sinifManager = new SinifManager(new EfSinifDal());

        private void OgrenciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisPaneli girisPaneli = new GirisPaneli();
            girisPaneli.Show();
            this.Hide();
        }

        private void mtxtOgrenciTc_TextChanged(object sender, EventArgs e)
        {
            mtxtOgrenciTc.Text = mtxtOgrenciTc.Text.Trim();
        }

        private void btnOgrenciGiris_Click(object sender, EventArgs e)
        {
            if (ogrenciManager.OgrenciBilgiKontrol(mtxtOgrenciTc.Text,txtOgrenciSifre.Text,out Ogrenci ogrenci))
            {
                MessageBox.Show("Giriş başarılı.","Sistem Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                OgrenciPaneli ogrenciPaneli = new OgrenciPaneli();
                ogrenciPaneli.Show();
                foreach (Control item in ogrenciPaneli.Controls)
                {
                    if (item.Name=="gbOgrenciBilgileri")
                    {
                        foreach (Control control in item.Controls)
                        {
                            if (control.Name== "lblTcNo")
                            {
                                control.Text = ogrenci.TcNo;
                            }
                            else if (control.Name== "lblAdSoyad")
                            {
                                control.Text = ogrenci.OgrenciAd + " " + ogrenci.OgrenciSoyad;
                            }
                            else if (control.Name== "lblSinif")
                            {
                                control.Text = sinifManager.GetSinif(ogrenci.SinifID).Seviye.ToString() + "-" + sinifManager.GetSinif(ogrenci.SinifID).Sube;
                            }
                        }
                    }
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş bilgileriniz hatalı.\nLütfen tekrar deneyiniz.", "Sistem Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
