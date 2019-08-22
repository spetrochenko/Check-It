using System.Collections.Generic;
using CI.Models.Models;

namespace CI.Bussiness.Services.Interfaces
{
    public interface IBoardService
    {
        bool CreateBoard(Board board);

        bool DeleteBoard(Board board);

        Board LoadBoardById(int id);

        IEnumerable<Board> LoadAllBoards();
    }
}
