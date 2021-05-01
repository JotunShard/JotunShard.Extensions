using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace JotunShard.Extensions.Test.Collections
{
    using static Assert;

    public class ListsTest
    {
        #region Constants

        private const int
            COUNT_ANY = 5,
            COUNT_RIGHT = 7,
            COUNT_LESSER = COUNT_RIGHT - 1,
            COUNT_GREATER = COUNT_RIGHT + 1,
            INDEX_RIGHTA = COUNT_RIGHT - 2,
            INDEX_RIGHTB = COUNT_RIGHT - 1,
            INDEX_WRONG = COUNT_RIGHT + 2;

        private static readonly IList<MultiItems>
            LIST_NULL = null;

        private static IList<MultiItems> LIST_EMPTY => new List<MultiItems>();

        private static IList<MultiItems> LIST_NON_EMPTY => Enumerable.Range(0, COUNT_RIGHT)
            .Select(x => new MultiItems
            {
                ID = x,
            })
            .ToList();

        #endregion Constants

        #region PartitionBy

        [Fact]
        public void PartitionBy_WithNullList_Throws()
            => Throws<ArgumentNullException>(
                () => LIST_NULL.PartitionBy(COUNT_ANY).ToList());

        [Fact]
        public void PartitionBy_WithEmptyListAndNegativeCount_Throws()
            => Throws<ArgumentOutOfRangeException>(
                () => LIST_EMPTY.PartitionBy(-COUNT_ANY).ToList());

        [Fact]
        public void PartitionBy_WithEmptyListAndEmptyCount_Throws()
            => Throws<ArgumentOutOfRangeException>(
                () => LIST_EMPTY.PartitionBy(0).ToList());

        [Fact]
        public void PartitionBy_WithNonEmptyListAndNegativeCount_Throws()
            => Throws<ArgumentOutOfRangeException>(
                () => LIST_NON_EMPTY.PartitionBy(-COUNT_ANY).ToList());

        [Fact]
        public void PartitionBy_WithNonEmptyListAndEmptyCount_Throws()
            => Throws<ArgumentOutOfRangeException>(
                () => LIST_NON_EMPTY.PartitionBy(0).ToList());

        [Fact]
        public void PartitionBy_WithNonEmptyListAndRightCount_ExpectsSameListAsSingleList()
            => Utilities.AssertManySequencesEqual(
                LIST_NON_EMPTY.PartitionBy(COUNT_RIGHT),
                Enumerable.Repeat(LIST_NON_EMPTY, 1));

        [Fact]
        public void PartitionBy_WithNonEmptyListAndGreaterCount_ExpectsSameListAsSingleList()
            => Utilities.AssertManySequencesEqual(
                LIST_NON_EMPTY.PartitionBy(COUNT_GREATER),
                Enumerable.Repeat(LIST_NON_EMPTY, 1));

        [Fact]
        public void PartitionBy_WithNonEmptyListAndLesserCount_ExpectsListWithMultipleSlices()
        {
            var slices = LIST_NON_EMPTY.PartitionBy(COUNT_LESSER);

            Equal(Math.Ceiling((double)COUNT_RIGHT / COUNT_LESSER), slices.Count());
            True(slices.SelectMany(s => s).SequenceEqual(LIST_NON_EMPTY));
        }

        #endregion PartitionBy

        #region Swap

        [Fact]
        public void Swap_WithNullList_Throws()
            => Throws<ArgumentNullException>(
                () => LIST_NULL.Swap(INDEX_RIGHTA, INDEX_RIGHTB));

        [Fact]
        public void Swap_WithIndexOutOfRange_Throws()
            => Throws<ArgumentOutOfRangeException>(
                () => LIST_NON_EMPTY.Swap(INDEX_WRONG, INDEX_RIGHTB));

        [Fact]
        public void Swap_WithOtherIndexOutOfRange_Throws()
            => Throws<ArgumentOutOfRangeException>(
                () => LIST_NON_EMPTY.Swap(INDEX_RIGHTA, INDEX_WRONG));

        [Fact]
        public void Swap_WithEmptyList_ExpectsSameList()
        {
            var actual = LIST_EMPTY;
            actual.Swap(INDEX_RIGHTA, INDEX_RIGHTB);

            True(LIST_EMPTY.SequenceEqual(actual));
        }

        [Fact]
        public void Swap_WithIndexAndOtherIndexTheSame_ExpectsSameList()
        {
            var actual = LIST_NON_EMPTY;
            actual.Swap(INDEX_RIGHTA, INDEX_RIGHTA);

            True(LIST_NON_EMPTY.SequenceEqual(actual));
        }

        [Fact]
        public void Swap_WithEveryItemIndexInverted_ExpectsSameList()
        {
            var actual = LIST_NON_EMPTY;

            for (var index = 0; index < COUNT_RIGHT; index++)
            {
                actual.Swap(index, COUNT_RIGHT - 1 - index);
            }

            True(LIST_NON_EMPTY.SequenceEqual(actual));
        }

        #endregion Swap

        #region Shuffle

        [Fact]
        public void Shuffle_WithNullList_Throws()
            => Throws<ArgumentNullException>(
                () => LIST_NULL.Shuffle());

        [Fact]
        public void Shuffle_WithEmptyList_ExpectsSameList()
        {
            var shuffled = LIST_EMPTY;
            shuffled.Shuffle();
            True(shuffled.SequenceEqual(LIST_EMPTY));
        }

        [Fact]
        public void Shuffle_WithNonEmptyList_ExpectsOtherList()
        {
            var shuffled = LIST_NON_EMPTY;
            shuffled.Shuffle();
            False(shuffled.SequenceEqual(LIST_NON_EMPTY));
        }

        [Fact]
        public void Shuffle_WithNonEmptyListSorted_ExpectsSameList()
        {
            var shuffled = LIST_NON_EMPTY;
            shuffled.Shuffle();
            True(shuffled.OrderBy(x => x.ID)
                .SequenceEqual(LIST_NON_EMPTY));
        }

        #endregion Shuffle

        #region InsertAll

        [Fact]
        public void InsertAll_WithNullList_Throws()
            => Throws<ArgumentNullException>(
                () => LIST_NULL.InsertAll(INDEX_RIGHTA, new MultiItems()));

        [Fact]
        public void InsertAll_WithIndexOutOfRange_Throws()
            => Throws<ArgumentOutOfRangeException>(
                () => LIST_NON_EMPTY.InsertAll(INDEX_WRONG, new MultiItems()));

        [Fact]
        public void InsertAll_WithNullItems_Throws()
            => Throws<ArgumentNullException>(
                () => LIST_NON_EMPTY.InsertAll(INDEX_RIGHTA, (IEnumerable<MultiItems>)null));

        [Fact]
        public void InsertAll_WithIndexAtCount_ExpectsItemsAppended()
        {
            var actual = LIST_NON_EMPTY;
            actual.InsertAll(COUNT_RIGHT, LIST_NON_EMPTY);

            True(LIST_NON_EMPTY.Concat(LIST_NON_EMPTY)
                .SequenceEqual(actual));
        }

        #endregion InsertAll
    }
}