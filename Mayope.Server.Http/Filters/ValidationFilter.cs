using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;

namespace Mayope.Server.Http.Filters
{
    public class ValidationFilter : IActionFilter
    {
        private ILogger Logger { get; }

        public ValidationFilter(ILogger<ValidationFilter> logger)
        {
            Logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = new Dictionary<string,string>();

                foreach (var item in context.ModelState)
                {
                    string key = item.Key;
                    ModelStateEntry state = item.Value;

                    if (state.Errors.Count > 0)
                    {
                        key = (key.Length == 0) ? "ROOT"
                            : Char.ToLowerInvariant(key[0]) + key.Substring(1);

                        errors[key] = String.Join(" ",
                                state.Errors.Select(e => e.ErrorMessage));
                    }
                }

                throw new ValidationException(errors);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // do nothing
        }
    }
}
