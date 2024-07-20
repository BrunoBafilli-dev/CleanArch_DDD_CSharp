namespace Application.Request.Events.Tools
{
    public interface IEmailSender
    {
        public void SendEmail(string email);
    }
}
