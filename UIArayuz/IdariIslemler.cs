using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;




namespace UIArayuz
{
    public partial class IdariIslemler : Form
    {
        public IdariIslemler()
        {
            InitializeComponent();
        }

        SinifManager sinifManager = new SinifManager(new EfSinifDal());
        OgrenciManager ogrenciManager=new OgrenciManager(new EfOgrenciDal());
        short toplamKapasite;
        

        private void kayıtAlmaGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgretmenKayitAlmaGuncelleme ogretmenKayitAlmaGuncelleme = new OgretmenKayitAlmaGuncelleme();
            ogretmenKayitAlmaGuncelleme.IsMdiContainer = true;
            ogretmenKayitAlmaGuncelleme.Show();
            this.Hide();
        }

        private void kayıtSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgretmenKayitSilme ogretmenKayitSilme = new OgretmenKayitSilme();
            ogretmenKayitSilme.IsMdiContainer = true;
            ogretmenKayitSilme.Show();
            this.Hide();
        }

        private void dersAçKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersIslemleri dersIslemleri = new DersIslemleri();
            dersIslemleri.IsMdiContainer = true;
            dersIslemleri.Show();
            this.Hide();
        }

        private void sınıfAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinifIslemleri sinifIslemleri = new SinifIslemleri();
            sinifIslemleri.IsMdiContainer = true;
            sinifIslemleri.Show();
            this.Hide();
        }

              

        private void IdariIslemler_FormClosing(object sender, FormClosingEventArgs e)
        {            
                e.Cancel = true;                
                new GirisPaneli().Show();
                this.Hide();
        }

        private void kayıtAlmaGüncellemeSilmeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OgrenciKayitAlmaGuncellemeSilme ogrenciKayitAlmaGuncellemeSilme = new OgrenciKayitAlmaGuncellemeSilme();

            ogrenciKayitAlmaGuncellemeSilme.IsMdiContainer = true;
            ogrenciKayitAlmaGuncellemeSilme.Show();
            this.Hide();
        }

        private void sınıfİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void IdariIslemler_Load(object sender, EventArgs e)
        {            
            foreach (Sinif sinif in sinifManager.TumSiniflariListele())
            {
                toplamKapasite += sinif.Kapasite;
            }

            lblToplamKapasite.Text = toplamKapasite.ToString();
            prbToplamKapasite.Value= toplamKapasite;

            lblToplamOgrenciSayisi.Text = ogrenciManager.TumOgrenciler().Count.ToString();
            prbToplamOgrenciSayisi.Value = ogrenciManager.TumOgrenciler().Count;

            lblErkekOgrenciSayisi.Text = ogrenciManager.TumOgrenciler().Where(x => x.Cinsiyet == "Erkek").Count().ToString();
            lblKizOgrenciSayisi.Text=ogrenciManager.TumOgrenciler().Where(x=>x.Cinsiyet=="Kadın").Count().ToString();

            prbErkekOgrenciSayisi.Value = ogrenciManager.TumOgrenciler().Where(x => x.Cinsiyet == "Erkek").Count();
            prbKizOgrenciSayisi.Value = ogrenciManager.TumOgrenciler().Where(x => x.Cinsiyet == "Kadın").Count();

        }
    }
}
