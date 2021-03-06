// <auto-generated>
// This code was auto-generated by the Mayope API builder.
// </auto-generated>

using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

namespace Mayope.Api.Requests
{
    /// <summary>
    /// A login request, including username/password credentials.
    /// </summary>
    public class LoginRequest : IRequest
    {
        /// <summary>
        /// The username to log in with.
        /// </summary>
        [Required]
        [JsonRequired]
        public string Username { get; set; }

        /// <summary>
        /// The user's password.
        /// </summary>
        [Required]
        [JsonRequired]
        public string Password { get; set; }
    }
}
