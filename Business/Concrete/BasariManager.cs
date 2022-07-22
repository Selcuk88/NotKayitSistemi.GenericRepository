using Business.Abstract;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class BasariManager:IBasariService
    {
        IBasariDal _basariDal;
        public BasariManager(IBasariDal basariDal)
        {
            _basariDal=basariDal;
        }
    }
}
