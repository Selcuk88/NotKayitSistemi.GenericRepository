using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.JoiningTables;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SiniflarOgretmenlerManager:ISiniflarOgretmenlerService
    {
        ISiniflarOgretmenlerDal _siniflarOgretmenlerDal;
        public SiniflarOgretmenlerManager(ISiniflarOgretmenlerDal siniflarOgretmenlerDal)
        {
            _siniflarOgretmenlerDal= siniflarOgretmenlerDal;
        }

        public IResult SinifaOgretmenGorevlendir(int sinifID, int ogretmenID)
        {
            if (this.OgretmenSiniftaGorevlimi(sinifID,ogretmenID))
            {
                return new ErrorResult("Seçilen öğretmen seçilen sınıfta zaten görevlidir.\nGörevlendirme işlemi iptal edilmiştir.");
            }
            else
            {
                _siniflarOgretmenlerDal.Add(new Entities.Concrete.JoiningTables.SiniflarOgretmenler { OgretmenID = ogretmenID, SinifID = sinifID });
                return new SuccessResult("Görevlendirme işlemi başarılı şekilde gerçekleştirilmiştir.");
            }
        }

        public bool OgretmenSiniftaGorevlimi(int sinifID,int ogretmenID)
        {
            return _siniflarOgretmenlerDal.GetAllOf().Find(x => x.SinifID == sinifID && x.OgretmenID == ogretmenID) != null ? true : false;     
        }
        public List<SiniflarOgretmenler> OgretmeninSiniflari(Ogretmen ogretmen)
        {
            return _siniflarOgretmenlerDal.GetAllOf(x => x.OgretmenID == ogretmen.OgretmenID);
        }

        public IResult SinifGorevlendirmesiniSil(Sinif sinif, Ogretmen ogretmen)
        {            
            _siniflarOgretmenlerDal.Delete(new SiniflarOgretmenler { SinifID=sinif.SinifID,OgretmenID=ogretmen.OgretmenID });

            return new SuccessResult($"{ogretmen.OgretmenAd} {ogretmen.OgretmenSoyad} isimli öğretmenin {sinif.Seviye}-{sinif.Sube} sınıfında ki görevi sonlandırılmıştır.");
        }
    }
}
