using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace JotunShard.Extensions.Test.Collections
{
    [DebuggerDisplay("ID = {ID}")]
    internal class MultiItems : IEquatable<MultiItems>, IEnumerable<MultiItems>
    {
        public int ID { get; set; }

        public IEnumerable<MultiItems> Items { get; set; }

        public bool Equals(MultiItems other)
            => MultiItemsEqualityComparer.Instance.Equals(this, other);

        public override bool Equals(object obj)
            => (obj as MultiItems)?.Equals(this) ?? false;

        public override int GetHashCode()
            => ID + 397 * Items?.Sum(x => x.GetHashCode()) ?? 0;

        public IEnumerator<MultiItems> GetEnumerator()
            => Items?.GetEnumerator()
                ?? Enumerable.Empty<MultiItems>().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        public static int Comparison(MultiItems x, MultiItems y)
            => x.GetHashCode() - y.GetHashCode();

        public static int SubComparison(IEnumerable<MultiItems> x, IEnumerable<MultiItems> y)
            => x.Sum(s => s.GetHashCode()) - y.Sum(s => s.GetHashCode());
    }

    internal class MultiItemsEqualityComparer : IEqualityComparer<MultiItems>
    {
        public static IEqualityComparer<MultiItems> Instance { get; } = new MultiItemsEqualityComparer();

        public bool Equals(MultiItems x, MultiItems y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (x.ID != y.ID) return false;
            if (x.Items == null || y.Items == null) return false;
            return x.Items.SequenceEqual(y.Items, Instance);
        }

        public int GetHashCode(MultiItems obj) => obj.GetHashCode();
    }

    internal class MultiItemsEnumerableEqualityComparer : IEqualityComparer<IEnumerable<MultiItems>>
    {
        public static IEqualityComparer<IEnumerable<MultiItems>> Instance { get; } = new MultiItemsEnumerableEqualityComparer();

        public bool Equals(IEnumerable<MultiItems> x, IEnumerable<MultiItems> y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (x == null || y == null) return false;
            return x.SequenceEqual(y, Instance);
        }

        public int GetHashCode(IEnumerable<MultiItems> obj)
            => obj?.Sum(x => x.GetHashCode()) ?? 0;
    }
}