using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BasariManager:IBasariService
    {
        IBasariDal _basariDal;
        public BasariManager(IBasariDal basariDal)
        {
            _basariDal=basariDal;
        }

        public void BasariEkle(Basari basari)
        {
            _basariDal.Add(basari);
        }

        public void BasariGuncelle(Basari basari)
        {
            _basariDal.Update(basari);
        }

        public Basari OgrencininBasarisi(int ogrenciID, int dersID)
        {
            return _basariDal.Get(x => x.OgrenciID == ogrenciID && x.DersID == dersID);
        }
    }
}
