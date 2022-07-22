using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class DersManager : IDersService
    {
        IDersDal _dersDal;
        public DersManager(IDersDal dersDal)
        {
            _dersDal = dersDal;
        }
        public IResult DersEkleme(string dersAd)
        {
            dersAd= dersAd.ToUpper();
            Ders ders = _dersDal.GetAllOf().Find(x => x.DersAd == dersAd);            
            if (ders!=null)
            {
                return new ErrorResult("Bu ders müfredatınızda mevcuttur.\n Ders açma işlemi iptal edildi.");
            }
            else
            {
                ders=new Ders { DersAd= dersAd };
                _dersDal.Add(ders);
                return new SuccessResult("Ders başarılı şekilde açıldı.");
            }
        }

        public Ders DersiGetir(string dersAd)
        {
            return _dersDal.Get(x => x.DersAd == dersAd);
        }

        public Ders DersiGetir(int dersId)
        {
            return _dersDal.Get(x => x.DersID == dersId);
        }

        public IResult DersSilme(string dersAd)
        {
            _dersDal.Delete(_dersDal.Get(x => x.DersAd == dersAd));
            return new SuccessResult($"{dersAd} dersi başarılı şekilde kapatıldı.");
        }

        public List<Ders> TumDersleriListele()
        {
            return _dersDal.GetAllOf();
        }
    }
}
