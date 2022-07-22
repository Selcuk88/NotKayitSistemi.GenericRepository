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
    public partial class OgretmenKayitSilme : Form
    {
        public OgretmenKayitSilme()
        {
            InitializeComponent();
        }

        OgretmenManager ogretmenManager = new OgretmenManager(new EfOgretmenDal());
        DersManager dersManager = new DersManager(new EfDersDal());
        void OgretmenKadrosuListesiniDoldur()
        {
            lstOgretmenKadrosu.Items.Clear();
            foreach (Ogretmen item in ogretmenManager.OgretmenKadrosuListele())
            {
                ListViewItem lvi = new ListViewItem(item.OgretmenID.ToString());
                lvi.SubItems.Add(item.OgretmenAd);
                lvi.SubItems.Add(item.OgretmenSoyad);
                lvi.SubItems.Add(item.TcNo);
                lvi.SubItems.Add(dersManager.DersiGetir(item.DersID).DersAd);
                lvi.Tag = item;
                lstOgretmenKadrosu.Items.Add(lvi);
            }
        }
        private void OgretmenKayitSilme_Load(object sender, EventArgs e)
        {
            OgretmenKadrosuListesiniDoldur();
        }

        private void btnOgretmenSil_Click(object sender, EventArgs e)
        {
            if (lstOgretmenKadrosu.SelectedItems.Count<0)
            {
                MessageBox.Show("Silmek istediğiniz öğretmeni listeden seçmiş olmalısınız.","Sistem Uyarısı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string mesaj = ogretmenManager.OgretmenSil((Ogretmen)lstOgretmenKadrosu.SelectedItems[0].Tag).Message;
                MessageBox.Show(mesaj,"Sistem Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                OgretmenKadrosuListesiniDoldur();
            }
        }

        private void OgretmenKayitSilme_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IdariIslemler idariIslemler = new IdariIslemler();
            idariIslemler.Show();
            this.Hide();
        }
    }
}
