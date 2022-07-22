using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete.JoiningTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSiniflarDerslerDal:EfEntityRepositoryBase<SiniflarDersler,ProjectContext> ,ISiniflarDerslerDal
    {
    }
}
