using CI.Models.Models;

namespace CI.Api.ViewModels
{
    public class BoardViewModel
    {
        public string Title { get; set; }

        public Column[] Columns { get; set; }
    }
}
