using AutoMapper;
using CI.Api.ViewModels.Board;
using CI.Models.Models;

namespace CI.Api.AutoMapper.BoardMap
{
    public class BoardProfile : Profile
    {
        public BoardProfile()
        {
            CreateMap<BoardViewModel, Board>();
        }
    }
}
