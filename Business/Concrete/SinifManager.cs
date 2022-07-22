using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SinifManager : ISinifService
    {
        ISinifDal _sinifDal;
        public SinifManager(ISinifDal sinifDal)
        {
            _sinifDal = sinifDal;
        }

        public Sinif GetSinif(int sinifId)
        {
            return _sinifDal.Get(x => x.SinifID == sinifId);
        }        

        public IResult SinifAcma(string seviye, string sube, short kapasite)
        {
            if (_sinifDal.GetAllOf(x => x.Seviye == seviye && x.Sube == sube).Count > 0)
            {
                return new ErrorResult("Açmaya çalıştığınız sınıf ve şube zaten mevcuttur. Farklı bir sinif veya şube açmalısınız.");
            }
            else
            {
                Sinif sinif = new Sinif { Seviye = seviye, Sube = sube, Kapasite = kapasite };
                _sinifDal.Add(sinif);
                return new SuccessResult("Sınıf/şube başarılı şekilde açılmıştır.");
            }
        }

        public IResult SinifGuncelleme(string seviye, string sube, short kapasite)
        {
            throw new NotImplementedException();
        }

        public DataResult<Sinif> SinifKapatma(Sinif sinif, int ogrenciSayisi)
        {
            Sinif _sinif = _sinifDal.Get(x => x.Seviye == sinif.Seviye && x.Sube == sinif.Sube && x.Kapasite == sinif.Kapasite);

            if (ogrenciSayisi > 0)
            {
                return new ErrorDataResult<Sinif>(_sinif, $"{_sinif.Seviye}-{_sinif.Sube} sınıfında {ogrenciSayisi} öğrenci bulunmaktadır. Sınıfta bulunan öğrencileri başka sınıflara transfer etmeden sınıf kapatma işlemini gerçekleştiremezsiniz.");
            }
            else
            {
                _sinifDal.Delete(_sinif);
                return new SuccessDataResult<Sinif>(_sinif, $"{_sinif.Seviye}-{_sinif.Sube} sınıfı başarılı şekilde kapatılmıştır.");
            }
        }
        public List<Sinif> TumSiniflariListele()
        {
            return _sinifDal.GetAllOf();
        }
    }
}
