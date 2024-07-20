using Application.Request.Events.EventBus;
using AutoMapper;
using Domain.Request.Services.Request.Interfaces;
using MediatR;

namespace Application.Request.Services.Request
{
    public class RequestApplicationServiceDependencies
    {
        public readonly IRequestDomainService _requestDomainService;
        public readonly IEventBus _eventBus;
        public readonly IMapper _mapper;
        public readonly IMediator _mediator;

        public RequestApplicationServiceDependencies(IRequestDomainService requestDomainService, IEventBus eventBus, IMapper mapper, IMediator mediator)
        {
            _requestDomainService = requestDomainService;
            _eventBus = eventBus;
            _mapper = mapper;
            _mediator = mediator;
        }
    }
}
