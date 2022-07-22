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
    public partial class IdariIslemler : Form
    {
        public IdariIslemler()
        {
            InitializeComponent();
        }

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
    }
}
