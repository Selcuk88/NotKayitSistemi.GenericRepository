using Core.Entities;
using Entities.Concrete.JoiningTables;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Sinif:IEntity
    {
        public int SinifID { get; set; }
        public string Seviye { get; set; }
        public string Sube { get; set; }
        public short Kapasite { get; set; }
        public IList<Ogrenci> Ogrenciler { get; set; }
        public IList<SiniflarOgretmenler> SiniflarOgretmenler { get; set; }
        public IList<SiniflarDersler> SiniflarDersler { get; set; }
    }
}