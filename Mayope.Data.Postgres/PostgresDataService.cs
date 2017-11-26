using Microsoft.Extensions.Logging;

using Mayope.Data.Sql;

namespace Mayope.Data.Postgres
{
    public class PostgresDataService : SqlDataService
    {
        public PostgresDataService(ILogger<PostgresDataService> logger)
            : base(logger)
        {
        }
    }
}
