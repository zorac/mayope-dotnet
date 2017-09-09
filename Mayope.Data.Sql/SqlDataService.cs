using Microsoft.Extensions.Logging;

namespace Mayope.Data.Sql
{
    public abstract class SqlDataService : IDataService
    {
        protected ILogger Logger { get; }

        protected SqlDataService(ILogger logger)
        {
            Logger = logger;
        }
    }
}
