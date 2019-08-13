namespace Service.Ticket
{
    public class TicketDocBuilder
    {
        private readonly ITicketBuilder builder;

        public TicketDocBuilder(ITicketBuilder builder) => this.builder = builder;

        public TicketDocument BuildTicket()
        {
            builder.BuildHeader();
            builder.BuildBody();
            builder.BuildFooter();
            return builder.GetTicket();
        }
    }
}
