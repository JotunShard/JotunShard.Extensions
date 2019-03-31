using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JotunShard.Extensions.Test.Collections
{
    using static Assert;

    internal static class Utilities
    {
        public static void AssertManySequences(
            IEnumerable<IEnumerable<MultiItems>> result,
            IEnumerable<IEnumerable<MultiItems>> expected,
            Action<bool> assertion)
            => assertion(result
                .Zip(
                    expected,
                    (resultItem, expectedItem) => new { resultItem, expectedItem, })
                .All(item => item.resultItem
                    .SequenceEqual(item.expectedItem,
                        EqualityComparer<MultiItems>.Default)));

        public static void AssertManySequencesEqual(
            IEnumerable<IEnumerable<MultiItems>> result,
            IEnumerable<IEnumerable<MultiItems>> expected)
        {
            CollectionAssert.AreEqual(
                expected.ToList(),
                result.ToList(),
                Comparer<IEnumerable<MultiItems>>.Create(MultiItems.SubComparison));
            CollectionAssert.AreEqual(
                expected.SelectMany(item => item).ToList(),
                result.SelectMany(item => item).ToList(),
                Comparer<MultiItems>.Create(MultiItems.Comparison));
            AssertManySequences(result, expected, IsTrue);
        }

        public static void AssertManySequencesEquivalent(
            IEnumerable<IEnumerable<MultiItems>> result,
            IEnumerable<IEnumerable<MultiItems>> expected)
        {
            CollectionAssert.AreEquivalent(
                expected.ToList(),
                result.ToList());
            CollectionAssert.AreEquivalent(
                expected.SelectMany(item => item).ToList(),
                result.SelectMany(item => item).ToList());
            AssertManySequences(result, expected, IsFalse);
        }

        public static void AssertManySequencesDiffer(
            IEnumerable<IEnumerable<MultiItems>> result,
            IEnumerable<IEnumerable<MultiItems>> expected)
        {
            CollectionAssert.AreNotEqual(
                expected.ToList(),
                result.ToList(),
                Comparer<IEnumerable<MultiItems>>.Create(MultiItems.SubComparison));
            CollectionAssert.AreNotEqual(
                expected.SelectMany(item => item).ToList(),
                result.SelectMany(item => item).ToList(),
                Comparer<MultiItems>.Create(MultiItems.Comparison));
            AssertManySequences(result, expected, IsFalse);
        }
    }
}