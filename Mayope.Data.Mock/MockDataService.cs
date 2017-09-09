using Microsoft.Extensions.Logging;

namespace Mayope.Data.Mock
{
    public class MockDataService : IDataService
    {
        private ILogger Logger { get; }

        public MockDataService(ILogger<MockDataService> logger)
        {
            Logger = logger;
        }
    }
}
