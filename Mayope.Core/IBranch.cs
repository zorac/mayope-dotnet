using System.Collections.Generic;

namespace Mayope.Core
{
    /// <summary>
    /// Details of a branch in a Mayope schema.
    /// </summary>
    public interface IBranch : INode
    {
        /// <summary>
        /// The type of the branch's value.
        /// </summary>
        BranchType Type { get; }

        /// <summary>
        /// Additional size specifiers for the type if needed.
        /// </summary>
        IList<int> Sizes { get; }

        /// <summary>
        /// The child branch type(s) if not a single-valued type.
        /// </summary>
        IList<IBranch> Branches { get; }
    }
}
