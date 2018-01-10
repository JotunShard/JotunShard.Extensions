using JetBrains.Annotations;
using System.Collections.Generic;
using System.Linq;

namespace JotunShard.Extensions
{
    public static class Collections
    {
        public static bool Any<TElem>(
            [NotNull] this ICollection<TElem> coll)
        {
            coll.CheckArgumentNull(nameof(coll));
            return coll.Count != 0;
        }

        public static void AddAll<TElem>(
            [NotNull] this ICollection<TElem> coll,
            [NotNull] IEnumerable<TElem> items)
        {
            if (coll is List<TElem> trueList)
            {
                trueList.AddRange(items);
                return;
            }
            coll.CheckArgumentNull(nameof(coll));
            items.CheckArgumentNull(nameof(items));
            foreach (var item in items)
            {
                coll.Add(item);
            }
        }

        public static void AddAll<TElem>(
            [NotNull] this ICollection<TElem> coll,
            [NotNull] params TElem[] items)
            => coll.AddAll(items.AsEnumerable());

        public static void RemoveAll<TElem>(
            [NotNull] this ICollection<TElem> coll,
            [NotNull] IEnumerable<TElem> items)
        {
            coll.CheckArgumentNull(nameof(coll));
            items.CheckArgumentNull(nameof(items));
            foreach (var item in items.ToList())
            {
                coll.Remove(item);
            }
        }

        public static void RemoveAll<TElem>(
            [NotNull] this ICollection<TElem> coll,
            [NotNull] params TElem[] items)
            => coll.RemoveAll(items.AsEnumerable());
    }
}