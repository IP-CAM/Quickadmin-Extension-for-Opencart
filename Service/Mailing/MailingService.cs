using System.Net;
using System.Net.Mail;

namespace Service.Mailing
{
    public class MailingService
    {
        private string Host { get; }
        private int Port { get; }

        public MailingService(string host, int port)
        {
            Host = host;
            Port = port;
        }

        public void Send(MailMessage mail, string from_pwd)
        {
            using (SmtpClient client = new SmtpClient
            {
                Port = Port,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = Host,
                EnableSsl = true,
                Credentials = new NetworkCredential(mail.From.Address, from_pwd)
            })
                client.Send(mail);
        }

        public void Send(string from, string pwd, string to, string subject, string body, params string[] attachments)
        {
            using (SmtpClient client = new SmtpClient
            {
                Port = Port,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = Host,
                EnableSsl = true,
                Credentials = new NetworkCredential(from, pwd),
                
            })
            {
                MailMessage mail = new MailMessage(from, to)
                {
                    Subject = subject,
                    Body = body,
                    Priority = MailPriority.Normal,
                    IsBodyHtml = false,
                };
                foreach (string attachment in attachments)
                    mail.Attachments.Add(new Attachment(attachment));
                client.Send(mail);
            }
        }
    }
}
