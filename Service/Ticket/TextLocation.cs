namespace Service.Ticket
{
    /// <summary>
    /// Used to append text in 
    /// <see cref="TicketPaperLocation.Header"/>, <see cref="TicketPaperLocation.Body"/>, <see cref="TicketPaperLocation.Footer"/>
    /// </summary>

    public enum TicketPaperLocation
    {
        /// <summary>
        /// Header Text
        /// </summary>
        Header,
        /// <summary>
        /// Body Text
        /// </summary>
        Body,
        /// <summary>
        /// Footer text
        /// </summary>
        Footer
    }
}
