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
    public partial class SinifIslemleri : Form
    {
        public SinifIslemleri()
        {
            InitializeComponent();
        }

        SinifManager sinifManager = new SinifManager(new EfSinifDal());
        OgrenciManager ogrenciManager = new OgrenciManager(new EfOgrenciDal());

        private void MevcutSiniflarListesiniDoldur()
        {
            lstMevcutSiniflar.Items.Clear();
            List<Sinif> siniflar = sinifManager.TumSiniflariListele();
            int sinifSayisi = siniflar.Count;

            for (int i = 0; i < sinifSayisi; i++)
            {
                ListViewItem listViewItem = new ListViewItem(siniflar[i].SinifID.ToString());
                listViewItem.SubItems.Add(siniflar[i].Seviye.ToString());
                listViewItem.SubItems.Add(siniflar[i].Sube);
                listViewItem.SubItems.Add(siniflar[i].Kapasite.ToString());
                listViewItem.SubItems.Add(ogrenciManager.AyniSiniftakiOgrenciler(siniflar[i].SinifID).Count.ToString());
                listViewItem.Tag = siniflar[i];
                lstMevcutSiniflar.Items.Add(listViewItem);                
            }            
        }

        private void btnSinifAc_Click(object sender, EventArgs e)
        {
            if (cmbSinifSubeler.SelectedIndex>=0 && nmrSinifKapasite.Value>0)
            {                
                MessageBox.Show(sinifManager.SinifAcma(nmrSinifNo.Value.ToString(), cmbSinifSubeler.SelectedItem.ToString(), Convert.ToInt16(nmrSinifKapasite.Value)).Message, "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MevcutSiniflarListesiniDoldur();
            }
            else
            {
                MessageBox.Show("Sınıf açmak için şube ve sınıf kapasitesini belirtmeniz gerekir. İşleminizi tekrar deneyin.","Sistem Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void SinifIslemleri_Load(object sender, EventArgs e)
        {
            MevcutSiniflarListesiniDoldur();
            cmbSinifSubeler.SelectedIndex = -1;
            nmrSinifKapasite.Value = 0;
        }

        private void btnSinifKapat_Click(object sender, EventArgs e)
        {
            if (lstMevcutSiniflar.SelectedItems.Count>0)
            {
                
                Sinif sinif = (Sinif)lstMevcutSiniflar.SelectedItems[0].Tag;
                DialogResult dialog=MessageBox.Show($"{sinif.Seviye}-{sinif.Sube} sınıfını kapatma işlemine devam etmek istiyor musunuz?","Sistem Mesajı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialog==DialogResult.Yes)
                {
                    int ogrenciSayisi = ogrenciManager.AyniSiniftakiOgrenciler(sinif.SinifID).Count;
                    MessageBox.Show(sinifManager.SinifKapatma(sinif, ogrenciSayisi).Message, "Sistem Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MevcutSiniflarListesiniDoldur();
                }                
            }
            else
            {
                MessageBox.Show("Listeden kapatmak istediğiniz sınıfı seçmeniz gereklidir.","Sistem Uyarısı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void SinifIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            IdariIslemler idariIslemler = new IdariIslemler();
            idariIslemler.Show();
            this.Hide();
        }
    }
}
