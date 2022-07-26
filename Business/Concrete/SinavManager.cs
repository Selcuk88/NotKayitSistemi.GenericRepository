using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SinavManager : ISinavService
    {
        ISinavDal _sinavDal;
        public SinavManager(ISinavDal sinavDal)
        {
            _sinavDal = sinavDal;
        }

        public List<Sinav> OgrencininSinavlari(int OgrenciID, int OgretmenID)
        {
            return _sinavDal.GetAllOf(x => x.OgrenciID == OgrenciID && x.OgretmenID == OgretmenID);
        }       

        public void SinavGuncelle(Sinav sinav)
        {
            _sinavDal.Update(sinav);
        }

        public void SinavKayit(Sinav sinav)
        {
            _sinavDal.Add(sinav);
        }
    }
}
