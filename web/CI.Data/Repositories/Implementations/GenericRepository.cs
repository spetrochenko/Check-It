using CI.Data.Context;
using CI.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace CI.Data.Repositories.Implementations
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        private readonly DomainContext domainContext;

        public GenericRepository(DomainContext domainContext)
        {
            this.domainContext = domainContext;
        }

        public bool Create(TEntity entity)
        {
            try
            {
                using (domainContext)
                {
                    domainContext.Attach(entity).State = EntityState.Added;
                    domainContext.SaveChanges();
                }

                return true;
            }
            catch (SqlException)
            {
                //TODO Implement logger
                return false;
            }
        }

        public bool Update(TEntity entity)
        {
            try
            {
                using (domainContext)
                {
                    domainContext.Entry(entity).State = EntityState.Modified;
                    domainContext.SaveChanges();
                }

                return true;
            }
            catch (SqlException)
            {
                //TODO Implement logger
                return false;
            }
        }

        public bool Delete(TEntity entity)
        {
            try
            {
                using (domainContext)
                {
                    domainContext.Entry(entity).State = EntityState.Deleted;
                    domainContext.SaveChanges();
                }

                return true;
            }
            catch (SqlException)
            {
                //TODO Implement logger
                return false;
            }
        }

        public TEntity LoadById(int id)
        {
            using (domainContext)
            {
                return domainContext.Set<TEntity>().Find(id);
            }
        }

        public IGenericRepository<TEntity> Include(Expression<Func<TEntity, object>> expression)
        {
            domainContext.Set<TEntity>().Include(expression);

            return this;
        }

        public IReadOnlyCollection<TEntity> Load()
        {
            using (domainContext)
            {
                domainContext.Set<TEntity>()
                             .AsNoTracking()
                             .Load();

                return domainContext.Set<TEntity>().ToList();
            }
        }

        public IReadOnlyCollection<TEntity> LoadBy(Expression<Func<TEntity, bool>> expression)
        {
            using (domainContext)
            {
                domainContext.Set<TEntity>()
                    .AsNoTracking()
                    .Where(expression)
                    .Load();

                return domainContext.Set<TEntity>().ToList();
            }
        }

        public IReadOnlyCollection<TEntity> OrderBy(Expression<Func<TEntity, bool>> expression)
        {
            using (domainContext)
            {
                domainContext.Set<TEntity>()
                    .AsNoTracking()
                    .OrderBy(expression)
                    .Load();

                return domainContext.Set<TEntity>().ToList();
            }
        }
    }
}
