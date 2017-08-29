using System;
using System.ComponentModel.DataAnnotations;

namespace Mayope.Api.Requests
{
    public abstract class AuthRequest : IRequest
    {
        [Required]
        public Guid Token { get; set; }
    }
}
