using System;

namespace Mayope.Data
{
    public interface IColumn
    {
        string Id { get; }
        string Name { get; }
        IType Type { get; }
        ITable Table { get; }
    }
}
