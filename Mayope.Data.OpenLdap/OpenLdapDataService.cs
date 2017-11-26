using Microsoft.Extensions.Logging;

using Mayope.Data.Ldap;

namespace Mayope.Data.OpenLdap
{
    public class OpenLdapDataService : LdapDataService
    {
        public OpenLdapDataService(ILogger<OpenLdapDataService> logger)
            : base(logger)
        {
        }
    }
}
