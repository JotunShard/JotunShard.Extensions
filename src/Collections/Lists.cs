using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JotunShard.Extensions
{
    public static class Lists
    {
        public static IEnumerable<IReadOnlyCollection<TElem>> PartitionBy<TElem>(
            [NotNull] this List<TElem> source,
            int count,
            Func<IList<TElem>, IReadOnlyCollection<TElem>> partitionProvider = null)
        {
            source.CheckArgumentNull(nameof(source));
            count.CheckArgumentIsGreater(nameof(count), 0);
            partitionProvider = partitionProvider
                ?? (list => new System.Collections.ObjectModel.ReadOnlyCollection<TElem>(list));
            for (var index = 0; index < source.Count; index += count)
                yield return partitionProvider(source.GetRange(
                    index,
                    Math.Min(count, source.Count - index - 1)));
        }

        public static void Swap<TElem>(
            [NotNull] this IList<TElem> list,
            int index,
            int otherIndex)
        {
            list.CheckArgumentNull(nameof(list));
            index.CheckArgumentOutOfRangeOrEqual(nameof(index), 0, list.Count - 1);
            otherIndex.CheckArgumentOutOfRangeOrEqual(nameof(otherIndex), 0, list.Count - 1);
            if (index == otherIndex) return;
            var item = list[otherIndex];
            list[otherIndex] = list[index];
            list[index] = item;
        }

        public static void Shuffle<TElem>(
            [NotNull] this IList<TElem> list,
            Func<int, int, int> randomSource = null)
        {
            list.CheckArgumentNull(nameof(list));
            randomSource = randomSource ?? new Random().Next;
            var end = list.Count - 2;
            for (var index = 0; index < end; ++index)
            {
                var newIndex = randomSource(index, list.Count);
                var item = list[index];
                list[index] = list[newIndex];
                list[newIndex] = item;
            }
        }

        public static void InsertAll<TElem>(
            [NotNull] this IList<TElem> list,
            int index,
            [NotNull] IEnumerable<TElem> items)
        {
            if (list is List<TElem> trueList)
            {
                trueList.InsertRange(index, items);
                return;
            }
            list.CheckArgumentNull(nameof(list));
            items.CheckArgumentNull(nameof(items));
            index.CheckArgumentOutOfRange(nameof(index), 0, list.Count);
            foreach (var item in items)
                list.Insert(index++, item);
        }

        public static void InsertAll<TElem>(
            [NotNull] this IList<TElem> list,
            int index,
            [NotNull] params TElem[] items)
            => list.InsertAll(index, items.AsEnumerable());
    }
}