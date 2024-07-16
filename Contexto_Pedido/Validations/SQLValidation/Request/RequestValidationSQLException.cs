using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validations.SQLValidation.Request
{
    public class RequestValidationSQLException : Exception
    {
        public RequestValidationSQLException(string message) : base(message) { }

        public static void InsufficientStockException()
        {
            throw new RequestValidationSQLException("Estoque insuficiente");
        }
    }
}
