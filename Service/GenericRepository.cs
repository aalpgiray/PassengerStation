using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PassengerStation.Service
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        DbContext context;

        public GenericRepository(DbContext context)
        {
            this.context = context;
        }

        public virtual IEnumerable<TEntity> Get()
        {
            return context.Set<TEntity>();
        }

        public virtual TEntity Find(int Id)
        {
            return context.Set<TEntity>().Find(Id);
        }

        public virtual IEnumerable<TEntity> Filter(Expression<Func<TEntity,bool>> expression)
        {
            return context.Set<TEntity>().Where(expression);
        }

        public virtual void Add(TEntity entity)
        {
            context.Entry<TEntity>(entity).State = EntityState.Added;
        }

        public void Attach(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Remove(TEntity entity)
        {
            context.Entry<TEntity>(entity).State = EntityState.Deleted;
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        
    }
}
