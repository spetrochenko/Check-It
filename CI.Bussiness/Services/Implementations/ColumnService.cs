using CI.Bussiness.Services.Interfaces;
using CI.Data.Repositories.Interfaces;
using CI.Models.Models;

namespace CI.Bussiness.Services.Implementations
{
    public class ColumnService : IColumnService
    {
        private readonly IColumnRepository columnRepository;

        public ColumnService(IColumnRepository columnRepository)
        {
            this.columnRepository = columnRepository;
        }

        public void CreateColumn(Column column)
        {
            columnRepository.Create(column);
        }
    }
}
