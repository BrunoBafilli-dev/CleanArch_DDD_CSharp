namespace Application.Request.Tools.Notifiers
{
    public interface IEmailSender
    {
        public void SendEmail(string email);
    }
}
