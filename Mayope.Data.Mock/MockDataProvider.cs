using System.Collections.Generic;

using Microsoft.Extensions.Logging;

namespace Mayope.Data.Mock
{
    public class MockDataProvider : IDataProvider
    {
        private ILogger Logger { get; }

        public MockDataProvider(ILogger<MockDataProvider> logger)
        {
            Logger = logger;
        }

        public IEnumerable<IDatabase> Databases { get; }
    }
}
