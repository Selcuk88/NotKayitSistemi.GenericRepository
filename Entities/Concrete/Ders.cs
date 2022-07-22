using Core.Entities;
using Entities.Concrete.JoiningTables;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Ders:IEntity
    {        
        public int DersID { get; set; }
        public string DersAd { get; set; }        
        public IList<SiniflarDersler> SiniflarDersler { get; set; }
    }
}
