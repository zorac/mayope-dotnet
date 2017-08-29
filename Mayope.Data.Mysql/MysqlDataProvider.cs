using Microsoft.Extensions.Logging;

using Mayope.Data.Sql;

namespace Mayope.Data.Mysql
{
    public class MysqlDataProvider : SqlDataProvider
    {
        public MysqlDataProvider(ILogger<MysqlDataProvider> logger)
            : base(logger)
        {
        }
    }
}
