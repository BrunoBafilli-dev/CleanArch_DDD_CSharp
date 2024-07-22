namespace Validations.Request.SQLValidation.Item
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
