using System.Collections.Generic;

namespace Mayope.Data
{
    public interface IDatabase
    {
        string Id { get; }
        string Name { get; }
        IEnumerable<ITable> Tables { get; }
    }
}
