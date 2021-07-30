using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace JotunShard.Extensions.Test.Collections
{
    using static Assert;

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

        [Fact]
        public void HasCount_WithNullEnumerable_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NULL.HasCount(COUNT_ANY));

        [Fact]
        public void HasCount_WithEmptyEnumerableAndNegativeCount_Throws()
            => Throws<ArgumentOutOfRangeException>(
                () => ENMRBL_EMPTY.HasCount(-COUNT_ANY));

        [Fact]
        public void HasCount_WithEmptyEnumerableAndEmptyCount_ExpectsTrue()
            => True(ENMRBL_EMPTY.HasCount(0));

        [Fact]
        public void HasCount_WithEmptyEnumerableAndPositiveCount_ExpectsFalse()
            => False(ENMRBL_EMPTY.HasCount(COUNT_ANY));

        [Fact]
        public void HasCount_WithNonEmptyEnumerableAndNegativeCount_Throws()
            => Throws<ArgumentOutOfRangeException>(
                () => ENMRBL_NON_EMPTY.HasCount(-COUNT_ANY));

        [Fact]
        public void HasCount_WithNonEmptyEnumerableAndEmptyCount_ExpectsFalse()
            => False(ENMRBL_NON_EMPTY.HasCount(0));

        [Fact]
        public void HasCount_WithNonEmptyEnumerableAndRightCount_ExpectsTrue()
            => True(ENMRBL_NON_EMPTY.HasCount(COUNT_RIGHT));

        [Fact]
        public void HasCount_WithNonEmptyEnumerableAndGreaterCount_ExpectsFalse()
            => False(ENMRBL_NON_EMPTY.HasCount(COUNT_GREATER));

        [Fact]
        public void HasCount_WithNonEmptyEnumerableAndLesserCount_ExpectsFalse()
            => False(ENMRBL_NON_EMPTY.HasCount(COUNT_LESSER));

        #endregion HasCount

        #region PartitionIf

        [Fact]
        public void PartitionIf_WithNullEnumerable_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NULL.PartitionIf(AlwaysSamePartition).ToList());

        [Fact]
        public void PartitionIf_WithEmptyEnumerableAndNullProvider_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_EMPTY.PartitionIf(null).ToList());

        [Fact]
        public void PartitionIf_WithEmptyEnumerable_ExpectsSameEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_EMPTY.PartitionIf(AlwaysSamePartition),
                ENMRBL_EMPTY);

        [Fact]
        public void PartitionIf_WithNonEmptyEnumerableAndAlwaysSamePartition_ExpectsSameEnumerableAsSingleEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.PartitionIf(AlwaysSamePartition),
                Enumerable.Repeat(ENMRBL_NON_EMPTY, 1));

        [Fact]
        public void PartitionIf_WithNonEmptyEnumerableAndAlwaysOtherPartition_ExpectsEnumerableOfEmpties()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.PartitionIf(AlwaysOtherPartition).Take(COUNT_BIG),
                Enumerable.Range(0, COUNT_BIG).Select(item => new MultiItems[0]));

        [Fact]
        public void PartitionIf_WithNonEmptyEnumerableAndAnyIndex_ExpectsEnumerablesOfSameTotalLength()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.PartitionIf((index, item) => index < COUNT_ANY),
                new[] {
                    ENMRBL_NON_EMPTY.Take(COUNT_ANY),
                    ENMRBL_NON_EMPTY.Skip(COUNT_ANY),
                });

        #endregion PartitionIf

        #region PartitionBy

        [Fact]
        public void PartitionBy_WithNullEnumerable_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NULL.PartitionBy(COUNT_ANY).ToList());

        [Fact]
        public void PartitionBy_WithEmptyEnumerableAndNegativeCount_Throws()
            => Throws<ArgumentOutOfRangeException>(
                () => ENMRBL_EMPTY.PartitionBy(-COUNT_ANY).ToList());

        [Fact]
        public void PartitionBy_WithEmptyEnumerableAndEmptyCount_Throws()
            => Throws<ArgumentOutOfRangeException>(
                () => ENMRBL_EMPTY.PartitionBy(0).ToList());

        [Fact]
        public void PartitionBy_WithNonEmptyEnumerableAndNegativeCount_Throws()
            => Throws<ArgumentOutOfRangeException>(
                () => ENMRBL_NON_EMPTY.PartitionBy(-COUNT_ANY).ToList());

        [Fact]
        public void PartitionBy_WithNonEmptyEnumerableAndEmptyCount_Throws()
            => Throws<ArgumentOutOfRangeException>(
                () => ENMRBL_NON_EMPTY.PartitionBy(0).ToList());

        [Fact]
        public void PartitionBy_WithNonEmptyEnumerableAndRightCount_ExpectsSameEnumerableAsSingleEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.PartitionBy(COUNT_RIGHT),
                Enumerable.Repeat(ENMRBL_NON_EMPTY, 1));

        [Fact]
        public void PartitionBy_WithNonEmptyEnumerableAndGreaterCount_ExpectsSameEnumerableAsSingleEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.PartitionBy(COUNT_GREATER),
                Enumerable.Repeat(ENMRBL_NON_EMPTY, 1));

        [Fact]
        public void PartitionBy_WithNonEmptyEnumerableAndLesserCount_ExpectsEnumerableWithMultipleSlices()
        {
            var slices = ENMRBL_NON_EMPTY.PartitionBy(COUNT_LESSER);

            Equal(Math.Ceiling((double)COUNT_RIGHT / COUNT_LESSER), slices.Count());
            Equal(ENMRBL_NON_EMPTY, slices.SelectMany(s => s), MultiItemsEnumerableEqualityComparer.Instance);
        }

        #endregion PartitionBy

        #region Flatten

        [Fact]
        public void Flatten_WithNullEnumerable_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NULL.Flatten().ToList());

        [Fact]
        public void Flatten_WithEmptyEnumerableAndNullProvider_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_EMPTY.Flatten(null).ToList());

        [Fact]
        public void Flatten_WithEmptyEnumerable_ExpectsSameEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_EMPTY.Flatten(),
                ENMRBL_EMPTY);

        [Fact]
        public void Flatten_WithNonEmptyEnumerableAndDepthMode_ExpectsRightEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.Flatten(TreeTraversalMode.Depth),
                ENMRBL_FLAT_DEPTH);

        [Fact]
        public void Flatten_WithNonEmptyEnumerableAndBreadthMode_ExpectsRightEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.Flatten(TreeTraversalMode.Breadth),
                ENMRBL_FLAT_BREADTH);

        #endregion Flatten

        #region Cycle

        [Fact]
        public void Cycle_WithNullEnumerable_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NULL.Cycle().ToList());

        [Fact]
        public void Cycle_WithEmptyEnumerable_ExpectsSameEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_EMPTY.Cycle(),
                ENMRBL_EMPTY);

        [Fact]
        public void Cycle_WithNonEmptyEnumerableAndNoRepeat_ExpectsEmptyEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.Cycle(0),
                ENMRBL_EMPTY);

        [Fact]
        public void Cycle_WithNonEmptyEnumerableAndNullRepeat_ExpectsInfiniteEnumerable()
        {
            var cycle = ENMRBL_NON_EMPTY.Cycle();
            using (var enmrtr = cycle.GetEnumerator())
            {
                for (var index = 0; enmrtr.MoveNext(); ++index)
                    if (index == COUNT_BIG)
                        break;
                True(enmrtr.MoveNext());
            }
        }

        [Fact]
        public void Cycle_WithNonEmptyEnumerableAndAnyRepeat_ExpectsSameEnumerableTimesAny()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.Cycle(COUNT_ANY),
                Enumerable.Repeat(ENMRBL_NON_EMPTY, COUNT_ANY)
                    .SelectMany(coll => coll));

        #endregion Cycle

        #region ToShuffled

        [Fact]
        public void ToShuffled_WithNullEnumerable_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NULL.ToShuffled().ToList());

        [Fact]
        public void ToShuffled_WithEmptyEnumerable_ExpectsSameEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_EMPTY.ToShuffled(),
                ENMRBL_EMPTY);

        [Fact]
        public void ToShuffled_WithNonEmptyEnumerable_ExpectsOtherEnumerable()
            => Utilities.AssertManySequencesEquivalent(
                ENMRBL_NON_EMPTY.ToShuffled(),
                ENMRBL_NON_EMPTY);

        [Fact]
        public void ToShuffled_WithNonEmptyEnumerableSorted_ExpectsSameEnumerable()
            => Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.ToShuffled().OrderBy(x => x.ID),
                ENMRBL_NON_EMPTY);

        #endregion ToShuffled

        #region GetRandom

        [Fact]
        public void GetRandom_WithNullEnumerable_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NULL.GetRandom());

        [Fact]
        public void GetRandom_WithEmptyEnumerable_Throws()
            => Throws<ArgumentOutOfRangeException>(
                () => ENMRBL_EMPTY.GetRandom());

        [Fact]
        public void GetRandom_WithNonEmptyEnumerableAndIndexedRandomSource_ExpectsSameItems()
            => True(ENMRBL_NON_EMPTY.SequenceEqual(
                Enumerable.Range(0, COUNT_RIGHT)
                    .Select(index => ENMRBL_NON_EMPTY.GetRandom(x => index))));

        #endregion GetRandom

        #region TryGetFirst

        [Fact]
        public void TryGetFirst_WithNullEnumerable_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NULL.TryGetFirst(DefaultDelegates.TautologicalLambda<MultiItems>(), out _));

        [Fact]
        public void TryGetFirst_WithNullPredicate_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NON_EMPTY.TryGetFirst(null, out _));

        [Fact]
        public void TryGetFirst_WithEmptyEnumerable_ExpectsFalse()
            => False(ENMRBL_EMPTY.TryGetFirst(DefaultDelegates.TautologicalLambda<MultiItems>(), out _));

        [Fact]
        public void TryGetFirst_WithNonEmptyEnumerableAndContradictionalLambda_ExpectsFalse()
            => False(ENMRBL_EMPTY.TryGetFirst(DefaultDelegates.ContradictionalLambda<MultiItems>(), out _));

        [Fact]
        public void TryGetFirst_WithNonEmptyEnumerableAndTautologicalLambda_ExpectsFirstItem()
        {
            True(ENMRBL_NON_EMPTY.TryGetFirst(DefaultDelegates.TautologicalLambda<MultiItems>(), out var firstItem));
            Equal(ENMRBL_NON_EMPTY.FirstOrDefault(), firstItem);
        }

        #endregion TryGetFirst

        #region TryGetLast

        [Fact]
        public void TryGetLast_WithNullEnumerable_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NULL.TryGetLast(DefaultDelegates.TautologicalLambda<MultiItems>(), out _));

        [Fact]
        public void TryGetLast_WithNullPredicate_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NON_EMPTY.TryGetLast(null, out _));

        [Fact]
        public void TryGetLast_WithEmptyEnumerable_ExpectsFalse()
            => False(ENMRBL_EMPTY.TryGetLast(DefaultDelegates.TautologicalLambda<MultiItems>(), out _));

        [Fact]
        public void TryGetLast_WithNonEmptyEnumerableAndContradictionalLambda_ExpectsFalse()
            => False(ENMRBL_EMPTY.TryGetLast(DefaultDelegates.ContradictionalLambda<MultiItems>(), out _));

        [Fact]
        public void TryGetLast_WithNonEmptyEnumerableAndTautologicalLambda_ExpectsLastItem()
        {
            True(ENMRBL_NON_EMPTY.TryGetLast(DefaultDelegates.TautologicalLambda<MultiItems>(), out var lastItem));
            Equal(ENMRBL_NON_EMPTY.LastOrDefault(), lastItem);
        }

        #endregion TryGetLast

        #region TryGetSingle

        [Fact]
        public void TryGetSingle_WithNullEnumerable_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NULL.TryGetSingle(DefaultDelegates.TautologicalLambda<MultiItems>(), out _));

        [Fact]
        public void TryGetSingle_WithNullPredicate_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NON_EMPTY.TryGetSingle(null, out _));

        [Fact]
        public void TryGetSingle_WithEmptyEnumerable_ExpectsFalse()
            => False(ENMRBL_EMPTY.TryGetSingle(DefaultDelegates.TautologicalLambda<MultiItems>(), out _));

        [Fact]
        public void TryGetSingle_WithNonEmptyEnumerableAndContradictionalLambda_ExpectsFalse()
            => False(ENMRBL_EMPTY.TryGetSingle(DefaultDelegates.ContradictionalLambda<MultiItems>(), out _));

        [Fact]
        public void TryGetSingle_WithNonEmptyEnumerableAndTautologicalLambda_ExpectsFalse()
            => False(ENMRBL_EMPTY.TryGetSingle(DefaultDelegates.ContradictionalLambda<MultiItems>(), out _));

        [Fact]
        public void TryGetSingle_WithNonEmptyEnumerableAndTautologicalLambda_ExpectsRightItem()
        {
            foreach (var itemPredicate in ENMRBL_NON_EMPTY)
            {
                True(ENMRBL_NON_EMPTY.TryGetSingle(item => item.ID == itemPredicate.ID, out var rightItem));
                Equal(ENMRBL_NON_EMPTY.SingleOrDefault(item => item.ID == itemPredicate.ID), rightItem);
            }
        }

        #endregion TryGetSingle

        #region GroupToDictionary

        [Fact]
        public void GroupToDictionary_WithNullEnumerable_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NULL.GroupToDictionary(DefaultDelegates.IdentityFunction<MultiItems>()));

        [Fact]
        public void GroupToDictionary_WithNullKeySelector_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NON_EMPTY.GroupToDictionary<MultiItems, MultiItems>(null));

        [Fact]
        public void GroupToDictionary_WithNullValueSelector_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NON_EMPTY.GroupToDictionary<MultiItems, MultiItems, MultiItems>(
                    DefaultDelegates.IdentityFunction<MultiItems>(), null));

        [Fact]
        public void GroupToDictionary_WithEmptyEnumerable_ExpectsEmptyDictionary()
            => Empty(ENMRBL_EMPTY.GroupToDictionary(DefaultDelegates.IdentityFunction<MultiItems>()));

        [Fact]
        public void GroupToDictionary_WithNonEmptyEnumerableAndIdentifyFunction_ExpectsDictionaryOfSingles()
        {
            var dictionary = ENMRBL_NON_EMPTY.GroupToDictionary(DefaultDelegates.IdentityFunction<MultiItems>());

            Equal(ENMRBL_NON_EMPTY.ToList(), dictionary.Keys);
            Utilities.AssertManySequencesEqual(
                ENMRBL_NON_EMPTY.Select(item => new[] { item }),
                dictionary.Values);
        }

        #endregion GroupToDictionary

        #region GetFNVHashCode

        [Fact]
        public void GetFNVHashCode_WithNullEnumerable_Throws()
            => Throws<ArgumentNullException>(
                () => ENMRBL_NULL.GetFNVHashCode());

        [Fact]
        public void GetFNVHashCode_WithEmptyEnumerable_ExpectsConstant()
            => Equal(Constants.FNV_OFFSET_BASIS, ENMRBL_EMPTY.GetFNVHashCode());

        [Fact]
        public void GetFNVHashCode_WithNonEmptyEnumerable_ExpectsAllUniqueHashCodes()
        {
            var result = ENMRBL_NON_EMPTY
                .Select(item => new[] { item }.GetFNVHashCode())
                .ToList();
            Equal(result, result.Distinct());
        }

        #endregion GetFNVHashCode
    }
}