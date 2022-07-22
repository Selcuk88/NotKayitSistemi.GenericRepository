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
    public partial class GirisPaneli : Form
    {
        public GirisPaneli()
        {
            InitializeComponent();
        }

        private void pcbMudur_Click(object sender, EventArgs e)
        {
            MudurGiris mudurGiris = new MudurGiris();
            mudurGiris.Show();
            this.Hide();
        }

        private void pcbOgretmen_Click(object sender, EventArgs e)
        {
            OgretmenGiris ogretmenGiris = new OgretmenGiris();
            ogretmenGiris.Show();
            this.Hide();
        }

        private void pcbOgrenci_Click(object sender, EventArgs e)
        {
            OgrenciGiris ogrenciGiris = new OgrenciGiris();
            ogrenciGiris.Show();
            this.Hide();
        }

        private void GirisPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
