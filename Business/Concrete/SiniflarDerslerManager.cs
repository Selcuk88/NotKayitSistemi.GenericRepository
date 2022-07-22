using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.JoiningTables;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SiniflarDerslerManager: ISiniflarDerslerService
    {
        ISiniflarDerslerDal _siniflarDerslerDal;
        public SiniflarDerslerManager(ISiniflarDerslerDal siniflarDerslerDal)
        {
            _siniflarDerslerDal = siniflarDerslerDal;
        }

        public List<SiniflarDersler> SinifinDersleri(int sinifID)
        {
            return _siniflarDerslerDal.GetAllOf(x => x.SinifID == sinifID);
        }
        public List<SiniflarDersler> DersinSiniflari(int DersID)
        {
            return _siniflarDerslerDal.GetAllOf(x => x.DersID == DersID);
        }
    }
}
