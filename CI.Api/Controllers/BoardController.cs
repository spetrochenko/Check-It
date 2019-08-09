using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CI.Api.ViewModels.Board;
using CI.Bussiness.Services.Interfaces;
using CI.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace CI.Api.Controllers
{
    [Route("api/BoardController")]
    public class BoardController : Controller
    {
        private readonly IBoardService boardService;
        private readonly IMapper mapper;

        public BoardController(IBoardService boardService, IMapper mapper)
        {
            this.boardService = boardService;
            this.mapper = mapper;
        }

        [HttpPost("CreateBoard")]
        public CreateBoardViewModel CreateBoard([FromBody]CreateBoardViewModel boardViewModel)
        {
            var board = mapper.Map<Board>(boardViewModel);

            boardService.CreateBoard(board);

            return boardViewModel;
        }

        [HttpGet("LoadAllBoards")]
        public IEnumerable<CreateBoardViewModel> LoadBoards()
        {
            return boardService.LoadAllBoards().Select(m => mapper.Map<CreateBoardViewModel>(m));
        }

        [HttpGet("LoadBoardById")]
        public BoardViewModel LoadById(int id)
        {
            return new BoardViewModel();
        }
    }
}