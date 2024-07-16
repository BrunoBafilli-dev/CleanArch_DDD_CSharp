using Domain.Entities.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Item;
using Domain.Entities.Request;
using Domain.Services.Request.Interfaces;

namespace Domain.Services
{
    public class RequestDomainService : IRequestDomainService
    {
        public RequestEntity CreateRequest(int clientId, ICollection<RequestItemEntity> requestItensEntities)
        {
            return new RequestEntity(clientId, requestItensEntities);
        }
    }
}
