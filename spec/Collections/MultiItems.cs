using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace JotunShard.Extensions.Test.Collections
{
    internal class MultiItems : IEquatable<MultiItems>, IEnumerable<MultiItems>
    {
        public int ID { get; set; }

        public IEnumerable<MultiItems> Items { get; set; }

        public bool Equals(MultiItems other)
            => ID == other?.ID
                && (Items?.SequenceEqual(other.Items)
                    ?? other.Items == null);

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
}