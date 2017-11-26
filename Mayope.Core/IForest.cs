using System.Collections.Generic;

namespace Mayope.Core
{
    /// <summary>
    /// Details of a forest.
    /// </summary>
    public interface IForest : INode
    {
        /// <summary>
        /// The children of this forest; empty if none, null if this is a stub
        /// record.
        /// </summary>
        IList<IForest> Forests { get; }

        /// <summary>
        /// The trees within this forest; empty if none, null if this is a stub
        /// record.
        /// </summary>
        IList<ITree> Trees { get; }
    }
}
