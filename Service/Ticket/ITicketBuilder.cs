namespace Service.Ticket
{
    public interface ITicketBuilder
    {
        TicketDocument GetTicket();
        void BuildHeader();
        void BuildBody();
        void BuildFooter();
    }
}
