using System.Collections.Generic;

using Mayope.Core;

namespace Mayope.Meta.File
{
    /// <summary>
    /// Details of a forest.
    /// </summary>
    internal class MetaForest : MetaNode, IForest
    {
        internal IList<MetaForest> MetaForests { get; set; }

        internal IList<MetaTree> MetaTrees { get; set; }

        public IList<IForest> Forests => (IList<IForest>)MetaForests;

        public IList<ITree> Trees => (IList<ITree>)MetaTrees;
    }
}
