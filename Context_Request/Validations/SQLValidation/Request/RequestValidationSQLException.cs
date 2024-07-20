namespace Validations.Request.SQLValidation.Request
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
