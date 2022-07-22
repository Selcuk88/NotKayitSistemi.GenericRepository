using Core.Entities;
using Entities.Concrete.JoiningTables;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Sinav:IEntity
    {
        public int SinavID { get; set; }
        public int Puan { get; set; }
        public int OgrenciID { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public int OgretmenID { get; set; }
        public Ogretmen Ogretmen { get; set; }        
    }
}