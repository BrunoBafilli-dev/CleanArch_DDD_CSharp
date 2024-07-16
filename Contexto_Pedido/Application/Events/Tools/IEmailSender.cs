namespace Application.Events.Tools
{
    public interface IEmailSender
    {
        public void SendEmail(string email);
    }
}
