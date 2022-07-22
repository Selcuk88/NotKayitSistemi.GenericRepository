using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        void Add(T Entity);
        void Delete(T Entity);
        void Update(T Entity);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAllOf(Expression<Func<T, bool>> filter=null);        
    }
}
