using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class OgretmenManager : IOgretmenService
    {
        IOgretmenDal _ogretmenDal;
        public OgretmenManager(IOgretmenDal ogretmenDal)
        {
            _ogretmenDal = ogretmenDal;
        }
        
        public List<Ogretmen> DersinOgretmenleri(int dersId)
        {
            return _ogretmenDal.GetAllOf(x => x.Brans.DersID == dersId);
        }

        public IResult OgretmenEkle(Ogretmen ogretmen, out bool kontrol)
        {
            kontrol = false;
            foreach (Ogretmen item in _ogretmenDal.GetAllOf())
            {
                if (item.TcNo == ogretmen.TcNo)
                {
                    kontrol = true;
                    break;
                }
            }
            if (kontrol)
            {
                return new ErrorResult($"{ogretmen.TcNo} kimlik numaralı kişi öğretmen kadronuzda mevcuttur. Ekleme işleminiz iptal edilmiştir.");
            }
            else
            {
                _ogretmenDal.Add(ogretmen);
                return new SuccessResult($"{ogretmen.TcNo} kimlik numaralı kişi öğretmen kadronuza başarılı şekilde eklenmiştir.");
            }
        }

        public Ogretmen OgretmenGetir(string TcNo)
        {
            return _ogretmenDal.Get(x => x.TcNo == TcNo);
        }

        public IResult OgretmenGuncelle(Ogretmen ogretmen)
        {
            _ogretmenDal.Update(ogretmen);
            return new SuccessResult("Güncelleme işlemi başarılı şekilde gerçekleştirilmiştir.");
        }

        public List<Ogretmen> OgretmenKadrosuListele()
        {
            return _ogretmenDal.GetAllOf();
        }

        public IResult Ogretmenmi(string TcNo, string Sifre)
        {
            Ogretmen ogretmen = this.OgretmenKadrosuListele().Find(x => x.TcNo == TcNo && x.Sifre == Sifre);
            if (ogretmen != null)
            {
                return new SuccessDataResult<Ogretmen>(ogretmen, "Giriş başaralı.");
            }
            else
            {
                return new ErrorResult("Giriş bilgileriniz hatalı.\nLütfen tekrar deneyiniz.");
            }            
        }

        public IResult OgretmenSil(Ogretmen ogretmen)
        {
            _ogretmenDal.Delete(ogretmen);
            return new SuccessResult($"{ogretmen.OgretmenAd} {ogretmen.OgretmenSoyad} isimli öğretmenin kaydı başarılı şekilde silinmiştir.");
        }

        
    }
}
