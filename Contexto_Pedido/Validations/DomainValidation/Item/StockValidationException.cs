namespace Validations.Request.DomainValidation.Item
{
    public class StockValidationException : Exception
    {
        public StockValidationException(string message) : base(message) { }

        public static void InsufficientStockException(int qntStock, int qntReduce)
        {
            throw new StockValidationException($"Stock insuficiente, stock: {qntStock} | solicitado: {qntReduce}");
        }
    }
}
