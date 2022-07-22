using Business.Concrete;
using Core.Results.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Windows.Forms;

namespace UIArayuz
{
    public partial class DersIslemleri : Form
    {
        public DersIslemleri()
        {
            InitializeComponent();
        }
        DersManager dersManager = new DersManager(new EfDersDal());

        private void mevcutDerslerListesiDoldur()
        {
            ltbMevcutDersler.Items.Clear();
            foreach (var item in dersManager.TumDersleriListele())
            {
                ltbMevcutDersler.Items.Add(item.DersAd.ToUpper());
            }
        }

        private void btnDersAc_Click(object sender, EventArgs e)
        {
            if (txtEklenecekDers.Text==string.Empty || txtEklenecekDers.Text.Length<3)
            {
                MessageBox.Show("Lütfen açmak istediğiniz ders adını giriniz.\nDers adı en az 3 harfli olmalıdır.","Sistem Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else 
            {
                IResult result = dersManager.DersEkleme(txtEklenecekDers.Text);

                MessageBox.Show(result.Message, "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HizliFormIslemleri.FormTemizle(this);
                if (result.Success)
                {
                    mevcutDerslerListesiDoldur();
                }
            }
        }
        private void btnSeciliDersiKapat_Click(object sender, EventArgs e)
        {
            if (ltbMevcutDersler.SelectedIndex>=0)
            {
                string kapatilacakDers = ltbMevcutDersler.SelectedItem.ToString();
                MessageBox.Show(dersManager.DersSilme(kapatilacakDers).Message);                
                mevcutDerslerListesiDoldur();                
            }
            else
            {
                MessageBox.Show("Listeden kapatmak istediğiniz dersi seçmeniz gereklidir.", "Sistem Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DersIslemleri_Load(object sender, EventArgs e)
        {
            mevcutDerslerListesiDoldur();
        }

        private void DersIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IdariIslemler idariIslemler = new IdariIslemler();
            idariIslemler.Show();
            this.Hide();
        }
    }
}
