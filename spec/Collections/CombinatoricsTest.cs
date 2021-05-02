using System;
using System.Linq;
using Xunit;

namespace JotunShard.Extensions.Test.Collections
{
    using static Assert;

    public class CombinatoricsTest
    {
        [Fact]
        public void ToAllCombinations_WithNullEnumerable_Throws()
            => Throws<ArgumentNullException>(
                () => ((IOrderedEnumerable<int>)null).ToAllCombinations().ToList());

        [Fact]
        public void ToAllCombinations_WithSizeOf0_ExpectsAllCombinations()
        {
            var source = new int[0];
            var expected = new int[0][];
            var actual = source.ToAllCombinations().ToList();
            Equal(expected, actual);
        }

        [Fact]
        public void ToAllCombinations_WithSizeOf1_ExpectsAllCombinations()
        {
            var source = new[] { 1 };
            var expected = new[]
            {
                new[]{ 1 }
            };
            var actual = source.ToAllCombinations().ToList();
            Equal(expected, actual);
        }

        [Fact]
        public void ToAllCombinations_WithSizeOf2_ExpectsAllCombinations()
        {
            var source = new[] { 1, 2 };
            var expected = new[]
            {
                new[]{ 1 },
                new[]{ 2 },
                new[]{ 1, 2 }
            };
            var actual = source.ToAllCombinations().ToList();
            Equal(expected, actual);
        }

        [Fact]
        public void ToAllCombinations_WithSizeOf3_ExpectsAllCombinations()
        {
            var source = new[] { 1, 2, 3 };
            var expected = new[]
            {
                new[]{ 1 },
                new[]{ 2 },
                new[]{ 1, 2 },
                new[]{ 3 },
                new[]{ 1, 3 },
                new[]{ 1, 2, 3 },
                new[]{ 2, 3 }
            };
            var actual = source.ToAllCombinations().ToList();
            Equal(expected, actual);
        }

        [Fact]
        public void ToAllCombinations_WithSizeOf4_ExpectsAllCombinations()
        {
            var source = new[] { 1, 2, 3, 4 };
            var expected = new[]
            {
                new[]{ 1 },
                new[]{ 2 },
                new[]{ 1, 2 },
                new[]{ 3 },
                new[]{ 1, 3 },
                new[]{ 1, 2, 3 },
                new[]{ 2, 3 },
                new[]{ 4 },
                new[]{ 1, 4 },
                new[]{ 1, 2, 4 },
                new[]{ 2, 4 },
                new[]{ 1, 3, 4 },
                new[]{ 1, 2, 3, 4 },
                new[]{ 2, 3, 4 },
                new[]{ 3, 4 }
            };
            var actual = source.ToAllCombinations().ToList();
            Equal(expected, actual);
        }
    }
}