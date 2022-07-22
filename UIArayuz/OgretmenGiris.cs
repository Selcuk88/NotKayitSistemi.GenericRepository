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
    public partial class OgretmenGiris : Form
    {
        public OgretmenGiris()
        {
            InitializeComponent();
        }

        private void OgretmenGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisPaneli girisPaneli = new GirisPaneli();
            girisPaneli.Show();
            this.Hide();
        }

        private void mtxtOgretmenTc_TextChanged(object sender, EventArgs e)
        {
            mtxtOgretmenTc.Text = mtxtOgretmenTc.Text.Trim();
        }
    }
}
