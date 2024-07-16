using Application.Events.EventBus;
using AutoMapper;
using Domain.Services.Request.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Request
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
