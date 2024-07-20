using Domain.Request.Entities.Request;
using MediatR;

namespace Application.Request.CQRS.Request.Queries
{
    public class RequestReadByIdQuery : IRequest<RequestEntity>
    {
        public int Id { get; set; }

        public RequestReadByIdQuery(int id)
        {
            Id = id;
        }
    }
}
