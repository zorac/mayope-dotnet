using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Mayope.Core
{
    /// <summary>
    /// Possible types of a branch.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BranchType
    {
        /// <summary>
        /// A boolean true/false values.
        /// </summary>
        Boolean,
        /// <summary>
        /// An integer value; sizes[0] is the number of bits (8, 16, 32, 64),
        /// sizes[1] is 0 for unsigned, 1 for signed.
        /// </summary>
        Integer,
        /// <summary>
        /// A floating-point number; sizes[0] is the number of bits (32, 64).
        /// </summary>
        Float,
        /// <summary>
        /// A decimal number; sizes[0] is the maximum number of digits before
        /// the decimal point, sizes[1] is the maximum number of digits after.
        /// </summary>
        Decimal,
        /// <summary>
        /// A string of UTF8 charcters; sizes[0] is the maximum length in
        /// characters.
        /// </summary>
        String,
        /// <summary>
        /// A UUID.
        /// </summary>
        Uuid,
        /// <summary>
        /// An ordered list of values; branches[0] is the type of the values.
        /// </summary>
        List,
        /// <summary>
        /// An unordered set of values; branches[0] is the type of the values.
        /// </summary>
        Set,
        /// <summary>
        /// A map of values; branches[0] is the type of the keys, branches[1]
        /// is the type of the values.
        /// </summary>
        Map,
        /// <summary>
        /// A tree of sub-values, as specified by branches[].
        /// </summary>
        Tree
    }
}
