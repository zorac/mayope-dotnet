using Microsoft.Extensions.Logging;

using Mayope.Data.Sql;

namespace Mayope.Data.Mysql
{
    public class MysqlDataService : SqlDataService
    {
        public MysqlDataService(ILogger<MysqlDataService> logger)
            : base(logger)
        {
        }
    }
}
