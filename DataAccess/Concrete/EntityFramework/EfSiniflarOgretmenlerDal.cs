using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete.JoiningTables;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSiniflarOgretmenlerDal:EfEntityRepositoryBase<SiniflarOgretmenler,ProjectContext>,ISiniflarOgretmenlerDal
    {
    }
}
