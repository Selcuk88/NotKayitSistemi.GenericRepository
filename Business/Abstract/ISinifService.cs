using Core.Results.Abstract;
using Core.Results.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISinifService
    {
        IResult SinifAcma(string seviye, string sube, short kapasite);
        DataResult<Sinif> SinifKapatma(Sinif Sinif, int OgrenciSayisi);
        IResult SinifGuncelleme(string seviye, string sube, short kapasite);
        List<Sinif> TumSiniflariListele();
        Sinif GetSinif(int SinifId);

    }
}
