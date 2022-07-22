using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.JoiningTables
{
    public class SiniflarDersler:IEntity
    {
        public int SinifID { get; set; }
        public int DersID { get; set; }
        public Sinif Sinif { get; set; }
        public Ders Ders { get; set; }
    }
}
