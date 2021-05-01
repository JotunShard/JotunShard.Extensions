using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace JotunShard.Extensions.Test.Collections
{
    using static Assert;

    internal static class Utilities
    {
        public static void AssertManySequencesEqual(
            IEnumerable<IEnumerable<MultiItems>> result,
            IEnumerable<IEnumerable<MultiItems>> expected)
            => Equal(expected, result, MultiItemsEnumerableEqualityComparer.Instance);

        public static void AssertManySequencesEquivalent(
            IEnumerable<IEnumerable<MultiItems>> result,
            IEnumerable<IEnumerable<MultiItems>> expected)
            => Collection(
                result,
                expected
                    .Select(x => (Action<IEnumerable<MultiItems>>)(r => Equal(x, r)))
                    .ToArray());
    }
}