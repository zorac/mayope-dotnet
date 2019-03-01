using System;

using Mayope.Core;

namespace Mayope.Meta.File
{
    /// <summary>
    /// A node in a Myaope schema.
    /// </summary>
    internal abstract class MetaNode : INode
    {
        public Guid Uuid { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
