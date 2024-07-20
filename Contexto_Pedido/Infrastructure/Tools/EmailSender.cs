using Application.Request.Events.Tools;

namespace Infrastructure.Request.Tools
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(string email)
        {
            Console.WriteLine($"{email} enviado com sucesso!");
        }
    }
}
