using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Mayope.Server.Rest.Filters
{
    public class ValidationFilter : IActionFilter
    {
        private readonly ILogger Logger;

        public ValidationFilter(
            ILogger<ValidationFilter> logger)
        {
            Logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                string messages = string.Join("; ", context.ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage));
                throw new ValidationException("Request is invalid: " + messages);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // do nothing
        }
    }
}
