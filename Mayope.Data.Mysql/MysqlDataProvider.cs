using System;
using Microsoft.Extensions.Logging;

using Mayope.Data.Sql;

namespace Mayope.Data.Mysql
{
    public class MysqlDataProvider : SqlDataProvider
    {
        private ILogger Logger;

        public MysqlDataProvider(ILogger<MysqlDataProvider> logger)
            : base(logger)
        {
            Logger = logger;
        }
    }
}
