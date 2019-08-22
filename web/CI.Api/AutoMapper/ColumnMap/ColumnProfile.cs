using AutoMapper;
using CI.Api.ViewModels.Column;
using CI.Models.Models;

namespace CI.Api.AutoMapper.ColumnMap
{
    public class ColumnProfile : Profile
    {
        public ColumnProfile()
        {
            CreateMap<CreateColumnViewModel, Column>();
            CreateMap<Column, CreateColumnViewModel>();
        }
    }
}
