using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Request;
using Domain.UnitOfWork;
using MediatR;

namespace Application.CQRS.Request.Queries
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
