using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.CQRS.Item.Commands;
using Application.CQRS.Request.Commands;
using Application.CQRS.Request.Queries;
using Application.DTOs.Request;
using Application.Events.EventBus;
using Application.Services.Request.Interfaces;
using AutoMapper;
using Domain.Entities.Request;
using Domain.Services;
using Domain.Services.Request.Interfaces;
using Domain.UnitOfWork;
using MediatR;

namespace Application.Services.Request
{
    public class RequestApplicationService : IRequestApplicationService
    {
        private readonly RequestApplicationServiceDependencies _requestServiceDependencies;

        public RequestApplicationService(RequestApplicationServiceDependencies requestServiceDependencies)
        {
            _requestServiceDependencies = requestServiceDependencies;
        }

        public async Task CreateRequestAsync(int clientId, ICollection<RequestItemEntityDTO> requestItemEntityDTO)
        {
            var requestItensEntities = _requestServiceDependencies._mapper.Map<ICollection<RequestItemEntity>>(requestItemEntityDTO);

            var requestEntity = _requestServiceDependencies._requestDomainService.CreateRequest(clientId, requestItensEntities);

            await _requestServiceDependencies._mediator.Send(new RequestCreateCommand(requestEntity));
        }

        public async Task<RequestEntityDTO> ReadRequestByIdAsync(int requestId)
        {
            var requestEntity = await _requestServiceDependencies._mediator.Send(new RequestReadByIdQuery(requestId));

            return _requestServiceDependencies._mapper.Map<RequestEntityDTO>(requestEntity);
        }

        public async Task RequestCreatedDispatchEvents(RequestEntity requestEntity)
        {
            foreach (var @event in requestEntity.RequestCreatedDomainEvents)
            {
                await _requestServiceDependencies._eventBus.Publish(@event);
            }
        }
    }
}
