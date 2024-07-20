namespace Validations.Request
{
    public class DefaultValidationsException : Exception
    {
        public DefaultValidationsException(string message) : base(message) { }

        public static void IsNullOrEmpty<TValue>(TValue value, string name)
        {
            if (value == null)
            {
                throw new DefaultValidationsException($"{name} is null or empty");
            }

            if (value is string stringValue && string.IsNullOrEmpty(stringValue))
            {
                throw new DefaultValidationsException($"{name} is null or empty");
            }
        }
    }
}
