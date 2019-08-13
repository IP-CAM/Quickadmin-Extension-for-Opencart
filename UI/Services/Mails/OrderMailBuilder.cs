using Service.Mailing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace UI.Services
{
    internal class OrderMailBuilder : IMailBuilder
    {
        private readonly string from;
        private readonly string to;
        private readonly string pdf_filename;

        public OrderMailBuilder(string from, string to, string pdf_filename)
        {
            this.from = from;
            this.to = to;
            this.pdf_filename = pdf_filename;
        }

        public MailMessage BuildMessage()
        {
            MailMessage mail = new MailMessage(from, to)
            {
                Subject = "Purchase!",
                Body = new StringBuilder()
                    .AppendLine("The reason of the present mail is to thank you for your preference to us and notice you that you have just realized a new purchase in our.")
                    .AppendLine().AppendLine()
                    .AppendLine("Please, do not forget our online store through the following link:")
                    .AppendLine("https://my-store.com/").AppendLine().AppendLine()
                    .AppendLine("Greetings!").ToString(),
                Priority = MailPriority.Normal,
                IsBodyHtml = false,
            };

            mail.Attachments.Add(new Attachment(pdf_filename));
            return mail;
        }
    }
}
