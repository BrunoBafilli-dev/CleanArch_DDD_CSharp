using Domain.Entities.Request;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.UnitOfWork;

namespace Application.CQRS.Request.Commands
{
    public class RequestCreateCommand : RequestCommand
    {
        public RequestCreateCommand(RequestEntity requestEntity)
        {
            RequestEntity = requestEntity;
        }
    }
}
