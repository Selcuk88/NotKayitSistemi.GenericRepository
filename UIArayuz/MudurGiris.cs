using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Windows.Forms;

namespace UIArayuz
{
    public partial class MudurGiris : Form
    {
        public MudurGiris()
        {
            InitializeComponent();
        }

        private void MudurGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisPaneli girisPaneli = new GirisPaneli();
            girisPaneli.Show();
            this.Hide();
        }

        private void btnMudurGiris_Click(object sender, EventArgs e)
        {            
            MudurManager mudurManager = new MudurManager(new EfMudurDal());
            bool kontrol;
            string mesaj = mudurManager.GirisKontrol(mtxtMudurTc.Text, txtMudurSifre.Text, out kontrol);            

            if (kontrol)
            {
                HizliFormIslemleri.FormTemizle(this);
                this.Hide();
                MessageBox.Show(mesaj, "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new IdariIslemler().Show();
            }
            else
            {
                MessageBox.Show(mesaj, "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void mtxtMudurTc_TextChanged(object sender, EventArgs e)
        {
            mtxtMudurTc.Text = mtxtMudurTc.Text.Trim();
        }
    }
}
