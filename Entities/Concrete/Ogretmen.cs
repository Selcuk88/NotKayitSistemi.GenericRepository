using Core.Entities;
using Entities.Concrete.JoiningTables;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Ogretmen : IEntity
    {
        public int OgretmenID { get; set; }
        public string OgretmenAd { get; set; }
        public string OgretmenSoyad { get; set; }
        public string Cinsiyet { get; set; }
        public string TcNo { get; set; }
        public string Sifre { get; set; }
        public int DersID { get; set; }
        public Ders Brans { get; set; }
        public IList<Sinav> Sinavlar { get; set; }
        public IList<SiniflarOgretmenler> SiniflarOgretmenler { get; set; }
    }
}