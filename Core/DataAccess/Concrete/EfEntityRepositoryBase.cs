using Core.DataAccess.Abstract;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.Concrete
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity Entity)
        {
            using (TContext context=new TContext())
            {
                context.Entry(Entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity Entity)
        {
            using (TContext context=new TContext())
            {
                context.Entry(Entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                context.Entry(Entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context=new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }            
        }
               
        public List<TEntity> GetAllOf(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context=new TContext())
            {                
                if (filter==null)
                {
                    return context.Set<TEntity>().ToList();
                }
                else
                {                        
                    return context.Set<TEntity>().Where(filter).ToList();
                }
            }
        }      
    }
}