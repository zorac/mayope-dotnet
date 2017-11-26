using Microsoft.Extensions.Logging;

using Mayope.Data.Sql;

namespace Mayope.Data.Sqlite
{
    public class SqliteDataService : SqlDataService
    {
        public SqliteDataService(ILogger<SqliteDataService> logger)
            : base(logger)
        {
        }
    }
}
