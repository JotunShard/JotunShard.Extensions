using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JotunShard.Extensions.Test.Collections
{
    using static Assert;

    [TestClass]
    public class ListsTest
    {
        #region Constants

        private const int
            COUNT_ANY = 5,
            COUNT_RIGHT = 7,
            COUNT_LESSER = COUNT_RIGHT - 1,
            COUNT_GREATER = COUNT_RIGHT + 1;

        private static readonly List<MultiItems>
            LIST_NULL = null;

        private static List<MultiItems> LIST_EMPTY
        {
            get => new List<MultiItems>();
        }

        private static List<MultiItems> LIST_NON_EMPTY
        {
            get => Enumerable.Range(0, COUNT_RIGHT)
                .Select(x => new MultiItems
                {
                    ID = x,
                })
                .ToList();
        }

        #endregion Constants

        #region Shuffle

        [TestMethod]
        public void Shuffle_WithNullList_ThrowsException()
            => ThrowsException<ArgumentNullException>(
                () => LIST_NULL.Shuffle());

        [TestMethod]
        public void Shuffle_WithEmptyList_ExpectsSameList()
        {
            var shuffled = LIST_EMPTY;
            shuffled.Shuffle();
            IsTrue(shuffled.SequenceEqual(LIST_EMPTY));
        }

        [TestMethod]
        public void Shuffle_WithNonEmptyList_ExpectsOtherList()
        {
            var shuffled = LIST_NON_EMPTY;
            shuffled.Shuffle();
            IsFalse(shuffled.SequenceEqual(LIST_NON_EMPTY));
        }

        [TestMethod]
        public void Shuffle_WithNonEmptyListSorted_ExpectsSameList()
        {
            var shuffled = LIST_NON_EMPTY;
            shuffled.Shuffle();
            IsTrue(shuffled.OrderBy(x => x.ID)
                .SequenceEqual(LIST_NON_EMPTY));
        }

        #endregion Shuffle

        #region InsertAll

        [TestMethod]
        public void InsertAll()
            => Fail();

        #endregion InsertAll
    }
}