using Entities.Concrete.JoiningTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISiniflarDerslerService
    {
        public List<SiniflarDersler> SinifinDersleri(int sinifID);
        public List<SiniflarDersler> DersinSiniflari(int DersID);
    }
}
