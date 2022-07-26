using Core.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOgretmenService
    {
        IResult OgretmenEkle(Ogretmen ogretmen, out bool kontrol);
        IResult OgretmenGuncelle(Ogretmen ogretmen);
        IResult OgretmenSil(Ogretmen ogretmen);
        Ogretmen OgretmenGetir(string TcNo);
        List<Ogretmen> OgretmenKadrosuListele();        
        List<Ogretmen> DersinOgretmenleri(int dersId);
        IResult Ogretmenmi(string TcNo, string Sifre);
    }
}
