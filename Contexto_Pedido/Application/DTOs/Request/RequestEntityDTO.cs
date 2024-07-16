using Domain.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Request
{
    public class RequestEntityDTO
    {
        public int ClientId { get; set; }
        public IReadOnlyCollection<RequestItemEntity> RequestItensEntities { get; set; }
    }
}
