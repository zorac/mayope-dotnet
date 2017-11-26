using Microsoft.Extensions.Logging;

using Mayope.Data.Ldap;

namespace Mayope.Data.ActiveDirectory
{
    public class ActiveDirectoryDataService : LdapDataService
    {
        public ActiveDirectoryDataService(ILogger<ActiveDirectoryDataService> logger)
            : base(logger)
        {
        }
    }
}
