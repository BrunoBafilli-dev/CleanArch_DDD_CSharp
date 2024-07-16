using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validations.DomainValidation.Item
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
