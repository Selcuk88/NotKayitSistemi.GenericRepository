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
    public partial class OgretmenKayitAlmaGuncelleme : Form
    {
        public OgretmenKayitAlmaGuncelleme()
        {
            InitializeComponent();
        }
        OgretmenManager ogretmenManager = new OgretmenManager(new EfOgretmenDal());
        DersManager dersManager = new DersManager(new EfDersDal());

        private void OgretmenKadrosuListesiniDoldur()
        {
            lstOgretmenKadrosu.Items.Clear();
            foreach (Ogretmen item in ogretmenManager.OgretmenKadrosuListele())
            {
                ListViewItem listViewItem = new ListViewItem(item.OgretmenID.ToString());
                listViewItem.SubItems.Add(item.OgretmenAd);
                listViewItem.SubItems.Add(item.OgretmenSoyad);
                listViewItem.SubItems.Add(item.TcNo);
                item.Brans = dersManager.DersiGetir(item.DersID);
                listViewItem.SubItems.Add(item.Brans.DersAd);
                listViewItem.Tag = item;
                lstOgretmenKadrosu.Items.Add(listViewItem);
            }            
        }       

        private void OgretmenKayitAlmaGuncelleme_Load(object sender, EventArgs e)
        {
            foreach (Ders item in dersManager.TumDersleriListele())
            {
                cmbDersler.Items.Add(item.DersAd);
            }

            OgretmenKadrosuListesiniDoldur();
        }

        private void btnOgretmenKaydet_Click(object sender, EventArgs e)
        {
            if (txtOgretmenAd.Text == string.Empty || txtOgretmenSoyad.Text == string.Empty || mtxtOgretmenTcNo.Text == string.Empty || txtOgretmenSifre.Text == string.Empty || cmbDersler.SelectedIndex < 0)
            {
                MessageBox.Show("Tüm alanların doldurulması gereklidir.", "Sistem Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Ders ders = dersManager.DersiGetir(cmbDersler.SelectedItem.ToString());
                Ogretmen ogretmen = new Ogretmen { OgretmenAd = txtOgretmenAd.Text.ToUpper(), OgretmenSoyad = txtOgretmenSoyad.Text.ToUpper(), TcNo = mtxtOgretmenTcNo.Text, Sifre = txtOgretmenSifre.Text, Brans = ders };
                string mesaj = ogretmenManager.OgretmenEkle(ogretmen, out bool kontrol).Message;
                MessageBox.Show(mesaj, "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HizliFormIslemleri.FormTemizle(this);
                if (!kontrol)
                {
                    OgretmenKadrosuListesiniDoldur();
                }
            }
        }

        private void lstOgretmenKadrosu_DoubleClick(object sender, EventArgs e)
        {
            Ogretmen ogretmen=(Ogretmen)lstOgretmenKadrosu.SelectedItems[0].Tag;
            txtOgretmenAd.Text = ogretmen.OgretmenAd;
            txtOgretmenSoyad.Text = ogretmen.OgretmenSoyad;
            mtxtOgretmenTcNo.Text = ogretmen.TcNo;
            ogretmen.Brans = dersManager.DersiGetir(ogretmen.Brans.DersID);
            cmbDersler.SelectedItem = ogretmen.Brans.DersAd;
        }

        private void btnOgretmenGuncelle_Click(object sender, EventArgs e)
        {
            if (lstOgretmenKadrosu.SelectedItems.Count<=0)
            {
                MessageBox.Show("Öncelikle listeden bir öğretmen seçimi yapmalısınız. Bunun için güncellemek istediğiniz öğretmene çift tıklayınız.","Sistem Uyarısı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (txtOgretmenAd.Text != string.Empty && txtOgretmenSoyad.Text != string.Empty && mtxtOgretmenTcNo.Text != string.Empty && cmbDersler.SelectedIndex >= 0)
                {
                    Ogretmen ogretmen = ogretmenManager.OgretmenGetir(mtxtOgretmenTcNo.Text);
                    ogretmen.OgretmenAd = txtOgretmenAd.Text.ToUpper();
                    ogretmen.OgretmenSoyad = txtOgretmenSoyad.Text.ToUpper();
                    ogretmen.TcNo = mtxtOgretmenTcNo.Text;
                    ogretmen.DersID = dersManager.DersiGetir(cmbDersler.Text).DersID;
                    MessageBox.Show(ogretmenManager.OgretmenGuncelle(ogretmen).Message,"Sistem Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);                    
                    OgretmenKadrosuListesiniDoldur();
                }
                else
                {
                    MessageBox.Show("Ad, Soyad, TC No ve Branş alanları boş geçilemez.", "Sistem Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }           
        }

        private void OgretmenKayitAlmaGuncelleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IdariIslemler idariIslemler = new IdariIslemler();
            idariIslemler.Show();
            this.Hide();
        }
    }
}
