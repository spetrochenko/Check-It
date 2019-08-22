using AutoMapper;
using CI.Api.ViewModels.Column;
using CI.Bussiness.Services.Interfaces;
using CI.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace CI.Api.Controllers
{
    [Route("api/ColumnController")]
    public class ColumnController : Controller
    {
        private readonly IMapper mapper;
        private readonly IColumnService columnService;

        public ColumnController(IMapper mapper, IColumnService columnService)
        {
            this.mapper = mapper;
            this.columnService = columnService;
        }

        [HttpPost("CreateColumn")]
        public CreateColumnViewModel CreateColumn([FromBody] CreateColumnViewModel columnView)
        {
            var column = mapper.Map<Column>(columnView);

            //columnService.CreateColumn(column);

            return columnView;
        }
    }
}
