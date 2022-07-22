using Core.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMudurService
    {
        string GirisKontrol(string mudurTcNo, string mudurSifre, out bool kontrol);
    }
}
