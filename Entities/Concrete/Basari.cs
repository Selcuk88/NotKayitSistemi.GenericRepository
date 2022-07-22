using Core.Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Basari:IEntity
    {
        public int BasariID { get; set; }
        public int DersID { get; set; }
        public Ders Ders { get; set; }
        public int OgrenciID { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public double Ortalama { get; set; }
        public BasariDurumu BasariDurumu { get; set; }
    }
}
