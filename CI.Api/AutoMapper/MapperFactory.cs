using AutoMapper;
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
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}
