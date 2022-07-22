using Core.Entities;
using Entities.Concrete.JoiningTables;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Ogrenci:IEntity
    {
        public int OgrenciID { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public string Cinsiyet { get; set; }
        public string TcNo { get; set; }
        public string Sifre { get; set; }
        public int SinifID { get; set; }
        public Sinif Sinif { get; set; }
        public IList<Sinav> Sinavlar { get; set; }
        public IList<Basari> Basarilar { get; set; }
    }
}