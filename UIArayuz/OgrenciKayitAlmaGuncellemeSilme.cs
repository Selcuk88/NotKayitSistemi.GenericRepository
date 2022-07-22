using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace UIArayuz
{
    public partial class OgrenciKayitAlmaGuncellemeSilme : Form
    {
        public OgrenciKayitAlmaGuncellemeSilme()
        {
            InitializeComponent();
        }

        SinifManager sinifManager = new SinifManager(new EfSinifDal());
        OgrenciManager ogrenciManager = new OgrenciManager(new EfOgrenciDal());
        Ogrenci guncellenecekOgrenci;

        void OgrenciListeDoldur()
        {
            lstOgrencilerListe.Items.Clear();
            int sinifId=0;
            foreach (ListViewItem item in lstMevcutSiniflar.SelectedItems)
            {
                sinifId=((Sinif)item.Tag).SinifID;
            }
            //int sinifId = ((Sinif)lstMevcutSiniflar.SelectedItems[0].Tag).SinifID;
            foreach (Ogrenci item in ogrenciManager.AyniSiniftakiOgrenciler(sinifId))
            {
                ListViewItem listViewItem = new ListViewItem(item.OgrenciID.ToString());
                listViewItem.SubItems.Add(item.OgrenciAd);
                listViewItem.SubItems.Add(item.OgrenciSoyad);
                listViewItem.SubItems.Add(item.TcNo);
                listViewItem.SubItems.Add(item.Cinsiyet);
                listViewItem.Tag = item;
                lstOgrencilerListe.Items.Add(listViewItem);
            }
        }
        void SinifSubeListesiDoldur()
        {
            lstMevcutSiniflar.Items.Clear();
            foreach (Sinif item in sinifManager.TumSiniflariListele())
            {
                ListViewItem lvi = new ListViewItem(item.SinifID.ToString());
                lvi.SubItems.Add(item.Seviye.ToString());
                lvi.SubItems.Add(item.Sube);
                lvi.SubItems.Add(item.Kapasite.ToString());
                lvi.SubItems.Add(ogrenciManager.AyniSiniftakiOgrenciler(item.SinifID).Count.ToString());
                lvi.Tag = item;
                lstMevcutSiniflar.Items.Add(lvi);
            }
        }
        private void OgrenciKayitAlmaGuncellemeSilme_Load(object sender, EventArgs e)
        {
            SinifSubeListesiDoldur();
        }
        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            if (txtOgrenciAd.Text!=string.Empty && txtOgrenciSoyad.Text!=string.Empty && mtxtOgrenciTcNo.Text!=string.Empty && txtOgrenciSifre.Text!=string.Empty)
            {
                ogrenci.OgrenciAd = txtOgrenciAd.Text.ToUpper();
                ogrenci.OgrenciSoyad = txtOgrenciSoyad.Text.ToUpper();
                ogrenci.TcNo = mtxtOgrenciTcNo.Text;
                ogrenci.Cinsiyet = rbKiz.Checked == true ? "KIZ" : "ERKEK";
                ogrenci.Sifre = txtOgrenciSifre.Text;

                if (lstMevcutSiniflar.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Herhangi bir sınıf seçimi yapmadınız.\nKayıt işleminin tamamlanması için öğrencinin hangi sınıf ve şubeye kaydının alınacağını yandaki listeden seçmeniz gereklidir.", "Sistem Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int kapasite = int.Parse(lstMevcutSiniflar.SelectedItems[0].SubItems[3].Text);
                    int mevcut = int.Parse(lstMevcutSiniflar.SelectedItems[0].SubItems[4].Text);
                    if (mevcut < kapasite)
                    {
                        ogrenci.SinifID = ((Sinif)lstMevcutSiniflar.SelectedItems[0].Tag).SinifID;
                        MessageBox.Show(ogrenciManager.Add(ogrenci).Message, "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SinifSubeListesiDoldur();                        
                        HizliFormIslemleri.FormTemizle(this);
                        foreach (ListViewItem item in lstMevcutSiniflar.Items)
                        {
                            if (((Sinif)item.Tag).SinifID == ogrenci.SinifID)
                            {
                                item.Selected = true;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seçtiğiniz sınıfın kapasitesi doludur, lütfen başka bir sınıf seçiniz", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurmalısınız.","Sistem Uyarısı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }            
        }        
        private void lstMevcutSiniflar_SelectedIndexChanged(object sender, EventArgs e)
        {            
            OgrenciListeDoldur();
        }
        private void btnSeciliOgrenciSil_Click(object sender, EventArgs e)
        {
            if (lstOgrencilerListe.SelectedItems.Count<=0)
            {
                MessageBox.Show("Listeden silmek istediğiniz öğrenciyi seçmelisiniz","Sistem Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                Ogrenci silinecekOgrenci = (Ogrenci)lstOgrencilerListe.SelectedItems[0].Tag;
                DialogResult dialog= MessageBox.Show($"{silinecekOgrenci.OgrenciAd} {silinecekOgrenci.OgrenciSoyad} isimli öğrenciyi silmek istediğinize emin misiniz?","Sistem Mesajı",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (dialog==DialogResult.Yes)
                {
                    int seciliSinifID = silinecekOgrenci.SinifID;
                    MessageBox.Show(ogrenciManager.Delete(silinecekOgrenci).Message,"Sistem Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    SinifSubeListesiDoldur();
                    foreach (ListViewItem item in lstMevcutSiniflar.Items)
                    {
                        if (((Sinif)item.Tag).SinifID == seciliSinifID)
                        {
                            item.Selected = true;
                        }
                    }
                    OgrenciListeDoldur();
                }
                else
                {
                    MessageBox.Show("Silme işleminiz iptal edilmiştir.","Sistem Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }        
        private void lstOgrencilerListe_DoubleClick(object sender, EventArgs e)
        {
            guncellenecekOgrenci= (Ogrenci)lstOgrencilerListe.SelectedItems[0].Tag;
            txtOgrenciAd.Text = guncellenecekOgrenci.OgrenciAd;
            txtOgrenciSoyad.Text = guncellenecekOgrenci.OgrenciSoyad;
            mtxtOgrenciTcNo.Text = guncellenecekOgrenci.TcNo;
            if (guncellenecekOgrenci.Cinsiyet=="KIZ")
            {
                rbKiz.Checked = true;
            }
            else
            {
                rbErkek.Checked = true;
            }
            DialogResult dialog = MessageBox.Show("Öğrencinin sınıfını da güncellemek istiyorsanız sınıflar listesinden seçim yapmalısınız.)", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            if (txtOgrenciAd.Text!=string.Empty && txtOgrenciSoyad.Text != string.Empty && mtxtOgrenciTcNo.Text!=string.Empty)
            {
                guncellenecekOgrenci.OgrenciAd = txtOgrenciAd.Text.ToUpper();
                guncellenecekOgrenci.OgrenciSoyad = txtOgrenciSoyad.Text.ToUpper();
                guncellenecekOgrenci.TcNo = mtxtOgrenciTcNo.Text;
               
                if (lstMevcutSiniflar.SelectedItems.Count>0)
                {
                    guncellenecekOgrenci.SinifID = ((Sinif)lstMevcutSiniflar.SelectedItems[0].Tag).SinifID;
                    MessageBox.Show(ogrenciManager.Update(guncellenecekOgrenci).Message,"Sistem Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ogrenciManager.Update(guncellenecekOgrenci).Message, "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                HizliFormIslemleri.FormTemizle(this);
                SinifSubeListesiDoldur();                
                foreach (ListViewItem item in lstMevcutSiniflar.Items)
                {
                    if (((Sinif)item.Tag).SinifID == guncellenecekOgrenci.SinifID)
                    {
                        item.Selected = true;
                    }
                }                
                OgrenciListeDoldur();
            }
            else
            {
                MessageBox.Show("Ad, Soyad, TC No alanları boş geçilemez.","Sistem Uyarısı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void OgrenciKayitAlmaGuncellemeSilme_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IdariIslemler idariIslemler = new IdariIslemler();
            idariIslemler.Show();
            this.Hide();
        }
    }
}
