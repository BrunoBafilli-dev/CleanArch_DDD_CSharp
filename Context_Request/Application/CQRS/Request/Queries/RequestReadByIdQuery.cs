using Application.Request.CQRS.Interfaces;
using Domain.Request.Entities.Request;
using MediatR;

namespace Application.Request.CQRS.Request.Queries
{
    public class RequestReadByIdQuery : IRequest<RequestEntity>, ICQRS
    {
        public int Id { get; set; }

        public RequestReadByIdQuery(int id)
        {
            Id = id;
        }
    }
}
