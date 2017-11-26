using System;

namespace Mayope.Core
{
    /// <summary>
    /// A node in a Myaope schema.
    /// </summary>
    public interface INode
    {
        /// <summary>
        /// A universally unique identifier for the node.
        /// </summary>
        Guid Uuid { get; }

        /// <summary>
        /// An ID which must be unique amongst sibling nodes.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// A plain-text name for the node.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// A free-text description of the node.
        /// </summary>
        string Description { get; }
    }
}
