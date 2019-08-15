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
    public class BoardRepository : IBoardRepository
    {
        private DomainContext domainContext;

        public void Create(Board entity)
        {
            using (domainContext = new DomainContext())
            {
                domainContext.Entry(entity).State = EntityState.Added;
                domainContext.SaveChanges();
            }
        }

        public void Update(Board entity)
        {
            using (domainContext = new DomainContext())
            {
                domainContext.Entry(entity).State = EntityState.Modified;
                domainContext.SaveChanges();
            }
        }

        public void Delete(Board entity)
        {
            using (domainContext = new DomainContext())
            {
                domainContext.Entry(entity).State = EntityState.Deleted;
                domainContext.SaveChanges();
            }
        }

        public Board LoadById(int id)
        {
            return domainContext.Boards.FirstOrDefault(b => b.BoardId == id);
        }

        public IReadOnlyCollection<Board> Load()
        {
            using (domainContext = new DomainContext())
            {
                domainContext.Boards.Load();

                return domainContext.Boards.ToList();
            }
        }

        public IReadOnlyCollection<Board> LoadBy(Expression<Func<Board, bool>> expression)
        {
            domainContext.Boards
                         .Where(expression)
                         .Load();

            return domainContext.Boards.ToList();
        }
    }
}
