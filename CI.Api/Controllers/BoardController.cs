using AutoMapper;
using CI.Api.ViewModels.Board;
using CI.Bussiness.Services.Interfaces;
using CI.Models.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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

            var isAdded = boardService.CreateBoard(board);

            if (!isAdded)
            {
                //TODO implement throw global exception
            }

            return boardViewModel;
        }

        [HttpGet("LoadAllBoards")]
        public IEnumerable<CreateBoardViewModel> LoadBoards()
        {
            return boardService.LoadAllBoards().Select(m => mapper.Map<CreateBoardViewModel>(m));
        }

        [HttpDelete("DeleteBoard")]
        public void DeleteBoard([FromBody]CreateBoardViewModel boardViewModel)
        {
            var board = mapper.Map<Board>(boardViewModel);

            var isDeleted = boardService.DeleteBoard(board);

            if (!isDeleted)
            {
                //TODO implement throw global exception
            }
        }

        [HttpGet("LoadBoardById")]
        public BoardViewModel LoadById(int id)
        {
            return new BoardViewModel();
        }
    }
}