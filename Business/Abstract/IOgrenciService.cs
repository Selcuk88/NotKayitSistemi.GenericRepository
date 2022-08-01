using Core.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOgrenciService
    {
        IResult Add(Ogrenci ogrenci);
        IResult Delete(Ogrenci ogrenci);
        IResult Update(Ogrenci ogrenci);
        Ogrenci GetByTcNo(string ogrenciTcNo);
        List<Ogrenci> AyniSiniftakiOgrenciler(int sinifId);
        IResult OgrenciMi(string TcNo, string Sifre);
        List<Ogrenci> TumOgrenciler();
    }
}
