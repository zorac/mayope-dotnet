using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

using Mayope.Api;
using Mayope.Api.Types;
using Mayope.Api.Responses;
using Mayope.Auth;

namespace Mayope.Server.Http.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        private ILogger Logger { get; }

        public ExceptionFilter(ILogger<ExceptionFilter> logger)
        {
            Logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var status = 500;
            var error = ErrorType.Unknown;
            var message = exception.Message;
            Dictionary<string,string> details = null;

            if (exception is AuthorizationException)
            {
                status = 403;
                error = ErrorType.Authorization;
            }
            else if (exception is ValidationException)
            {
                status = 400;
                error = ErrorType.Validation;
                details = (exception as ValidationException).Errors;
            }
            else if (exception is AuthenticationException)
            {
                status = 400;
                error = ErrorType.Authentication;
            }
            else
            {
                Logger.LogError(exception, "Unexpected exeption");
                message = null; // Avoid information leak
            }

            var response = new ErrorResponse
            {
                Error = error,
                Message = message,
                Details = details
            };

            context.Result = new ObjectResult(response)
            {
                StatusCode = status
            };
        }
    }
}
