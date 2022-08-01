using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.JoiningTables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace UIArayuz
{
    public partial class OgrenciPaneli : Form
    {
        public OgrenciPaneli()
        {
            InitializeComponent();
        }

        DersManager dersManager = new DersManager(new EfDersDal());

        OgretmenManager ogretmenManager = new OgretmenManager(new EfOgretmenDal());
        SinifManager sinifManager = new SinifManager(new EfSinifDal());
        SiniflarOgretmenlerManager SiniflarOgretmenlerManager = new SiniflarOgretmenlerManager(new EfSiniflarOgretmenlerDal());
        SinavManager sinavManager = new SinavManager(new EfSinavDal());
        BasariManager basariManager = new BasariManager(new EfBasariDal());

        Ogrenci ogrenci;
        Ogretmen ogretmen;
        Sinif sinif;
        Ders ders;
        List<Sinav> sinavlar;
        Basari basari;

        private void OgrenciPaneli_Load(object sender, EventArgs e)
        {
            ogrenci = (Ogrenci)this.Tag;
            sinif = sinifManager.GetSinif(ogrenci.SinifID);

            List<SiniflarOgretmenler> siniflarOgretmenler = SiniflarOgretmenlerManager.SinifinOgretmenleri(ogrenci.SinifID);

            foreach (SiniflarOgretmenler sinifOgretmen in siniflarOgretmenler)
            {
                ogretmen = ogretmenManager.OgretmenGetir(sinifOgretmen.OgretmenID);
                ders = dersManager.DersiGetir(ogretmen.DersID);

                ListViewItem ogrencininDersleri = new ListViewItem(ders.DersAd);
                ogrencininDersleri.SubItems.Add(ogretmen.OgretmenAd + " " + ogretmen.OgretmenSoyad);                

                sinavlar = sinavManager.OgrencininSinavlari(ogrenci.OgrenciID, ogretmen.OgretmenID);
                for (int i = 0; i < sinavlar.Count; i++)
                {
                    ogrencininDersleri.SubItems.Add(sinavlar[i].Puan.ToString());
                }

                basari = basariManager.OgrencininBasarisi(ogrenci.OgrenciID, ders.DersID);
                if (basari != null)
                {
                    ogrencininDersleri.SubItems.Add(basari.Ortalama.ToString());
                    ogrencininDersleri.SubItems.Add(basari.BasariDurumu.ToString());
                    if (basari.BasariDurumu==Entities.Enums.BasariDurumu.Gecti)
                    {
                        ogrencininDersleri.BackColor = Color.Green;
                    }
                    else if(basari.BasariDurumu==Entities.Enums.BasariDurumu.Kaldi)
                    {
                        ogrencininDersleri.BackColor = Color.Red;
                    }
                }
                lstDerslerim.Items.Add(ogrencininDersleri);
            }
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnDersCikar_Click(object sender, EventArgs e)
        {

        }
    }
}
