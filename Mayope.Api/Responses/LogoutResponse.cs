using System.ComponentModel.DataAnnotations;

namespace Mayope.Api.Responses
{
    public class LogoutResponse : IResponse
    {
        [Required]
        public bool Success { get; set; }
    }
}
