using Domain.Entities.Item;
using Domain.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Request.Interfaces
{
    public interface IRequestDomainService
    {
        public RequestEntity CreateRequest(int clientId, ICollection<RequestItemEntity> requestItensEntities);
    }
}
