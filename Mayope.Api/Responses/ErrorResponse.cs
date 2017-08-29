using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mayope.Api.Responses
{
    public class ErrorResponse : IResponse
    {
        [Required]
        public string Error { get; set; }

        public string Message { get; set; }

        public Dictionary<string,string> Details { get; set; }
    }
}
