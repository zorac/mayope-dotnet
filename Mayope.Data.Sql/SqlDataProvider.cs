using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Mayope.Data.Sql
{
    public abstract class SqlDataProvider : IDataProvider
    {
        private readonly ILogger Logger;

        protected SqlDataProvider(ILogger logger)
        {
            Logger = logger;
        }

        public IEnumerable<IDatabase> Databases { get; } // TODO
    }
}
