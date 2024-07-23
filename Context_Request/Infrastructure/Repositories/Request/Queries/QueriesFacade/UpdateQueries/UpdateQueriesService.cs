using Domain.Request.Entities.Request;
using Infrastructure.Request.Database.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validations.Request;
using Validations.Request.SQLValidation.Request;

namespace Infrastructure.Request.Repositories.Request.Queries.QueriesFacade.UpdateQueries
{
    public class UpdateQueriesService
    {
        public static async Task ExecuteAsync(RequestEntity requestEntity, RequestDataContext _requestDataContext)
        {
            // Verifica se a entidade existe no banco de dados
            var findedRequestEntity = await _requestDataContext.RequestEntities.FindAsync(requestEntity.Id);
            
            DefaultValidationsException.IsNullOrEmpty(findedRequestEntity, nameof(findedRequestEntity));

            // Atualiza a entidade existente com novos valores
            _requestDataContext.Entry(findedRequestEntity).CurrentValues.SetValues(requestEntity);
        }
    }
}
