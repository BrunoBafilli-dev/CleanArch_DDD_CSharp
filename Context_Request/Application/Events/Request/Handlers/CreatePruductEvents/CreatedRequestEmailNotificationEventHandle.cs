using Application.Request.Events.Tools;
using Domain.Request.Events.Request.Events;
using MediatR;

namespace Application.Request.Events.Request.Handlers.CreatePruductEvents
{
    public class CreatedRequestEmailNotificationEventHandle : INotificationHandler<CreatedRequestDomainEvent>
    {
        private readonly IEmailSender _emailSender;

        public CreatedRequestEmailNotificationEventHandle(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public Task Handle(CreatedRequestDomainEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"ID: {notification.Id} - Date: {notification.OcurredOn}");

            _emailSender.SendEmail("brunobafilli");

            return Task.CompletedTask;
        }
    }
}
