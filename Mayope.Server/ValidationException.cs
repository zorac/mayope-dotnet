using System;
using System.Collections.Generic;

namespace Mayope.Server
{
    public class ValidationException : Exception
    {
        public Dictionary<string,string> Errors;

        public ValidationException(Dictionary<string,string> errors)
            : base("Validation failed")
        {
            Errors = errors;
        }
    }
}
