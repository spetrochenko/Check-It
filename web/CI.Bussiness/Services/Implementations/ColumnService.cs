using CI.Bussiness.Services.Interfaces;
using CI.Data.Repositories.Interfaces;
using CI.Models.Models;
using System;

namespace CI.Bussiness.Services.Implementations
{
    public class ColumnService : IColumnService
    {
        private readonly IGenericRepository<Column> repository;

        public ColumnService(IGenericRepository<Column> repository)
        {
            this.repository = repository;
        }

        public void CreateColumn(Column column)
        {
            throw new NotImplementedException();
        }
    }
}
