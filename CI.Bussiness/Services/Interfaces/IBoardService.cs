using System.Collections.Generic;
using CI.Models.Models;

namespace CI.Bussiness.Services.Interfaces
{
    public interface IBoardService
    {
        void CreateBoard(Board board);

        Board LoadBoardById(int id);

        IEnumerable<Board> LoadAllBoards();
    }
}
