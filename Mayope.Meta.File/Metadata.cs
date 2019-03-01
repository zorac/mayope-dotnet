using System;
using System.Collections.Generic;

namespace Mayope.Meta.File
{
    internal class Metadata
    {
        internal Metadata(IEnumerable<MetaForest> input)
        {

        }

        internal IList<MetaForest> roots { get; }

        internal IDictionary<Guid,MetaForest> forests { get; }

        internal IDictionary<Guid,MetaTree> trees { get; }

        internal IDictionary<Guid,MetaBranch> branches { get; }
    }
}
