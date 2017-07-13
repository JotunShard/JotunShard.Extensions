using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JotunShard.Extensions.Test.Collections
{
    using static Assert;

    internal static class Utilities
    {
        public static void AssertManySequences<TElem>(
            IEnumerable<IEnumerable<TElem>> result,
            IEnumerable<IEnumerable<TElem>> expected,
            Action<bool> assertion)
            => assertion(result
                .Zip(
                    expected,
                    (resultItem, expectedItem) => new { resultItem, expectedItem, })
                .All(item => item.resultItem
                    .SequenceEqual(item.expectedItem)));

        public static void AssertManySequencesEqual<TElem>(
            IEnumerable<IEnumerable<TElem>> result,
            IEnumerable<IEnumerable<TElem>> expected)
            => AssertManySequences(result, expected, IsTrue);

        public static void AssertManySequencesDiffer<TElem>(
            IEnumerable<IEnumerable<TElem>> result,
            IEnumerable<IEnumerable<TElem>> expected)
            => AssertManySequences(result, expected, IsFalse);
    }
}