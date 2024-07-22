using Application.Request.Tools.Notifiers;

namespace Infrastructure.Request.Tools.Notifiers
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(string email)
        {
            Console.WriteLine($"{email} enviado com sucesso!");
        }
    }
}
