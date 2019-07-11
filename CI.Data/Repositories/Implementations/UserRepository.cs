using CI.Data.Context;
using CI.Data.Repositories.Interfaces;
using CI.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CI.Data.Repositories.Implementations
{
    public class UserRepository :  IUserRepository
    {
        private DomainContext domainContext;

        public UserRepository(DomainContext domainContext)
        {
            this.domainContext = domainContext;
        }

        public void Create(User entity)
        {
            using (domainContext = new DomainContext())
            {
                domainContext.Entry(entity).State = EntityState.Added;
                domainContext.SaveChanges();
            }
        }

        public void Update(User entity)
        {
            using (domainContext = new DomainContext())
            {
                domainContext.Entry(entity).State = EntityState.Modified;
                domainContext.SaveChanges();
            }
        }

        public void Delete(User entity)
        {
            using (domainContext = new DomainContext())
            {
                domainContext.Entry(entity).State = EntityState.Deleted;
                domainContext.SaveChanges();
            }
        }

        public User LoadById(int id)
        {
            return domainContext.Users.FirstOrDefault(u => u.Id == id);
        }

        public IReadOnlyCollection<User> Load()
        {
            domainContext.Users.Load();

            return domainContext.Users.ToList();
        }

        public IReadOnlyCollection<User> LoadBy(Expression<Func<User, bool>> expression)
        {
            domainContext.Users.Where(expression)
                               .Load();

            return domainContext.Users.ToList();
        }
    }
}
