namespace Mayope.Auth
{
    public class UsernamePasswordCredentials : ICredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
