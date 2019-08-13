using System.Drawing;
using System.Text;

namespace Service.Ticket
{
    /// <summary>
    /// Text used by <see cref="Ticket"/>
    /// </summary>
    public class TicketText
    {
        public StringBuilder Text { get; private set; }
        public Font Font { get; set; }
        public Brush Brush { get; set; }

        public TicketText(FontFamily font, Brush brush, FontStyle style, int font_size)
        {
            Text = new StringBuilder();
            Font = new Font(font, font_size, style);
            Brush = brush;
        }
    }
}
