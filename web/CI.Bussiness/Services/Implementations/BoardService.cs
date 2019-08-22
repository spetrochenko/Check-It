using CI.Bussiness.Services.Interfaces;
using CI.Data.Repositories.Interfaces;
using CI.Models.Models;
using System;
using System.Collections.Generic;
using ExecuteHelper = CI.Bussiness.ExecutableHelper.ExecutableHelper;

namespace CI.Bussiness.Services.Implementations
{
    public class BoardService : IBoardService
    {
        private readonly IGenericRepository<Board> boardRepository;

        public BoardService(IGenericRepository<Board> boardRepository)
        {
            this.boardRepository = boardRepository;
        }

        public bool CreateBoard(Board board)
        {
            if (board == null)
            {
                return false;
            }

            board.CreatedTime = DateTime.Now;

            return ExecuteHelper.ExecuteCreateMethod(boardRepository, board);
        }

        public bool DeleteBoard(Board board)
        {
            if (board == null)
            {
                return false;
            }

            return ExecuteHelper.ExecuteDeleteMethod(boardRepository, board);
        }

        public Board LoadBoardById(int id)
        {
            return boardRepository.LoadById(id);
        }

        public IEnumerable<Board> LoadAllBoards()
        {
            return boardRepository.Load();
        }
    }
}
