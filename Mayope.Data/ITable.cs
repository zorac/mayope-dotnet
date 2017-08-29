using System;
using System.Collections.Generic;

namespace Mayope.Data
{
    public interface ITable
    {
        string Id { get; }
        string Name { get; }
        IDatabase Database { get; }
        IEnumerable<IColumn> Columns { get; }
    }
}
