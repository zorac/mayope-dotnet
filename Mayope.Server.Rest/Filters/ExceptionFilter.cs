using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

using Mayope.Api;
using Mayope.Api.Responses;
using Mayope.Auth;

namespace Mayope.Server.Rest.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        private readonly ILogger Logger;

        public ExceptionFilter(
            ILogger<ExceptionFilter> logger)
        {
            Logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var status = 500;
            var error = ErrorType.Unknown;
            var message = exception.Message;

            if (exception is AuthorizationException)
            {
                status = 403;
                error = ErrorType.Authorization;
            }
            else if (exception is ValidationException)
            {
                status = 400;
                error = ErrorType.Validation;
            }
            else if (exception is AuthenticationException)
            {
                status = 400;
                error = ErrorType.Authentication;
            }
            else
            {
                Logger.LogError(exception, "Unexpected exeption");
                message = "An unexpected error occurred"; // Avoid information leak
            }

            var response = new ErrorResponse
            {
                Error = error,
                Message = message
            };

            context.Result = new ObjectResult(response)
            {
                StatusCode = status
            };
        }
    }
}
