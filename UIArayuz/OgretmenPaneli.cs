using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.JoiningTables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UIArayuz
{
    public partial class OgretmenPaneli : Form
    {
        public OgretmenPaneli()
        {
            InitializeComponent();
        }

        SiniflarOgretmenlerManager siniflarOgretmenlerManager = new SiniflarOgretmenlerManager(new EfSiniflarOgretmenlerDal());
        SinifManager sinifManager = new SinifManager(new EfSinifDal());
        OgrenciManager ogrenciManager = new OgrenciManager(new EfOgrenciDal());
        SinavManager sinavManager = new SinavManager(new EfSinavDal());
        BasariManager basariManager = new BasariManager(new EfBasariDal());

        Sinif sinif;
        Ogrenci _ogrenci;
        Ogretmen ogretmen;
        Basari basari;
        List<Sinav> sinavlar;

        private void BasariOlustur()
        {
            basari = new Basari();
            for (int i = 0; i < sinavlar.Count; i++)
            {
                basari.Ortalama += sinavlar[i].Puan;
                if (i == 2)
                {
                    basari.Ortalama = basari.Ortalama / 3;
                    if (basari.Ortalama > 50)
                    {
                        basari.BasariDurumu = Entities.Enums.BasariDurumu.Gecti;
                    }
                    else
                    {
                        basari.BasariDurumu = Entities.Enums.BasariDurumu.Kaldi;
                    }
                    basari.DersID = ogretmen.DersID;
                    basari.OgrenciID = _ogrenci.OgrenciID;
                    basariManager.BasariEkle(basari);
                }
            }
        }
        private void NotListesiniDoldur()
        {
            lstOgrencininNotlari.Items.Clear();

            ListViewItem listViewItem = new ListViewItem();
            for (int i = 0; i < sinavlar.Count; i++)
            {
                if (i == 0)
                {
                    listViewItem.Text = sinavlar[i].Puan.ToString();
                    listViewItem.SubItems[i].Tag = sinavlar[i];
                }
                else
                {
                    listViewItem.SubItems.Add(sinavlar[i].Puan.ToString());
                    listViewItem.SubItems[i].Tag = sinavlar[i];
                }

                if (basari == null && sinavlar.Count == 3 && i==2)
                {
                    this.BasariOlustur();
                    listViewItem.SubItems.Add(basari.Ortalama.ToString());
                    if (basari.Ortalama > 50)
                    {
                        listViewItem.SubItems.Add("Geçti");
                    }
                    else
                    {
                        listViewItem.SubItems.Add("Kaldı");
                    }
                }
                else if (i == 2)
                {
                    listViewItem.SubItems.Add(basari.Ortalama.ToString());
                    listViewItem.SubItems.Add(basari.Ortalama > 50 ? "Geçti" : "Kaldı");
                }
            }
            lstOgrencininNotlari.Items.Add(listViewItem);
        }
        private void OgretmenPaneli_Load(object sender, EventArgs e)
        {
            nmrSinav1.Enabled = false;
            nmrSinav2.Enabled = false;
            nmrSinav3.Enabled = false;

            ogretmen = (Ogretmen)this.Tag;
            List<SiniflarOgretmenler> ogretmeninSiniflari = siniflarOgretmenlerManager.OgretmeninSiniflari(ogretmen);

            foreach (SiniflarOgretmenler sinifOgretmen in ogretmeninSiniflari)
            {
                sinif = sinifManager.GetSinif(sinifOgretmen.SinifID);
                ListViewItem listViewItem = new ListViewItem(sinif.Seviye);
                listViewItem.SubItems.Add(sinif.Sube);
                listViewItem.Tag = sinif;
                lstOgretmeninSiniflari.Items.Add(listViewItem);
            }
            btnNotKayit.Enabled = false;
            btnNotGuncelle.Enabled = false;
        }
        private void lstOgretmeninSiniflari_MouseClick(object sender, MouseEventArgs e)
        {
            lstSinifinOgrencileri.Items.Clear();
            List<Ogrenci> ogrenciler = ogrenciManager.AyniSiniftakiOgrenciler(((Sinif)lstOgretmeninSiniflari.SelectedItems[0].Tag).SinifID);
            foreach (Ogrenci ogrenci in ogrenciler)
            {
                ListViewItem listViewItem = new ListViewItem(ogrenci.TcNo);
                listViewItem.SubItems.Add(ogrenci.OgrenciAd);
                listViewItem.SubItems.Add(ogrenci.OgrenciSoyad);
                listViewItem.Tag = ogrenci;
                lstSinifinOgrencileri.Items.Add(listViewItem);
            }
        }
        private void lstSinifinOgrencileri_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            nmrSinav1.Enabled = true;
            nmrSinav2.Enabled = true;
            nmrSinav3.Enabled = true;

            nmrSinav1.Value = 0;
            nmrSinav2.Value = 0;
            nmrSinav3.Value = 0;

            btnNotKayit.Enabled = false;
            btnNotGuncelle.Enabled = false;

            _ogrenci = (Ogrenci)lstSinifinOgrencileri.SelectedItems[0].Tag;
            lblOgrenciAd.Text = _ogrenci.OgrenciAd;
            lblOgrenciSoyad.Text = _ogrenci.OgrenciSoyad;
            lblOgrenciTc.Text = _ogrenci.TcNo;

            sinavlar = sinavManager.OgrencininSinavlari(_ogrenci.OgrenciID, ogretmen.OgretmenID).OrderBy(x => x.SinavID).ToList();

            basari = basariManager.OgrencininBasarisi(_ogrenci.OgrenciID, ogretmen.DersID);

            this.NotListesiniDoldur();

            if (sinavlar.Count >= 0 && sinavlar.Count < 3)
            {
                btnNotKayit.Enabled = true;
            }

            if (sinavlar.Count == 1)
            {
                nmrSinav1.Value = decimal.Parse(lstOgrencininNotlari.Items[0].SubItems[0].Text);
                nmrSinav1.Enabled = false;
            }
            else if (sinavlar.Count == 2)
            {
                nmrSinav1.Value = decimal.Parse(lstOgrencininNotlari.Items[0].SubItems[0].Text);
                nmrSinav1.Enabled = false;
                nmrSinav2.Value = decimal.Parse(lstOgrencininNotlari.Items[0].SubItems[1].Text);
                nmrSinav2.Enabled = false;
            }
            else if (sinavlar.Count == 3)
            {
                nmrSinav1.Value = decimal.Parse(lstOgrencininNotlari.Items[0].SubItems[0].Text);
                nmrSinav1.Enabled = false;
                nmrSinav2.Value = decimal.Parse(lstOgrencininNotlari.Items[0].SubItems[1].Text);
                nmrSinav2.Enabled = false;
                nmrSinav3.Value = decimal.Parse(lstOgrencininNotlari.Items[0].SubItems[2].Text);
                nmrSinav3.Enabled = false;
            }
        }
        private void btnNotKayit_Click(object sender, EventArgs e)
        {
            Sinav sinav;
            if (nmrSinav1.Enabled && nmrSinav1.Value>0)
            {
                sinav = new Sinav { OgrenciID = _ogrenci.OgrenciID, OgretmenID = ogretmen.OgretmenID, Puan = (int)nmrSinav1.Value };
                sinavManager.SinavKayit(sinav);
                nmrSinav1.Enabled = false;
            }

            if (nmrSinav2.Enabled && nmrSinav2.Value>0)
            {
                sinav = new Sinav { OgrenciID = _ogrenci.OgrenciID, OgretmenID = ogretmen.OgretmenID, Puan = (int)nmrSinav2.Value };
                sinavManager.SinavKayit(sinav);
                nmrSinav2.Enabled = false;
            }

            if (nmrSinav3.Enabled && nmrSinav3.Value>0)
            {
                sinav = new Sinav { OgrenciID = _ogrenci.OgrenciID, OgretmenID = ogretmen.OgretmenID, Puan = (int)nmrSinav3.Value };
                sinavManager.SinavKayit(sinav);
                nmrSinav3.Enabled = false;
            }

            sinavlar = sinavManager.OgrencininSinavlari(_ogrenci.OgrenciID, ogretmen.OgretmenID).OrderBy(x => x.SinavID).ToList();
            if (sinavlar.Count == 3)
            {
                btnNotKayit.Enabled = false;
            }

            this.NotListesiniDoldur();
        }
        private void btnNotGuncelle_Click(object sender, EventArgs e)
        {
            Sinav sinav;
            if (nmrSinav1.Enabled)
            {
                sinav = (Sinav)lstOgrencininNotlari.Items[0].SubItems[0].Tag;
                sinav.Puan = (int)nmrSinav1.Value;
                nmrSinav1.Enabled = false;
                sinavManager.SinavGuncelle(sinav);

            }

            if (nmrSinav2.Enabled)
            {
                sinav = (Sinav)lstOgrencininNotlari.Items[0].SubItems[1].Tag;
                sinav.Puan = (int)nmrSinav2.Value;
                nmrSinav2.Enabled = false;
                sinavManager.SinavGuncelle(sinav);
            }

            if (nmrSinav3.Enabled)
            {
                sinav = (Sinav)lstOgrencininNotlari.Items[0].SubItems[2].Tag;
                sinav.Puan = (int)nmrSinav3.Value;
                nmrSinav3.Enabled = false;
                sinavManager.SinavGuncelle(sinav);
            }

            basari.Ortalama = (sinavlar[0].Puan + sinavlar[1].Puan + sinavlar[2].Puan) / 3;
            if (basari.Ortalama > 50)
            {
                basari.BasariDurumu = Entities.Enums.BasariDurumu.Gecti;
            }
            else
            {
                basari.BasariDurumu = Entities.Enums.BasariDurumu.Kaldi;
            }

            basariManager.BasariGuncelle(basari);

            btnNotGuncelle.Enabled = false;

            this.NotListesiniDoldur();
        }
        private void lstOgrencininNotlari_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnNotGuncelle.Enabled = true;
            if (sinavlar.Count == 1)
            {
                nmrSinav1.Enabled = true;
            }
            else if (sinavlar.Count == 2)
            {
                nmrSinav1.Enabled = true;
                nmrSinav2.Enabled = true;
            }
            else if (sinavlar.Count == 3)
            {
                nmrSinav1.Enabled = true;
                nmrSinav2.Enabled = true;
                nmrSinav3.Enabled = true;
            }
        }
    }
}

