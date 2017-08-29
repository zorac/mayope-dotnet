using System;
using System.ComponentModel.DataAnnotations;

namespace Mayope.Api.Responses
{
    public class LoginResponse : IResponse
    {
        [Required]
        public Guid Token { get; set; }
    }
}
