using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JotunShard.Extensions.Test.Collections
{
    using static Assert;

    [TestClass]
    public class EnumerablesTest
    {
        #region Constants

        private const int
            COUNT_ANY = 5,
            COUNT_RIGHT = 7,
            COUNT_LESSER = COUNT_RIGHT - 1,
            COUNT_GREATER = COUNT_RIGHT + 1;

        private static readonly IEnumerable<MultiItems>
            ENMRBL_NULL = null,
            ENMRBL_EMPTY = Enumerable.Empty<MultiItems>(),
            ENMRBL_NON_EMPTY = Enumerable.Range(0, COUNT_RIGHT)
                .Select(x => new MultiItems
                {
                    ID = x,
                    Items = Enumerable.Range(0, x)
                        .Select(n => new MultiItems
                        {
                            ID = n * x,
                        }),
                }),
            ENMRBL_FLAT_DEPTH = ENMRBL_NON_EMPTY.SelectMany(
                item => Enumerable.Repeat(item, 1).Union(item.Items)),
            ENMRBL_FLAT_BREADTH = ENMRBL_NON_EMPTY.Union(
                ENMRBL_NON_EMPTY.SelectMany(item => item.Items));

        #endregion Constants

        #region Facilities

        private static bool AlwaysSamePartition<TElem>(int index, TElem item) => true;

        private static bool AlwaysOtherPartition<TElem>(int index, TElem item) => false;

        #endregion Facilities

        #region HasCount

        [TestMethod]
        public void HasCount_WithNullEnumerable_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NULL.HasCount(COUNT_ANY));

        [TestMethod]
        public void HasCount_WithEmptyEnumerableAndNegativeCount_ThrowsException()
            => ThrowsException<ArgumentOutOfRangeException>(
                () => ENMRBL_EMPTY.HasCount(-COUNT_ANY));

        [TestMethod]
        public void HasCount_WithEmptyEnumerableAndEmptyCount_ExpectsTrue()
            => IsTrue(ENMRBL_EMPTY.HasCount(0));

        [TestMethod]
        public void HasCount_WithEmptyEnumerableAndPositiveCount_ExpectsFalse()
            => IsFalse(ENMRBL_EMPTY.HasCount(COUNT_ANY));

        [TestMethod]
        public void HasCount_WithNonEmptyEnumerableAndNegativeCount_ThrowsException()
            => ThrowsException<ArgumentOutOfRangeException>(
                () => ENMRBL_NON_EMPTY.HasCount(-COUNT_ANY));

        [TestMethod]
        public void HasCount_WithNonEmptyEnumerableAndEmptyCount_ExpectsFalse()
            => IsFalse(ENMRBL_NON_EMPTY.HasCount(0));

        [TestMethod]
        public void HasCount_WithNonEmptyEnumerableAndRightCount_ExpectsTrue()
            => IsTrue(ENMRBL_NON_EMPTY.HasCount(COUNT_RIGHT));

        [TestMethod]
        public void HasCount_WithNonEmptyEnumerableAndGreaterCount_ExpectsFalse()
            => IsFalse(ENMRBL_NON_EMPTY.HasCount(COUNT_GREATER));

        [TestMethod]
        public void HasCount_WithNonEmptyEnumerableAndLesserCount_ExpectsFalse()
            => IsFalse(ENMRBL_NON_EMPTY.HasCount(COUNT_LESSER));

        #endregion HasCount

        #region PartitionIf

        [TestMethod]
        public void PartitionIf_WithNullEnumerable_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NULL.PartitionIf(AlwaysSamePartition).ToList());

        [TestMethod]
        public void PartitionIf_WithEmptyEnumerableAndNullProvider_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_EMPTY.PartitionIf(null).ToList());

        [TestMethod]
        public void PartitionIf_WithEmptyEnumerable_ExpectsSameEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_EMPTY.PartitionIf(AlwaysSamePartition),
                ENMRBL_EMPTY);

        [TestMethod]
        public void PartitionIf_WithNonEmptyEnumerableAndAlwaysSamePartition_ExpectsSameEnumerableAsSingleEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.PartitionIf(AlwaysSamePartition),
                Enumerable.Repeat(ENMRBL_NON_EMPTY, 1));

        [TestMethod]
        public void PartitionIf_WithNonEmptyEnumerableAndAlwaysOtherPartition_ExpectsSameEnumerableAsEachEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.PartitionIf(AlwaysOtherPartition),
                ENMRBL_NON_EMPTY.Select(item => Enumerable.Repeat(item, 1)));

        #endregion PartitionIf

        #region PartitionBy

        [TestMethod]
        public void PartitionBy_WithNullEnumerable_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NULL.PartitionBy(COUNT_ANY).ToList());

        [TestMethod]
        public void PartitionBy_WithEmptyEnumerableAndNegativeCount_ThrowsException()
            => ThrowsException<ArgumentOutOfRangeException>(
                () => ENMRBL_EMPTY.PartitionBy(-COUNT_ANY).ToList());

        [TestMethod]
        public void PartitionBy_WithEmptyEnumerableAndEmptyCount_ThrowsException()
            => ThrowsException<ArgumentOutOfRangeException>(
                () => ENMRBL_EMPTY.PartitionBy(0).ToList());

        [TestMethod]
        public void PartitionBy_WithNonEmptyEnumerableAndNegativeCount_ThrowsException()
            => ThrowsException<ArgumentOutOfRangeException>(
                () => ENMRBL_NON_EMPTY.PartitionBy(-COUNT_ANY).ToList());

        [TestMethod]
        public void PartitionBy_WithNonEmptyEnumerableAndEmptyCount_ThrowsException()
            => ThrowsException<ArgumentOutOfRangeException>(
                () => ENMRBL_NON_EMPTY.PartitionBy(0).ToList());

        [TestMethod]
        public void PartitionBy_WithNonEmptyEnumerableAndRightCount_ExpectsSameEnumerableAsSingleEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.PartitionBy(COUNT_RIGHT),
                Enumerable.Repeat(ENMRBL_NON_EMPTY, 1));

        [TestMethod]
        public void PartitionBy_WithNonEmptyEnumerableAndGreaterCount_ExpectsSameEnumerableAsSingleEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.PartitionBy(COUNT_GREATER),
                Enumerable.Repeat(ENMRBL_NON_EMPTY, 1));

        [TestMethod]
        public void PartitionBy_WithNonEmptyEnumerableAndLesserCount_ExpectsEnumerableWithMultipleSlices()
        {
            var slices = ENMRBL_NON_EMPTY.PartitionBy(COUNT_LESSER);
            var comparison = true;
            var count = 0;
            using (var enmrtr = ENMRBL_NON_EMPTY.GetEnumerator())
                foreach (var slice in slices)
                    using (var slice_enmrtr = slice.GetEnumerator())
                        while (comparison
                            && slice_enmrtr.MoveNext()
                            && enmrtr.MoveNext())
                        {
                            comparison = comparison
                                && Equals(enmrtr.Current, slice_enmrtr.Current);
                            ++count;
                        }
            IsTrue(comparison);
            AreEqual(count, ENMRBL_NON_EMPTY.Count());
        }

        #endregion PartitionBy

        #region Flatten

        [TestMethod]
        public void Flatten_WithNullEnumerable_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NULL.Flatten().ToList());

        [TestMethod]
        public void Flatten_WithEmptyEnumerableAndNullProvider_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_EMPTY.Flatten(null).ToList());

        [TestMethod]
        public void Flatten_WithEmptyEnumerable_ExpectsSameEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_EMPTY.Flatten(),
                ENMRBL_EMPTY);

        [TestMethod]
        public void Flatten_WithNonEmptyEnumerableAndDepthMode_ExpectsRightEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.Flatten(TreeTraversalMode.Depth),
                ENMRBL_FLAT_DEPTH);

        [TestMethod]
        public void Flatten_WithNonEmptyEnumerableAndBreadthMode_ExpectsRightEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.Flatten(TreeTraversalMode.Breadth),
                ENMRBL_FLAT_BREADTH);

        #endregion Flatten

        #region ToShuffled

        [TestMethod]
        public void ToShuffled_WithNullEnumerable_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NULL.ToShuffled().ToList());

        [TestMethod]
        public void ToShuffled_WithEmptyEnumerable_ExpectsSameEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_EMPTY.ToShuffled(),
                ENMRBL_EMPTY);

        [TestMethod]
        public void ToShuffled_WithNonEmptyEnumerable_ExpectsOtherEnumerable()
            => Utilities.AssertManySequencesDiffer(
                ENMRBL_NON_EMPTY.ToShuffled(),
                ENMRBL_NON_EMPTY);

        [TestMethod]
        public void ToShuffled_WithNonEmptyEnumerableSorted_ExpectsSameEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.ToShuffled().OrderBy(x => x.ID),
                ENMRBL_NON_EMPTY);

        #endregion ToShuffled
    }
}