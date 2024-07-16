using Application.DTOs.Request;
using Domain.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Request.Interfaces
{
    public interface IRequestApplicationService
    {
        public Task CreateRequestAsync(int clientId, ICollection<RequestItemEntityDTO> requestItemEntity);
        public Task<RequestEntityDTO> ReadRequestByIdAsync(int requestId);
    }
}
