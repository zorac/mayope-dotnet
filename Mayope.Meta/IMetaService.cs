using System;
using System.Collections.Generic;

using Mayope.Core;

namespace Mayope.Meta
{
    public interface IMetaService
    {
        IList<IForest> GetRootForests();
        IList<IForest> GetChildForests(Guid parent);
        IList<ITree> GetTrees(Guid forest);
        IList<IBranch> GetBranches(Guid tree);
    }
}
