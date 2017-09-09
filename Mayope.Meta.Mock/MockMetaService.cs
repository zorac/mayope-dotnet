using Microsoft.Extensions.Logging;

namespace Mayope.Meta.Mock
{
    public class MockMetaService : IMetaService
    {
        private ILogger Logger { get; }

        public MockMetaService(ILogger<MockMetaService> logger)
        {
            Logger = logger;
        }
    }
}
