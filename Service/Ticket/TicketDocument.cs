using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

namespace Service.Ticket
{
    /**
     * @DateRelease: September 3th, 2018.
     * @Author: PerezRE.
     * @Comment: Code based on StackOverFlow thread by "marcelo c": https://es.stackoverflow.com/questions/71270/impresion-de-tickets-c
     */

    /// <summary>
    /// Ticket object. It prints appended text in <see cref="TicketText"/>: Header, Body and Footer.
    /// </summary>
    public class TicketDocument : PrintDocument
    {
        /// <summary>
        /// Ticket's logo.
        /// </summary>
        public Image Logo { get; set; }

        public IDictionary<TicketPaperLocation, TicketText> Text { get; set; }

        public TicketPaperLocation TextLocationMode { get; set; }

        private int NumChars { get; }

        /// <summary>
        /// Creates new ticket, ready to call <see cref="PrintDocument.Print"/>.
        /// </summary>
        /// <param name="MaxChars">Num of chars fitted in paper size.</param>
        /// <param name="DocumentName">Document's name. By detault is "Ticket".</param>
        /// <param name="font_size">Font size. By default is 8.</param>
        public TicketDocument(string DocumentName = "Ticket", int font_size = 8, int MaxChars = 45)
        {
            NumChars = MaxChars;
            this.DocumentName = DocumentName;
            TextLocationMode = TicketPaperLocation.Header;
            Text = new Dictionary<TicketPaperLocation, TicketText>
            {
                { TicketPaperLocation.Header, new TicketText(FontFamily.GenericMonospace, Brushes.Black, FontStyle.Regular, font_size) },
                { TicketPaperLocation.Body, new TicketText(FontFamily.GenericMonospace, Brushes.Black, FontStyle.Regular, font_size) },
                { TicketPaperLocation.Footer, new TicketText(FontFamily.GenericMonospace, Brushes.Black, FontStyle.Regular, font_size) }
            };
            PrintPage += Ticket_PrintPage;
        }

        /// <summary>
        /// Appends left formatted text.
        /// </summary>
        /// <param name="text">Text to be appended</param>
        /// <param name="textType">Site where the text is going to be appended: Header, Body, Footer </param>
        public void LeftText(string text)
        {
            int length = text.Length;
            if (length > NumChars)
            {
                int currentChar = 0; //Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = text.Length; longitudTexto > NumChars; longitudTexto -= NumChars)
                {
                    //Agregamos los fragmentos que salgan del texto
                    Text[TextLocationMode].Text.AppendLine(text.Substring(currentChar, NumChars));
                    currentChar += NumChars;
                }
                //agregamos el fragmento restante
                Text[TextLocationMode].Text.AppendLine(text.Substring(currentChar, text.Length - currentChar));
            }
            else
                Text[TextLocationMode].Text.AppendLine(text);
        }

        /// <summary>
        /// Appends right formatted text.
        /// </summary>
        /// <param name="text">Text to be appended.</param>
        /// <param name="textType">Site where the text is going to be appended: Header, Body, Footer </param>
        public void RightText(string text)
        {
            //Si la longitud del texto es mayor al numero maximo de caracteres permitidos, realizar el siguiente procedimiento.
            if (text.Length > NumChars)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = text.Length; longitudTexto > NumChars; longitudTexto -= NumChars)
                {// Agregamos los fragmentos que salgan del texto
                    Text[TextLocationMode].Text.AppendLine(text.Substring(caracterActual, NumChars));
                    caracterActual += NumChars;
                }
                //Variable para poner espacios restntes
                string espacios = "";
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < (NumChars - text.Substring(caracterActual, text.Length - caracterActual).Length); i++)
                    espacios += " ";//Agrega espacios para alinear a la derecha
                                    //agregamos el fragmento restante, agregamos antes del texto los espacios
                Text[TextLocationMode].Text.AppendLine(espacios + text.Substring(caracterActual, text.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < (NumChars - text.Length); i++)
                    espacios += " "; // Agrega espacios para alinear a la derecha
                                     //Si no es mayor solo agregarlo.
                Text[TextLocationMode].Text.AppendLine(espacios + text);
            }
        }

        /// <summary>
        /// Appends center formatted text.
        /// </summary>
        /// <param name="text">Text to be appended.</param>
        /// <param name="textType">Site where the text is going to be appended: Header, Body, Footer </param>
        public void CenterText(string text)
        {
            if (text.Length > NumChars)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = text.Length; longitudTexto > NumChars; longitudTexto -= NumChars)
                {
                    //Agregamos los fragmentos que salgan del texto
                    Text[TextLocationMode].Text.AppendLine(text.Substring(caracterActual, NumChars));
                    caracterActual += NumChars;
                }
                //Variable para poner espacios restntes
                string espacios = "";
                //sacamos la cantidad de espacios libres y el resultado lo dividimos entre dos
                int centrar = (NumChars - text.Substring(caracterActual, text.Length - caracterActual).Length) / 2;
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < centrar; i++)
                    espacios += " "; // Agrega espacios para centrar
                                     // Agregamos el fragmento restante, agregamos antes del texto los espacios
                Text[TextLocationMode].Text.AppendLine(espacios + text.Substring(caracterActual, text.Length - caracterActual));
            }
            else
            {
                string free_spaces = string.Empty;
                //sacamos la cantidad de espacios libres y el resultado lo dividimos entre dos
                int centrar = (int)Math.Ceiling((decimal)(NumChars - text.Length) / 2);
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < centrar; i++)
                    free_spaces += " "; // Agrega espacios para centrar
                                        // Agregamos el fragmento restante, agregamos antes del texto los espacios
                Text[TextLocationMode].Text.AppendLine(free_spaces + text);
            }
        }

        /// <summary>
        /// Appends text on sides.
        /// </summary>
        /// <param name="left_text">Text on the left side.</param>
        /// <param name="right_text">Text on the right side.</param>
        /// <param name="textType">Site where the text is going to be appended: Header, Body, Footer </param>
        public void SideText(string left_text, string right_text)
        {
            string l_text, r_text, complete_text = string.Empty, espacios = string.Empty;
            int cortar;
            //Si el texto que va a la izquierda es mayor a 18, cortamos el texto.
            if (left_text.Length > 22)
            {
                cortar = left_text.Length - 22;
                l_text = left_text.Remove(22, cortar);
            }
            else
                l_text = left_text;
            complete_text = l_text; // Agregamos el primer texto.
            if (right_text.Length > 24) // Si es mayor a 20 lo cortamos
            {
                cortar = right_text.Length - 24;
                r_text = right_text.Remove(24, cortar);
            }
            else
                r_text = right_text;
            // Obtenemos el numero de espacios restantes para poner textoDerecho al final
            int nroEspacios = NumChars - (l_text.Length + r_text.Length);
            for (int i = 0; i < nroEspacios; i++)
                espacios += " "; // Agrega los espacios para poner textoDerecho al final
            complete_text += espacios + right_text; // Agregamos el segundo texto con los espacios para alinearlo a la derecha.
            Text[TextLocationMode].Text.Append(complete_text).AppendLine();
        }

        /// <summary>
        /// Appends a line as separator.
        /// </summary>
        /// <param name="separatorType">Separator's type: Dash, Blank, Asterisk, Equal</param>
        /// <param name="textType">Site where the separator is going to be appended: Header, Body, Footer </param>
        public void Separator(TicketSeparator separator)
        {
            // Get line
            switch (separator)
            {
                case TicketSeparator.Dash:
                    Text[TextLocationMode].Text.Append('-', NumChars).AppendLine();
                    break;
                case TicketSeparator.Asterisk:
                    Text[TextLocationMode].Text.Append('*', NumChars).AppendLine();
                    break;
                case TicketSeparator.Equal:
                    Text[TextLocationMode].Text.Append('=', NumChars).AppendLine();
                    break;
                case TicketSeparator.Blank:
                    Text[TextLocationMode].Text.AppendLine();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Prints the ticket on a canvas.
        /// </summary>
        /// <param name="sender">Object which invokes the event <see cref="PrintDocument.PrintPage"/></param>
        /// <param name="e"><see cref="PrintPageEventArgs"/> passed by the sender.</param>
        private void Ticket_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Size and coordinates
            float x = 10, y = 5;
            // 270.0F for 80mm & 190.0F for 58mm
            float paper_width = e.PageSettings.PaperSize.Width > 200F ? 270F : 190F;
            // If log is setted.
            if (Logo != null)
            {
                // Get X position of the image.
                float x_img = paper_width == 190F ? paper_width / 5 : paper_width / 3.75F;
                // Draw logo.
                e.Graphics.DrawImage(Logo, x_img, y, Logo.Width, Logo.Height);
            }
            // String Sizes of the header, body and footer.
            TicketText HeaderText = Text[TicketPaperLocation.Header];
            TicketText BodyText = Text[TicketPaperLocation.Body];
            TicketText FooterText = Text[TicketPaperLocation.Footer];
            SizeF h_size = e.Graphics.MeasureString(HeaderText.Text.ToString(), HeaderText.Font, (int)paper_width);
            SizeF b_size = e.Graphics.MeasureString(BodyText.Text.ToString(), BodyText.Font, (int)paper_width);
            SizeF f_size = e.Graphics.MeasureString(FooterText.Text.ToString(), FooterText.Font, (int)paper_width);
            // Logo Height
            int img_height = Logo?.Height is int i_height ? i_height : 0;
            // Canvas to be used by header, body and footer.
            RectangleF h_canvas = new RectangleF(x, y + img_height, paper_width, h_size.Height);
            RectangleF b_canvas = new RectangleF(x, y + img_height + h_size.Height, paper_width, b_size.Height);
            RectangleF f_canvas = new RectangleF(x, y + img_height + h_size.Height + b_size.Height, paper_width, f_size.Height);
            // Drawing
            //// Header Text
            e.Graphics.DrawString(HeaderText.Text.ToString(), HeaderText.Font, HeaderText.Brush, h_canvas);
            //// Body Text
            e.Graphics.DrawString(BodyText.Text.ToString(), BodyText.Font, BodyText.Brush, b_canvas);
            //// Footer Text
            e.Graphics.DrawString(FooterText.Text.ToString(), FooterText.Font, FooterText.Brush, f_canvas);
        }
    }
}
