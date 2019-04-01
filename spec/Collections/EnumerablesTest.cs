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
            COUNT_GREATER = COUNT_RIGHT + 1,
            COUNT_BIG = COUNT_RIGHT * COUNT_ANY;

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
                            ID = x * COUNT_RIGHT + n,
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
        public void PartitionIf_WithNonEmptyEnumerableAndAlwaysOtherPartition_ExpectsEnumerableOfEmpties()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.PartitionIf(AlwaysOtherPartition).Take(COUNT_BIG),
                Enumerable.Range(0, COUNT_BIG).Select(item => new MultiItems[0]));

        [TestMethod]
        public void PartitionIf_WithNonEmptyEnumerableAndAnyIndex_ExpectsEnumerablesOfSameTotalLength()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.PartitionIf((index, item) => index < COUNT_ANY),
                new[] {
                    ENMRBL_NON_EMPTY.Take(COUNT_ANY),
                    ENMRBL_NON_EMPTY.Skip(COUNT_ANY),
                });

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

            AreEqual(Math.Ceiling((double)COUNT_RIGHT / COUNT_LESSER), slices.Count());
            IsTrue(slices.SelectMany(s => s).SequenceEqual(ENMRBL_NON_EMPTY));
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

        #region Cycle

        [TestMethod]
        public void Cycle_WithNullEnumerable_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NULL.Cycle().ToList());

        [TestMethod]
        public void Cycle_WithEmptyEnumerable_ExpectsSameEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_EMPTY.Cycle(),
                ENMRBL_EMPTY);

        [TestMethod]
        public void Cycle_WithNonEmptyEnumerableAndNoRepeat_ExpectsEmptyEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.Cycle(0),
                ENMRBL_EMPTY);

        [TestMethod]
        public void Cycle_WithNonEmptyEnumerableAndNullRepeat_ExpectsInfiniteEnumerable()
        {
            var cycle = ENMRBL_NON_EMPTY.Cycle();
            using (var enmrtr = cycle.GetEnumerator())
            {
                for (var index = 0; enmrtr.MoveNext(); ++index)
                    if (index == COUNT_BIG)
                        break;
                IsTrue(enmrtr.MoveNext());
            }
        }

        [TestMethod]
        public void Cycle_WithNonEmptyEnumerableAndAnyRepeat_ExpectsSameEnumerableTimesAny()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.Cycle(COUNT_ANY),
                Enumerable.Repeat(ENMRBL_NON_EMPTY, COUNT_ANY)
                    .SelectMany(coll => coll));

        #endregion Cycle

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
            => Utilities.AssertManySequencesEquivalent(
                ENMRBL_NON_EMPTY.ToShuffled(),
                ENMRBL_NON_EMPTY);

        [TestMethod]
        public void ToShuffled_WithNonEmptyEnumerableSorted_ExpectsSameEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.ToShuffled().OrderBy(x => x.ID),
                ENMRBL_NON_EMPTY);

        #endregion ToShuffled

        #region GetRandom

        [TestMethod]
        public void GetRandom_WithNullEnumerable_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NULL.GetRandom());

        [TestMethod]
        public void GetRandom_WithEmptyEnumerable_ThrowsException()
            => ThrowsException<ArgumentOutOfRangeException>(
                () => ENMRBL_EMPTY.GetRandom());

        [TestMethod]
        public void GetRandom_WithNonEmptyEnumerableAndIndexedRandomSource_ExpectsSameItems()
            => IsTrue(ENMRBL_NON_EMPTY.SequenceEqual(
                Enumerable.Range(0, COUNT_RIGHT)
                    .Select(index => ENMRBL_NON_EMPTY.GetRandom(x => index))));

        #endregion GetRandom

        #region TryGetFirst

        [TestMethod]
        public void TryGetFirst_WithNullEnumerable_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NULL.TryGetFirst(DefaultDelegates.TautologicalLambda<MultiItems>(), out _));

        [TestMethod]
        public void TryGetFirst_WithNullPredicate_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NON_EMPTY.TryGetFirst(null, out _));

        [TestMethod]
        public void TryGetFirst_WithEmptyEnumerable_ExpectsFalse()
            => IsFalse(ENMRBL_EMPTY.TryGetFirst(DefaultDelegates.TautologicalLambda<MultiItems>(), out _));

        [TestMethod]
        public void TryGetFirst_WithNonEmptyEnumerableAndContradictionalLambda_ExpectsFalse()
            => IsFalse(ENMRBL_EMPTY.TryGetFirst(DefaultDelegates.ContradictionalLambda<MultiItems>(), out _));

        [TestMethod]
        public void TryGetFirst_WithNonEmptyEnumerableAndTautologicalLambda_ExpectsFirstItem()
        {
            IsTrue(ENMRBL_NON_EMPTY.TryGetFirst(DefaultDelegates.TautologicalLambda<MultiItems>(), out var firstItem));
            AreEqual(ENMRBL_NON_EMPTY.FirstOrDefault(), firstItem);
        }

        #endregion TryGetFirst

        #region TryGetLast

        [TestMethod]
        public void TryGetLast_WithNullEnumerable_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NULL.TryGetLast(DefaultDelegates.TautologicalLambda<MultiItems>(), out _));

        [TestMethod]
        public void TryGetLast_WithNullPredicate_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NON_EMPTY.TryGetLast(null, out _));

        [TestMethod]
        public void TryGetLast_WithEmptyEnumerable_ExpectsFalse()
            => IsFalse(ENMRBL_EMPTY.TryGetLast(DefaultDelegates.TautologicalLambda<MultiItems>(), out _));

        [TestMethod]
        public void TryGetLast_WithNonEmptyEnumerableAndContradictionalLambda_ExpectsFalse()
            => IsFalse(ENMRBL_EMPTY.TryGetLast(DefaultDelegates.ContradictionalLambda<MultiItems>(), out _));

        [TestMethod]
        public void TryGetLast_WithNonEmptyEnumerableAndTautologicalLambda_ExpectsLastItem()
        {
            IsTrue(ENMRBL_NON_EMPTY.TryGetLast(DefaultDelegates.TautologicalLambda<MultiItems>(), out var lastItem));
            AreEqual(ENMRBL_NON_EMPTY.LastOrDefault(), lastItem);
        }

        #endregion TryGetLast

        #region TryGetSingle

        [TestMethod]
        public void TryGetSingle_WithNullEnumerable_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NULL.TryGetSingle(DefaultDelegates.TautologicalLambda<MultiItems>(), out _));

        [TestMethod]
        public void TryGetSingle_WithNullPredicate_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NON_EMPTY.TryGetSingle(null, out _));

        [TestMethod]
        public void TryGetSingle_WithEmptyEnumerable_ExpectsFalse()
            => IsFalse(ENMRBL_EMPTY.TryGetSingle(DefaultDelegates.TautologicalLambda<MultiItems>(), out _));

        [TestMethod]
        public void TryGetSingle_WithNonEmptyEnumerableAndContradictionalLambda_ExpectsFalse()
            => IsFalse(ENMRBL_EMPTY.TryGetSingle(DefaultDelegates.ContradictionalLambda<MultiItems>(), out _));

        [TestMethod]
        public void TryGetSingle_WithNonEmptyEnumerableAndTautologicalLambda_ExpectsFalse()
            => IsFalse(ENMRBL_EMPTY.TryGetSingle(DefaultDelegates.ContradictionalLambda<MultiItems>(), out _));

        [TestMethod]
        public void TryGetSingle_WithNonEmptyEnumerableAndTautologicalLambda_ExpectsRightItem()
        {
            foreach (var itemPredicate in ENMRBL_NON_EMPTY)
            {
                IsTrue(ENMRBL_NON_EMPTY.TryGetSingle(item => item.ID == itemPredicate.ID, out var rightItem));
                AreEqual(ENMRBL_NON_EMPTY.SingleOrDefault(item => item.ID == itemPredicate.ID), rightItem);
            }
        }

        #endregion TryGetSingle

        #region GroupToDictionary

        [TestMethod]
        public void GroupToDictionary_WithNullEnumerable_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NULL.GroupToDictionary(DefaultDelegates.IdentityFunction<MultiItems>()));

        [TestMethod]
        public void GroupToDictionary_WithNullKeySelector_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NON_EMPTY.GroupToDictionary<MultiItems, MultiItems>(null));

        [TestMethod]
        public void GroupToDictionary_WithNullValueSelector_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NON_EMPTY.GroupToDictionary<MultiItems, MultiItems, MultiItems>(
                    DefaultDelegates.IdentityFunction<MultiItems>(), null));

        [TestMethod]
        public void GroupToDictionary_WithEmptyEnumerable_ExpectsEmptyDictionary()
            => CollectionAssert.AreEqual(
                new Dictionary<MultiItems, MultiItems>(),
                ENMRBL_EMPTY.GroupToDictionary(
                    DefaultDelegates.IdentityFunction<MultiItems>()));

        [TestMethod]
        public void GroupToDictionary_WithNonEmptyEnumerableAndIdentifyFunction_ExpectsDictionaryOfSingles()
        {
            var dictionary = ENMRBL_NON_EMPTY.GroupToDictionary(DefaultDelegates.IdentityFunction<MultiItems>());

            CollectionAssert.AreEqual(ENMRBL_NON_EMPTY.ToList(), dictionary.Keys);
            Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.Select(item => new[] { item }),
                dictionary.Values);
        }

        #endregion GroupToDictionary

        #region GetFNVHashCode

        [TestMethod]
        public void GetFNVHashCode_WithNullEnumerable_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => ENMRBL_NULL.GetFNVHashCode());

        [TestMethod]
        public void GetFNVHashCode_WithEmptyEnumerable_ExpectsConstant()
            => AreEqual(Constants.FNV_OFFSET_BASIS, ENMRBL_EMPTY.GetFNVHashCode());

        [TestMethod]
        public void GetFNVHashCode_WithNonEmptyEnumerable_ExpectsAllUniqueHashCodes()
            => CollectionAssert.AllItemsAreUnique(ENMRBL_NON_EMPTY
                .Select(item => new[] { item }.GetFNVHashCode())
                .ToList());

        #endregion GetFNVHashCode
    }
}