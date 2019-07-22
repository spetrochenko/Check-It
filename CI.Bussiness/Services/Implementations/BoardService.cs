using CI.Bussiness.Services.Interfaces;
using CI.Data.Repositories.Interfaces;
using CI.Models.Models;

namespace CI.Bussiness.Services.Implementations
{
    public class BoardService : IBoardService
    {
        private readonly IBoardRepository boardRepository;

        public BoardService(IBoardRepository boardRepository)
        {
            this.boardRepository = boardRepository;
        }

        public void CreateBoard(Board board)
        {
            boardRepository.Create(board);
        }

        public Board LoadBoardById(int id)
        {
            return boardRepository.LoadById(id);
        }
    }
}
