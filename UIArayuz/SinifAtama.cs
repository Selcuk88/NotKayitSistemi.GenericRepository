using Business.Concrete;
using Core.Results.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.JoiningTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UIArayuz
{
    public partial class SinifAtama : Form
    {
        public SinifAtama()
        {
            InitializeComponent();
        }

        OgretmenManager ogretmenManager = new OgretmenManager(new EfOgretmenDal());
        DersManager dersManager = new DersManager(new EfDersDal());
        SinifManager sinifManager = new SinifManager(new EfSinifDal());
        SiniflarOgretmenlerManager siniflarOgretmenlerManager = new SiniflarOgretmenlerManager(new EfSiniflarOgretmenlerDal());
        SiniflarDerslerManager siniflarDerslerManager = new SiniflarDerslerManager(new EfSiniflarDerslerDal());

        Ogretmen gorevlendirilecekOgretmen;
        Sinif gorevlendirilecekSinif;
        DialogResult dialogResult;

        private void SinifAtama_Load(object sender, EventArgs e)
        {            
            List<Ogretmen> ogretmenler = ogretmenManager.OgretmenKadrosuListele();
            foreach (Ogretmen ogretmen in ogretmenler)
            {
                ListViewItem ogretmenKadrosu = new ListViewItem();
                ogretmenKadrosu.Text = ogretmen.OgretmenID.ToString();
                ogretmenKadrosu.SubItems.Add(ogretmen.OgretmenAd);
                ogretmenKadrosu.SubItems.Add(ogretmen.OgretmenSoyad);
                ogretmenKadrosu.SubItems.Add(ogretmen.TcNo);
                ogretmenKadrosu.SubItems.Add(dersManager.DersiGetir(ogretmen.DersID).DersAd);
                ogretmenKadrosu.Tag = ogretmen;
                lstOgretmenKadrosu.Items.Add(ogretmenKadrosu);
            }
            
            List<Sinif> siniflar = sinifManager.TumSiniflariListele();
            foreach (Sinif sinif in siniflar)
            {
                ListViewItem sinifListesi = new ListViewItem();
                sinifListesi.Text = sinif.SinifID.ToString();
                sinifListesi.SubItems.Add(sinif.Seviye);
                sinifListesi.SubItems.Add(sinif.Sube);
                sinifListesi.Tag = sinif;
                lstMevcutSiniflar.Items.Add(sinifListesi);
            }


        }

        private void lstOgretmenKadrosu_MouseClick(object sender, MouseEventArgs e)
        {
            lstOgretmeninSiniflari.Items.Clear();
            gorevlendirilecekOgretmen = (Ogretmen)lstOgretmenKadrosu.SelectedItems[0].Tag;

            foreach (SiniflarOgretmenler sinifOgretmen in siniflarOgretmenlerManager.OgretmeninSiniflari(gorevlendirilecekOgretmen))
            {
                Sinif ogretmeninSinifi = sinifManager.GetSinif(sinifOgretmen.SinifID);
                ListViewItem ogretmeninSiniflari =new ListViewItem(ogretmeninSinifi.SinifID.ToString());
                ogretmeninSiniflari.SubItems.Add(ogretmeninSinifi.Seviye);
                ogretmeninSiniflari.SubItems.Add(ogretmeninSinifi.Sube);
                ogretmeninSiniflari.Tag = ogretmeninSinifi;
                lstOgretmeninSiniflari.Items.Add(ogretmeninSiniflari);
            }
        }

        private void lstOgretmenKadrosu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstMevcutSiniflar_MouseClick(object sender, MouseEventArgs e)
        {
            gorevlendirilecekSinif = (Sinif)lstMevcutSiniflar.SelectedItems[0].Tag;
        }

        private void btnGorevlendirmeyiOnayla_Click(object sender, EventArgs e)
        {
            if (lstOgretmenKadrosu.SelectedItems.Count<=0 || lstMevcutSiniflar.SelectedItems.Count<=0)
            {
                MessageBox.Show("Hangi öğretmeni hangi sınıfa atamak istediğinizi listeler üzerinden seçmiş olmalısınız.","Sistem Mesajı",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            }
            else
            {                
                List<SiniflarDersler> gorevlendirilebilecekSiniflar = siniflarDerslerManager.DersinSiniflari(gorevlendirilecekOgretmen.DersID).Where(x => x.SinifID == gorevlendirilecekSinif.SinifID).ToList();

                if (gorevlendirilebilecekSiniflar.Count>0)
                {
                    dialogResult = MessageBox.Show($"{gorevlendirilecekOgretmen.OgretmenAd} {gorevlendirilecekOgretmen.OgretmenSoyad} isimli öğretmeni {gorevlendirilecekSinif.Seviye}-{gorevlendirilecekSinif.Sube} sınıfına görevlendiriyorsunuz.\nİşleme devam etmek istiyor musunuz?", "Sistem Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        IResult result = siniflarOgretmenlerManager.SinifaOgretmenGorevlendir(gorevlendirilecekSinif.SinifID, gorevlendirilecekOgretmen.OgretmenID);
                        MessageBox.Show($"{result.Message}", "Sistem Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Görevlendirilmek istenen öğretmenin branşı görevlendirme yapılacak sınıfın ders listesine uygun değildir.\nGörevlendirme işlemi iptal edilmiştir. Lütfen sınıfın ders listesine uygun branşta öğretmen seçerek işleminize devam edin.","Sistem Uyarısı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }                
            }
        }
    }
}
