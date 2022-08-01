using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class OgrenciManager : IOgrenciService
    {
        IOgrenciDal _ogrenciDal;
        public OgrenciManager(IOgrenciDal ogrenciDal)
        {
            _ogrenciDal = ogrenciDal;
        }
        public IResult Add(Ogrenci ogrenci)
        {
            if (_ogrenciDal.Get(x=>x.TcNo ==ogrenci.TcNo)!=null)
            {
                return new ErrorResult("Bu öğrenci sistemde kayıtlıdır.\nKayıt işlemi iptal edildi.");
            }
            else
            {
                _ogrenciDal.Add(ogrenci);
                string message = ogrenci.OgrenciAd + " " + ogrenci.OgrenciSoyad + "isimli öğrencinin kaydı alınmıştır";                
                return new SuccessResult(message);
            }
        }

        public List<Ogrenci> AyniSiniftakiOgrenciler(int sinifId)
        {
            return _ogrenciDal.GetAllOf(x => x.SinifID == sinifId);
        }

        public IResult Delete(Ogrenci ogrenci)
        {
            _ogrenciDal.Delete(ogrenci);
            string message = ogrenci.OgrenciAd + " " + ogrenci.OgrenciSoyad + "isimli öğrencinin kaydı silinmiştir";            
            return new SuccessResult(message);
        }

        public Ogrenci GetByTcNo(string ogrenciTcNo)
        {
            return _ogrenciDal.Get(x => x.TcNo == ogrenciTcNo);
        }

        public IResult OgrenciMi(string TcNo, string Sifre)
        {
            Ogrenci ogrenci = _ogrenciDal.Get(x => x.TcNo == TcNo && x.Sifre == Sifre);
            if (ogrenci != null)
            {
                return new SuccessDataResult<Ogrenci>(ogrenci, "Giriş başaralı.");
            }
            else
            {
                return new ErrorResult("Giriş bilgileriniz hatalı.\nLütfen tekrar deneyiniz.");
            }
        }

        public List<Ogrenci> TumOgrenciler()
        {
            return _ogrenciDal.GetAllOf();
        }

        public IResult Update(Ogrenci ogrenci)
        {
            _ogrenciDal.Update(ogrenci);
            return new SuccessResult($"{ogrenci.OgrenciAd} {ogrenci.OgrenciSoyad} isimli öğrencinin bilgileri güncellenmiştir.");
        }
    }
}
