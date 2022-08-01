using Business.Concrete;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
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
        Ogrenci ogrenci;

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
            IResult sonuc = ogrenciManager.OgrenciMi(mtxtOgrenciTc.Text, txtOgrenciSifre.Text);
            if (sonuc.Success)
            {
                MessageBox.Show(sonuc.Message,"Sistem Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                OgrenciPaneli ogrenciPaneli = new OgrenciPaneli();                
                ogrenci = ((SuccessDataResult<Ogrenci>)sonuc).Data;
                ogrenciPaneli.Tag = ogrenci;
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
                MessageBox.Show(((ErrorResult)sonuc).Message, "Sistem Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
