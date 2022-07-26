using Business.Concrete;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace UIArayuz
{
    public partial class OgretmenGiris : Form
    {
        public OgretmenGiris()
        {
            InitializeComponent();
        }

        OgretmenManager ogretmenManager = new OgretmenManager(new EfOgretmenDal());
        DersManager dersManager = new DersManager(new EfDersDal());
        Ogretmen ogretmen;

        private void OgretmenGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisPaneli girisPaneli = new GirisPaneli();
            girisPaneli.Show();
            this.Hide();
        }

        private void mtxtOgretmenTc_TextChanged(object sender, EventArgs e)
        {
            mtxtOgretmenTc.Text = mtxtOgretmenTc.Text.Trim();
        }

        private void btnOgretmenGiris_Click(object sender, EventArgs e)
        {
            IResult result = ogretmenManager.Ogretmenmi(mtxtOgretmenTc.Text, txtOgretmenSifre.Text);
            if (result.Success)
            {
                MessageBox.Show(result.Message,"Sistem Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);

                OgretmenPaneli ogretmenPaneli = new OgretmenPaneli();

                ogretmenPaneli.Tag = ((SuccessDataResult<Ogretmen>)result).Data;
                ogretmen = (Ogretmen)ogretmenPaneli.Tag;

                foreach (Control groupBox in ogretmenPaneli.Controls)
                {
                    if (groupBox.Name== "gbxOgretmenBilgileri")
                    {
                        foreach (Control label in groupBox.Controls)
                        {
                            if (label.Name== "lblOgretmenAd")
                            {
                                label.Text = ogretmen.OgretmenAd;
                            }
                            else if (label.Name== "lblOgretmenSoyad")
                            {
                                label.Text = ogretmen.OgretmenSoyad;
                            }
                            else if (label.Name== "lblOgretmenBrans")
                            {
                                label.Text = dersManager.DersiGetir(ogretmen.DersID).DersAd;
                            }
                        }
                    }
                }
                ogretmenPaneli.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show(result.Message,"Sistem Uyarısı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            

        }
    }
}
