using Microsoft.Extensions.Logging;

using Mayope.Data;

namespace Mayope.Meta.Data
{
    public class DataMetaService : IMetaService
    {
        private IDataService DataService { get; }
        private ILogger Logger { get; }

        public DataMetaService(
            IDataService dataService,
            ILogger<DataMetaService> logger)
        {
            DataService = dataService;
            Logger = logger;
        }
    }
}
