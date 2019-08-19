using CI.Data.Context;
using CI.Data.Repositories.Interfaces;
using CI.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace CI.Data.Repositories.Implementations
{
    public class BoardRepository : IBoardRepository
    {
        private DomainContext domainContext;

        public bool Create(Board entity)
        {
            try
            {
                using (domainContext = new DomainContext())
                {
                    domainContext.Entry(entity).State = EntityState.Added;
                    domainContext.SaveChanges();
                }

                return true;
            }
            catch (SqlException)
            {
                //TODO Logger implementation
                return false;
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

        public bool Delete(Board entity)
        {
            try
            {
                using (domainContext = new DomainContext())
                {
                    domainContext.Entry(entity).State = EntityState.Deleted;
                    domainContext.SaveChanges();
                }

                return true;
            }
            catch (SqlException)
            {
                //TODO Logger implementation
                return false;
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

                var test = domainContext.Boards.ToList();

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
