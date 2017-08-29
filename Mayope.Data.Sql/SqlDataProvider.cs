using System.Collections.Generic;

using Microsoft.Extensions.Logging;

namespace Mayope.Data.Sql
{
    public abstract class SqlDataProvider : IDataProvider
    {
        protected ILogger Logger { get; }

        protected SqlDataProvider(ILogger logger)
        {
            Logger = logger;
        }

        public IEnumerable<IDatabase> Databases { get; } // TODO
    }
}
