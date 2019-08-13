using Service.Mailing;
using System.Net.Mail;
using System.Text;

namespace UI.Services
{
    internal class WelcomeMailBuilder : IMailBuilder
    {
        private readonly string from;
        private readonly string to;
        private readonly string customer_pwd;
        private readonly string[] attachments;

        public WelcomeMailBuilder(string from, string to, string customer_pwd, string[] attachments = null)
        {
            this.from = from;
            this.to = to;
            this.customer_pwd = customer_pwd;
            this.attachments = attachments;
        }

        public MailMessage BuildMessage()
        {
            MailMessage mail = new MailMessage(from, to)
            {
                Subject = "¡Welcome!",
                Body = new StringBuilder()
                    .AppendLine("This email is to thank you for you preference for us and notice you that you are now registered in our online store, which you can buy through the following credential, made just for you:")
                    .AppendLine().AppendLine()
                    .AppendLine("Access Credential:")
                    .AppendLine($"User: {to}")
                    .AppendLine($"Password: {customer_pwd}").AppendLine()
                    .AppendLine("To access to our online store with your credential, just click in the following link:")
                    .AppendLine("https://my-store.com/index.php?route=account/login").AppendLine().AppendLine()
                    .AppendLine("Remember that the credential is merely private").AppendLine()
                    .AppendLine("Greetings!").ToString(),
                Priority = MailPriority.Normal,
                IsBodyHtml = false,
            };
            if (attachments != null)
                foreach (string attachment in attachments)
                    mail.Attachments.Add(new Attachment(attachment));

            return mail;
        }
    }
}
