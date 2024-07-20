using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Request.DTOs.Request;

namespace Application.Services.Request.Interfaces
{
    public interface IRequestApplicationService
    {
        public Task CreateRequestAsync(int clientId, ICollection<RequestItemEntityDTO> requestItemEntity);
        public Task<RequestEntityDTO> ReadRequestByIdAsync(int requestId);
    }
}
