using Microsoft.Extensions.Logging;

using Mayope.Data.Sql;

namespace Mayope.Data.SqlServer
{
    public class SqlServerDataService : SqlDataService
    {
        public SqlServerDataService(ILogger<SqlServerDataService> logger)
            : base(logger)
        {
        }
    }
}
