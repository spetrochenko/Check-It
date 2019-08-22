using CI.Api.ViewModels.Column;

namespace CI.Api.ViewModels.Board
{
    public class BoardViewModel
    {
        public int BoardId { get; set; }

        public string Title { get; set; }

        public ColumnViewModel[] Columns { get; set; }
    }
}
