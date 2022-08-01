using Core.Results.Abstract;
using Entities.Concrete;
using Entities.Concrete.JoiningTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISiniflarOgretmenlerService
    {
        public IResult SinifaOgretmenGorevlendir(int sinifID, int ogretmenID);
        public bool OgretmenSiniftaGorevlimi(int sinifID, int ogretmenID);
        public List<SiniflarOgretmenler> OgretmeninSiniflari(Ogretmen ogretmen);
        public List<SiniflarOgretmenler> SinifinOgretmenleri(int sinifId);
        public IResult SinifGorevlendirmesiniSil(Sinif sinif, Ogretmen ogretmen);
    }
}
