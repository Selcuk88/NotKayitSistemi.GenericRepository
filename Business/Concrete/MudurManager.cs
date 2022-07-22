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
    public class MudurManager : IMudurService
    {
        IMudurDal _mudurDal;
        public MudurManager(IMudurDal mudurDal)
        {
            _mudurDal = mudurDal;
        }        

        public string GirisKontrol(string mudurTcNo, string mudurSifre, out bool kontrol)
        {
            if (_mudurDal.Get(x => x.MudurTcNo == mudurTcNo && x.MudurSifre == mudurSifre) == null)
            {
                kontrol = false;
                return "Giriş bilgileriniz hatalı.\nLütfen tekrar deneyiniz.";
            }
            else
            {
                kontrol = true;
                return "Giriş başarılı.";
            }
        }
    }
}
