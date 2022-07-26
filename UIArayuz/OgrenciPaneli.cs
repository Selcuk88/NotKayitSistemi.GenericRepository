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
    public partial class OgrenciPaneli : Form
    {
        public OgrenciPaneli()
        {
            InitializeComponent();
        }

        DersManager dersManager = new DersManager(new EfDersDal());
        OgrenciManager ogrenciManager = new OgrenciManager(new EfOgrenciDal());
        OgretmenManager ogretmenManager = new OgretmenManager(new EfOgretmenDal());
        Ogrenci ogrenci;

        private void OgrenciPaneli_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDersCikar_Click(object sender, EventArgs e)
        {

        }
    }
}
