using System.Collections.Generic;

using Mayope.Core;

namespace Mayope.Meta.File
{
    /// <summary>
    /// Details of a branch in a Mayope schema.
    /// </summary>
    internal class MetaBranch : MetaNode, IBranch
    {
        internal IList<MetaBranch> MetaBranches { get; set; }

        public BranchType Type { get; set; }

        public IList<int> Sizes { get; set; }

        public IList<IBranch> Branches => (IList<IBranch>)MetaBranches;
    }
}
