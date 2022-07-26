using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISinavService
    {
        public List<Sinav> OgrencininSinavlari(int OgrenciID, int OgretmenID);
        public void SinavKayit(Sinav sinav);
        public void SinavGuncelle(Sinav sinav);        

    }
}
