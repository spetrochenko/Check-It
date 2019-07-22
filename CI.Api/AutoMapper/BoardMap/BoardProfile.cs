using AutoMapper;
using CI.Api.ViewModels;
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
