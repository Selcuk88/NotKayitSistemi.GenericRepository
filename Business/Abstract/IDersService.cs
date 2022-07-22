using Core.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDersService
    {
        IResult DersEkleme(string dersAd);
        IResult DersSilme(string dersAd);
        List<Ders> TumDersleriListele();
        Ders DersiGetir(string dersAd);
        Ders DersiGetir(int dersId);
    }
}
