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

        void DerslerimiListele()
        {
            
        }

        private void OgrenciPaneli_Load(object sender, EventArgs e)
        {
            ogrenci = ogrenciManager.GetByTcNo(lblTcNo.Text);
            foreach (Ders drs in dersManager.TumDersleriListele())
            {
                ListViewItem listView;               
                    foreach (Ogretmen ogrt in ogretmenManager.DersinOgretmenleri(drs.DersID))
                    {
                        listView = new ListViewItem(drs.DersAd);
                        listView.SubItems.Add(ogrt.OgretmenAd + " " + ogrt.OgretmenSoyad);
                        listView.Tag = ogrt;
                        lstDersler.Items.Add(listView);
                    }                
            }
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            //ListViewItem lvt;
            //Ogretmen dersinOgretmeni = (Ogretmen)lstDersler.SelectedItems[0].Tag;
            //Ders eklenecekDers = dersManager.DersiGetir(dersinOgretmeni.DersID);
            
            //if (!ogrenciManager.OgrencininDersleriniGetir(ogrenci).Contains(eklenecekDers))
            //{
            //    ogrenci.Dersler.Add(eklenecekDers);
            //    lvt = new ListViewItem(eklenecekDers.DersAd);
            //    lvt.SubItems.Add(dersinOgretmeni.OgretmenAd + " " + dersinOgretmeni.OgretmenSoyad);
            //}
            //else
            //{
            //    MessageBox.Show("Ders programınıza eklemeye çalıştığınız ders, programınızda vardır.\nDers ekleme işlemini iptal edilmiştir.","Sistem Uyarısı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //}
        }

        private void btnDersCikar_Click(object sender, EventArgs e)
        {

        }
    }
}
