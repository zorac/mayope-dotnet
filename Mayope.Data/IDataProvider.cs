using System.Collections.Generic;

namespace Mayope.Data
{
    public interface IDataProvider
    {
        IEnumerable<IDatabase> Databases { get; }
    }
}
