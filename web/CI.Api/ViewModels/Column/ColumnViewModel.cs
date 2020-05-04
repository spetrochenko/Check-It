using CI.Api.ViewModels.Ticket;

namespace CI.Api.ViewModels.Column
{
    public class ColumnViewModel
    {
        public int ColumnId { get; set; }

        public string Title { get; set; }

        public TicketViewModel[] Tickets { get; set; }
    }
}
