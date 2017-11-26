using System.Collections.Generic;

namespace Mayope.Core
{
    /// <summary>
    /// Details of a tree.
    /// </summary>
    public interface ITree : INode
    {
        /// <summary>
        /// The branches within this tree; empty if none, null if this is a stub
        /// record.
        /// </summary>
        IList<IBranch> Branches { get; }
    }
}
