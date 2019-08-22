using CI.Data.Context;
using CI.Data.Repositories.Interfaces;
using CI.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CI.Data.Repositories.Implementations
{
    public class ColumnRepository : IColumnRepository
    {
        private DomainContext domainContext;

        public bool Create(Column entity)
        {
            using (domainContext = new DomainContext())
            {
                domainContext.Entry(entity).State = EntityState.Added;
                domainContext.SaveChanges();
            }

            return true;
        }

        public void Update(Column entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Column entity)
        {
            throw new NotImplementedException();
        }

        public Column LoadById(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Column> Load()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Column> LoadBy(Expression<Func<Column, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
