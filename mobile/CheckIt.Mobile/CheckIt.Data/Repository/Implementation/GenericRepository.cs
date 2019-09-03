using CheckIt.Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CheckIt.Data.Repository.Implementation
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        private readonly DomainContext domainContext;

        public GenericRepository(DomainContext domainContext)
        {
            this.domainContext = domainContext;
        }

        public void Create(TEntity entity)
        {
            using (domainContext)
            {
                domainContext.Attach(entity).State = EntityState.Added;
                domainContext.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (domainContext)
            {
                domainContext.Entry(entity).State = EntityState.Modified;
                domainContext.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (domainContext)
            {
                domainContext.Entry(entity).State = EntityState.Deleted;
                domainContext.SaveChanges();
            }
        }

        public TEntity LoadById(int id)
        {
            using (domainContext)
            {
                return domainContext.Set<TEntity>().Find(id);
            }
        }

        public IQueryable<TEntity> Load()
        {
            return domainContext.Set<TEntity>();
        }
    }
}
