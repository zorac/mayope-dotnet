using System;

namespace Mayope.Server.Rest.Filters
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }
}
