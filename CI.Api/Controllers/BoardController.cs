using AutoMapper;
using CI.Api.ViewModels;
using CI.Bussiness.Services.Interfaces;
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
        public void CreateBoard([FromBody]BoardViewModel boardViewModel)
        {

        }

        [HttpGet("LoadBoardById")]
        public BoardViewModel LoadById(int id)
        {
            return new BoardViewModel();
        }
    }
}
