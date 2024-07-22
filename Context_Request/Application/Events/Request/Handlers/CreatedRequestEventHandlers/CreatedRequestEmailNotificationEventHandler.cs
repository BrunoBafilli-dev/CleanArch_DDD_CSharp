using Application.Request.Tools.Notifiers;
using Domain.Request.Events.Request.Events;
using MediatR;

namespace Application.Request.Events.Request.Handlers.CreatePruductEvents
{
    public class CreatedRequestEmailNotificationEventHandler : INotificationHandler<CreatedRequestDomainEvent>
    {
        private readonly IEmailSender _emailSender;

        public CreatedRequestEmailNotificationEventHandler(IEmailSender emailSender)
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
