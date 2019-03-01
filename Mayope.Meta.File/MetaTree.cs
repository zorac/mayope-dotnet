using System.Collections.Generic;

using Mayope.Core;

namespace Mayope.Meta.File
{
    /// <summary>
    /// Details of a tree.
    /// </summary>
    internal class MetaTree : MetaNode, ITree
    {
        internal IList<MetaBranch> MetaBranches { get; set; }

        public IList<IBranch> Branches => (IList<IBranch>)MetaBranches;
    }
}
