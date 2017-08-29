namespace Mayope.Api.Responses
{
    public class ErrorResponse : IResponse
    {
        public string Error { get; set; }

        public string Message { get; set; }
    }
}
