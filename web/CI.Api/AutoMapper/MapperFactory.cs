using AutoMapper;
using CI.Api.AutoMapper.BoardMap;
using CI.Api.AutoMapper.ColumnMap;

namespace CI.Api.AutoMapper
{
    public class MapperFactory
    {
        public static IMapper GetMapper()
        {
            var mapperConfiguration = new MapperConfiguration(am =>
            {
                am.AddProfile<ColumnProfile>();
                am.AddProfile<BoardProfile>();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}
