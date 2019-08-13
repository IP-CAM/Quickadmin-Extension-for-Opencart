using System.Net.Mail;

namespace Service.Mailing
{
    public interface IMailBuilder
    {
        MailMessage BuildMessage();
    }
}
