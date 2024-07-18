using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.CQRS.Item.Commands;
using Application.Events.Tools;
using AutoMapper;
using Domain.Events.Request.Events;
using MediatR;

namespace Application.Events.Request.Handlers.CreatePruductEventsGroup
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
