using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Validations.SQLValidation.Item
{
    public class ItemValidationSQLException : Exception
    {
        public ItemValidationSQLException(string message) : base(message)
        { }

        public static void ItemValidationNotFoundSQLException<TValue>(TValue value, string name)
        {
            if (value == null)
            {
                throw new DefaultValidationsException($"{name} is not found");
            }

            if (value is string stringValue && string.IsNullOrEmpty(stringValue))
            {
                throw new DefaultValidationsException($"{name} is not found");
            }
        }
    }
}
