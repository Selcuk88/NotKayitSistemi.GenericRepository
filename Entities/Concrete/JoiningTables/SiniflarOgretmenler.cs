using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.JoiningTables
{
    public class SiniflarOgretmenler:IEntity
    {
        public int SinifID { get; set; }
        public int OgretmenID { get; set; }
        public Sinif Sinif { get; set; }
        public Ogretmen Ogretmen { get; set; }
    }
}
